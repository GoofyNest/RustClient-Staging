public class GraphicsFormatUtility // TypeDefIndex: 3903
{	// Methods

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182CB70 Offset: 0x182B170 VA: 0x18182CB70
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x182CBF0 Offset: 0x182B1F0 VA: 0x18182CBF0
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x182CBF0 Offset: 0x182B1F0 VA: 0x18182CBF0
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x182CBB0 Offset: 0x182B1B0 VA: 0x18182CBB0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182CBB0 Offset: 0x182B1B0 VA: 0x18182CBB0
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x182CC30 Offset: 0x182B230 VA: 0x18182CC30
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x182CD30 Offset: 0x182B330 VA: 0x18182CD30
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x182CC90 Offset: 0x182B290 VA: 0x18182CC90
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85990 Offset: 0x84D90 VA: 0x180085990
	// RVA: 0x182CCD0 Offset: 0x182B2D0 VA: 0x18182CCD0
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x182CD10 Offset: 0x182B310 VA: 0x18182CD10
	public static bool IsCrunchFormat(TextureFormat format) { }

}

