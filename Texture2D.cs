public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9FA40 Offset: 0x9EE40 VA: 0x18009FA40
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9FA40 Offset: 0x9EE40 VA: 0x18009FA40
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }


	[NativeNameAttribute] // RVA: 0x9E9C0 Offset: 0x9DDC0 VA: 0x18009E9C0
	public TextureFormat get_format() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture2D get_blackTexture() { }

	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9EAB0 Offset: 0x9DEB0 VA: 0x18009EAB0
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EBF0 Offset: 0x9DFF0 VA: 0x18009EBF0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EC60 Offset: 0x9E060 VA: 0x18009EC60
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9ED40 Offset: 0x9E140 VA: 0x18009ED40
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9EDD0 Offset: 0x9E1D0 VA: 0x18009EDD0
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9EE90 Offset: 0x9E290 VA: 0x18009EE90
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EF00 Offset: 0x9E300 VA: 0x18009EF00
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EF40 Offset: 0x9E340 VA: 0x18009EF40
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EF80 Offset: 0x9E380 VA: 0x18009EF80
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9F090 Offset: 0x9E490 VA: 0x18009F090
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	private IntPtr GetWritableImageData(int frame) { }

	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9F0D0 Offset: 0x9E4D0 VA: 0x18009F0D0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F1B0 Offset: 0x9E5B0 VA: 0x18009F1B0
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F2B0 Offset: 0x9E6B0 VA: 0x18009F2B0
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F2F0 Offset: 0x9E6F0 VA: 0x18009F2F0
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F330 Offset: 0x9E730 VA: 0x18009F330
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F3C0 Offset: 0x9E7C0 VA: 0x18009F3C0
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F430 Offset: 0x9E830 VA: 0x18009F430
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F4D0 Offset: 0x9E8D0 VA: 0x18009F4D0
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

