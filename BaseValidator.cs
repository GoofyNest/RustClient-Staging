internal class BaseValidator // TypeDefIndex: 2140
{	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0xF46D90 Offset: 0xF45390 VA: 0x180F46D90
	public void .ctor(BaseValidator other) { }

	// RVA: 0xF46E50 Offset: 0xF45450 VA: 0x180F46E50
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XmlNameTable get_NameTable() { }

	// RVA: 0xF47030 Offset: 0xF45630 VA: 0x180F47030
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Uri get_BaseUri() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_BaseUri(Uri value) { }

	// RVA: 0xF46FC0 Offset: 0xF455C0 VA: 0x180F46FC0
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0xF470D0 Offset: 0xF456D0 VA: 0x180F470D0
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0xF46860 Offset: 0xF44E60 VA: 0x180F46860
	public void ValidateText() { }

	// RVA: 0xF46C60 Offset: 0xF45260 VA: 0x180F46C60
	public void ValidateWhitespace() { }

	// RVA: 0xF461B0 Offset: 0xF447B0 VA: 0x180F461B0
	private void SaveTextValue(string value) { }

	// RVA: 0xF465F0 Offset: 0xF44BF0 VA: 0x180F465F0
	protected void SendValidationEvent(string code) { }

	// RVA: 0xF46350 Offset: 0xF44950 VA: 0x180F46350
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xF464A0 Offset: 0xF44AA0 VA: 0x180F464A0
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0xF466D0 Offset: 0xF44CD0 VA: 0x180F466D0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF46740 Offset: 0xF44D40 VA: 0x180F46740
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xF46230 Offset: 0xF44830 VA: 0x180F46230
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xF46650 Offset: 0xF44C50 VA: 0x180F46650
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF45EC0 Offset: 0xF444C0 VA: 0x180F45EC0
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0xF46050 Offset: 0xF44650 VA: 0x180F46050
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0xF45D10 Offset: 0xF44310 VA: 0x180F45D10
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

