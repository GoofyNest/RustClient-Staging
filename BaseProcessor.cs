internal class BaseProcessor // TypeDefIndex: 2139
{	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0xF44DB0 Offset: 0xF433B0 VA: 0x180F44DB0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xF44E50 Offset: 0xF43450 VA: 0x180F44E50
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected XmlNameTable get_NameTable() { }

	// RVA: 0xF44F30 Offset: 0xF43530 VA: 0x180F44F30
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0xF44F20 Offset: 0xF43520 VA: 0x180F44F20
	protected bool get_HasErrors() { }

	// RVA: 0xF43B00 Offset: 0xF42100 VA: 0x180F43B00
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0xF44080 Offset: 0xF42680 VA: 0x180F44080
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF441A0 Offset: 0xF427A0 VA: 0x180F441A0
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF442C0 Offset: 0xF428C0 VA: 0x180F442C0
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF44820 Offset: 0xF42E20 VA: 0x180F44820
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0xF44B80 Offset: 0xF43180 VA: 0x180F44B80
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0xF44470 Offset: 0xF42A70 VA: 0x180F44470
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0xF44A30 Offset: 0xF43030 VA: 0x180F44A30
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0xF44640 Offset: 0xF42C40 VA: 0x180F44640
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xF44C70 Offset: 0xF43270 VA: 0x180F44C70
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF44900 Offset: 0xF42F00 VA: 0x180F44900
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF44990 Offset: 0xF42F90 VA: 0x180F44990
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF44D00 Offset: 0xF43300 VA: 0x180F44D00
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF443E0 Offset: 0xF429E0 VA: 0x180F443E0
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

