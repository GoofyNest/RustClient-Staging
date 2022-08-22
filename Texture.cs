public class Texture : Object // TypeDefIndex: 3444
{	public static readonly int GenerateAllMips; // 0x144D0

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


	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0x9CE00 Offset: 0x9C200 VA: 0x18009CE00
	public int get_mipmapCount() { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9CFE0 Offset: 0x9C3E0 VA: 0x18009CFE0
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	public virtual GraphicsFormat get_graphicsFormat() { }

	private int GetDataWidth() { }

	private int GetDataHeight() { }

	private TextureDimension GetDimension() { }

	public virtual int get_width() { }

	public virtual void set_width(int value) { }

	public virtual int get_height() { }

	public virtual void set_height(int value) { }

	public virtual TextureDimension get_dimension() { }

	public virtual void set_dimension(TextureDimension value) { }

	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9D110 Offset: 0x9C510 VA: 0x18009D110
	public TextureWrapMode get_wrapMode() { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_filterMode(FilterMode value) { }

	public void set_anisoLevel(int value) { }

	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D350 Offset: 0x9C750 VA: 0x18009D350
	public Vector2 get_texelSize() { }

	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D380 Offset: 0x9C780 VA: 0x18009D380
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D440 Offset: 0x9C840 VA: 0x18009D440
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D640 Offset: 0x9CA40 VA: 0x18009D640
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D690 Offset: 0x9CA90 VA: 0x18009D690
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DB90 Offset: 0x9CF90 VA: 0x18009DB90
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DBE0 Offset: 0x9CFE0 VA: 0x18009DBE0
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DCF0 Offset: 0x9D0F0 VA: 0x18009DCF0
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD60 Offset: 0x9D160 VA: 0x18009DD60
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DEF0 Offset: 0x9D2F0 VA: 0x18009DEF0
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DFD0 Offset: 0x9D3D0 VA: 0x18009DFD0
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E090 Offset: 0x9D490 VA: 0x18009E090
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E160 Offset: 0x9D560 VA: 0x18009E160
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E270 Offset: 0x9D670 VA: 0x18009E270
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	internal UnityException CreateNonReadableException(Texture t) { }

	private static void .cctor() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool SaveAsPng(Texture texture, string fileName) { }

	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11968
{	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int streamingBudgetOverride; // 0x2B10380

	[ClientVar] // RVA: 0xC1950 Offset: 0xC0D50 VA: 0x1800C1950
	public static bool streaming { get; set; }


	public static bool get_streaming() { }

	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void stats(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

