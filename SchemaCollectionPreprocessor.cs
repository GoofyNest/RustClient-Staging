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

	// RVA: 0xEE6070 Offset: 0xEE4670 VA: 0x180EE6070
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xEDB450 Offset: 0xED9A50 VA: 0x180EDB450
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0xEDAE70 Offset: 0xED9470 VA: 0x180EDAE70
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEDB790 Offset: 0xED9D90 VA: 0x180EDB790
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0xEDA420 Offset: 0xED8A20 VA: 0x180EDA420
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xEE35D0 Offset: 0xEE1BD0 VA: 0x180EE35D0
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0xEE0BE0 Offset: 0xEDF1E0 VA: 0x180EE0BE0
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0xEDB120 Offset: 0xED9720 VA: 0x180EDB120
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0xEDAC60 Offset: 0xED9260 VA: 0x180EDAC60
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xEDA630 Offset: 0xED8C30 VA: 0x180EDA630
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xEDACF0 Offset: 0xED92F0 VA: 0x180EDACF0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xEDA780 Offset: 0xED8D80 VA: 0x180EDA780
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xEDC7D0 Offset: 0xEDADD0 VA: 0x180EDC7D0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDE770 Offset: 0xEDCD70 VA: 0x180EDE770
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDC4F0 Offset: 0xEDAAF0 VA: 0x180EDC4F0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDC6C0 Offset: 0xEDACC0 VA: 0x180EDC6C0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xEDE060 Offset: 0xEDC660 VA: 0x180EDE060
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xEDE8F0 Offset: 0xEDCEF0 VA: 0x180EDE8F0
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xEDDC90 Offset: 0xEDC290 VA: 0x180EDDC90
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xEDE410 Offset: 0xEDCA10 VA: 0x180EDE410
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xEE2CF0 Offset: 0xEE12F0 VA: 0x180EE2CF0
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xEDD2F0 Offset: 0xEDB8F0 VA: 0x180EDD2F0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xEDE270 Offset: 0xEDC870 VA: 0x180EDE270
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xEDEC50 Offset: 0xEDD250 VA: 0x180EDEC50
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xEDEE10 Offset: 0xEDD410 VA: 0x180EDEE10
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xEDC910 Offset: 0xEDAF10 VA: 0x180EDC910
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xEE5A30 Offset: 0xEE4030 VA: 0x180EE5A30
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE5C30 Offset: 0xEE4230 VA: 0x180EE5C30
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE5F50 Offset: 0xEE4550 VA: 0x180EE5F50
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB26620 Offset: 0xB24C20 VA: 0x180B26620
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xEDC3F0 Offset: 0xEDA9F0 VA: 0x180EDC3F0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xEE5990 Offset: 0xEE3F90 VA: 0x180EE5990
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xEDB6C0 Offset: 0xED9CC0 VA: 0x180EDB6C0
	private Stream GetSchemaEntity(Uri ruri) { }

}

private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 2274
{	// Fields
	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;

}

