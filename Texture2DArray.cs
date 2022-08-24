public sealed class Texture2DArray : Texture // TypeDefIndex: 3448
{	public static int allSlices { get; }
	public int depth { get; }
	public TextureFormat format { get; }
	public override bool isReadable { get; }


	[NativeNameAttribute] // RVA: 0xA2A40 Offset: 0xA1E40 VA: 0x1800A2A40
	public static int get_allSlices() { }

	[NativeNameAttribute] // RVA: 0xA2590 Offset: 0xA1990 VA: 0x1800A2590
	public int get_depth() { }

	[NativeNameAttribute] // RVA: 0x9E8B0 Offset: 0x9DCB0 VA: 0x18009E8B0
	public TextureFormat get_format() { }

	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xA2AF0 Offset: 0xA1EF0 VA: 0x1800A2AF0
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

}

