public sealed class CubemapArray : Texture // TypeDefIndex: 3449
{	public override bool isReadable { get; }


	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA3000 Offset: 0xA2400 VA: 0x1800A3000
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

}

