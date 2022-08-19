public sealed class Texture2D : Texture // TypeDefIndex: 3445
{	// Properties
	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x9F880 Offset: 0x9EC80 VA: 0x18009F880
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x9F880 Offset: 0x9EC80 VA: 0x18009F880
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }
	public int requestedMipmapLevel { set; }
	public int minimumMipmapLevel { set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E800 Offset: 0x9DC00 VA: 0x18009E800
	// RVA: 0x217BEE0 Offset: 0x217A4E0 VA: 0x18217BEE0
	public TextureFormat get_format() { }

	// RVA: 0x217BF60 Offset: 0x217A560 VA: 0x18217BF60
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x217BEB0 Offset: 0x217A4B0 VA: 0x18217BEB0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x217A6D0 Offset: 0x2178CD0 VA: 0x18217A6D0
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x9E870 Offset: 0x9DC70 VA: 0x18009E870
	// RVA: 0x217AD60 Offset: 0x2179360 VA: 0x18217AD60
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217ADC0 Offset: 0x21793C0 VA: 0x18217ADC0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x217BF20 Offset: 0x217A520 VA: 0x18217BF20 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x9EA30 Offset: 0x9DE30 VA: 0x18009EA30
	// RVA: 0x217A520 Offset: 0x2178B20 VA: 0x18217A520
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x9EAA0 Offset: 0x9DEA0 VA: 0x18009EAA0
	// RVA: 0x217B290 Offset: 0x2179890 VA: 0x18217B290
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x9EBF0 Offset: 0x9DFF0 VA: 0x18009EBF0
	// RVA: 0x217B5D0 Offset: 0x2179BD0 VA: 0x18217B5D0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x9EC60 Offset: 0x9E060 VA: 0x18009EC60
	// RVA: 0x217A940 Offset: 0x2178F40 VA: 0x18217A940
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x9ECD0 Offset: 0x9E0D0 VA: 0x18009ECD0
	// RVA: 0x217A780 Offset: 0x2178D80 VA: 0x18217A780
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x9ED40 Offset: 0x9E140 VA: 0x18009ED40
	// RVA: 0x217B2E0 Offset: 0x21798E0 VA: 0x18217B2E0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x9ED80 Offset: 0x9E180 VA: 0x18009ED80
	// RVA: 0x217B080 Offset: 0x2179680 VA: 0x18217B080
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x9EDC0 Offset: 0x9E1C0 VA: 0x18009EDC0
	// RVA: 0x217B7D0 Offset: 0x2179DD0 VA: 0x18217B7D0
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x9EE50 Offset: 0x9E250 VA: 0x18009EE50
	// RVA: 0x217AE90 Offset: 0x2179490 VA: 0x18217AE90
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	// RVA: 0x217AD20 Offset: 0x2179320 VA: 0x18217AD20
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x217ACE0 Offset: 0x21792E0 VA: 0x18217ACE0
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x9EF10 Offset: 0x9E310 VA: 0x18009EF10
	// RVA: 0x217BFD0 Offset: 0x217A5D0 VA: 0x18217BFD0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9EFF0 Offset: 0x9E3F0 VA: 0x18009EFF0
	// RVA: 0x217BF90 Offset: 0x217A590 VA: 0x18217BF90
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x9F080 Offset: 0x9E480 VA: 0x18009F080
	// RVA: 0x217A690 Offset: 0x2178C90 VA: 0x18217A690
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F150 Offset: 0x9E550 VA: 0x18009F150
	// RVA: 0x217A650 Offset: 0x2178C50 VA: 0x18217A650
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x9F1C0 Offset: 0x9E5C0 VA: 0x18009F1C0
	// RVA: 0x217B4B0 Offset: 0x2179AB0 VA: 0x18217B4B0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F230 Offset: 0x9E630 VA: 0x18009F230
	// RVA: 0x217B510 Offset: 0x2179B10 VA: 0x18217B510
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F2A0 Offset: 0x9E6A0 VA: 0x18009F2A0
	// RVA: 0x217ABE0 Offset: 0x21791E0 VA: 0x18217ABE0
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x9F340 Offset: 0x9E740 VA: 0x18009F340
	// RVA: 0x217AAE0 Offset: 0x21790E0 VA: 0x18217AAE0
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x217AAA0 Offset: 0x21790A0 VA: 0x18217AAA0
	public Color32[] GetPixels32() { }

	// RVA: 0x217BCF0 Offset: 0x217A2F0 VA: 0x18217BCF0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x217BB50 Offset: 0x217A150 VA: 0x18217BB50
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217BDB0 Offset: 0x217A3B0 VA: 0x18217BDB0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x217BA10 Offset: 0x217A010 VA: 0x18217BA10
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217BC60 Offset: 0x217A260 VA: 0x18217BC60
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217BAB0 Offset: 0x217A0B0 VA: 0x18217BAB0
	public void .ctor(int width, int height) { }

	// RVA: 0x217B640 Offset: 0x2179C40 VA: 0x18217B640
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x217B830 Offset: 0x2179E30 VA: 0x18217B830
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x217B960 Offset: 0x2179F60 VA: 0x18217B960
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217B8F0 Offset: 0x2179EF0 VA: 0x18217B8F0
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217A9C0 Offset: 0x2178FC0 VA: 0x18217A9C0
	public Color GetPixel(int x, int y) { }

	// RVA: 0x217A800 Offset: 0x2178E00 VA: 0x18217A800
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x217AEF0 Offset: 0x21794F0 VA: 0x18217AEF0
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BB50 Offset: 0x1A3A150 VA: 0x181A3BB50
	|-Texture2D.GetRawTextureData<half2>
	|
	|-RVA: 0x1A3BA30 Offset: 0x1A3A030 VA: 0x181A3BA30
	|-Texture2D.GetRawTextureData<Color32>
	*/

	// RVA: 0x217A5A0 Offset: 0x2178BA0 VA: 0x18217A5A0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217A590 Offset: 0x2178B90 VA: 0x18217A590
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x217A580 Offset: 0x2178B80 VA: 0x18217A580
	public void Apply() { }

	// RVA: 0x217B410 Offset: 0x2179A10 VA: 0x18217B410
	public bool Resize(int width, int height) { }

	// RVA: 0x217B350 Offset: 0x2179950 VA: 0x18217B350
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x217B1C0 Offset: 0x21797C0 VA: 0x18217B1C0
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x217B0F0 Offset: 0x21796F0 VA: 0x18217B0F0
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x217B4B0 Offset: 0x2179AB0 VA: 0x18217B4B0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x217B780 Offset: 0x2179D80 VA: 0x18217B780
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x217B510 Offset: 0x2179B10 VA: 0x18217B510
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x217B710 Offset: 0x2179D10 VA: 0x18217B710
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x217AB20 Offset: 0x2179120 VA: 0x18217AB20
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x217AC40 Offset: 0x2179240 VA: 0x18217AC40
	public Color[] GetPixels() { }

	// RVA: 0x217B570 Offset: 0x2179B70 VA: 0x18217B570
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x217A8E0 Offset: 0x2178EE0 VA: 0x18217A8E0
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x217A720 Offset: 0x2178D20 VA: 0x18217A720
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x217B010 Offset: 0x2179610 VA: 0x18217B010
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

