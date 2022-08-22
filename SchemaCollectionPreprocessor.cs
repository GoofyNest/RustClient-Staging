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

	// RVA: 0xEE6DE0 Offset: 0xEE53E0 VA: 0x180EE6DE0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xEDC1C0 Offset: 0xEDA7C0 VA: 0x180EDC1C0
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0xEDBBE0 Offset: 0xEDA1E0 VA: 0x180EDBBE0
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEDC500 Offset: 0xEDAB00 VA: 0x180EDC500
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0xEDB190 Offset: 0xED9790 VA: 0x180EDB190
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xEE4340 Offset: 0xEE2940 VA: 0x180EE4340
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0xEE1950 Offset: 0xEDFF50 VA: 0x180EE1950
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0xEDBE90 Offset: 0xEDA490 VA: 0x180EDBE90
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0xEDB9D0 Offset: 0xED9FD0 VA: 0x180EDB9D0
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xEDB3A0 Offset: 0xED99A0 VA: 0x180EDB3A0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xEDBA60 Offset: 0xEDA060 VA: 0x180EDBA60
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xEDB4F0 Offset: 0xED9AF0 VA: 0x180EDB4F0
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xEDD540 Offset: 0xEDBB40 VA: 0x180EDD540
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDF4E0 Offset: 0xEDDAE0 VA: 0x180EDF4E0
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDD260 Offset: 0xEDB860 VA: 0x180EDD260
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xEDD430 Offset: 0xEDBA30 VA: 0x180EDD430
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xEDEDD0 Offset: 0xEDD3D0 VA: 0x180EDEDD0
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xEDF660 Offset: 0xEDDC60 VA: 0x180EDF660
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xEDEA00 Offset: 0xEDD000 VA: 0x180EDEA00
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xEDF180 Offset: 0xEDD780 VA: 0x180EDF180
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xEE3A60 Offset: 0xEE2060 VA: 0x180EE3A60
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xEDE060 Offset: 0xEDC660 VA: 0x180EDE060
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xEDEFE0 Offset: 0xEDD5E0 VA: 0x180EDEFE0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xEDF9C0 Offset: 0xEDDFC0 VA: 0x180EDF9C0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xEDFB80 Offset: 0xEDE180 VA: 0x180EDFB80
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xEDD680 Offset: 0xEDBC80 VA: 0x180EDD680
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xEE67A0 Offset: 0xEE4DA0 VA: 0x180EE67A0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE69A0 Offset: 0xEE4FA0 VA: 0x180EE69A0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE6CC0 Offset: 0xEE52C0 VA: 0x180EE6CC0
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB26DB0 Offset: 0xB253B0 VA: 0x180B26DB0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xEDD160 Offset: 0xEDB760 VA: 0x180EDD160
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xEE6700 Offset: 0xEE4D00 VA: 0x180EE6700
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xEDC430 Offset: 0xEDAA30 VA: 0x180EDC430
	private Stream GetSchemaEntity(Uri ruri) { }

}

private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 2274
{	// Fields
	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;

}

