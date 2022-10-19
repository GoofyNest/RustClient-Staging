public static class TextureFormatUtilities // TypeDefIndex: 13623
{
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; 
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; 
	private static Dictionary<int, bool> s_SupportedTextureFormats; 


	private static void .cctor() { }

	private static bool IsObsolete(object value) { }

	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[ExtensionAttribute] 
	internal static bool IsSupported(RenderTextureFormat format) { }

	[ExtensionAttribute] 
	internal static bool IsSupported(TextureFormat format) { }

}

