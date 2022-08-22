public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	// RVA: 0x217C9D0 Offset: 0x217AFD0 VA: 0x18217C9D0
	public int get_depth() { }

	// RVA: 0x217CA10 Offset: 0x217B010 VA: 0x18217CA10 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2560 Offset: 0xA1960 VA: 0x1800A2560
	// RVA: 0x217C2B0 Offset: 0x217A8B0 VA: 0x18217C2B0
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C310 Offset: 0x217A910 VA: 0x18217C310
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA2630 Offset: 0xA1A30 VA: 0x1800A2630
	// RVA: 0x217C110 Offset: 0x217A710 VA: 0x18217C110
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA26C0 Offset: 0xA1AC0 VA: 0x1800A26C0
	// RVA: 0x217C3E0 Offset: 0x217A9E0 VA: 0x18217C3E0
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x217C440 Offset: 0x217AA40 VA: 0x18217C440
	public void SetPixels(Color[] colors) { }

	// RVA: 0x217C6C0 Offset: 0x217ACC0 VA: 0x18217C6C0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217C490 Offset: 0x217AA90 VA: 0x18217C490
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x217C900 Offset: 0x217AF00 VA: 0x18217C900
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x217C5B0 Offset: 0x217ABB0 VA: 0x18217C5B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x217C7E0 Offset: 0x217ADE0 VA: 0x18217C7E0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x217C170 Offset: 0x217A770 VA: 0x18217C170
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x217C220 Offset: 0x217A820 VA: 0x18217C220
	public void Apply() { }

}

