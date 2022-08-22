public static class TextureFormatUtilities // TypeDefIndex: 11873
{	// Fields
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10

	// Methods

	// RVA: 0x11E38B0 Offset: 0x11E1EB0 VA: 0x1811E38B0
	private static void .cctor() { }

	// RVA: 0x11E3680 Offset: 0x11E1C80 VA: 0x1811E3680
	private static bool IsObsolete(object value) { }

	// RVA: 0x11E3490 Offset: 0x11E1A90 VA: 0x1811E3490
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E3790 Offset: 0x11E1D90 VA: 0x1811E3790
	internal static bool IsSupported(RenderTextureFormat format) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E3820 Offset: 0x11E1E20 VA: 0x1811E3820
	internal static bool IsSupported(TextureFormat format) { }

}

