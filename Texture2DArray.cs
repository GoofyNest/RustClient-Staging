public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	// Properties
	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA28D0 Offset: 0xA1CD0 VA: 0x1800A28D0
	// RVA: 0x217A430 Offset: 0x2178A30 VA: 0x18217A430
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA2420 Offset: 0xA1820 VA: 0x1800A2420
	// RVA: 0x217A460 Offset: 0x2178A60 VA: 0x18217A460
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E800 Offset: 0x9DC00 VA: 0x18009E800
	// RVA: 0x217A4A0 Offset: 0x2178AA0 VA: 0x18217A4A0
	public TextureFormat get_format() { }

	// RVA: 0x217A4E0 Offset: 0x2178AE0 VA: 0x18217A4E0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA29A0 Offset: 0xA1DA0 VA: 0x1800A29A0
	// RVA: 0x2179E40 Offset: 0x2178440 VA: 0x182179E40
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2179EA0 Offset: 0x21784A0 VA: 0x182179EA0
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2179F70 Offset: 0x2178570 VA: 0x182179F70
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x217A1A0 Offset: 0x21787A0 VA: 0x18217A1A0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217A360 Offset: 0x2178960 VA: 0x18217A360
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217A090 Offset: 0x2178690 VA: 0x18217A090
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x217A310 Offset: 0x2178910 VA: 0x18217A310
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217A2C0 Offset: 0x21788C0 VA: 0x18217A2C0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

