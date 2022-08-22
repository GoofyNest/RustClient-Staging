public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	// Properties
	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9F910 Offset: 0x9ED10 VA: 0x18009F910
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9F910 Offset: 0x9ED10 VA: 0x18009F910
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x217BD20 Offset: 0x217A320 VA: 0x18217BD20
	public TextureFormat get_format() { }

	// RVA: 0x217BDA0 Offset: 0x217A3A0 VA: 0x18217BDA0
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x217BCF0 Offset: 0x217A2F0 VA: 0x18217BCF0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x217A510 Offset: 0x2178B10 VA: 0x18217A510
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E980 Offset: 0x9DD80 VA: 0x18009E980
	// RVA: 0x217ABA0 Offset: 0x21791A0 VA: 0x18217ABA0
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217AC00 Offset: 0x2179200 VA: 0x18217AC00
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217BD60 Offset: 0x217A360 VA: 0x18217BD60 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EAC0 Offset: 0x9DEC0 VA: 0x18009EAC0
	// RVA: 0x217A360 Offset: 0x2178960 VA: 0x18217A360
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EB30 Offset: 0x9DF30 VA: 0x18009EB30
	// RVA: 0x217B0D0 Offset: 0x21796D0 VA: 0x18217B0D0
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EC60 Offset: 0x9E060 VA: 0x18009EC60
	// RVA: 0x217B410 Offset: 0x2179A10 VA: 0x18217B410
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9ECF0 Offset: 0x9E0F0 VA: 0x18009ECF0
	// RVA: 0x217A780 Offset: 0x2178D80 VA: 0x18217A780
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9ED60 Offset: 0x9E160 VA: 0x18009ED60
	// RVA: 0x217A5C0 Offset: 0x2178BC0 VA: 0x18217A5C0
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EDD0 Offset: 0x9E1D0 VA: 0x18009EDD0
	// RVA: 0x217B120 Offset: 0x2179720 VA: 0x18217B120
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EE10 Offset: 0x9E210 VA: 0x18009EE10
	// RVA: 0x217AEC0 Offset: 0x21794C0 VA: 0x18217AEC0
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EE50 Offset: 0x9E250 VA: 0x18009EE50
	// RVA: 0x217B610 Offset: 0x2179C10 VA: 0x18217B610
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9EF60 Offset: 0x9E360 VA: 0x18009EF60
	// RVA: 0x217ACD0 Offset: 0x21792D0 VA: 0x18217ACD0
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	// RVA: 0x217AB60 Offset: 0x2179160 VA: 0x18217AB60
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x217AB20 Offset: 0x2179120 VA: 0x18217AB20
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EFA0 Offset: 0x9E3A0 VA: 0x18009EFA0
	// RVA: 0x217BE10 Offset: 0x217A410 VA: 0x18217BE10
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F080 Offset: 0x9E480 VA: 0x18009F080
	// RVA: 0x217BDD0 Offset: 0x217A3D0 VA: 0x18217BDD0
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F180 Offset: 0x9E580 VA: 0x18009F180
	// RVA: 0x217A4D0 Offset: 0x2178AD0 VA: 0x18217A4D0
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F1E0 Offset: 0x9E5E0 VA: 0x18009F1E0
	// RVA: 0x217A490 Offset: 0x2178A90 VA: 0x18217A490
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F220 Offset: 0x9E620 VA: 0x18009F220
	// RVA: 0x217B2F0 Offset: 0x21798F0 VA: 0x18217B2F0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F290 Offset: 0x9E690 VA: 0x18009F290
	// RVA: 0x217B350 Offset: 0x2179950 VA: 0x18217B350
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F300 Offset: 0x9E700 VA: 0x18009F300
	// RVA: 0x217AA20 Offset: 0x2179020 VA: 0x18217AA20
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F3A0 Offset: 0x9E7A0 VA: 0x18009F3A0
	// RVA: 0x217A920 Offset: 0x2178F20 VA: 0x18217A920
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x217A8E0 Offset: 0x2178EE0 VA: 0x18217A8E0
	public Color32[] GetPixels32() { }

	// RVA: 0x217BB30 Offset: 0x217A130 VA: 0x18217BB30
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x217B990 Offset: 0x2179F90 VA: 0x18217B990
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217BBF0 Offset: 0x217A1F0 VA: 0x18217BBF0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x217B850 Offset: 0x2179E50 VA: 0x18217B850
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217BAA0 Offset: 0x217A0A0 VA: 0x18217BAA0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217B8F0 Offset: 0x2179EF0 VA: 0x18217B8F0
	public void .ctor(int width, int height) { }

	// RVA: 0x217B480 Offset: 0x2179A80 VA: 0x18217B480
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x217B670 Offset: 0x2179C70 VA: 0x18217B670
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x217B7A0 Offset: 0x2179DA0 VA: 0x18217B7A0
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217B730 Offset: 0x2179D30 VA: 0x18217B730
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217A800 Offset: 0x2178E00 VA: 0x18217A800
	public Color GetPixel(int x, int y) { }

	// RVA: 0x217A640 Offset: 0x2178C40 VA: 0x18217A640
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x217AD30 Offset: 0x2179330 VA: 0x18217AD30
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BB10 Offset: 0x1A3A110 VA: 0x181A3BB10
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1A3B9F0 Offset: 0x1A39FF0 VA: 0x181A3B9F0
	|-Texture2D.GetRawTextureData<Color32>
	*/

	// RVA: 0x217A3E0 Offset: 0x21789E0 VA: 0x18217A3E0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217A3D0 Offset: 0x21789D0 VA: 0x18217A3D0
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x217A3C0 Offset: 0x21789C0 VA: 0x18217A3C0
	public void Apply() { }

	// RVA: 0x217B250 Offset: 0x2179850 VA: 0x18217B250
	public bool Resize(int width, int height) { }

	// RVA: 0x217B190 Offset: 0x2179790 VA: 0x18217B190
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x217B000 Offset: 0x2179600 VA: 0x18217B000
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217AF30 Offset: 0x2179530 VA: 0x18217AF30
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x217B2F0 Offset: 0x21798F0 VA: 0x18217B2F0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x217B5C0 Offset: 0x2179BC0 VA: 0x18217B5C0
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x217B350 Offset: 0x2179950 VA: 0x18217B350
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x217B550 Offset: 0x2179B50 VA: 0x18217B550
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x217A960 Offset: 0x2178F60 VA: 0x18217A960
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x217AA80 Offset: 0x2179080 VA: 0x18217AA80
	public Color[] GetPixels() { }

	// RVA: 0x217B3B0 Offset: 0x21799B0 VA: 0x18217B3B0
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x217A720 Offset: 0x2178D20 VA: 0x18217A720
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x217A560 Offset: 0x2178B60 VA: 0x18217A560
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x217AE50 Offset: 0x2179450 VA: 0x18217AE50
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

