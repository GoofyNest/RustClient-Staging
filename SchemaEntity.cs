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

	// RVA: 0xEE7C40 Offset: 0xEE6240 VA: 0x180EE7C40
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0xB292C0 Offset: 0xB278C0 VA: 0x180B292C0 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0xEE7BF0 Offset: 0xEE61F0 VA: 0x180EE7BF0 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xEE7C10 Offset: 0xEE6210 VA: 0x180EE7C10 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0xEE7B50 Offset: 0xEE6150 VA: 0x180EE7B50 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0xEE7BA0 Offset: 0xEE61A0 VA: 0x180EE7BA0 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0xEE7AB0 Offset: 0xEE60B0 VA: 0x180EE7AB0
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_Url() { }

	// RVA: 0xEE7DE0 Offset: 0xEE63E0 VA: 0x180EE7DE0
	internal void set_Url(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_Pubid() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Pubid(string value) { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00
	internal bool get_IsExternal() { }

	// RVA: 0xEE7DA0 Offset: 0xEE63A0 VA: 0x180EE7DA0
	internal void set_IsExternal(bool value) { }

	// RVA: 0xEE7BF0 Offset: 0xEE61F0 VA: 0x180EE7BF0
	internal bool get_DeclaredInExternal() { }

	// RVA: 0xEE7D90 Offset: 0xEE6390 VA: 0x180EE7D90
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal string get_Text() { }

	// RVA: 0xEE7DC0 Offset: 0xEE63C0 VA: 0x180EE7DC0
	internal void set_Text(string value) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	internal int get_Line() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	internal void set_Line(int value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	internal int get_Pos() { }

	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	internal void set_Pos(int value) { }

	// RVA: 0xEE7CE0 Offset: 0xEE62E0 VA: 0x180EE7CE0
	internal string get_BaseURI() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	internal void set_BaseURI(string value) { }

	// RVA: 0xEE7D80 Offset: 0xEE6380 VA: 0x180EE7D80
	internal bool get_ParsingInProgress() { }

	// RVA: 0xEE7DB0 Offset: 0xEE63B0 VA: 0x180EE7DB0
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0xEE7D30 Offset: 0xEE6330 VA: 0x180EE7D30
	internal string get_DeclaredURI() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	internal void set_DeclaredURI(string value) { }

}

