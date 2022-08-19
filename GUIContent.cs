public class GUIContent // TypeDefIndex: 4035
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Texture m_Image; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1A6C720 Offset: 0x1A6AD20 VA: 0x181A6C720
	public string get_tooltip() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_tooltip(string value) { }

	// RVA: 0x1A6C690 Offset: 0x1A6AC90 VA: 0x181A6C690
	public void .ctor() { }

	// RVA: 0x1A6C630 Offset: 0x1A6AC30 VA: 0x181A6C630
	public void .ctor(string text) { }

	// RVA: 0x1A6C700 Offset: 0x1A6AD00 VA: 0x181A6C700
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x1A6C490 Offset: 0x1A6AA90 VA: 0x181A6C490
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1A6C560 Offset: 0x1A6AB60 VA: 0x181A6C560
	public void .ctor(GUIContent src) { }

	// RVA: 0x1A6BF70 Offset: 0x1A6A570 VA: 0x181A6BF70
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCD0D0 Offset: 0xCC4D0 VA: 0x1800CD0D0
	// RVA: 0x1A6BE10 Offset: 0x1A6A410 VA: 0x181A6BE10
	internal static void ClearStaticCache() { }

	// RVA: 0x1A6C030 Offset: 0x1A6A630 VA: 0x181A6C030
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x1A6C240 Offset: 0x1A6A840 VA: 0x181A6C240
	private static void .cctor() { }

}

