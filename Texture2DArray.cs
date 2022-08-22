public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0xA2960 Offset: 0xA1D60 VA: 0x1800A2960
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA24B0 Offset: 0xA18B0 VA: 0x1800A24B0
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E890 Offset: 0x9DC90 VA: 0x18009E890
	public TextureFormat get_format() { }

	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2A00 Offset: 0xA1E00 VA: 0x1800A2A00
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

