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

	// RVA: 0xB27780 Offset: 0xB25D80 VA: 0x180B27780
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xB1B940 Offset: 0xB19F40 VA: 0x180B1B940
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0xB1A600 Offset: 0xB18C00 VA: 0x180B1A600
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0xB1A550 Offset: 0xB18B50 VA: 0x180B1A550
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal XmlSchema get_RootSchema() { }

	// RVA: 0xB19B50 Offset: 0xB18150 VA: 0x180B19B50
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0xB1C860 Offset: 0xB1AE60 VA: 0x180B1C860
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0xB1BF50 Offset: 0xB1A550 VA: 0x180B1BF50
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0xB198A0 Offset: 0xB17EA0 VA: 0x180B198A0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xB1D4C0 Offset: 0xB1BAC0 VA: 0x180B1D4C0
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0xB24F20 Offset: 0xB23520 VA: 0x180B24F20
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0xB1A700 Offset: 0xB18D00 VA: 0x180B1A700
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0xB228D0 Offset: 0xB20ED0 VA: 0x180B228D0
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0xB1C630 Offset: 0xB1AC30 VA: 0x180B1C630
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0xB1C7A0 Offset: 0xB1ADA0 VA: 0x180B1C7A0
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0xB26DE0 Offset: 0xB253E0 VA: 0x180B26DE0
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0xB1B5E0 Offset: 0xB19BE0 VA: 0x180B1B5E0
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0xB1A330 Offset: 0xB18930 VA: 0x180B1A330
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xB19D00 Offset: 0xB18300 VA: 0x180B19D00
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB1A3D0 Offset: 0xB189D0 VA: 0x180B1A3D0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xB19E50 Offset: 0xB18450 VA: 0x180B19E50
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xB1DAC0 Offset: 0xB1C0C0 VA: 0x180B1DAC0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB20290 Offset: 0xB1E890 VA: 0x180B20290
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1D7E0 Offset: 0xB1BDE0 VA: 0x180B1D7E0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1D9B0 Offset: 0xB1BFB0 VA: 0x180B1D9B0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB1FB80 Offset: 0xB1E180 VA: 0x180B1FB80
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xB20410 Offset: 0xB1EA10 VA: 0x180B20410
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xB1F0B0 Offset: 0xB1D6B0 VA: 0x180B1F0B0
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xB1FF30 Offset: 0xB1E530 VA: 0x180B1FF30
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xB24590 Offset: 0xB22B90 VA: 0x180B24590
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xB1E710 Offset: 0xB1CD10 VA: 0x180B1E710
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xB1FD90 Offset: 0xB1E390 VA: 0x180B1FD90
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xB20770 Offset: 0xB1ED70 VA: 0x180B20770
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xB20990 Offset: 0xB1EF90 VA: 0x180B20990
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB1DC00 Offset: 0xB1C200 VA: 0x180B1DC00
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xB26ED0 Offset: 0xB254D0 VA: 0x180B26ED0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB27140 Offset: 0xB25740 VA: 0x180B27140
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB27460 Offset: 0xB25A60 VA: 0x180B27460
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB26D60 Offset: 0xB25360 VA: 0x180B26D60
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xB1C820 Offset: 0xB1AE20 VA: 0x180B1C820
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0xB1C4D0 Offset: 0xB1AAD0 VA: 0x180B1C4D0
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0xB26DB0 Offset: 0xB253B0 VA: 0x180B26DB0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xB1D5E0 Offset: 0xB1BBE0 VA: 0x180B1D5E0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xB1D750 Offset: 0xB1BD50 VA: 0x180B1D750
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

}

