public static class TextureFormatUtilities // TypeDefIndex: 11873
{	// Fields
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10

	// Methods

	// RVA: 0x11E2F50 Offset: 0x11E1550 VA: 0x1811E2F50
	private static void .cctor() { }

	// RVA: 0x11E2D20 Offset: 0x11E1320 VA: 0x1811E2D20
	private static bool IsObsolete(object value) { }

	// RVA: 0x11E2B30 Offset: 0x11E1130 VA: 0x1811E2B30
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E2E30 Offset: 0x11E1430 VA: 0x1811E2E30
	internal static bool IsSupported(RenderTextureFormat format) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E2EC0 Offset: 0x11E14C0 VA: 0x1811E2EC0
	internal static bool IsSupported(TextureFormat format) { }

}

