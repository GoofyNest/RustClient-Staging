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

	// RVA: 0xE50300 Offset: 0xE4E900 VA: 0x180E50300
	public void .ctor() { }

	// RVA: 0xE502D0 Offset: 0xE4E8D0 VA: 0x180E502D0
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_LocalName() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_LocalName(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Namespace(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Prefix() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Prefix(string value) { }

	// RVA: 0xE50080 Offset: 0xE4E680 VA: 0x180E50080
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_Depth() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	public void set_Depth(int value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_RawValue() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_RawValue(string value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_OriginalStringValue() { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public XmlNodeType get_NodeType() { }

	// RVA: 0x8D8F40 Offset: 0x8D7540 VA: 0x1808D8F40
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public int get_LineNumber() { }

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	public int get_LinePosition() { }

	// RVA: 0xE4FFB0 Offset: 0xE4E5B0 VA: 0x180E4FFB0
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0xE50250 Offset: 0xE4E850 VA: 0x180E50250
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0xE50260 Offset: 0xE4E860 VA: 0x180E50260
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0xE501B0 Offset: 0xE4E7B0 VA: 0x180E501B0
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0xE50130 Offset: 0xE4E730 VA: 0x180E50130
	internal void SetItemData(string value) { }

	// RVA: 0xE50170 Offset: 0xE4E770 VA: 0x180E50170
	internal void SetItemData(string value, string originalStringValue) { }

}

