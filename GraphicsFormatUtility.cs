public class GraphicsFormatUtility // TypeDefIndex: 3903
{
	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	internal static GraphicsFormat GetFormat(Texture texture) { }

	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A550 Offset: 0x79950 VA: 0x18007A550
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85990 Offset: 0x84D90 VA: 0x180085990
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	public static bool IsCrunchFormat(TextureFormat format) { }

}

