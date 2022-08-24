public class GraphicsFormatUtility // TypeDefIndex: 3903
{
	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	internal static GraphicsFormat GetFormat(Texture texture) { }

	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x856F0 Offset: 0x84AF0 VA: 0x1800856F0
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x856F0 Offset: 0x84AF0 VA: 0x1800856F0
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x856F0 Offset: 0x84AF0 VA: 0x1800856F0
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85A80 Offset: 0x84E80 VA: 0x180085A80
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	public static bool IsCrunchFormat(TextureFormat format) { }

}

