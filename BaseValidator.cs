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

	// RVA: 0xF46030 Offset: 0xF44630 VA: 0x180F46030
	public void .ctor(BaseValidator other) { }

	// RVA: 0xF460F0 Offset: 0xF446F0 VA: 0x180F460F0
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XmlNameTable get_NameTable() { }

	// RVA: 0xF462D0 Offset: 0xF448D0 VA: 0x180F462D0
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Uri get_BaseUri() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_BaseUri(Uri value) { }

	// RVA: 0xF46260 Offset: 0xF44860 VA: 0x180F46260
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0xF46370 Offset: 0xF44970 VA: 0x180F46370
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0xF45B00 Offset: 0xF44100 VA: 0x180F45B00
	public void ValidateText() { }

	// RVA: 0xF45F00 Offset: 0xF44500 VA: 0x180F45F00
	public void ValidateWhitespace() { }

	// RVA: 0xF45450 Offset: 0xF43A50 VA: 0x180F45450
	private void SaveTextValue(string value) { }

	// RVA: 0xF45890 Offset: 0xF43E90 VA: 0x180F45890
	protected void SendValidationEvent(string code) { }

	// RVA: 0xF455F0 Offset: 0xF43BF0 VA: 0x180F455F0
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xF45740 Offset: 0xF43D40 VA: 0x180F45740
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0xF45970 Offset: 0xF43F70 VA: 0x180F45970
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF459E0 Offset: 0xF43FE0 VA: 0x180F459E0
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xF454D0 Offset: 0xF43AD0 VA: 0x180F454D0
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xF458F0 Offset: 0xF43EF0 VA: 0x180F458F0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF45160 Offset: 0xF43760 VA: 0x180F45160
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0xF452F0 Offset: 0xF438F0 VA: 0x180F452F0
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0xF44FB0 Offset: 0xF435B0 VA: 0x180F44FB0
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

