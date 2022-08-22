public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	// Properties
	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA2960 Offset: 0xA1D60 VA: 0x1800A2960
	// RVA: 0x217AD50 Offset: 0x2179350 VA: 0x18217AD50
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	// RVA: 0x217AD80 Offset: 0x2179380 VA: 0x18217AD80
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x217ADC0 Offset: 0x21793C0 VA: 0x18217ADC0
	public TextureFormat get_format() { }

	// RVA: 0x217AE00 Offset: 0x2179400 VA: 0x18217AE00 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2A00 Offset: 0xA1E00 VA: 0x1800A2A00
	// RVA: 0x217A760 Offset: 0x2178D60 VA: 0x18217A760
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217A7C0 Offset: 0x2178DC0 VA: 0x18217A7C0
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217A890 Offset: 0x2178E90 VA: 0x18217A890
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217AAC0 Offset: 0x21790C0 VA: 0x18217AAC0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217AC80 Offset: 0x2179280 VA: 0x18217AC80
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217A9B0 Offset: 0x2178FB0 VA: 0x18217A9B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x217AC30 Offset: 0x2179230 VA: 0x18217AC30
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217ABE0 Offset: 0x21791E0 VA: 0x18217ABE0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

