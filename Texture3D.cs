public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	// RVA: 0x217D1F0 Offset: 0x217B7F0 VA: 0x18217D1F0
	public int get_depth() { }

	// RVA: 0x217D230 Offset: 0x217B830 VA: 0x18217D230 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2560 Offset: 0xA1960 VA: 0x1800A2560
	// RVA: 0x217CAD0 Offset: 0x217B0D0 VA: 0x18217CAD0
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217CB30 Offset: 0x217B130 VA: 0x18217CB30
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA2630 Offset: 0xA1A30 VA: 0x1800A2630
	// RVA: 0x217C930 Offset: 0x217AF30 VA: 0x18217C930
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA26C0 Offset: 0xA1AC0 VA: 0x1800A26C0
	// RVA: 0x217CC00 Offset: 0x217B200 VA: 0x18217CC00
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217CC60 Offset: 0x217B260 VA: 0x18217CC60
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217CEE0 Offset: 0x217B4E0 VA: 0x18217CEE0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217CCB0 Offset: 0x217B2B0 VA: 0x18217CCB0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217D120 Offset: 0x217B720 VA: 0x18217D120
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217CDD0 Offset: 0x217B3D0 VA: 0x18217CDD0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x217D000 Offset: 0x217B600 VA: 0x18217D000
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217C990 Offset: 0x217AF90 VA: 0x18217C990
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217CA40 Offset: 0x217B040 VA: 0x18217CA40
	public void Apply() { }

}

