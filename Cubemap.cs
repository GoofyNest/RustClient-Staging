public sealed class Cubemap : Texture // TypeDefIndex: 3446
{	// Properties
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x18279A0 Offset: 0x1825FA0 VA: 0x1818279A0
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x9FB40 Offset: 0x9EF40 VA: 0x18009FB40
	// RVA: 0x18273A0 Offset: 0x18259A0 VA: 0x1818273A0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1827400 Offset: 0x1825A00 VA: 0x181827400
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x18279E0 Offset: 0x1825FE0 VA: 0x1818279E0 Slot: 11
	public override bool get_isReadable() { }

	// RVA: 0x1827580 Offset: 0x1825B80 VA: 0x181827580
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1827700 Offset: 0x1825D00 VA: 0x181827700
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1827510 Offset: 0x1825B10 VA: 0x181827510
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x18277E0 Offset: 0x1825DE0 VA: 0x1818277E0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1827890 Offset: 0x1825E90 VA: 0x181827890
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x18274D0 Offset: 0x1825AD0 VA: 0x1818274D0
	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x1827670 Offset: 0x1825C70 VA: 0x181827670
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

