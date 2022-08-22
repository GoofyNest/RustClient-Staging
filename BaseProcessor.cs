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

	// RVA: 0xF45B10 Offset: 0xF44110 VA: 0x180F45B10
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xF45BB0 Offset: 0xF441B0 VA: 0x180F45BB0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	protected XmlNameTable get_NameTable() { }

	// RVA: 0xF45C90 Offset: 0xF44290 VA: 0x180F45C90
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0xF45C80 Offset: 0xF44280 VA: 0x180F45C80
	protected bool get_HasErrors() { }

	// RVA: 0xF44860 Offset: 0xF42E60 VA: 0x180F44860
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0xF44DE0 Offset: 0xF433E0 VA: 0x180F44DE0
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF44F00 Offset: 0xF43500 VA: 0x180F44F00
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF45020 Offset: 0xF43620 VA: 0x180F45020
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF45580 Offset: 0xF43B80 VA: 0x180F45580
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0xF458E0 Offset: 0xF43EE0 VA: 0x180F458E0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0xF451D0 Offset: 0xF437D0 VA: 0x180F451D0
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0xF45790 Offset: 0xF43D90 VA: 0x180F45790
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0xF453A0 Offset: 0xF439A0 VA: 0x180F453A0
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xF459D0 Offset: 0xF43FD0 VA: 0x180F459D0
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF45660 Offset: 0xF43C60 VA: 0x180F45660
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF456F0 Offset: 0xF43CF0 VA: 0x180F456F0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF45A60 Offset: 0xF44060 VA: 0x180F45A60
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF45140 Offset: 0xF43740 VA: 0x180F45140
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

