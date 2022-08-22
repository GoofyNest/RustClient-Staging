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

	// RVA: 0x181D9F0 Offset: 0x181BFF0 VA: 0x18181D9F0
	public string get_text() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_text(string value) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_image(Texture value) { }

	// RVA: 0x1A6C6E0 Offset: 0x1A6ACE0 VA: 0x181A6C6E0
	public string get_tooltip() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_tooltip(string value) { }

	// RVA: 0x1A6C650 Offset: 0x1A6AC50 VA: 0x181A6C650
	public void .ctor() { }

	// RVA: 0x1A6C5F0 Offset: 0x1A6ABF0 VA: 0x181A6C5F0
	public void .ctor(string text) { }

	// RVA: 0x1A6C6C0 Offset: 0x1A6ACC0 VA: 0x181A6C6C0
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x1A6C450 Offset: 0x1A6AA50 VA: 0x181A6C450
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1A6C520 Offset: 0x1A6AB20 VA: 0x181A6C520
	public void .ctor(GUIContent src) { }

	// RVA: 0x1A6BF30 Offset: 0x1A6A530 VA: 0x181A6BF30
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCD160 Offset: 0xCC560 VA: 0x1800CD160
	// RVA: 0x1A6BDD0 Offset: 0x1A6A3D0 VA: 0x181A6BDD0
	internal static void ClearStaticCache() { }

	// RVA: 0x1A6BFF0 Offset: 0x1A6A5F0 VA: 0x181A6BFF0
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x1A6C200 Offset: 0x1A6A800 VA: 0x181A6C200
	private static void .cctor() { }

}

