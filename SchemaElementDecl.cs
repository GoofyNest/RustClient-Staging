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

	// RVA: 0xEE6F30 Offset: 0xEE5530 VA: 0x180EE6F30
	internal void .ctor() { }

	// RVA: 0xEE6CF0 Offset: 0xEE52F0 VA: 0x180EE6CF0
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0xEE6DF0 Offset: 0xEE53F0 VA: 0x180EE6DF0
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE6A80 Offset: 0xEE5080 VA: 0x180EE6A80
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0xE75B00 Offset: 0xE74100 VA: 0x180E75B00 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE6BE0 Offset: 0xEE51E0 VA: 0x180EE6BE0 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0xC315B0 Offset: 0xC2FBB0 VA: 0x180C315B0
	internal bool get_IsIdDeclared() { }

	// RVA: 0xC326D0 Offset: 0xC30CD0 VA: 0x180C326D0
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0xE75B00 Offset: 0xE74100 VA: 0x180E75B00
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0xE75B30 Offset: 0xE74130 VA: 0x180E75B30
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0xEE6A20 Offset: 0xEE5020 VA: 0x180EE6A20
	internal SchemaElementDecl Clone() { }

	// RVA: 0xE75AE0 Offset: 0xE740E0 VA: 0x180E75AE0
	internal bool get_IsAbstract() { }

	// RVA: 0xE75B10 Offset: 0xE74110 VA: 0x180E75B10
	internal void set_IsAbstract(bool value) { }

	// RVA: 0xE75AF0 Offset: 0xE740F0 VA: 0x180E75AF0
	internal bool get_IsNillable() { }

	// RVA: 0xE75B20 Offset: 0xE74120 VA: 0x180E75B20
	internal void set_IsNillable(bool value) { }

	// RVA: 0xD27AA0 Offset: 0xD260A0 VA: 0x180D27AA0
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0xD27A10 Offset: 0xD26010 VA: 0x180D27A10
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0xEE6FE0 Offset: 0xEE55E0 VA: 0x180EE6FE0
	internal bool get_IsNotationDeclared() { }

	// RVA: 0xEE6FF0 Offset: 0xEE55F0 VA: 0x180EE6FF0
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0xEE6FD0 Offset: 0xEE55D0 VA: 0x180EE6FD0
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0xCA6D60 Offset: 0xCA5360 VA: 0x180CA6D60
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0xEE6700 Offset: 0xEE4D00 VA: 0x180EE6700
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0xEE6B60 Offset: 0xEE5160 VA: 0x180EE6B60
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0xEE67E0 Offset: 0xEE4DE0 VA: 0x180EE67E0
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0xEE6C90 Offset: 0xEE5290 VA: 0x180EE6C90
	private static void .cctor() { }

}

