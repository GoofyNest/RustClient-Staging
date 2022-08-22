public class GraphicsFormatUtility // TypeDefIndex: 3903
{	// Methods

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1819FB0 Offset: 0x18185B0 VA: 0x181819FB0
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x181A030 Offset: 0x1818630 VA: 0x18181A030
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x181A030 Offset: 0x1818630 VA: 0x18181A030
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1819FF0 Offset: 0x18185F0 VA: 0x181819FF0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1819FF0 Offset: 0x18185F0 VA: 0x181819FF0
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x181A070 Offset: 0x1818670 VA: 0x18181A070
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x181A170 Offset: 0x1818770 VA: 0x18181A170
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x181A0D0 Offset: 0x18186D0 VA: 0x18181A0D0
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85990 Offset: 0x84D90 VA: 0x180085990
	// RVA: 0x181A110 Offset: 0x1818710 VA: 0x18181A110
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x181A150 Offset: 0x1818750 VA: 0x18181A150
	public static bool IsCrunchFormat(TextureFormat format) { }

}

