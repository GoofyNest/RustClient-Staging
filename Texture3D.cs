public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA2420 Offset: 0xA1820 VA: 0x1800A2420
	// RVA: 0x217C8D0 Offset: 0x217AED0 VA: 0x18217C8D0
	public int get_depth() { }

	// RVA: 0x217C910 Offset: 0x217AF10 VA: 0x18217C910 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA24A0 Offset: 0xA18A0 VA: 0x1800A24A0
	// RVA: 0x217C1B0 Offset: 0x217A7B0 VA: 0x18217C1B0
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C210 Offset: 0x217A810 VA: 0x18217C210
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA25F0 Offset: 0xA19F0 VA: 0x1800A25F0
	// RVA: 0x217C010 Offset: 0x217A610 VA: 0x18217C010
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA2630 Offset: 0xA1A30 VA: 0x1800A2630
	// RVA: 0x217C2E0 Offset: 0x217A8E0 VA: 0x18217C2E0
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217C340 Offset: 0x217A940 VA: 0x18217C340
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217C5C0 Offset: 0x217ABC0 VA: 0x18217C5C0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x217C390 Offset: 0x217A990 VA: 0x18217C390
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C800 Offset: 0x217AE00 VA: 0x18217C800
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217C4B0 Offset: 0x217AAB0 VA: 0x18217C4B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x217C6E0 Offset: 0x217ACE0 VA: 0x18217C6E0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217C070 Offset: 0x217A670 VA: 0x18217C070
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217C120 Offset: 0x217A720 VA: 0x18217C120
	public void Apply() { }

}

