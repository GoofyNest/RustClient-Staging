public static class TextureFormatUtilities // TypeDefIndex: 11873
{	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10


	private static void .cctor() { }

	private static bool IsObsolete(object value) { }

	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool IsSupported(RenderTextureFormat format) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool IsSupported(TextureFormat format) { }

}

