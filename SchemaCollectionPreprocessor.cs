internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 2273
{	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0xEE6330 Offset: 0xEE4930 VA: 0x180EE6330
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xEDB710 Offset: 0xED9D10 VA: 0x180EDB710
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0xEDB130 Offset: 0xED9730 VA: 0x180EDB130
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEDBA50 Offset: 0xEDA050 VA: 0x180EDBA50
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0xEDA6E0 Offset: 0xED8CE0 VA: 0x180EDA6E0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xEE3890 Offset: 0xEE1E90 VA: 0x180EE3890
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0xEE0EA0 Offset: 0xEDF4A0 VA: 0x180EE0EA0
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0xEDB3E0 Offset: 0xED99E0 VA: 0x180EDB3E0
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0xEDAF20 Offset: 0xED9520 VA: 0x180EDAF20
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xEDA8F0 Offset: 0xED8EF0 VA: 0x180EDA8F0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xEDAFB0 Offset: 0xED95B0 VA: 0x180EDAFB0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xEDAA40 Offset: 0xED9040 VA: 0x180EDAA40
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xEDCA90 Offset: 0xEDB090 VA: 0x180EDCA90
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDEA30 Offset: 0xEDD030 VA: 0x180EDEA30
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDC7B0 Offset: 0xEDADB0 VA: 0x180EDC7B0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDC980 Offset: 0xEDAF80 VA: 0x180EDC980
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xEDE320 Offset: 0xEDC920 VA: 0x180EDE320
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xEDEBB0 Offset: 0xEDD1B0 VA: 0x180EDEBB0
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xEDDF50 Offset: 0xEDC550 VA: 0x180EDDF50
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xEDE6D0 Offset: 0xEDCCD0 VA: 0x180EDE6D0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xEE2FB0 Offset: 0xEE15B0 VA: 0x180EE2FB0
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xEDD5B0 Offset: 0xEDBBB0 VA: 0x180EDD5B0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xEDE530 Offset: 0xEDCB30 VA: 0x180EDE530
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xEDEF10 Offset: 0xEDD510 VA: 0x180EDEF10
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xEDF0D0 Offset: 0xEDD6D0 VA: 0x180EDF0D0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xEDCBD0 Offset: 0xEDB1D0 VA: 0x180EDCBD0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xEE5CF0 Offset: 0xEE42F0 VA: 0x180EE5CF0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE5EF0 Offset: 0xEE44F0 VA: 0x180EE5EF0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE6210 Offset: 0xEE4810 VA: 0x180EE6210
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB268E0 Offset: 0xB24EE0 VA: 0x180B268E0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xEDC6B0 Offset: 0xEDACB0 VA: 0x180EDC6B0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xEE5C50 Offset: 0xEE4250 VA: 0x180EE5C50
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xEDB980 Offset: 0xED9F80 VA: 0x180EDB980
	private Stream GetSchemaEntity(Uri ruri) { }

}

private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 2274
{	// Fields
	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;

}

