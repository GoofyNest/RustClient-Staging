public class Texture : Object // TypeDefIndex: 3444
{	public static readonly int GenerateAllMips; // 0x2B10794

	public int mipmapCount { get; }
	[NativePropertyAttribute] // RVA: 0x9E660 Offset: 0x9DA60 VA: 0x18009E660
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

	[NativeNameAttribute] // RVA: 0x9CF40 Offset: 0x9C340 VA: 0x18009CF40
	public int get_mipmapCount() { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	[NativeNameAttribute] // RVA: 0x9D0D0 Offset: 0x9C4D0 VA: 0x18009D0D0
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

	[NativeNameAttribute] // RVA: 0x9D1B0 Offset: 0x9C5B0 VA: 0x18009D1B0
	public TextureWrapMode get_wrapMode() { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_filterMode(FilterMode value) { }

	public void set_anisoLevel(int value) { }

	public void set_mipMapBias(float value) { }

	[NativeNameAttribute] // RVA: 0x9D3A0 Offset: 0x9C7A0 VA: 0x18009D3A0
	public Vector2 get_texelSize() { }

	public IntPtr GetNativeTexturePtr() { }

	[FreeFunctionAttribute] // RVA: 0x9D3D0 Offset: 0x9C7D0 VA: 0x18009D3D0
	public static ulong get_totalTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D440 Offset: 0x9C840 VA: 0x18009D440
	public static ulong get_desiredTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D680 Offset: 0x9CA80 VA: 0x18009D680
	public static ulong get_targetTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9D710 Offset: 0x9CB10 VA: 0x18009D710
	public static ulong get_currentTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DC50 Offset: 0x9D050 VA: 0x18009DC50
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunctionAttribute] // RVA: 0x9DCE0 Offset: 0x9D0E0 VA: 0x18009DCE0
	public static ulong get_streamingMipmapUploadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DD70 Offset: 0x9D170 VA: 0x18009DD70
	public static ulong get_streamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DE40 Offset: 0x9D240 VA: 0x18009DE40
	public static ulong get_nonStreamingTextureCount() { }

	[FreeFunctionAttribute] // RVA: 0x9DE70 Offset: 0x9D270 VA: 0x18009DE70
	public static ulong get_streamingTexturePendingLoadCount() { }

	[FreeFunctionAttribute] // RVA: 0x9E000 Offset: 0x9D400 VA: 0x18009E000
	public static ulong get_streamingTextureLoadingCount() { }

	[FreeFunctionAttribute] // RVA: 0x9E0E0 Offset: 0x9D4E0 VA: 0x18009E0E0
	public static bool get_streamingTextureForceLoadAll() { }

	[FreeFunctionAttribute] // RVA: 0x9E1A0 Offset: 0x9D5A0 VA: 0x18009E1A0
	public static void set_streamingTextureForceLoadAll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x9E230 Offset: 0x9D630 VA: 0x18009E230
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[FreeFunctionAttribute] // RVA: 0x9E2F0 Offset: 0x9D6F0 VA: 0x18009E2F0
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
{	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static int streamingBudgetOverride; // 0x1E9B9

	[ClientVar] // RVA: 0xC1340 Offset: 0xC0740 VA: 0x1800C1340
	public static bool streaming { get; set; }


	public static bool get_streaming() { }

	public static void set_streaming(bool value) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void stats(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

