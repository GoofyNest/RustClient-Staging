public sealed class SecurityElement // TypeDefIndex: 905
{	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	public Hashtable Attributes { get; }
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { get; set; }
	internal string m_strText { set; }


	public void .ctor(string tag) { }

	public void .ctor(string tag, string text) { }

	public Hashtable get_Attributes() { }

	public ArrayList get_Children() { }

	public string get_Tag() { }

	public string get_Text() { }

	public void set_Text(string value) { }

	public void AddAttribute(string name, string value) { }

	public void AddChild(SecurityElement child) { }

	public static string Escape(string str) { }

	private static string Unescape(string str) { }

	public static SecurityElement FromString(string xml) { }

	public static bool IsValidAttributeName(string name) { }

	public static bool IsValidAttributeValue(string value) { }

	public static bool IsValidTag(string tag) { }

	public static bool IsValidText(string text) { }

	public SecurityElement SearchForChildByTag(string tag) { }

	public override string ToString() { }

	private void ToXml(ref StringBuilder s, int level) { }

	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	internal void set_m_strText(string value) { }

	internal string SearchForTextOfLocalName(string strLocalName) { }

	private static void .cctor() { }

}

internal class SecurityElement.SecurityAttribute // TypeDefIndex: 906
{	private string _name; // 0x10
	private string _value; // 0x18

	public string Name { get; }
	public string Value { get; }


	public void .ctor(string name, string value) { }

	public string get_Name() { }

	public string get_Value() { }

}

