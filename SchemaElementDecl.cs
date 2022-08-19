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

	// RVA: 0xEE6C70 Offset: 0xEE5270 VA: 0x180EE6C70
	internal void .ctor() { }

	// RVA: 0xEE6A30 Offset: 0xEE5030 VA: 0x180EE6A30
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0xEE6B30 Offset: 0xEE5130 VA: 0x180EE6B30
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE67C0 Offset: 0xEE4DC0 VA: 0x180EE67C0
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0xE75840 Offset: 0xE73E40 VA: 0x180E75840 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE6920 Offset: 0xEE4F20 VA: 0x180EE6920 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	internal bool get_IsIdDeclared() { }

	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0xE75840 Offset: 0xE73E40 VA: 0x180E75840
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0xE75870 Offset: 0xE73E70 VA: 0x180E75870
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0xEE6760 Offset: 0xEE4D60 VA: 0x180EE6760
	internal SchemaElementDecl Clone() { }

	// RVA: 0xE75820 Offset: 0xE73E20 VA: 0x180E75820
	internal bool get_IsAbstract() { }

	// RVA: 0xE75850 Offset: 0xE73E50 VA: 0x180E75850
	internal void set_IsAbstract(bool value) { }

	// RVA: 0xE75830 Offset: 0xE73E30 VA: 0x180E75830
	internal bool get_IsNillable() { }

	// RVA: 0xE75860 Offset: 0xE73E60 VA: 0x180E75860
	internal void set_IsNillable(bool value) { }

	// RVA: 0xD277E0 Offset: 0xD25DE0 VA: 0x180D277E0
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0xD27750 Offset: 0xD25D50 VA: 0x180D27750
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0xEE6D20 Offset: 0xEE5320 VA: 0x180EE6D20
	internal bool get_IsNotationDeclared() { }

	// RVA: 0xEE6D30 Offset: 0xEE5330 VA: 0x180EE6D30
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0xEE6D10 Offset: 0xEE5310 VA: 0x180EE6D10
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0xCA6AA0 Offset: 0xCA50A0 VA: 0x180CA6AA0
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

	// RVA: 0xEE6440 Offset: 0xEE4A40 VA: 0x180EE6440
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0xEE68A0 Offset: 0xEE4EA0 VA: 0x180EE68A0
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0xEE6520 Offset: 0xEE4B20 VA: 0x180EE6520
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0xEE69D0 Offset: 0xEE4FD0 VA: 0x180EE69D0
	private static void .cctor() { }

}

