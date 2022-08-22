public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	// Properties
	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA2960 Offset: 0xA1D60 VA: 0x1800A2960
	// RVA: 0x217A270 Offset: 0x2178870 VA: 0x18217A270
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	// RVA: 0x217A2A0 Offset: 0x21788A0 VA: 0x18217A2A0
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x217A2E0 Offset: 0x21788E0 VA: 0x18217A2E0
	public TextureFormat get_format() { }

	// RVA: 0x217A320 Offset: 0x2178920 VA: 0x18217A320 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2A00 Offset: 0xA1E00 VA: 0x1800A2A00
	// RVA: 0x2179C80 Offset: 0x2178280 VA: 0x182179C80
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2179CE0 Offset: 0x21782E0 VA: 0x182179CE0
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2179DB0 Offset: 0x21783B0 VA: 0x182179DB0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179FE0 Offset: 0x21785E0 VA: 0x182179FE0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217A1A0 Offset: 0x21787A0 VA: 0x18217A1A0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2179ED0 Offset: 0x21784D0 VA: 0x182179ED0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x217A150 Offset: 0x2178750 VA: 0x18217A150
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217A100 Offset: 0x2178700 VA: 0x18217A100
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

