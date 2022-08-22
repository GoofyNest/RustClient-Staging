public class GraphicsFormatUtility // TypeDefIndex: 3903
{	// Methods

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182C8B0 Offset: 0x182AEB0 VA: 0x18182C8B0
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x182C930 Offset: 0x182AF30 VA: 0x18182C930
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x182C930 Offset: 0x182AF30 VA: 0x18182C930
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x182C8F0 Offset: 0x182AEF0 VA: 0x18182C8F0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x182C8F0 Offset: 0x182AEF0 VA: 0x18182C8F0
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x182C970 Offset: 0x182AF70 VA: 0x18182C970
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x182CA70 Offset: 0x182B070 VA: 0x18182CA70
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x182C9D0 Offset: 0x182AFD0 VA: 0x18182C9D0
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85990 Offset: 0x84D90 VA: 0x180085990
	// RVA: 0x182CA10 Offset: 0x182B010 VA: 0x18182CA10
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x182CA50 Offset: 0x182B050 VA: 0x18182CA50
	public static bool IsCrunchFormat(TextureFormat format) { }

}

