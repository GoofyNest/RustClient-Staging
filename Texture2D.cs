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
	// RVA: 0x217BFE0 Offset: 0x217A5E0 VA: 0x18217BFE0
	public TextureFormat get_format() { }

	// RVA: 0x217C060 Offset: 0x217A660 VA: 0x18217C060
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x217BFB0 Offset: 0x217A5B0 VA: 0x18217BFB0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x217A7D0 Offset: 0x2178DD0 VA: 0x18217A7D0
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E980 Offset: 0x9DD80 VA: 0x18009E980
	// RVA: 0x217AE60 Offset: 0x2179460 VA: 0x18217AE60
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217AEC0 Offset: 0x21794C0 VA: 0x18217AEC0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217C020 Offset: 0x217A620 VA: 0x18217C020 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EAC0 Offset: 0x9DEC0 VA: 0x18009EAC0
	// RVA: 0x217A620 Offset: 0x2178C20 VA: 0x18217A620
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EB30 Offset: 0x9DF30 VA: 0x18009EB30
	// RVA: 0x217B390 Offset: 0x2179990 VA: 0x18217B390
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EC60 Offset: 0x9E060 VA: 0x18009EC60
	// RVA: 0x217B6D0 Offset: 0x2179CD0 VA: 0x18217B6D0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9ECF0 Offset: 0x9E0F0 VA: 0x18009ECF0
	// RVA: 0x217AA40 Offset: 0x2179040 VA: 0x18217AA40
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9ED60 Offset: 0x9E160 VA: 0x18009ED60
	// RVA: 0x217A880 Offset: 0x2178E80 VA: 0x18217A880
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9EDD0 Offset: 0x9E1D0 VA: 0x18009EDD0
	// RVA: 0x217B3E0 Offset: 0x21799E0 VA: 0x18217B3E0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9EE10 Offset: 0x9E210 VA: 0x18009EE10
	// RVA: 0x217B180 Offset: 0x2179780 VA: 0x18217B180
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EE50 Offset: 0x9E250 VA: 0x18009EE50
	// RVA: 0x217B8D0 Offset: 0x2179ED0 VA: 0x18217B8D0
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9EF60 Offset: 0x9E360 VA: 0x18009EF60
	// RVA: 0x217AF90 Offset: 0x2179590 VA: 0x18217AF90
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	// RVA: 0x217AE20 Offset: 0x2179420 VA: 0x18217AE20
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x217ADE0 Offset: 0x21793E0 VA: 0x18217ADE0
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EFA0 Offset: 0x9E3A0 VA: 0x18009EFA0
	// RVA: 0x217C0D0 Offset: 0x217A6D0 VA: 0x18217C0D0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F080 Offset: 0x9E480 VA: 0x18009F080
	// RVA: 0x217C090 Offset: 0x217A690 VA: 0x18217C090
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F180 Offset: 0x9E580 VA: 0x18009F180
	// RVA: 0x217A790 Offset: 0x2178D90 VA: 0x18217A790
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F1E0 Offset: 0x9E5E0 VA: 0x18009F1E0
	// RVA: 0x217A750 Offset: 0x2178D50 VA: 0x18217A750
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F220 Offset: 0x9E620 VA: 0x18009F220
	// RVA: 0x217B5B0 Offset: 0x2179BB0 VA: 0x18217B5B0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F290 Offset: 0x9E690 VA: 0x18009F290
	// RVA: 0x217B610 Offset: 0x2179C10 VA: 0x18217B610
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F300 Offset: 0x9E700 VA: 0x18009F300
	// RVA: 0x217ACE0 Offset: 0x21792E0 VA: 0x18217ACE0
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F3A0 Offset: 0x9E7A0 VA: 0x18009F3A0
	// RVA: 0x217ABE0 Offset: 0x21791E0 VA: 0x18217ABE0
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x217ABA0 Offset: 0x21791A0 VA: 0x18217ABA0
	public Color32[] GetPixels32() { }

	// RVA: 0x217BDF0 Offset: 0x217A3F0 VA: 0x18217BDF0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x217BC50 Offset: 0x217A250 VA: 0x18217BC50
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217BEB0 Offset: 0x217A4B0 VA: 0x18217BEB0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x217BB10 Offset: 0x217A110 VA: 0x18217BB10
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217BD60 Offset: 0x217A360 VA: 0x18217BD60
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217BBB0 Offset: 0x217A1B0 VA: 0x18217BBB0
	public void .ctor(int width, int height) { }

	// RVA: 0x217B740 Offset: 0x2179D40 VA: 0x18217B740
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x217B930 Offset: 0x2179F30 VA: 0x18217B930
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x217BA60 Offset: 0x217A060 VA: 0x18217BA60
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217B9F0 Offset: 0x2179FF0 VA: 0x18217B9F0
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217AAC0 Offset: 0x21790C0 VA: 0x18217AAC0
	public Color GetPixel(int x, int y) { }

	// RVA: 0x217A900 Offset: 0x2178F00 VA: 0x18217A900
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x217AFF0 Offset: 0x21795F0 VA: 0x18217AFF0
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BDD0 Offset: 0x1A3A3D0 VA: 0x181A3BDD0
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1A3BCB0 Offset: 0x1A3A2B0 VA: 0x181A3BCB0
	|-Texture2D.GetRawTextureData<Color32>
	*/

	// RVA: 0x217A6A0 Offset: 0x2178CA0 VA: 0x18217A6A0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217A690 Offset: 0x2178C90 VA: 0x18217A690
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x217A680 Offset: 0x2178C80 VA: 0x18217A680
	public void Apply() { }

	// RVA: 0x217B510 Offset: 0x2179B10 VA: 0x18217B510
	public bool Resize(int width, int height) { }

	// RVA: 0x217B450 Offset: 0x2179A50 VA: 0x18217B450
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x217B2C0 Offset: 0x21798C0 VA: 0x18217B2C0
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217B1F0 Offset: 0x21797F0 VA: 0x18217B1F0
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x217B5B0 Offset: 0x2179BB0 VA: 0x18217B5B0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x217B880 Offset: 0x2179E80 VA: 0x18217B880
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x217B610 Offset: 0x2179C10 VA: 0x18217B610
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x217B810 Offset: 0x2179E10 VA: 0x18217B810
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x217AC20 Offset: 0x2179220 VA: 0x18217AC20
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x217AD40 Offset: 0x2179340 VA: 0x18217AD40
	public Color[] GetPixels() { }

	// RVA: 0x217B670 Offset: 0x2179C70 VA: 0x18217B670
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x217A9E0 Offset: 0x2178FE0 VA: 0x18217A9E0
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x217A820 Offset: 0x2178E20 VA: 0x18217A820
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x217B110 Offset: 0x2179710 VA: 0x18217B110
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

