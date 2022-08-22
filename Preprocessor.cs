internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 2268
{	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0xB272B0 Offset: 0xB258B0 VA: 0x180B272B0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xB1B470 Offset: 0xB19A70 VA: 0x180B1B470
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0xB1A130 Offset: 0xB18730 VA: 0x180B1A130
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0xB1A080 Offset: 0xB18680 VA: 0x180B1A080
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal XmlSchema get_RootSchema() { }

	// RVA: 0xB19680 Offset: 0xB17C80 VA: 0x180B19680
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0xB1C390 Offset: 0xB1A990 VA: 0x180B1C390
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0xB1BA80 Offset: 0xB1A080 VA: 0x180B1BA80
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0xB193D0 Offset: 0xB179D0 VA: 0x180B193D0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xB1CFF0 Offset: 0xB1B5F0 VA: 0x180B1CFF0
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0xB24A50 Offset: 0xB23050 VA: 0x180B24A50
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0xB1A230 Offset: 0xB18830 VA: 0x180B1A230
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0xB22400 Offset: 0xB20A00 VA: 0x180B22400
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0xB1C160 Offset: 0xB1A760 VA: 0x180B1C160
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0xB1C2D0 Offset: 0xB1A8D0 VA: 0x180B1C2D0
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0xB26910 Offset: 0xB24F10 VA: 0x180B26910
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0xB1B110 Offset: 0xB19710 VA: 0x180B1B110
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0xB19E60 Offset: 0xB18460 VA: 0x180B19E60
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xB19830 Offset: 0xB17E30 VA: 0x180B19830
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB19F00 Offset: 0xB18500 VA: 0x180B19F00
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xB19980 Offset: 0xB17F80 VA: 0x180B19980
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xB1D5F0 Offset: 0xB1BBF0 VA: 0x180B1D5F0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1FDC0 Offset: 0xB1E3C0 VA: 0x180B1FDC0
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1D310 Offset: 0xB1B910 VA: 0x180B1D310
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1D4E0 Offset: 0xB1BAE0 VA: 0x180B1D4E0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB1F6B0 Offset: 0xB1DCB0 VA: 0x180B1F6B0
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xB1FF40 Offset: 0xB1E540 VA: 0x180B1FF40
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xB1EBE0 Offset: 0xB1D1E0 VA: 0x180B1EBE0
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xB1FA60 Offset: 0xB1E060 VA: 0x180B1FA60
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xB240C0 Offset: 0xB226C0 VA: 0x180B240C0
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xB1E240 Offset: 0xB1C840 VA: 0x180B1E240
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xB1F8C0 Offset: 0xB1DEC0 VA: 0x180B1F8C0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xB202A0 Offset: 0xB1E8A0 VA: 0x180B202A0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xB204C0 Offset: 0xB1EAC0 VA: 0x180B204C0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB1D730 Offset: 0xB1BD30 VA: 0x180B1D730
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xB26A00 Offset: 0xB25000 VA: 0x180B26A00
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB26C70 Offset: 0xB25270 VA: 0x180B26C70
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB26F90 Offset: 0xB25590 VA: 0x180B26F90
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB26890 Offset: 0xB24E90 VA: 0x180B26890
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xB1C350 Offset: 0xB1A950 VA: 0x180B1C350
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0xB1C000 Offset: 0xB1A600 VA: 0x180B1C000
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0xB268E0 Offset: 0xB24EE0 VA: 0x180B268E0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xB1D110 Offset: 0xB1B710 VA: 0x180B1D110
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xB1D280 Offset: 0xB1B880 VA: 0x180B1D280
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

}

