public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	// RVA: 0x217C710 Offset: 0x217AD10 VA: 0x18217C710
	public int get_depth() { }

	// RVA: 0x217C750 Offset: 0x217AD50 VA: 0x18217C750 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2560 Offset: 0xA1960 VA: 0x1800A2560
	// RVA: 0x217BFF0 Offset: 0x217A5F0 VA: 0x18217BFF0
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C050 Offset: 0x217A650 VA: 0x18217C050
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA2630 Offset: 0xA1A30 VA: 0x1800A2630
	// RVA: 0x217BE50 Offset: 0x217A450 VA: 0x18217BE50
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA26C0 Offset: 0xA1AC0 VA: 0x1800A26C0
	// RVA: 0x217C120 Offset: 0x217A720 VA: 0x18217C120
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217C180 Offset: 0x217A780 VA: 0x18217C180
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217C400 Offset: 0x217AA00 VA: 0x18217C400
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217C1D0 Offset: 0x217A7D0 VA: 0x18217C1D0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C640 Offset: 0x217AC40 VA: 0x18217C640
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217C2F0 Offset: 0x217A8F0 VA: 0x18217C2F0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x217C520 Offset: 0x217AB20 VA: 0x18217C520
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217BEB0 Offset: 0x217A4B0 VA: 0x18217BEB0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217BF60 Offset: 0x217A560 VA: 0x18217BF60
	public void Apply() { }

}

