public sealed class Texture3D : Texture // TypeDefIndex: 3447
{	public int depth { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0xA25D0 Offset: 0xA19D0 VA: 0x1800A25D0
	public int get_depth() { }

	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2680 Offset: 0xA1A80 VA: 0x1800A2680
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xA2750 Offset: 0xA1B50 VA: 0x1800A2750
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xA27E0 Offset: 0xA1BE0 VA: 0x1800A27E0
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

