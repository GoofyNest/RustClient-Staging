internal class ValidatingReaderNodeData // TypeDefIndex: 1870
{	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0xE51070 Offset: 0xE4F670 VA: 0x180E51070
	public void .ctor() { }

	// RVA: 0xE51040 Offset: 0xE4F640 VA: 0x180E51040
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_LocalName() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_LocalName(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Namespace(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Prefix() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Prefix(string value) { }

	// RVA: 0xE50DF0 Offset: 0xE4F3F0 VA: 0x180E50DF0
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public int get_Depth() { }

	// RVA: 0x6840F0 Offset: 0x6826F0 VA: 0x1806840F0
	public void set_Depth(int value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_RawValue() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_RawValue(string value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_OriginalStringValue() { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public XmlNodeType get_NodeType() { }

	// RVA: 0x8D9560 Offset: 0x8D7B60 VA: 0x1808D9560
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	public int get_LineNumber() { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public int get_LinePosition() { }

	// RVA: 0xE50D20 Offset: 0xE4F320 VA: 0x180E50D20
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0xE50FC0 Offset: 0xE4F5C0 VA: 0x180E50FC0
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0xE50FD0 Offset: 0xE4F5D0 VA: 0x180E50FD0
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0xE50F20 Offset: 0xE4F520 VA: 0x180E50F20
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0xE50EA0 Offset: 0xE4F4A0 VA: 0x180E50EA0
	internal void SetItemData(string value) { }

	// RVA: 0xE50EE0 Offset: 0xE4F4E0 VA: 0x180E50EE0
	internal void SetItemData(string value, string originalStringValue) { }

}

