public sealed class Cubemap : Texture // TypeDefIndex: 3446
{	// Properties
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x1814DE0 Offset: 0x18133E0 VA: 0x181814DE0
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x9FB40 Offset: 0x9EF40 VA: 0x18009FB40
	// RVA: 0x18147E0 Offset: 0x1812DE0 VA: 0x1818147E0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1814840 Offset: 0x1812E40 VA: 0x181814840
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1814E20 Offset: 0x1813420 VA: 0x181814E20 Slot: 11
	public override bool get_isReadable() { }

	// RVA: 0x18149C0 Offset: 0x1812FC0 VA: 0x1818149C0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1814B40 Offset: 0x1813140 VA: 0x181814B40
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1814950 Offset: 0x1812F50 VA: 0x181814950
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x1814C20 Offset: 0x1813220 VA: 0x181814C20
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1814CD0 Offset: 0x18132D0 VA: 0x181814CD0
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x1814910 Offset: 0x1812F10 VA: 0x181814910
	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x1814AB0 Offset: 0x18130B0 VA: 0x181814AB0
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

