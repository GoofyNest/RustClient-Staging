public sealed class Cubemap : Texture // TypeDefIndex: 3446
{	public TextureFormat format { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0x9E8B0 Offset: 0x9DCB0 VA: 0x18009E8B0
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x9FBA0 Offset: 0x9EFA0 VA: 0x18009FBA0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	public override bool get_isReadable() { }

	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, TextureFormat format, int mipCount) { }

	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

