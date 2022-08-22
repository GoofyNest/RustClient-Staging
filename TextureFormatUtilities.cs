public static class TextureFormatUtilities // TypeDefIndex: 11873
{	// Fields
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10

	// Methods

	// RVA: 0x11E3210 Offset: 0x11E1810 VA: 0x1811E3210
	private static void .cctor() { }

	// RVA: 0x11E2FE0 Offset: 0x11E15E0 VA: 0x1811E2FE0
	private static bool IsObsolete(object value) { }

	// RVA: 0x11E2DF0 Offset: 0x11E13F0 VA: 0x1811E2DF0
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E30F0 Offset: 0x11E16F0 VA: 0x1811E30F0
	internal static bool IsSupported(RenderTextureFormat format) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E3180 Offset: 0x11E1780 VA: 0x1811E3180
	internal static bool IsSupported(TextureFormat format) { }

}

