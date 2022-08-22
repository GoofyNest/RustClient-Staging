public sealed class CubemapArray : Texture // TypeDefIndex: 3449
{	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x18147A0 Offset: 0x1812DA0 VA: 0x1818147A0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2EE0 Offset: 0xA22E0 VA: 0x1800A2EE0
	// RVA: 0x18141F0 Offset: 0x18127F0 VA: 0x1818141F0
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1814250 Offset: 0x1812850 VA: 0x181814250
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1814540 Offset: 0x1812B40 VA: 0x181814540
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1814430 Offset: 0x1812A30 VA: 0x181814430
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1814650 Offset: 0x1812C50 VA: 0x181814650
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1814310 Offset: 0x1812910 VA: 0x181814310
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1814750 Offset: 0x1812D50 VA: 0x181814750
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x1814710 Offset: 0x1812D10 VA: 0x181814710
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

}

