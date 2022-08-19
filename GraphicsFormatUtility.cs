public class GraphicsFormatUtility // TypeDefIndex: 3903
{	// Methods

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x182C8F0 Offset: 0x182AEF0 VA: 0x18182C8F0
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x182C970 Offset: 0x182AF70 VA: 0x18182C970
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	// RVA: 0x182C970 Offset: 0x182AF70 VA: 0x18182C970
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x182C930 Offset: 0x182AF30 VA: 0x18182C930
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x182C930 Offset: 0x182AF30 VA: 0x18182C930
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x182C9B0 Offset: 0x182AFB0 VA: 0x18182C9B0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	// RVA: 0x182CAB0 Offset: 0x182B0B0 VA: 0x18182CAB0
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	// RVA: 0x182CA10 Offset: 0x182B010 VA: 0x18182CA10
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x858D0 Offset: 0x84CD0 VA: 0x1800858D0
	// RVA: 0x182CA50 Offset: 0x182B050 VA: 0x18182CA50
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x182CA90 Offset: 0x182B090 VA: 0x18182CA90
	public static bool IsCrunchFormat(TextureFormat format) { }

}

