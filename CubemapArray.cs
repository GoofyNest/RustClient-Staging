public sealed class CubemapArray : Texture // TypeDefIndex: 3449
{	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x18270A0 Offset: 0x18256A0 VA: 0x1818270A0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2EE0 Offset: 0xA22E0 VA: 0x1800A2EE0
	// RVA: 0x1826AF0 Offset: 0x18250F0 VA: 0x181826AF0
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1826B50 Offset: 0x1825150 VA: 0x181826B50
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1826E40 Offset: 0x1825440 VA: 0x181826E40
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1826D30 Offset: 0x1825330 VA: 0x181826D30
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1826F50 Offset: 0x1825550 VA: 0x181826F50
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1826C10 Offset: 0x1825210 VA: 0x181826C10
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1827050 Offset: 0x1825650 VA: 0x181827050
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x1827010 Offset: 0x1825610 VA: 0x181827010
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

}

