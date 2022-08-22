public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	// Properties
	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA2960 Offset: 0xA1D60 VA: 0x1800A2960
	// RVA: 0x217A530 Offset: 0x2178B30 VA: 0x18217A530
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	// RVA: 0x217A560 Offset: 0x2178B60 VA: 0x18217A560
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x217A5A0 Offset: 0x2178BA0 VA: 0x18217A5A0
	public TextureFormat get_format() { }

	// RVA: 0x217A5E0 Offset: 0x2178BE0 VA: 0x18217A5E0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2A00 Offset: 0xA1E00 VA: 0x1800A2A00
	// RVA: 0x2179F40 Offset: 0x2178540 VA: 0x182179F40
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2179FA0 Offset: 0x21785A0 VA: 0x182179FA0
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217A070 Offset: 0x2178670 VA: 0x18217A070
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217A2A0 Offset: 0x21788A0 VA: 0x18217A2A0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217A460 Offset: 0x2178A60 VA: 0x18217A460
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217A190 Offset: 0x2178790 VA: 0x18217A190
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x217A410 Offset: 0x2178A10 VA: 0x18217A410
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x217A3C0 Offset: 0x21789C0 VA: 0x18217A3C0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

