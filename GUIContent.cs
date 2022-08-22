public class GUIContent // TypeDefIndex: 4035
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Texture m_Image; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_Tooltip; // 0x20
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x180B0F0 Offset: 0x18096F0 VA: 0x18180B0F0
	public string get_text() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_text(string value) { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_image(Texture value) { }

	// RVA: 0x1A58ED0 Offset: 0x1A574D0 VA: 0x181A58ED0
	public string get_tooltip() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_tooltip(string value) { }

	// RVA: 0x1A58E40 Offset: 0x1A57440 VA: 0x181A58E40
	public void .ctor() { }

	// RVA: 0x1A58DE0 Offset: 0x1A573E0 VA: 0x181A58DE0
	public void .ctor(string text) { }

	// RVA: 0x1A58EB0 Offset: 0x1A574B0 VA: 0x181A58EB0
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x1A58C40 Offset: 0x1A57240 VA: 0x181A58C40
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1A58D10 Offset: 0x1A57310 VA: 0x181A58D10
	public void .ctor(GUIContent src) { }

	// RVA: 0x1A58720 Offset: 0x1A56D20 VA: 0x181A58720
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCD160 Offset: 0xCC560 VA: 0x1800CD160
	// RVA: 0x1A585C0 Offset: 0x1A56BC0 VA: 0x181A585C0
	internal static void ClearStaticCache() { }

	// RVA: 0x1A587E0 Offset: 0x1A56DE0 VA: 0x181A587E0
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x1A589F0 Offset: 0x1A56FF0 VA: 0x181A589F0
	private static void .cctor() { }

}

