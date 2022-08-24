public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9F950 Offset: 0x9ED50 VA: 0x18009F950
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9F950 Offset: 0x9ED50 VA: 0x18009F950
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }


	[NativeNameAttribute] // RVA: 0x9E8B0 Offset: 0x9DCB0 VA: 0x18009E8B0
	public TextureFormat get_format() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture2D get_blackTexture() { }

	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EB30 Offset: 0x9DF30 VA: 0x18009EB30
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EBA0 Offset: 0x9DFA0 VA: 0x18009EBA0
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EC80 Offset: 0x9E080 VA: 0x18009EC80
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9ECF0 Offset: 0x9E0F0 VA: 0x18009ECF0
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9ED60 Offset: 0x9E160 VA: 0x18009ED60
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EDD0 Offset: 0x9E1D0 VA: 0x18009EDD0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EE10 Offset: 0x9E210 VA: 0x18009EE10
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EEA0 Offset: 0x9E2A0 VA: 0x18009EEA0
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9EFE0 Offset: 0x9E3E0 VA: 0x18009EFE0
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	private IntPtr GetWritableImageData(int frame) { }

	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9F050 Offset: 0x9E450 VA: 0x18009F050
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F160 Offset: 0x9E560 VA: 0x18009F160
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F290 Offset: 0x9E690 VA: 0x18009F290
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F390 Offset: 0x9E790 VA: 0x18009F390
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F420 Offset: 0x9E820 VA: 0x18009F420
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F460 Offset: 0x9E860 VA: 0x18009F460
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F4A0 Offset: 0x9E8A0 VA: 0x18009F4A0
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F510 Offset: 0x9E910 VA: 0x18009F510
	public Color32[] GetPixels32(int miplevel) { }

	public Color32[] GetPixels32() { }

	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	public void .ctor(int width, int height) { }

	public void SetPixel(int x, int y, Color color) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors) { }

	public Color GetPixel(int x, int y) { }

	public Color GetPixelBilinear(float u, float v) { }

	public void LoadRawTextureData(IntPtr data, int size) { }

	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-Texture2D.GetRawTextureData<half2>
	|
	|-Texture2D.GetRawTextureData<Color32>
	*/

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply(bool updateMipmaps) { }

	public void Apply() { }

	public bool Resize(int width, int height) { }

	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void ReadPixels(Rect source, int destX, int destY) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	public void SetPixels32(Color32[] colors) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	public Color[] GetPixels(int miplevel) { }

	public Color[] GetPixels() { }

	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

