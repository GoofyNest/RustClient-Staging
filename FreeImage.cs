public static class FreeImage // TypeDefIndex: 8020
{	// Fields
	public const uint FI_RGBA_RED_MASK = 16711680;
	public const uint FI_RGBA_GREEN_MASK = 65280;
	public const uint FI_RGBA_BLUE_MASK = 255;
	public const string FreeImageLibrary = "FreeImage";

	// Methods

	// RVA: 0x106CF60 Offset: 0x106B560 VA: 0x18106CF60
	public static extern FreeImage.Format GetFIFFromFilename(string filename) { }

	// RVA: 0x106D2A0 Offset: 0x106B8A0 VA: 0x18106D2A0
	public static extern FreeImage.Bitmap Load(FreeImage.Format fif, string filename, FreeImage.LoadFlags flags = 0) { }

	// RVA: 0x106D3F0 Offset: 0x106B9F0 VA: 0x18106D3F0
	public static extern bool Save(FreeImage.Format fif, FreeImage.Bitmap bitmap, string filename, FreeImage.SaveFlags flags = 0) { }

	// RVA: 0x106CCA0 Offset: 0x106B2A0 VA: 0x18106CCA0
	public static extern FreeImage.Bitmap Allocate(int width, int height, int bpp, uint red_mask = 16711680, uint green_mask = 65280, uint blue_mask = 255) { }

	// RVA: 0x106D4B0 Offset: 0x106BAB0 VA: 0x18106D4B0
	public static extern void Unload(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106CEE0 Offset: 0x106B4E0 VA: 0x18106CEE0
	public static extern IntPtr GetBits(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106CE60 Offset: 0x106B460 VA: 0x18106CE60
	public static extern uint GetBPP(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106D220 Offset: 0x106B820 VA: 0x18106D220
	public static extern uint GetWidth(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106CFF0 Offset: 0x106B5F0 VA: 0x18106CFF0
	public static extern uint GetHeight(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106D070 Offset: 0x106B670 VA: 0x18106D070
	public static extern uint GetLine(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106D0F0 Offset: 0x106B6F0 VA: 0x18106D0F0
	public static extern uint GetPitch(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106D170 Offset: 0x106B770 VA: 0x18106D170
	public static extern bool GetPixelColor(FreeImage.Bitmap bitmap, uint x, uint y, out FreeImage.RGBQuad value) { }

	// RVA: 0x106D350 Offset: 0x106B950 VA: 0x18106D350
	public static extern FreeImage.Bitmap Rescale(FreeImage.Bitmap bitmap, int dst_width, int dst_height, FreeImage.Filter filter) { }

	// RVA: 0x106CD60 Offset: 0x106B360 VA: 0x18106CD60
	public static extern FreeImage.Bitmap ConvertTo24Bits(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106CDE0 Offset: 0x106B3E0 VA: 0x18106CDE0
	public static extern FreeImage.Bitmap ConvertTo32Bits(FreeImage.Bitmap bitmap) { }

}

public enum FreeImage.Format // TypeDefIndex: 8021
{	// Fields
	public int value__; // 0x0
	public const FreeImage.Format Unknown = -1;
	public const FreeImage.Format BMP = 0;
	public const FreeImage.Format JPEG = 2;
	public const FreeImage.Format PNG = 13;
	public const FreeImage.Format TARGA = 17;
	public const FreeImage.Format TIFF = 18;
	public const FreeImage.Format PSD = 20;
	public const FreeImage.Format DDS = 24;
	public const FreeImage.Format HDR = 26;
	public const FreeImage.Format EXR = 29;
	public const FreeImage.Format J2K = 30;
	public const FreeImage.Format JP2 = 31;
	public const FreeImage.Format WEBP = 35;
	public const FreeImage.Format JXR = 36;

}

public enum FreeImage.SaveFlags // TypeDefIndex: 8022
{	// Fields
	public int value__; // 0x0
	public const FreeImage.SaveFlags DEFAULT = 0;
	public const FreeImage.SaveFlags BMP_SAVE_RLE = 1;
	public const FreeImage.SaveFlags EXR_FLOAT = 1;
	public const FreeImage.SaveFlags EXR_NONE = 2;
	public const FreeImage.SaveFlags EXR_ZIP = 4;
	public const FreeImage.SaveFlags EXR_PIZ = 8;
	public const FreeImage.SaveFlags EXR_PXR24 = 16;
	public const FreeImage.SaveFlags EXR_B44 = 32;
	public const FreeImage.SaveFlags EXR_LC = 64;
	public const FreeImage.SaveFlags JPEG_QUALITYSUPERB = 128;
	public const FreeImage.SaveFlags JPEG_QUALITYGOOD = 256;
	public const FreeImage.SaveFlags JPEG_QUALITYNORMAL = 512;
	public const FreeImage.SaveFlags JPEG_QUALITYAVERAGE = 1024;
	public const FreeImage.SaveFlags JPEG_QUALITYBAD = 2048;
	public const FreeImage.SaveFlags JPEG_PROGRESSIVE = 8192;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_411 = 4096;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_420 = 16384;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_422 = 32768;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_444 = 65536;
	public const FreeImage.SaveFlags JPEG_OPTIMIZE = 131072;
	public const FreeImage.SaveFlags JPEG_BASELINE = 262144;
	public const FreeImage.SaveFlags PNG_Z_BEST_SPEED = 1;
	public const FreeImage.SaveFlags PNG_Z_DEFAULT_COMPRESSION = 6;
	public const FreeImage.SaveFlags PNG_Z_BEST_COMPRESSION = 9;
	public const FreeImage.SaveFlags PNG_Z_NO_COMPRESSION = 256;
	public const FreeImage.SaveFlags PNG_INTERLACED = 512;
	public const FreeImage.SaveFlags PNM_SAVE_ASCII = 1;
	public const FreeImage.SaveFlags TIFF_CMYK = 1;
	public const FreeImage.SaveFlags TIFF_PACKBITS = 256;
	public const FreeImage.SaveFlags TIFF_DEFLATE = 512;
	public const FreeImage.SaveFlags TIFF_ADOBE_DEFLATE = 1024;
	public const FreeImage.SaveFlags TIFF_NONE = 2048;
	public const FreeImage.SaveFlags TIFF_CCITTFAX3 = 4096;
	public const FreeImage.SaveFlags TIFF_CCITTFAX4 = 8192;
	public const FreeImage.SaveFlags TIFF_LZW = 16384;
	public const FreeImage.SaveFlags TIFF_JPEG = 32768;

}

public enum FreeImage.LoadFlags // TypeDefIndex: 8023
{	// Fields
	public int value__; // 0x0
	public const FreeImage.LoadFlags DEFAULT = 0;
	public const FreeImage.LoadFlags GIF_LOAD256 = 1;
	public const FreeImage.LoadFlags GIF_PLAYBACK = 2;
	public const FreeImage.LoadFlags ICO_MAKEALPHA = 1;
	public const FreeImage.LoadFlags JPEG_FAST = 1;
	public const FreeImage.LoadFlags JPEG_ACCURATE = 2;
	public const FreeImage.LoadFlags JPEG_CMYK = 4;
	public const FreeImage.LoadFlags JPEG_EXIFROTATE = 8;
	public const FreeImage.LoadFlags PCD_BASE = 1;
	public const FreeImage.LoadFlags PCD_BASEDIV4 = 2;
	public const FreeImage.LoadFlags PCD_BASEDIV16 = 3;
	public const FreeImage.LoadFlags PNG_IGNOREGAMMA = 1;
	public const FreeImage.LoadFlags TARGA_LOAD_RGB888 = 1;
	public const FreeImage.LoadFlags TIFF_CMYK = 1;
	public const FreeImage.LoadFlags RAW_PREVIEW = 1;
	public const FreeImage.LoadFlags RAW_DISPLAY = 2;

}

public struct FreeImage.Header // TypeDefIndex: 8024
{	// Fields
	public uint size; // 0x0
	public int width; // 0x4
	public int height; // 0x8
	public ushort planes; // 0xC
	public ushort bitCount; // 0xE
	public uint compression; // 0x10
	public uint sizeImage; // 0x14
	public int xPelsPerMeter; // 0x18
	public int yPelsPerMeter; // 0x1C
	public uint clrUsed; // 0x20
	public uint clrImportant; // 0x24

}

public struct FreeImage.Bitmap // TypeDefIndex: 8025
{	// Fields
	public IntPtr data; // 0x0
	public static FreeImage.Bitmap Null; // 0x0

	// Properties
	public bool IsNull { get; }

	// Methods

	// RVA: 0x193830 Offset: 0x192C30 VA: 0x180193830
	public bool get_IsNull() { }

	// RVA: 0x193780 Offset: 0x192B80 VA: 0x180193780
	public void Unload() { }

	// RVA: 0x1068E40 Offset: 0x1067440 VA: 0x181068E40
	private static void .cctor() { }

}

public struct FreeImage.RGBQuad // TypeDefIndex: 8026
{	// Fields
	public byte rgbBlue; // 0x0
	public byte rgbGreen; // 0x1
	public byte rgbRed; // 0x2
	public byte rgbReserved; // 0x3
	public uint uintValue; // 0x0

}

public enum FreeImage.Filter // TypeDefIndex: 8027
{	// Fields
	public int value__; // 0x0
	public const FreeImage.Filter Box = 0;
	public const FreeImage.Filter Bicubic = 1;
	public const FreeImage.Filter Bilinear = 2;
	public const FreeImage.Filter Bspline = 3;
	public const FreeImage.Filter CatmullRom = 4;
	public const FreeImage.Filter Lanczos3 = 5;

}

