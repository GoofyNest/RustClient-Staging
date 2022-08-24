public class Texture : Object // TypeDefIndex: 3444
{	public static readonly int GenerateAllMips; // 0x13A04

	public int mipmapCount { get; }
	[NativePropertyAttribute] // RVA: 0x9E710 Offset: 0x9DB10 VA: 0x18009E710
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

	[NativeNameAttribute] // RVA: 0x9CF30 Offset: 0x9C330 VA: 0x18009CF30
	public int get_mipmapCount() { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9D0C0 Offset: 0x9C4C0 VA: 0x18009D0C0
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

	[NativeNameAttribute] // RVA: 0x9D1F0 Offset: 0x9C5F0 VA: 0x18009D1F0
	public TextureWrapMode get_wrapMode() { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_filterMode(FilterMode value) { }

	public void set_anisoLevel(int value) { }

	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D3E0 Offset: 0x9C7E0 VA: 0x18009D3E0
	public Vector2 get_texelSize() { }

	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D460 Offset: 0x9C860 VA: 0x18009D460
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D520 Offset: 0x9C920 VA: 0x18009D520
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D770 Offset: 0x9CB70 VA: 0x18009D770
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D7C0 Offset: 0x9CBC0 VA: 0x18009D7C0
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DCC0 Offset: 0x9D0C0 VA: 0x18009DCC0
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DD10 Offset: 0x9D110 VA: 0x18009DD10
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD60 Offset: 0x9D160 VA: 0x18009DD60
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DDE0 Offset: 0x9D1E0 VA: 0x18009DDE0
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DE10 Offset: 0x9D210 VA: 0x18009DE10
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DFA0 Offset: 0x9D3A0 VA: 0x18009DFA0
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9E080 Offset: 0x9D480 VA: 0x18009E080
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E180 Offset: 0x9D580 VA: 0x18009E180
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E250 Offset: 0x9D650 VA: 0x18009E250
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E350 Offset: 0x9D750 VA: 0x18009E350
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	internal UnityException CreateNonReadableException(Texture t) { }

	private static void .cctor() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

}

public static class Texture // TypeDefIndex: 5611
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void CompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void DecompressNormals(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool SaveAsPng(Texture texture, string fileName) { }

	public static Texture2D CreateReadableCopy(Texture2D texture, int width = 0, int height = 0) { }

	public static Texture2D LimitSize(Texture2D tex, int w, int h) { }

	public static Texture2D LimitSize(Texture2D tex, object maxTextureSize1, object maxTextureSize2) { }

}

public class Texture : ConsoleSystem // TypeDefIndex: 11972
{	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static int streamingBudgetOverride; // 0x1D8F0

	[ClientVar] // RVA: 0xC1AB0 Offset: 0xC0EB0 VA: 0x1800C1AB0
	public static bool streaming { get; set; }


	public static bool get_streaming() { }

	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void stats(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

