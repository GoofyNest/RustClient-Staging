internal class SchemaInfo : IDtdInfo // TypeDefIndex: 2280
{	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0xEE8670 Offset: 0xEE6C70 VA: 0x180EE8670
	internal void .ctor() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0xEE8800 Offset: 0xEE6E00 VA: 0x180EE8800
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0xEE88E0 Offset: 0xEE6EE0 VA: 0x180EE88E0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	internal SchemaType get_SchemaType() { }

	// RVA: 0x574430 Offset: 0x572A30 VA: 0x180574430
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0xEE8870 Offset: 0xEE6E70 VA: 0x180EE8870
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	internal int get_ErrorCount() { }

	// RVA: 0xD27C30 Offset: 0xD26230 VA: 0x180D27C30
	internal void set_ErrorCount(int value) { }

	// RVA: 0xEE8300 Offset: 0xEE6900 VA: 0x180EE8300
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0xEE8410 Offset: 0xEE6A10 VA: 0x180EE8410
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0xEE8380 Offset: 0xEE6980 VA: 0x180EE8380
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0xEE8490 Offset: 0xEE6A90 VA: 0x180EE8490
	internal bool HasSchema(string ns) { }

	// RVA: 0xEE7BD0 Offset: 0xEE61D0 VA: 0x180EE7BD0
	internal bool Contains(string ns) { }

	// RVA: 0xEE7DC0 Offset: 0xEE63C0 VA: 0x180EE7DC0
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0xEE8090 Offset: 0xEE6690 VA: 0x180EE8090
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0xEE7F40 Offset: 0xEE6540 VA: 0x180EE7F40
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0xEE7350 Offset: 0xEE5950 VA: 0x180EE7350
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0xEE7C30 Offset: 0xEE6230 VA: 0x180EE7C30
	internal void Finish() { }

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE84F0 Offset: 0xEE6AF0 VA: 0x180EE84F0 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0xEE85B0 Offset: 0xEE6BB0 VA: 0x180EE85B0 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

}

internal struct SchemaInfo // TypeDefIndex: 4379
{	// Fields
	public string name; // 0x0
	public string typeName; // 0x8
	public Type type; // 0x10

}

