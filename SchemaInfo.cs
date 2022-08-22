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

	// RVA: 0xEE9120 Offset: 0xEE7720 VA: 0x180EE9120
	internal void .ctor() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0xEE92B0 Offset: 0xEE78B0 VA: 0x180EE92B0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0xEE9390 Offset: 0xEE7990 VA: 0x180EE9390
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	internal SchemaType get_SchemaType() { }

	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0xEE9320 Offset: 0xEE7920 VA: 0x180EE9320
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	internal int get_ErrorCount() { }

	// RVA: 0xD280D0 Offset: 0xD266D0 VA: 0x180D280D0
	internal void set_ErrorCount(int value) { }

	// RVA: 0xEE8DB0 Offset: 0xEE73B0 VA: 0x180EE8DB0
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0xEE8EC0 Offset: 0xEE74C0 VA: 0x180EE8EC0
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0xEE8E30 Offset: 0xEE7430 VA: 0x180EE8E30
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0xEE8F40 Offset: 0xEE7540 VA: 0x180EE8F40
	internal bool HasSchema(string ns) { }

	// RVA: 0xEE8680 Offset: 0xEE6C80 VA: 0x180EE8680
	internal bool Contains(string ns) { }

	// RVA: 0xEE8870 Offset: 0xEE6E70 VA: 0x180EE8870
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0xEE8B40 Offset: 0xEE7140 VA: 0x180EE8B40
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0xEE89F0 Offset: 0xEE6FF0 VA: 0x180EE89F0
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0xEE7E00 Offset: 0xEE6400 VA: 0x180EE7E00
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0xEE86E0 Offset: 0xEE6CE0 VA: 0x180EE86E0
	internal void Finish() { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE8FA0 Offset: 0xEE75A0 VA: 0x180EE8FA0 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0xEE9060 Offset: 0xEE7660 VA: 0x180EE9060 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

}

internal struct SchemaInfo // TypeDefIndex: 4379
{	// Fields
	public string name; // 0x0
	public string typeName; // 0x8
	public Type type; // 0x10

}

