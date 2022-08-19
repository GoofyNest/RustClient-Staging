public class Texture : Object // TypeDefIndex: 3444
{	// Fields
	public static readonly int GenerateAllMips; // 0x14792

	// Properties
	public int mipmapCount { get; }
	[NativePropertyAttribute] // RVA: 0x9E500 Offset: 0x9D900 VA: 0x18009E500
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

	// RVA: 0x19BADF0 Offset: 0x19B93F0 VA: 0x1819BADF0
	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CDC0 Offset: 0x9C1C0 VA: 0x18009CDC0
	// RVA: 0x19BAF00 Offset: 0x19B9500 VA: 0x1819BAF00
	public int get_mipmapCount() { }

	// RVA: 0x19BB240 Offset: 0x19B9840 VA: 0x1819BB240
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CF20 Offset: 0x9C320 VA: 0x18009CF20
	// RVA: 0x19BA9B0 Offset: 0x19B8FB0 VA: 0x1819BA9B0
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x19BAEB0 Offset: 0x19B94B0 VA: 0x1819BAEB0 Slot: 4
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19BA8F0 Offset: 0x19B8EF0 VA: 0x1819BA8F0
	private int GetDataWidth() { }

	// RVA: 0x19BA8B0 Offset: 0x19B8EB0 VA: 0x1819BA8B0
	private int GetDataHeight() { }

	// RVA: 0x19BA930 Offset: 0x19B8F30 VA: 0x1819BA930
	private TextureDimension GetDimension() { }

	// RVA: 0x19BA8F0 Offset: 0x19B8EF0 VA: 0x1819BA8F0 Slot: 5
	public virtual int get_width() { }

	// RVA: 0x19BB430 Offset: 0x19B9A30 VA: 0x1819BB430 Slot: 6
	public virtual void set_width(int value) { }

	// RVA: 0x19BA8B0 Offset: 0x19B8EB0 VA: 0x1819BA8B0 Slot: 7
	public virtual int get_height() { }

	// RVA: 0x19BB310 Offset: 0x19B9910 VA: 0x1819BB310 Slot: 8
	public virtual void set_height(int value) { }

	// RVA: 0x19BA930 Offset: 0x19B8F30 VA: 0x1819BA930 Slot: 9
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x19BB280 Offset: 0x19B9880 VA: 0x1819BB280 Slot: 10
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x19BAEC0 Offset: 0x19B94C0 VA: 0x1819BAEC0 Slot: 11
	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9D050 Offset: 0x9C450 VA: 0x18009D050
	// RVA: 0x19BB1C0 Offset: 0x19B97C0 VA: 0x1819BB1C0
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x19BB480 Offset: 0x19B9A80 VA: 0x1819BB480
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x19BB2D0 Offset: 0x19B98D0 VA: 0x1819BB2D0
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x19BB200 Offset: 0x19B9800 VA: 0x1819BB200
	public void set_anisoLevel(int value) { }

	// RVA: 0x19BB360 Offset: 0x19B9960 VA: 0x1819BB360
	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D240 Offset: 0x9C640 VA: 0x18009D240
	// RVA: 0x19BB140 Offset: 0x19B9740 VA: 0x1819BB140
	public Vector2 get_texelSize() { }

	// RVA: 0x19BA970 Offset: 0x19B8F70 VA: 0x1819BA970
	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D340 Offset: 0x9C740 VA: 0x18009D340
	// RVA: 0x19BB190 Offset: 0x19B9790 VA: 0x1819BB190
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D3B0 Offset: 0x9C7B0 VA: 0x18009D3B0
	// RVA: 0x19BAE80 Offset: 0x19B9480 VA: 0x1819BAE80
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D5B0 Offset: 0x9C9B0 VA: 0x18009D5B0
	// RVA: 0x19BB0C0 Offset: 0x19B96C0 VA: 0x1819BB0C0
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D600 Offset: 0x9CA00 VA: 0x18009D600
	// RVA: 0x19BAE50 Offset: 0x19B9450 VA: 0x1819BAE50
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D850 Offset: 0x9CC50 VA: 0x18009D850
	// RVA: 0x19BAF70 Offset: 0x19B9570 VA: 0x1819BAF70
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DB50 Offset: 0x9CF50 VA: 0x18009DB50
	// RVA: 0x19BAFA0 Offset: 0x19B95A0 VA: 0x1819BAFA0
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DBA0 Offset: 0x9CFA0 VA: 0x18009DBA0
	// RVA: 0x19BAFD0 Offset: 0x19B95D0 VA: 0x1819BAFD0
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC60 Offset: 0x9D060 VA: 0x18009DC60
	// RVA: 0x19BAF40 Offset: 0x19B9540 VA: 0x1819BAF40
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DCD0 Offset: 0x9D0D0 VA: 0x18009DCD0
	// RVA: 0x19BB090 Offset: 0x19B9690 VA: 0x1819BB090
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DE60 Offset: 0x9D260 VA: 0x18009DE60
	// RVA: 0x19BB060 Offset: 0x19B9660 VA: 0x1819BB060
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DED0 Offset: 0x9D2D0 VA: 0x18009DED0
	// RVA: 0x19BB030 Offset: 0x19B9630 VA: 0x1819BB030
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E040 Offset: 0x9D440 VA: 0x18009E040
	// RVA: 0x19BB3F0 Offset: 0x19B99F0 VA: 0x1819BB3F0
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x19BB000 Offset: 0x19B9600 VA: 0x1819BB000
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E1B0 Offset: 0x9D5B0 VA: 0x18009E1B0
	// RVA: 0x19BB3B0 Offset: 0x19B99B0 VA: 0x1819BB3B0
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	// RVA: 0x19BA9F0 Offset: 0x19B8FF0 VA: 0x1819BA9F0
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x19BAC50 Offset: 0x19B9250 VA: 0x1819BAC50
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x19BA830 Offset: 0x19B8E30 VA: 0x1819BA830
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x19BADB0 Offset: 0x19B93B0 VA: 0x1819BADB0
	private static void .cctor() { }

	// RVA: 0x19BB0F0 Offset: 0x19B96F0 VA: 0x1819BB0F0
	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19A4090 Offset: 0x19A2690 VA: 0x1819A4090
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19A43B0 Offset: 0x19A29B0 VA: 0x1819A43B0
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19A4670 Offset: 0x19A2C70 VA: 0x1819A4670
	public static bool SaveAsPng(Texture texture, string fileName) { }

	// RVA: 0x19A4190 Offset: 0x19A2790 VA: 0x1819A4190
	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	// RVA: 0x19A4550 Offset: 0x19A2B50 VA: 0x1819A4550
	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	// RVA: 0x19A4500 Offset: 0x19A2B00 VA: 0x1819A4500
	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11968
{	// Fields
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static int streamingBudgetOverride; // 0x204B0

	// Properties
	[ClientVar] // RVA: 0xC1830 Offset: 0xC0C30 VA: 0x1800C1830
	public static bool streaming { get; set; }

	// Methods

	// RVA: 0x36BBB0 Offset: 0x36A1B0 VA: 0x18036BBB0
	public static bool get_streaming() { }

	// RVA: 0x36BBC0 Offset: 0x36A1C0 VA: 0x18036BBC0
	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x36BBD0 Offset: 0x36A1D0 VA: 0x18036BBD0
	public static void stats(ConsoleSystem.Arg arg) { }

	// RVA: 0x36BB50 Offset: 0x36A150 VA: 0x18036BB50
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

