public class Texture : Object // TypeDefIndex: 3444
{	// Fields
	public static readonly int GenerateAllMips; // 0x144D0

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

	// RVA: 0x19A8470 Offset: 0x19A6A70 VA: 0x1819A8470
	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CE00 Offset: 0x9C200 VA: 0x18009CE00
	// RVA: 0x19A8580 Offset: 0x19A6B80 VA: 0x1819A8580
	public int get_mipmapCount() { }

	// RVA: 0x19A88C0 Offset: 0x19A6EC0 VA: 0x1819A88C0
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CFE0 Offset: 0x9C3E0 VA: 0x18009CFE0
	// RVA: 0x19A8030 Offset: 0x19A6630 VA: 0x1819A8030
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x19A8530 Offset: 0x19A6B30 VA: 0x1819A8530 Slot: 4
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19A7F70 Offset: 0x19A6570 VA: 0x1819A7F70
	private int GetDataWidth() { }

	// RVA: 0x19A7F30 Offset: 0x19A6530 VA: 0x1819A7F30
	private int GetDataHeight() { }

	// RVA: 0x19A7FB0 Offset: 0x19A65B0 VA: 0x1819A7FB0
	private TextureDimension GetDimension() { }

	// RVA: 0x19A7F70 Offset: 0x19A6570 VA: 0x1819A7F70 Slot: 5
	public virtual int get_width() { }

	// RVA: 0x19A8AB0 Offset: 0x19A70B0 VA: 0x1819A8AB0 Slot: 6
	public virtual void set_width(int value) { }

	// RVA: 0x19A7F30 Offset: 0x19A6530 VA: 0x1819A7F30 Slot: 7
	public virtual int get_height() { }

	// RVA: 0x19A8990 Offset: 0x19A6F90 VA: 0x1819A8990 Slot: 8
	public virtual void set_height(int value) { }

	// RVA: 0x19A7FB0 Offset: 0x19A65B0 VA: 0x1819A7FB0 Slot: 9
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x19A8900 Offset: 0x19A6F00 VA: 0x1819A8900 Slot: 10
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x19A8540 Offset: 0x19A6B40 VA: 0x1819A8540 Slot: 11
	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9D110 Offset: 0x9C510 VA: 0x18009D110
	// RVA: 0x19A8840 Offset: 0x19A6E40 VA: 0x1819A8840
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x19A8B00 Offset: 0x19A7100 VA: 0x1819A8B00
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x19A8950 Offset: 0x19A6F50 VA: 0x1819A8950
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x19A8880 Offset: 0x19A6E80 VA: 0x1819A8880
	public void set_anisoLevel(int value) { }

	// RVA: 0x19A89E0 Offset: 0x19A6FE0 VA: 0x1819A89E0
	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D350 Offset: 0x9C750 VA: 0x18009D350
	// RVA: 0x19A87C0 Offset: 0x19A6DC0 VA: 0x1819A87C0
	public Vector2 get_texelSize() { }

	// RVA: 0x19A7FF0 Offset: 0x19A65F0 VA: 0x1819A7FF0
	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D380 Offset: 0x9C780 VA: 0x18009D380
	// RVA: 0x19A8810 Offset: 0x19A6E10 VA: 0x1819A8810
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D440 Offset: 0x9C840 VA: 0x18009D440
	// RVA: 0x19A8500 Offset: 0x19A6B00 VA: 0x1819A8500
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D640 Offset: 0x9CA40 VA: 0x18009D640
	// RVA: 0x19A8740 Offset: 0x19A6D40 VA: 0x1819A8740
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D690 Offset: 0x9CA90 VA: 0x18009D690
	// RVA: 0x19A84D0 Offset: 0x19A6AD0 VA: 0x1819A84D0
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DB90 Offset: 0x9CF90 VA: 0x18009DB90
	// RVA: 0x19A85F0 Offset: 0x19A6BF0 VA: 0x1819A85F0
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DBE0 Offset: 0x9CFE0 VA: 0x18009DBE0
	// RVA: 0x19A8620 Offset: 0x19A6C20 VA: 0x1819A8620
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	// RVA: 0x19A8650 Offset: 0x19A6C50 VA: 0x1819A8650
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DCF0 Offset: 0x9D0F0 VA: 0x18009DCF0
	// RVA: 0x19A85C0 Offset: 0x19A6BC0 VA: 0x1819A85C0
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD60 Offset: 0x9D160 VA: 0x18009DD60
	// RVA: 0x19A8710 Offset: 0x19A6D10 VA: 0x1819A8710
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DEF0 Offset: 0x9D2F0 VA: 0x18009DEF0
	// RVA: 0x19A86E0 Offset: 0x19A6CE0 VA: 0x1819A86E0
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DFD0 Offset: 0x9D3D0 VA: 0x18009DFD0
	// RVA: 0x19A86B0 Offset: 0x19A6CB0 VA: 0x1819A86B0
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E090 Offset: 0x9D490 VA: 0x18009E090
	// RVA: 0x19A8A70 Offset: 0x19A7070 VA: 0x1819A8A70
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E160 Offset: 0x9D560 VA: 0x18009E160
	// RVA: 0x19A8680 Offset: 0x19A6C80 VA: 0x1819A8680
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E270 Offset: 0x9D670 VA: 0x18009E270
	// RVA: 0x19A8A30 Offset: 0x19A7030 VA: 0x1819A8A30
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	// RVA: 0x19A8070 Offset: 0x19A6670 VA: 0x1819A8070
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x19A82D0 Offset: 0x19A68D0 VA: 0x1819A82D0
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x19A7EB0 Offset: 0x19A64B0 VA: 0x1819A7EB0
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x19A8430 Offset: 0x19A6A30 VA: 0x1819A8430
	private static void .cctor() { }

	// RVA: 0x19A8770 Offset: 0x19A6D70 VA: 0x1819A8770
	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991710 Offset: 0x198FD10 VA: 0x181991710
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991A30 Offset: 0x1990030 VA: 0x181991A30
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991CF0 Offset: 0x19902F0 VA: 0x181991CF0
	public static bool SaveAsPng(Texture texture, string fileName) { }

	// RVA: 0x1991810 Offset: 0x198FE10 VA: 0x181991810
	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	// RVA: 0x1991BD0 Offset: 0x19901D0 VA: 0x181991BD0
	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	// RVA: 0x1991B80 Offset: 0x1990180 VA: 0x181991B80
	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11968
{	// Fields
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int streamingBudgetOverride; // 0x2B10380

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

