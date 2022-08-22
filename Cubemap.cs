public sealed class Cubemap : Texture // TypeDefIndex: 3446
{	// Properties
	public TextureFormat format { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	// RVA: 0x18276E0 Offset: 0x1825CE0 VA: 0x1818276E0
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x9FB40 Offset: 0x9EF40 VA: 0x18009FB40
	// RVA: 0x18270E0 Offset: 0x18256E0 VA: 0x1818270E0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1827140 Offset: 0x1825740 VA: 0x181827140
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1827720 Offset: 0x1825D20 VA: 0x181827720 Slot: 11
	public override bool get_isReadable() { }

	// RVA: 0x18272C0 Offset: 0x18258C0 VA: 0x1818272C0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1827440 Offset: 0x1825A40 VA: 0x181827440
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1827250 Offset: 0x1825850 VA: 0x181827250
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x1827520 Offset: 0x1825B20 VA: 0x181827520
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x18275D0 Offset: 0x1825BD0 VA: 0x1818275D0
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x1827210 Offset: 0x1825810 VA: 0x181827210
	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x18273B0 Offset: 0x18259B0 VA: 0x1818273B0
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

}

