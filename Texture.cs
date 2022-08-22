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

	// RVA: 0x19BADB0 Offset: 0x19B93B0 VA: 0x1819BADB0
	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CE00 Offset: 0x9C200 VA: 0x18009CE00
	// RVA: 0x19BAEC0 Offset: 0x19B94C0 VA: 0x1819BAEC0
	public int get_mipmapCount() { }

	// RVA: 0x19BB200 Offset: 0x19B9800 VA: 0x1819BB200
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CFE0 Offset: 0x9C3E0 VA: 0x18009CFE0
	// RVA: 0x19BA970 Offset: 0x19B8F70 VA: 0x1819BA970
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x19BAE70 Offset: 0x19B9470 VA: 0x1819BAE70 Slot: 4
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19BA8B0 Offset: 0x19B8EB0 VA: 0x1819BA8B0
	private int GetDataWidth() { }

	// RVA: 0x19BA870 Offset: 0x19B8E70 VA: 0x1819BA870
	private int GetDataHeight() { }

	// RVA: 0x19BA8F0 Offset: 0x19B8EF0 VA: 0x1819BA8F0
	private TextureDimension GetDimension() { }

	// RVA: 0x19BA8B0 Offset: 0x19B8EB0 VA: 0x1819BA8B0 Slot: 5
	public virtual int get_width() { }

	// RVA: 0x19BB3F0 Offset: 0x19B99F0 VA: 0x1819BB3F0 Slot: 6
	public virtual void set_width(int value) { }

	// RVA: 0x19BA870 Offset: 0x19B8E70 VA: 0x1819BA870 Slot: 7
	public virtual int get_height() { }

	// RVA: 0x19BB2D0 Offset: 0x19B98D0 VA: 0x1819BB2D0 Slot: 8
	public virtual void set_height(int value) { }

	// RVA: 0x19BA8F0 Offset: 0x19B8EF0 VA: 0x1819BA8F0 Slot: 9
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x19BB240 Offset: 0x19B9840 VA: 0x1819BB240 Slot: 10
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x19BAE80 Offset: 0x19B9480 VA: 0x1819BAE80 Slot: 11
	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9D110 Offset: 0x9C510 VA: 0x18009D110
	// RVA: 0x19BB180 Offset: 0x19B9780 VA: 0x1819BB180
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x19BB440 Offset: 0x19B9A40 VA: 0x1819BB440
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x19BB290 Offset: 0x19B9890 VA: 0x1819BB290
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x19BB1C0 Offset: 0x19B97C0 VA: 0x1819BB1C0
	public void set_anisoLevel(int value) { }

	// RVA: 0x19BB320 Offset: 0x19B9920 VA: 0x1819BB320
	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D350 Offset: 0x9C750 VA: 0x18009D350
	// RVA: 0x19BB100 Offset: 0x19B9700 VA: 0x1819BB100
	public Vector2 get_texelSize() { }

	// RVA: 0x19BA930 Offset: 0x19B8F30 VA: 0x1819BA930
	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D380 Offset: 0x9C780 VA: 0x18009D380
	// RVA: 0x19BB150 Offset: 0x19B9750 VA: 0x1819BB150
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D440 Offset: 0x9C840 VA: 0x18009D440
	// RVA: 0x19BAE40 Offset: 0x19B9440 VA: 0x1819BAE40
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D640 Offset: 0x9CA40 VA: 0x18009D640
	// RVA: 0x19BB080 Offset: 0x19B9680 VA: 0x1819BB080
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D690 Offset: 0x9CA90 VA: 0x18009D690
	// RVA: 0x19BAE10 Offset: 0x19B9410 VA: 0x1819BAE10
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DB90 Offset: 0x9CF90 VA: 0x18009DB90
	// RVA: 0x19BAF30 Offset: 0x19B9530 VA: 0x1819BAF30
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DBE0 Offset: 0x9CFE0 VA: 0x18009DBE0
	// RVA: 0x19BAF60 Offset: 0x19B9560 VA: 0x1819BAF60
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	// RVA: 0x19BAF90 Offset: 0x19B9590 VA: 0x1819BAF90
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DCF0 Offset: 0x9D0F0 VA: 0x18009DCF0
	// RVA: 0x19BAF00 Offset: 0x19B9500 VA: 0x1819BAF00
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD60 Offset: 0x9D160 VA: 0x18009DD60
	// RVA: 0x19BB050 Offset: 0x19B9650 VA: 0x1819BB050
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DEF0 Offset: 0x9D2F0 VA: 0x18009DEF0
	// RVA: 0x19BB020 Offset: 0x19B9620 VA: 0x1819BB020
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DFD0 Offset: 0x9D3D0 VA: 0x18009DFD0
	// RVA: 0x19BAFF0 Offset: 0x19B95F0 VA: 0x1819BAFF0
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E090 Offset: 0x9D490 VA: 0x18009E090
	// RVA: 0x19BB3B0 Offset: 0x19B99B0 VA: 0x1819BB3B0
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E160 Offset: 0x9D560 VA: 0x18009E160
	// RVA: 0x19BAFC0 Offset: 0x19B95C0 VA: 0x1819BAFC0
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E270 Offset: 0x9D670 VA: 0x18009E270
	// RVA: 0x19BB370 Offset: 0x19B9970 VA: 0x1819BB370
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	// RVA: 0x19BA9B0 Offset: 0x19B8FB0 VA: 0x1819BA9B0
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x19BAC10 Offset: 0x19B9210 VA: 0x1819BAC10
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x19BA7F0 Offset: 0x19B8DF0 VA: 0x1819BA7F0
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x19BAD70 Offset: 0x19B9370 VA: 0x1819BAD70
	private static void .cctor() { }

	// RVA: 0x19BB0B0 Offset: 0x19B96B0 VA: 0x1819BB0B0
	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4050 Offset: 0x19A2650 VA: 0x1819A4050
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4370 Offset: 0x19A2970 VA: 0x1819A4370
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4630 Offset: 0x19A2C30 VA: 0x1819A4630
	public static bool SaveAsPng(Texture texture, string fileName) { }

	// RVA: 0x19A4150 Offset: 0x19A2750 VA: 0x1819A4150
	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	// RVA: 0x19A4510 Offset: 0x19A2B10 VA: 0x1819A4510
	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	// RVA: 0x19A44C0 Offset: 0x19A2AC0 VA: 0x1819A44C0
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

