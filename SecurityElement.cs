public sealed class SecurityElement // TypeDefIndex: 905
{	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public Hashtable Attributes { get; }
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { get; set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x17C4CB0 Offset: 0x17C32B0 VA: 0x1817C4CB0
	public void .ctor(string tag) { }

	// RVA: 0x17C4CC0 Offset: 0x17C32C0 VA: 0x1817C4CC0
	public void .ctor(string tag, string text) { }

	// RVA: 0x17C4F70 Offset: 0x17C3570 VA: 0x1817C4F70
	public Hashtable get_Attributes() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public ArrayList get_Children() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Tag() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Text() { }

	// RVA: 0x17C51E0 Offset: 0x17C37E0 VA: 0x1817C51E0
	public void set_Text(string value) { }

	// RVA: 0x17C3800 Offset: 0x17C1E00 VA: 0x1817C3800
	public void AddAttribute(string name, string value) { }

	// RVA: 0x17C39A0 Offset: 0x17C1FA0 VA: 0x1817C39A0
	public void AddChild(SecurityElement child) { }

	// RVA: 0x17C3A70 Offset: 0x17C2070 VA: 0x1817C3A70
	public static string Escape(string str) { }

	// RVA: 0x17C49E0 Offset: 0x17C2FE0 VA: 0x1817C49E0
	private static string Unescape(string str) { }

	// RVA: 0x17C3C50 Offset: 0x17C2250 VA: 0x1817C3C50
	public static SecurityElement FromString(string xml) { }

	// RVA: 0x17C3F60 Offset: 0x17C2560 VA: 0x1817C3F60
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x17C3FE0 Offset: 0x17C25E0 VA: 0x1817C3FE0
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x17C4060 Offset: 0x17C2660 VA: 0x1817C4060
	public static bool IsValidTag(string tag) { }

	// RVA: 0x17C40E0 Offset: 0x17C26E0 VA: 0x1817C40E0
	public static bool IsValidText(string text) { }

	// RVA: 0x17C4160 Offset: 0x17C2760 VA: 0x1817C4160
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x17C4460 Offset: 0x17C2A60 VA: 0x1817C4460 Slot: 3
	public override string ToString() { }

	// RVA: 0x17C44F0 Offset: 0x17C2AF0 VA: 0x1817C44F0
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x17C3D90 Offset: 0x17C2390 VA: 0x1817C3D90
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_m_strText(string value) { }

	// RVA: 0x17C42A0 Offset: 0x17C28A0 VA: 0x1817C42A0
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x17C4AF0 Offset: 0x17C30F0 VA: 0x1817C4AF0
	private static void .cctor() { }

}

internal class SecurityElement.SecurityAttribute // TypeDefIndex: 906
{	// Fields
	private string _name; // 0x10
	private string _value; // 0x18

	// Properties
	public string Name { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x17C29E0 Offset: 0x17C0FE0 VA: 0x1817C29E0
	public void .ctor(string name, string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Value() { }

}

