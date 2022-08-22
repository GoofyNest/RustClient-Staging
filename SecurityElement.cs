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

	// RVA: 0x17C2AC0 Offset: 0x17C10C0 VA: 0x1817C2AC0
	public void .ctor(string tag) { }

	// RVA: 0x17C2AD0 Offset: 0x17C10D0 VA: 0x1817C2AD0
	public void .ctor(string tag, string text) { }

	// RVA: 0x17C2D80 Offset: 0x17C1380 VA: 0x1817C2D80
	public Hashtable get_Attributes() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public ArrayList get_Children() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Tag() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Text() { }

	// RVA: 0x17C2FF0 Offset: 0x17C15F0 VA: 0x1817C2FF0
	public void set_Text(string value) { }

	// RVA: 0x17C1610 Offset: 0x17BFC10 VA: 0x1817C1610
	public void AddAttribute(string name, string value) { }

	// RVA: 0x17C17B0 Offset: 0x17BFDB0 VA: 0x1817C17B0
	public void AddChild(SecurityElement child) { }

	// RVA: 0x17C1880 Offset: 0x17BFE80 VA: 0x1817C1880
	public static string Escape(string str) { }

	// RVA: 0x17C27F0 Offset: 0x17C0DF0 VA: 0x1817C27F0
	private static string Unescape(string str) { }

	// RVA: 0x17C1A60 Offset: 0x17C0060 VA: 0x1817C1A60
	public static SecurityElement FromString(string xml) { }

	// RVA: 0x17C1D70 Offset: 0x17C0370 VA: 0x1817C1D70
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x17C1DF0 Offset: 0x17C03F0 VA: 0x1817C1DF0
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x17C1E70 Offset: 0x17C0470 VA: 0x1817C1E70
	public static bool IsValidTag(string tag) { }

	// RVA: 0x17C1EF0 Offset: 0x17C04F0 VA: 0x1817C1EF0
	public static bool IsValidText(string text) { }

	// RVA: 0x17C1F70 Offset: 0x17C0570 VA: 0x1817C1F70
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x17C2270 Offset: 0x17C0870 VA: 0x1817C2270 Slot: 3
	public override string ToString() { }

	// RVA: 0x17C2300 Offset: 0x17C0900 VA: 0x1817C2300
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x17C1BA0 Offset: 0x17C01A0 VA: 0x1817C1BA0
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_m_strText(string value) { }

	// RVA: 0x17C20B0 Offset: 0x17C06B0 VA: 0x1817C20B0
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x17C2900 Offset: 0x17C0F00 VA: 0x1817C2900
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

	// RVA: 0x17C07F0 Offset: 0x17BEDF0 VA: 0x1817C07F0
	public void .ctor(string name, string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Value() { }

}

