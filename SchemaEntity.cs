internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 2278
{	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0xEE6ED0 Offset: 0xEE54D0 VA: 0x180EE6ED0
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0xB28B30 Offset: 0xB27130 VA: 0x180B28B30 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0xEE6E80 Offset: 0xEE5480 VA: 0x180EE6E80 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xEE6EA0 Offset: 0xEE54A0 VA: 0x180EE6EA0 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0xEE6DE0 Offset: 0xEE53E0 VA: 0x180EE6DE0 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0xEE6E30 Offset: 0xEE5430 VA: 0x180EE6E30 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0xEE6D40 Offset: 0xEE5340 VA: 0x180EE6D40
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_Url() { }

	// RVA: 0xEE7070 Offset: 0xEE5670 VA: 0x180EE7070
	internal void set_Url(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_Pubid() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Pubid(string value) { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90
	internal bool get_IsExternal() { }

	// RVA: 0xEE7030 Offset: 0xEE5630 VA: 0x180EE7030
	internal void set_IsExternal(bool value) { }

	// RVA: 0xEE6E80 Offset: 0xEE5480 VA: 0x180EE6E80
	internal bool get_DeclaredInExternal() { }

	// RVA: 0xEE7020 Offset: 0xEE5620 VA: 0x180EE7020
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal string get_Text() { }

	// RVA: 0xEE7050 Offset: 0xEE5650 VA: 0x180EE7050
	internal void set_Text(string value) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	internal int get_Line() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	internal void set_Line(int value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	internal int get_Pos() { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	internal void set_Pos(int value) { }

	// RVA: 0xEE6F70 Offset: 0xEE5570 VA: 0x180EE6F70
	internal string get_BaseURI() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_BaseURI(string value) { }

	// RVA: 0xEE7010 Offset: 0xEE5610 VA: 0x180EE7010
	internal bool get_ParsingInProgress() { }

	// RVA: 0xEE7040 Offset: 0xEE5640 VA: 0x180EE7040
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0xEE6FC0 Offset: 0xEE55C0 VA: 0x180EE6FC0
	internal string get_DeclaredURI() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void set_DeclaredURI(string value) { }

}

