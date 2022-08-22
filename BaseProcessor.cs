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

	// RVA: 0xF45070 Offset: 0xF43670 VA: 0x180F45070
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xF45110 Offset: 0xF43710 VA: 0x180F45110
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected XmlNameTable get_NameTable() { }

	// RVA: 0xF451F0 Offset: 0xF437F0 VA: 0x180F451F0
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0xF451E0 Offset: 0xF437E0 VA: 0x180F451E0
	protected bool get_HasErrors() { }

	// RVA: 0xF43DC0 Offset: 0xF423C0 VA: 0x180F43DC0
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0xF44340 Offset: 0xF42940 VA: 0x180F44340
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF44460 Offset: 0xF42A60 VA: 0x180F44460
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF44580 Offset: 0xF42B80 VA: 0x180F44580
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF44AE0 Offset: 0xF430E0 VA: 0x180F44AE0
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0xF44E40 Offset: 0xF43440 VA: 0x180F44E40
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0xF44730 Offset: 0xF42D30 VA: 0x180F44730
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0xF44CF0 Offset: 0xF432F0 VA: 0x180F44CF0
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0xF44900 Offset: 0xF42F00 VA: 0x180F44900
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xF44F30 Offset: 0xF43530 VA: 0x180F44F30
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF44BC0 Offset: 0xF431C0 VA: 0x180F44BC0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF44C50 Offset: 0xF43250 VA: 0x180F44C50
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF44FC0 Offset: 0xF435C0 VA: 0x180F44FC0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF446A0 Offset: 0xF42CA0 VA: 0x180F446A0
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

