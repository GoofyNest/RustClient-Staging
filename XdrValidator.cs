internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 2302
{	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x142D5B0 Offset: 0x142BBB0 VA: 0x18142D5B0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x142D4F0 Offset: 0x142BAF0 VA: 0x18142D4F0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x142AE90 Offset: 0x1429490 VA: 0x18142AE90
	private void Init() { }

	// RVA: 0x142D420 Offset: 0x142BA20 VA: 0x18142D420 Slot: 5
	public override void Validate() { }

	// RVA: 0x142C5F0 Offset: 0x142ABF0 VA: 0x18142C5F0
	private void ValidateElement() { }

	// RVA: 0x142C440 Offset: 0x142AA40 VA: 0x18142C440
	private void ValidateChildElement() { }

	// RVA: 0x111B540 Offset: 0x1119B40 VA: 0x18111B540
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x142BA00 Offset: 0x142A000 VA: 0x18142BA00
	private void ProcessInlineSchema() { }

	// RVA: 0x142B920 Offset: 0x1429F20 VA: 0x18142B920
	private void ProcessElement() { }

	// RVA: 0x142CA00 Offset: 0x142B000 VA: 0x18142CA00
	private void ValidateEndElement() { }

	// RVA: 0x142C090 Offset: 0x142A690 VA: 0x18142C090
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x142CFD0 Offset: 0x142B5D0 VA: 0x18142CFD0
	private void ValidateStartElement() { }

	// RVA: 0x142CCB0 Offset: 0x142B2B0 VA: 0x18142CCB0
	private void ValidateEndStartElement() { }

	// RVA: 0x142B070 Offset: 0x1429670 VA: 0x18142B070
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x142B6F0 Offset: 0x1429CF0 VA: 0x18142B6F0
	private void LoadSchema(string uri) { }

	// RVA: 0x111B520 Offset: 0x1119B20 VA: 0x18111B520
	private bool get_HasSchema() { }

	// RVA: 0x111B550 Offset: 0x1119B50 VA: 0x18111B550 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x142BC20 Offset: 0x142A220 VA: 0x18142BC20
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x142ACC0 Offset: 0x14292C0 VA: 0x18142ACC0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x142A7F0 Offset: 0x1428DF0 VA: 0x18142A7F0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x142A2B0 Offset: 0x14288B0 VA: 0x18142A2B0
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x142A200 Offset: 0x1428800 VA: 0x18142A200
	internal void AddID(string name, object node) { }

	// RVA: 0x1117A40 Offset: 0x1116040 VA: 0x181117A40 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x142BEA0 Offset: 0x142A4A0 VA: 0x18142BEA0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x142B880 Offset: 0x1429E80 VA: 0x18142B880
	private void Pop() { }

	// RVA: 0x142A6B0 Offset: 0x1428CB0 VA: 0x18142A6B0
	private void CheckForwardRefs() { }

	// RVA: 0x142BFF0 Offset: 0x142A5F0 VA: 0x18142BFF0
	private XmlQualifiedName QualifiedName(string name, string ns) { }

}

