public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9F910 Offset: 0x9ED10 VA: 0x18009F910
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9F910 Offset: 0x9ED10 VA: 0x18009F910
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }


	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	public TextureFormat get_format() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture2D get_blackTexture() { }

	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E980 Offset: 0x9DD80 VA: 0x18009E980
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EAC0 Offset: 0x9DEC0 VA: 0x18009EAC0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EB30 Offset: 0x9DF30 VA: 0x18009EB30
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EC60 Offset: 0x9E060 VA: 0x18009EC60
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9ECF0 Offset: 0x9E0F0 VA: 0x18009ECF0
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9ED60 Offset: 0x9E160 VA: 0x18009ED60
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EDD0 Offset: 0x9E1D0 VA: 0x18009EDD0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EE10 Offset: 0x9E210 VA: 0x18009EE10
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EE50 Offset: 0x9E250 VA: 0x18009EE50
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9EF60 Offset: 0x9E360 VA: 0x18009EF60
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	private IntPtr GetWritableImageData(int frame) { }

	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EFA0 Offset: 0x9E3A0 VA: 0x18009EFA0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F080 Offset: 0x9E480 VA: 0x18009F080
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F180 Offset: 0x9E580 VA: 0x18009F180
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F1E0 Offset: 0x9E5E0 VA: 0x18009F1E0
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F220 Offset: 0x9E620 VA: 0x18009F220
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F290 Offset: 0x9E690 VA: 0x18009F290
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F300 Offset: 0x9E700 VA: 0x18009F300
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F3A0 Offset: 0x9E7A0 VA: 0x18009F3A0
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
	|-RVA: 0x1A3B4F0 Offset: 0x1A39AF0 VA: 0x181A3B4F0
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1A3B3D0 Offset: 0x1A399D0 VA: 0x181A3B3D0
	|-Texture2D.GetRawTextureData<Color32>
	*/

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply(bool updateMipmaps) { }

	public void Apply() { }

	public bool Resize(int width, int height) { }

	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

