public static class FreeImage // TypeDefIndex: 8020
{	// Fields
	public const uint FI_RGBA_RED_MASK = 16711680;
	public const uint FI_RGBA_GREEN_MASK = 65280;
	public const uint FI_RGBA_BLUE_MASK = 255;
	public const string FreeImageLibrary = "FreeImage";

	// Methods

	// RVA: 0x106C230 Offset: 0x106A830 VA: 0x18106C230
	public static extern FreeImage.Format GetFIFFromFilename(string filename) { }

	// RVA: 0x106C570 Offset: 0x106AB70 VA: 0x18106C570
	public static extern FreeImage.Bitmap Load(FreeImage.Format fif, string filename, FreeImage.LoadFlags flags = 0) { }

	// RVA: 0x106C6C0 Offset: 0x106ACC0 VA: 0x18106C6C0
	public static extern bool Save(FreeImage.Format fif, FreeImage.Bitmap bitmap, string filename, FreeImage.SaveFlags flags = 0) { }

	// RVA: 0x106BF70 Offset: 0x106A570 VA: 0x18106BF70
	public static extern FreeImage.Bitmap Allocate(int width, int height, int bpp, uint red_mask = 16711680, uint green_mask = 65280, uint blue_mask = 255) { }

	// RVA: 0x106C780 Offset: 0x106AD80 VA: 0x18106C780
	public static extern void Unload(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C1B0 Offset: 0x106A7B0 VA: 0x18106C1B0
	public static extern IntPtr GetBits(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C130 Offset: 0x106A730 VA: 0x18106C130
	public static extern uint GetBPP(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C4F0 Offset: 0x106AAF0 VA: 0x18106C4F0
	public static extern uint GetWidth(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C2C0 Offset: 0x106A8C0 VA: 0x18106C2C0
	public static extern uint GetHeight(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C340 Offset: 0x106A940 VA: 0x18106C340
	public static extern uint GetLine(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C3C0 Offset: 0x106A9C0 VA: 0x18106C3C0
	public static extern uint GetPitch(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C440 Offset: 0x106AA40 VA: 0x18106C440
	public static extern bool GetPixelColor(FreeImage.Bitmap bitmap, uint x, uint y, out FreeImage.RGBQuad value) { }

	// RVA: 0x106C620 Offset: 0x106AC20 VA: 0x18106C620
	public static extern FreeImage.Bitmap Rescale(FreeImage.Bitmap bitmap, int dst_width, int dst_height, FreeImage.Filter filter) { }

	// RVA: 0x106C030 Offset: 0x106A630 VA: 0x18106C030
	public static extern FreeImage.Bitmap ConvertTo24Bits(FreeImage.Bitmap bitmap) { }

	// RVA: 0x106C0B0 Offset: 0x106A6B0 VA: 0x18106C0B0
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

	// RVA: 0x184E90 Offset: 0x184290 VA: 0x180184E90
	public bool get_IsNull() { }

	// RVA: 0x184DE0 Offset: 0x1841E0 VA: 0x180184DE0
	public void Unload() { }

	// RVA: 0x1068110 Offset: 0x1066710 VA: 0x181068110
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

