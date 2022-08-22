internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 2277
{	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0xEE79E0 Offset: 0xEE5FE0 VA: 0x180EE79E0
	internal void .ctor() { }

	// RVA: 0xEE77A0 Offset: 0xEE5DA0 VA: 0x180EE77A0
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0xEE78A0 Offset: 0xEE5EA0 VA: 0x180EE78A0
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE7530 Offset: 0xEE5B30 VA: 0x180EE7530
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0xE765B0 Offset: 0xE74BB0 VA: 0x180E765B0 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE7690 Offset: 0xEE5C90 VA: 0x180EE7690 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0xC31A80 Offset: 0xC30080 VA: 0x180C31A80
	internal bool get_IsIdDeclared() { }

	// RVA: 0xC32BA0 Offset: 0xC311A0 VA: 0x180C32BA0
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0xE765B0 Offset: 0xE74BB0 VA: 0x180E765B0
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0xE765E0 Offset: 0xE74BE0 VA: 0x180E765E0
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0xEE74D0 Offset: 0xEE5AD0 VA: 0x180EE74D0
	internal SchemaElementDecl Clone() { }

	// RVA: 0xE76590 Offset: 0xE74B90 VA: 0x180E76590
	internal bool get_IsAbstract() { }

	// RVA: 0xE765C0 Offset: 0xE74BC0 VA: 0x180E765C0
	internal void set_IsAbstract(bool value) { }

	// RVA: 0xE765A0 Offset: 0xE74BA0 VA: 0x180E765A0
	internal bool get_IsNillable() { }

	// RVA: 0xE765D0 Offset: 0xE74BD0 VA: 0x180E765D0
	internal void set_IsNillable(bool value) { }

	// RVA: 0xD27F40 Offset: 0xD26540 VA: 0x180D27F40
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0xD27EB0 Offset: 0xD264B0 VA: 0x180D27EB0
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0xEE7A90 Offset: 0xEE6090 VA: 0x180EE7A90
	internal bool get_IsNotationDeclared() { }

	// RVA: 0xEE7AA0 Offset: 0xEE60A0 VA: 0x180EE7AA0
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0xEE7A80 Offset: 0xEE6080 VA: 0x180EE7A80
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0xCA7200 Offset: 0xCA5800 VA: 0x180CA7200
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0xEE71B0 Offset: 0xEE57B0 VA: 0x180EE71B0
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0xEE7610 Offset: 0xEE5C10 VA: 0x180EE7610
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0xEE7290 Offset: 0xEE5890 VA: 0x180EE7290
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0xEE7740 Offset: 0xEE5D40 VA: 0x180EE7740
	private static void .cctor() { }

}

