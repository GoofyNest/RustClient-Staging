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

	// RVA: 0xB26FF0 Offset: 0xB255F0 VA: 0x180B26FF0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xB1B1B0 Offset: 0xB197B0 VA: 0x180B1B1B0
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0xB19E70 Offset: 0xB18470 VA: 0x180B19E70
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0xB19DC0 Offset: 0xB183C0 VA: 0x180B19DC0
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal XmlSchema get_RootSchema() { }

	// RVA: 0xB193C0 Offset: 0xB179C0 VA: 0x180B193C0
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0xB1C0D0 Offset: 0xB1A6D0 VA: 0x180B1C0D0
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0xB1B7C0 Offset: 0xB19DC0 VA: 0x180B1B7C0
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0xB19110 Offset: 0xB17710 VA: 0x180B19110
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xB1CD30 Offset: 0xB1B330 VA: 0x180B1CD30
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0xB24790 Offset: 0xB22D90 VA: 0x180B24790
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0xB19F70 Offset: 0xB18570 VA: 0x180B19F70
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0xB22140 Offset: 0xB20740 VA: 0x180B22140
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0xB1BEA0 Offset: 0xB1A4A0 VA: 0x180B1BEA0
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0xB1C010 Offset: 0xB1A610 VA: 0x180B1C010
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0xB26650 Offset: 0xB24C50 VA: 0x180B26650
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0xB1AE50 Offset: 0xB19450 VA: 0x180B1AE50
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0xB19BA0 Offset: 0xB181A0 VA: 0x180B19BA0
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xB19570 Offset: 0xB17B70 VA: 0x180B19570
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB19C40 Offset: 0xB18240 VA: 0x180B19C40
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xB196C0 Offset: 0xB17CC0 VA: 0x180B196C0
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xB1D330 Offset: 0xB1B930 VA: 0x180B1D330
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1FB00 Offset: 0xB1E100 VA: 0x180B1FB00
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1D050 Offset: 0xB1B650 VA: 0x180B1D050
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1D220 Offset: 0xB1B820 VA: 0x180B1D220
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB1F3F0 Offset: 0xB1D9F0 VA: 0x180B1F3F0
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xB1FC80 Offset: 0xB1E280 VA: 0x180B1FC80
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xB1E920 Offset: 0xB1CF20 VA: 0x180B1E920
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xB1F7A0 Offset: 0xB1DDA0 VA: 0x180B1F7A0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xB23E00 Offset: 0xB22400 VA: 0x180B23E00
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xB1DF80 Offset: 0xB1C580 VA: 0x180B1DF80
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xB1F600 Offset: 0xB1DC00 VA: 0x180B1F600
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xB1FFE0 Offset: 0xB1E5E0 VA: 0x180B1FFE0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xB20200 Offset: 0xB1E800 VA: 0x180B20200
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB1D470 Offset: 0xB1BA70 VA: 0x180B1D470
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xB26740 Offset: 0xB24D40 VA: 0x180B26740
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB269B0 Offset: 0xB24FB0 VA: 0x180B269B0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB26CD0 Offset: 0xB252D0 VA: 0x180B26CD0
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB265D0 Offset: 0xB24BD0 VA: 0x180B265D0
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xB1C090 Offset: 0xB1A690 VA: 0x180B1C090
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0xB1BD40 Offset: 0xB1A340 VA: 0x180B1BD40
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0xB26620 Offset: 0xB24C20 VA: 0x180B26620
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xB1CE50 Offset: 0xB1B450 VA: 0x180B1CE50
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xB1CFC0 Offset: 0xB1B5C0 VA: 0x180B1CFC0
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

}

