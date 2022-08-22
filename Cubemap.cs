public sealed class Cubemap : Texture // TypeDefIndex: 3446
{	public TextureFormat format { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x9FB40 Offset: 0x9EF40 VA: 0x18009FB40
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, TextureFormat format, int mipCount) { }

	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

