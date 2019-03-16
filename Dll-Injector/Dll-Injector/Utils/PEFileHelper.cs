﻿using Dll_Injector.Native;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_Injector.Utils
{
    // functions that work on the dll before it is loaded via loadlibary (e.g. still on the disk)
    class PEFileHelper
    {
        // does not open a handle
        // retrieves the offset of a function in a DLL
        public static uint GetFunctionOffsetFromDisk(string modulepath, string func_name)
        {
            using (FileStream fs = new FileStream(modulepath, FileMode.Open, FileAccess.Read))
            {
                return GetFunctionOffsetFromModuleStream(fs, func_name);
            }
        }

        public static uint GetFunctionOffsetFromBytes(byte[] modulebytes, string func_name)
        {
            using (var memstream = new MemoryStream(modulebytes))
            {
                return GetFunctionOffsetFromModuleStream(memstream, func_name);
            }
        }

        public static uint GetFunctionOffsetFromModuleStream(Stream modulestream, string func_name)
        {
            // load in the pe header
            PEHeader peh = PEHeader.CreateFromStream(modulestream);
            if (peh == null)
                return 0;

            // get address of export table
            uint rva_et = 0;
            switch (peh.GetArchitecture())
            {
                case ProcessArchitecture.x86:
                    rva_et = peh.Optional_header32.ExportTable.VirtualAddress;
                    break;
                case ProcessArchitecture.x64:
                    rva_et = peh.Optional_header64.ExportTable.VirtualAddress;
                    break;
            }

            if (rva_et == 0)
            {
                return 0;
            }

            // convert the relative virtual address to the physical address
            uint phys_et = peh.ConvertRVAtoPhysical(rva_et);

            modulestream.Seek(phys_et, SeekOrigin.Begin); // postition the stream at the start of export table
            Winnt.IMAGE_EXPORT_DIRECTORY ied = BinaryConverter.StreamToType<Winnt.IMAGE_EXPORT_DIRECTORY>(modulestream);

            // now we parse the names similar to the other ProcessExtensions.GetFunctionAddress
            UInt32 phys_funcs = peh.ConvertRVAtoPhysical(ied.AddressOfFunctions);
            UInt32 phys_names = peh.ConvertRVAtoPhysical(ied.AddressOfNames);
            UInt32 phys_odinals = peh.ConvertRVAtoPhysical(ied.AddressOfNameOrdinals);

            byte[] name_rva_table = new byte[ied.NumberOfNames * 4]; // 4 byte per rva
            modulestream.Seek(phys_names, SeekOrigin.Begin);
            modulestream.Read(name_rva_table, 0, (int)(ied.NumberOfNames * 4));

            byte[] funcaddress_rva_table = new byte[ied.NumberOfFunctions * 4]; // 4 byte per rva
            modulestream.Seek(phys_funcs, SeekOrigin.Begin);
            modulestream.Read(funcaddress_rva_table, 0, (int)(ied.NumberOfFunctions * 4));

            byte[] odinal_rva_table = new byte[ied.NumberOfNames * 2]; // 2 byte per index
            modulestream.Seek(phys_odinals, SeekOrigin.Begin);
            modulestream.Read(odinal_rva_table, 0, (int)(ied.NumberOfNames * 2));

            // walk through the function names
            for (int i = 0; i < ied.NumberOfNames; i++)
            {
                UInt32 phys_funcname = peh.ConvertRVAtoPhysical(BitConverter.ToUInt32(name_rva_table, i * 4));

                byte[] namebuffer = new byte[64];
                modulestream.Seek(phys_funcname, SeekOrigin.Begin);
                modulestream.Read(namebuffer, 0, namebuffer.Length);

                var str = System.Text.Encoding.UTF8.GetString(namebuffer);
                int idx = str.IndexOf('\0');
                if (idx >= 0) str = str.Substring(0, idx);

                if (str.Contains(func_name))
                {
                    ushort offset = BitConverter.ToUInt16(odinal_rva_table, i * 2);
                    uint func_rva = BitConverter.ToUInt32(funcaddress_rva_table, offset * 4);

                    // Convert the RVA to the offset into the array and return
                    return peh.ConvertRVAtoPhysical(func_rva);
                }
            }
            return 0;
        }

        // does not open a handle
        public static ProcessArchitecture GetArchitecture(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                if (!fs.CanRead)
                    return ProcessArchitecture.Unknown;

                Winnt.IMAGE_DOS_HEADER idh = BinaryConverter.StreamToType<Winnt.IMAGE_DOS_HEADER>(fs);
                if (idh.e_magic_byte != Winnt.IMAGE_DOS_SIGNATURE)
                {
                    return ProcessArchitecture.Unknown;
                }

                // reposition the stream position
                fs.Seek(idh.e_lfanew, SeekOrigin.Begin);

                Winnt.IMAGE_FILE_HEADER ifh = BinaryConverter.StreamToType<Winnt.IMAGE_FILE_HEADER>(fs);
                if (ifh.Magic != Winnt.IMAGE_NT_SIGNATURE)
                {
                    return ProcessArchitecture.Unknown;
                }

                if (ifh.Machine == Winnt.MachineType.I386)
                {
                    return ProcessArchitecture.x86;
                }
                else if (ifh.Machine == Winnt.MachineType.x64)
                {
                    return ProcessArchitecture.x64;
                }
            }
            return ProcessArchitecture.Unknown;
        }
    }
}