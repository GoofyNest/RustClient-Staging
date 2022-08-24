public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	public int depth { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0xA2590 Offset: 0xA1990 VA: 0x1800A2590
	public int get_depth() { }

	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2640 Offset: 0xA1A40 VA: 0x1800A2640
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA26C0 Offset: 0xA1AC0 VA: 0x1800A26C0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA2790 Offset: 0xA1B90 VA: 0x1800A2790
	public void SetPixels(Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply() { }

}

