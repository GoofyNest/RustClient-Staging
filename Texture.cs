public class Texture : Object // TypeDefIndex: 3444
{	// Fields
	public static readonly int GenerateAllMips; // 0x14792

	// Properties
	public int mipmapCount { get; }
	[NativePropertyAttribute] // RVA: 0x9E620 Offset: 0x9DA20 VA: 0x18009E620
	public static AnisotropicFiltering anisotropicFiltering { set; }
	public virtual GraphicsFormat graphicsFormat { get; }
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual TextureDimension dimension { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public FilterMode filterMode { set; }
	public int anisoLevel { set; }
	public float mipMapBias { set; }
	public Vector2 texelSize { get; }
	public static ulong totalTextureMemory { get; }
	public static ulong desiredTextureMemory { get; }
	public static ulong targetTextureMemory { get; }
	public static ulong currentTextureMemory { get; }
	public static ulong nonStreamingTextureMemory { get; }
	public static ulong streamingMipmapUploadCount { get; }
	public static ulong streamingTextureCount { get; }
	public static ulong nonStreamingTextureCount { get; }
	public static ulong streamingTexturePendingLoadCount { get; }
	public static ulong streamingTextureLoadingCount { get; }
	public static bool streamingTextureForceLoadAll { get; set; }
	public static bool streamingTextureDiscardUnusedMips { get; set; }

	// Methods

	// RVA: 0x19BB070 Offset: 0x19B9670 VA: 0x1819BB070
	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CE00 Offset: 0x9C200 VA: 0x18009CE00
	// RVA: 0x19BB180 Offset: 0x19B9780 VA: 0x1819BB180
	public int get_mipmapCount() { }

	// RVA: 0x19BB4C0 Offset: 0x19B9AC0 VA: 0x1819BB4C0
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CFE0 Offset: 0x9C3E0 VA: 0x18009CFE0
	// RVA: 0x19BAC30 Offset: 0x19B9230 VA: 0x1819BAC30
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x19BB130 Offset: 0x19B9730 VA: 0x1819BB130 Slot: 4
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19BAB70 Offset: 0x19B9170 VA: 0x1819BAB70
	private int GetDataWidth() { }

	// RVA: 0x19BAB30 Offset: 0x19B9130 VA: 0x1819BAB30
	private int GetDataHeight() { }

	// RVA: 0x19BABB0 Offset: 0x19B91B0 VA: 0x1819BABB0
	private TextureDimension GetDimension() { }

	// RVA: 0x19BAB70 Offset: 0x19B9170 VA: 0x1819BAB70 Slot: 5
	public virtual int get_width() { }

	// RVA: 0x19BB6B0 Offset: 0x19B9CB0 VA: 0x1819BB6B0 Slot: 6
	public virtual void set_width(int value) { }

	// RVA: 0x19BAB30 Offset: 0x19B9130 VA: 0x1819BAB30 Slot: 7
	public virtual int get_height() { }

	// RVA: 0x19BB590 Offset: 0x19B9B90 VA: 0x1819BB590 Slot: 8
	public virtual void set_height(int value) { }

	// RVA: 0x19BABB0 Offset: 0x19B91B0 VA: 0x1819BABB0 Slot: 9
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x19BB500 Offset: 0x19B9B00 VA: 0x1819BB500 Slot: 10
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x19BB140 Offset: 0x19B9740 VA: 0x1819BB140 Slot: 11
	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9D110 Offset: 0x9C510 VA: 0x18009D110
	// RVA: 0x19BB440 Offset: 0x19B9A40 VA: 0x1819BB440
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x19BB700 Offset: 0x19B9D00 VA: 0x1819BB700
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x19BB550 Offset: 0x19B9B50 VA: 0x1819BB550
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x19BB480 Offset: 0x19B9A80 VA: 0x1819BB480
	public void set_anisoLevel(int value) { }

	// RVA: 0x19BB5E0 Offset: 0x19B9BE0 VA: 0x1819BB5E0
	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D350 Offset: 0x9C750 VA: 0x18009D350
	// RVA: 0x19BB3C0 Offset: 0x19B99C0 VA: 0x1819BB3C0
	public Vector2 get_texelSize() { }

	// RVA: 0x19BABF0 Offset: 0x19B91F0 VA: 0x1819BABF0
	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D380 Offset: 0x9C780 VA: 0x18009D380
	// RVA: 0x19BB410 Offset: 0x19B9A10 VA: 0x1819BB410
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D440 Offset: 0x9C840 VA: 0x18009D440
	// RVA: 0x19BB100 Offset: 0x19B9700 VA: 0x1819BB100
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D640 Offset: 0x9CA40 VA: 0x18009D640
	// RVA: 0x19BB340 Offset: 0x19B9940 VA: 0x1819BB340
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D690 Offset: 0x9CA90 VA: 0x18009D690
	// RVA: 0x19BB0D0 Offset: 0x19B96D0 VA: 0x1819BB0D0
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DB90 Offset: 0x9CF90 VA: 0x18009DB90
	// RVA: 0x19BB1F0 Offset: 0x19B97F0 VA: 0x1819BB1F0
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DBE0 Offset: 0x9CFE0 VA: 0x18009DBE0
	// RVA: 0x19BB220 Offset: 0x19B9820 VA: 0x1819BB220
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	// RVA: 0x19BB250 Offset: 0x19B9850 VA: 0x1819BB250
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DCF0 Offset: 0x9D0F0 VA: 0x18009DCF0
	// RVA: 0x19BB1C0 Offset: 0x19B97C0 VA: 0x1819BB1C0
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD60 Offset: 0x9D160 VA: 0x18009DD60
	// RVA: 0x19BB310 Offset: 0x19B9910 VA: 0x1819BB310
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DEF0 Offset: 0x9D2F0 VA: 0x18009DEF0
	// RVA: 0x19BB2E0 Offset: 0x19B98E0 VA: 0x1819BB2E0
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DFD0 Offset: 0x9D3D0 VA: 0x18009DFD0
	// RVA: 0x19BB2B0 Offset: 0x19B98B0 VA: 0x1819BB2B0
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E090 Offset: 0x9D490 VA: 0x18009E090
	// RVA: 0x19BB670 Offset: 0x19B9C70 VA: 0x1819BB670
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E160 Offset: 0x9D560 VA: 0x18009E160
	// RVA: 0x19BB280 Offset: 0x19B9880 VA: 0x1819BB280
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E270 Offset: 0x9D670 VA: 0x18009E270
	// RVA: 0x19BB630 Offset: 0x19B9C30 VA: 0x1819BB630
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	// RVA: 0x19BAC70 Offset: 0x19B9270 VA: 0x1819BAC70
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x19BAED0 Offset: 0x19B94D0 VA: 0x1819BAED0
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x19BAAB0 Offset: 0x19B90B0 VA: 0x1819BAAB0
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x19BB030 Offset: 0x19B9630 VA: 0x1819BB030
	private static void .cctor() { }

	// RVA: 0x19BB370 Offset: 0x19B9970 VA: 0x1819BB370
	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4310 Offset: 0x19A2910 VA: 0x1819A4310
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4630 Offset: 0x19A2C30 VA: 0x1819A4630
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A48F0 Offset: 0x19A2EF0 VA: 0x1819A48F0
	public static bool SaveAsPng(Texture texture, string fileName) { }

	// RVA: 0x19A4410 Offset: 0x19A2A10 VA: 0x1819A4410
	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	// RVA: 0x19A47D0 Offset: 0x19A2DD0 VA: 0x1819A47D0
	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	// RVA: 0x19A4780 Offset: 0x19A2D80 VA: 0x1819A4780
	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11968
{	// Fields
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int streamingBudgetOverride; // 0x204B0

	// Properties
	[ClientVar] // RVA: 0xC1950 Offset: 0xC0D50 VA: 0x1800C1950
	public static bool streaming { get; set; }

	// Methods

	// RVA: 0x36BBB0 Offset: 0x36A1B0 VA: 0x18036BBB0
	public static bool get_streaming() { }

	// RVA: 0x36BBC0 Offset: 0x36A1C0 VA: 0x18036BBC0
	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x36BBD0 Offset: 0x36A1D0 VA: 0x18036BBD0
	public static void stats(ConsoleSystem.Arg arg) { }

	// RVA: 0x36BB50 Offset: 0x36A150 VA: 0x18036BB50
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

