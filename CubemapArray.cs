public sealed class CubemapArray : Texture // TypeDefIndex: 3449
{	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x1827360 Offset: 0x1825960 VA: 0x181827360 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2EE0 Offset: 0xA22E0 VA: 0x1800A2EE0
	// RVA: 0x1826DB0 Offset: 0x18253B0 VA: 0x181826DB0
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1826E10 Offset: 0x1825410 VA: 0x181826E10
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1827100 Offset: 0x1825700 VA: 0x181827100
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1826FF0 Offset: 0x18255F0 VA: 0x181826FF0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1827210 Offset: 0x1825810 VA: 0x181827210
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1826ED0 Offset: 0x18254D0 VA: 0x181826ED0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1827310 Offset: 0x1825910 VA: 0x181827310
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x18272D0 Offset: 0x18258D0 VA: 0x1818272D0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

}

