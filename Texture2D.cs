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
	// RVA: 0x217C800 Offset: 0x217AE00 VA: 0x18217C800
	public TextureFormat get_format() { }

	// RVA: 0x217C880 Offset: 0x217AE80 VA: 0x18217C880
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x217C7D0 Offset: 0x217ADD0 VA: 0x18217C7D0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x217AFF0 Offset: 0x21795F0 VA: 0x18217AFF0
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E980 Offset: 0x9DD80 VA: 0x18009E980
	// RVA: 0x217B680 Offset: 0x2179C80 VA: 0x18217B680
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217B6E0 Offset: 0x2179CE0 VA: 0x18217B6E0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217C840 Offset: 0x217AE40 VA: 0x18217C840 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EAC0 Offset: 0x9DEC0 VA: 0x18009EAC0
	// RVA: 0x217AE40 Offset: 0x2179440 VA: 0x18217AE40
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EB30 Offset: 0x9DF30 VA: 0x18009EB30
	// RVA: 0x217BBB0 Offset: 0x217A1B0 VA: 0x18217BBB0
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EC60 Offset: 0x9E060 VA: 0x18009EC60
	// RVA: 0x217BEF0 Offset: 0x217A4F0 VA: 0x18217BEF0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9ECF0 Offset: 0x9E0F0 VA: 0x18009ECF0
	// RVA: 0x217B260 Offset: 0x2179860 VA: 0x18217B260
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9ED60 Offset: 0x9E160 VA: 0x18009ED60
	// RVA: 0x217B0A0 Offset: 0x21796A0 VA: 0x18217B0A0
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EDD0 Offset: 0x9E1D0 VA: 0x18009EDD0
	// RVA: 0x217BC00 Offset: 0x217A200 VA: 0x18217BC00
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EE10 Offset: 0x9E210 VA: 0x18009EE10
	// RVA: 0x217B9A0 Offset: 0x2179FA0 VA: 0x18217B9A0
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EE50 Offset: 0x9E250 VA: 0x18009EE50
	// RVA: 0x217C0F0 Offset: 0x217A6F0 VA: 0x18217C0F0
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9EF60 Offset: 0x9E360 VA: 0x18009EF60
	// RVA: 0x217B7B0 Offset: 0x2179DB0 VA: 0x18217B7B0
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	// RVA: 0x217B640 Offset: 0x2179C40 VA: 0x18217B640
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x217B600 Offset: 0x2179C00 VA: 0x18217B600
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EFA0 Offset: 0x9E3A0 VA: 0x18009EFA0
	// RVA: 0x217C8F0 Offset: 0x217AEF0 VA: 0x18217C8F0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F080 Offset: 0x9E480 VA: 0x18009F080
	// RVA: 0x217C8B0 Offset: 0x217AEB0 VA: 0x18217C8B0
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F180 Offset: 0x9E580 VA: 0x18009F180
	// RVA: 0x217AFB0 Offset: 0x21795B0 VA: 0x18217AFB0
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F1E0 Offset: 0x9E5E0 VA: 0x18009F1E0
	// RVA: 0x217AF70 Offset: 0x2179570 VA: 0x18217AF70
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F220 Offset: 0x9E620 VA: 0x18009F220
	// RVA: 0x217BDD0 Offset: 0x217A3D0 VA: 0x18217BDD0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F290 Offset: 0x9E690 VA: 0x18009F290
	// RVA: 0x217BE30 Offset: 0x217A430 VA: 0x18217BE30
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F300 Offset: 0x9E700 VA: 0x18009F300
	// RVA: 0x217B500 Offset: 0x2179B00 VA: 0x18217B500
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F3A0 Offset: 0x9E7A0 VA: 0x18009F3A0
	// RVA: 0x217B400 Offset: 0x2179A00 VA: 0x18217B400
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x217B3C0 Offset: 0x21799C0 VA: 0x18217B3C0
	public Color32[] GetPixels32() { }

	// RVA: 0x217C610 Offset: 0x217AC10 VA: 0x18217C610
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x217C470 Offset: 0x217AA70 VA: 0x18217C470
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C6D0 Offset: 0x217ACD0 VA: 0x18217C6D0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x217C330 Offset: 0x217A930 VA: 0x18217C330
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217C580 Offset: 0x217AB80 VA: 0x18217C580
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217C3D0 Offset: 0x217A9D0 VA: 0x18217C3D0
	public void .ctor(int width, int height) { }

	// RVA: 0x217BF60 Offset: 0x217A560 VA: 0x18217BF60
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x217C150 Offset: 0x217A750 VA: 0x18217C150
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x217C280 Offset: 0x217A880 VA: 0x18217C280
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217C210 Offset: 0x217A810 VA: 0x18217C210
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217B2E0 Offset: 0x21798E0 VA: 0x18217B2E0
	public Color GetPixel(int x, int y) { }

	// RVA: 0x217B120 Offset: 0x2179720 VA: 0x18217B120
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x217B810 Offset: 0x2179E10 VA: 0x18217B810
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B4F0 Offset: 0x1A39AF0 VA: 0x181A3B4F0
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1A3B3D0 Offset: 0x1A399D0 VA: 0x181A3B3D0
	|-Texture2D.GetRawTextureData<Color32>
	*/

	// RVA: 0x217AEC0 Offset: 0x21794C0 VA: 0x18217AEC0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217AEB0 Offset: 0x21794B0 VA: 0x18217AEB0
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x217AEA0 Offset: 0x21794A0 VA: 0x18217AEA0
	public void Apply() { }

	// RVA: 0x217BD30 Offset: 0x217A330 VA: 0x18217BD30
	public bool Resize(int width, int height) { }

	// RVA: 0x217BC70 Offset: 0x217A270 VA: 0x18217BC70
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x217BAE0 Offset: 0x217A0E0 VA: 0x18217BAE0
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217BA10 Offset: 0x217A010 VA: 0x18217BA10
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x217BDD0 Offset: 0x217A3D0 VA: 0x18217BDD0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x217C0A0 Offset: 0x217A6A0 VA: 0x18217C0A0
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x217BE30 Offset: 0x217A430 VA: 0x18217BE30
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x217C030 Offset: 0x217A630 VA: 0x18217C030
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x217B440 Offset: 0x2179A40 VA: 0x18217B440
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x217B560 Offset: 0x2179B60 VA: 0x18217B560
	public Color[] GetPixels() { }

	// RVA: 0x217BE90 Offset: 0x217A490 VA: 0x18217BE90
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x217B200 Offset: 0x2179800 VA: 0x18217B200
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x217B040 Offset: 0x2179640 VA: 0x18217B040
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x217B930 Offset: 0x2179F30 VA: 0x18217B930
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

