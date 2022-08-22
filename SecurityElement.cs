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

	// RVA: 0x17C4F70 Offset: 0x17C3570 VA: 0x1817C4F70
	public void .ctor(string tag) { }

	// RVA: 0x17C4F80 Offset: 0x17C3580 VA: 0x1817C4F80
	public void .ctor(string tag, string text) { }

	// RVA: 0x17C5230 Offset: 0x17C3830 VA: 0x1817C5230
	public Hashtable get_Attributes() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public ArrayList get_Children() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Tag() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Text() { }

	// RVA: 0x17C54A0 Offset: 0x17C3AA0 VA: 0x1817C54A0
	public void set_Text(string value) { }

	// RVA: 0x17C3AC0 Offset: 0x17C20C0 VA: 0x1817C3AC0
	public void AddAttribute(string name, string value) { }

	// RVA: 0x17C3C60 Offset: 0x17C2260 VA: 0x1817C3C60
	public void AddChild(SecurityElement child) { }

	// RVA: 0x17C3D30 Offset: 0x17C2330 VA: 0x1817C3D30
	public static string Escape(string str) { }

	// RVA: 0x17C4CA0 Offset: 0x17C32A0 VA: 0x1817C4CA0
	private static string Unescape(string str) { }

	// RVA: 0x17C3F10 Offset: 0x17C2510 VA: 0x1817C3F10
	public static SecurityElement FromString(string xml) { }

	// RVA: 0x17C4220 Offset: 0x17C2820 VA: 0x1817C4220
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x17C42A0 Offset: 0x17C28A0 VA: 0x1817C42A0
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x17C4320 Offset: 0x17C2920 VA: 0x1817C4320
	public static bool IsValidTag(string tag) { }

	// RVA: 0x17C43A0 Offset: 0x17C29A0 VA: 0x1817C43A0
	public static bool IsValidText(string text) { }

	// RVA: 0x17C4420 Offset: 0x17C2A20 VA: 0x1817C4420
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x17C4720 Offset: 0x17C2D20 VA: 0x1817C4720 Slot: 3
	public override string ToString() { }

	// RVA: 0x17C47B0 Offset: 0x17C2DB0 VA: 0x1817C47B0
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x17C4050 Offset: 0x17C2650 VA: 0x1817C4050
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_m_strText(string value) { }

	// RVA: 0x17C4560 Offset: 0x17C2B60 VA: 0x1817C4560
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x17C4DB0 Offset: 0x17C33B0 VA: 0x1817C4DB0
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

	// RVA: 0x17C2CA0 Offset: 0x17C12A0 VA: 0x1817C2CA0
	public void .ctor(string name, string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Value() { }

}

