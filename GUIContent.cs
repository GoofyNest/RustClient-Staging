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

	// RVA: 0x181DCB0 Offset: 0x181C2B0 VA: 0x18181DCB0
	public string get_text() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_text(string value) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_image(Texture value) { }

	// RVA: 0x1A6C9A0 Offset: 0x1A6AFA0 VA: 0x181A6C9A0
	public string get_tooltip() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_tooltip(string value) { }

	// RVA: 0x1A6C910 Offset: 0x1A6AF10 VA: 0x181A6C910
	public void .ctor() { }

	// RVA: 0x1A6C8B0 Offset: 0x1A6AEB0 VA: 0x181A6C8B0
	public void .ctor(string text) { }

	// RVA: 0x1A6C980 Offset: 0x1A6AF80 VA: 0x181A6C980
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x1A6C710 Offset: 0x1A6AD10 VA: 0x181A6C710
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1A6C7E0 Offset: 0x1A6ADE0 VA: 0x181A6C7E0
	public void .ctor(GUIContent src) { }

	// RVA: 0x1A6C1F0 Offset: 0x1A6A7F0 VA: 0x181A6C1F0
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCD160 Offset: 0xCC560 VA: 0x1800CD160
	// RVA: 0x1A6C090 Offset: 0x1A6A690 VA: 0x181A6C090
	internal static void ClearStaticCache() { }

	// RVA: 0x1A6C2B0 Offset: 0x1A6A8B0 VA: 0x181A6C2B0
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x1A6C4C0 Offset: 0x1A6AAC0 VA: 0x181A6C4C0
	private static void .cctor() { }

}

