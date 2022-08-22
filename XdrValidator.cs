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

	// RVA: 0x142C690 Offset: 0x142AC90 VA: 0x18142C690
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x142C5D0 Offset: 0x142ABD0 VA: 0x18142C5D0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1429F70 Offset: 0x1428570 VA: 0x181429F70
	private void Init() { }

	// RVA: 0x142C500 Offset: 0x142AB00 VA: 0x18142C500 Slot: 5
	public override void Validate() { }

	// RVA: 0x142B6D0 Offset: 0x1429CD0 VA: 0x18142B6D0
	private void ValidateElement() { }

	// RVA: 0x142B520 Offset: 0x1429B20 VA: 0x18142B520
	private void ValidateChildElement() { }

	// RVA: 0x111BFB0 Offset: 0x111A5B0 VA: 0x18111BFB0
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x142AAE0 Offset: 0x14290E0 VA: 0x18142AAE0
	private void ProcessInlineSchema() { }

	// RVA: 0x142AA00 Offset: 0x1429000 VA: 0x18142AA00
	private void ProcessElement() { }

	// RVA: 0x142BAE0 Offset: 0x142A0E0 VA: 0x18142BAE0
	private void ValidateEndElement() { }

	// RVA: 0x142B170 Offset: 0x1429770 VA: 0x18142B170
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x142C0B0 Offset: 0x142A6B0 VA: 0x18142C0B0
	private void ValidateStartElement() { }

	// RVA: 0x142BD90 Offset: 0x142A390 VA: 0x18142BD90
	private void ValidateEndStartElement() { }

	// RVA: 0x142A150 Offset: 0x1428750 VA: 0x18142A150
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x142A7D0 Offset: 0x1428DD0 VA: 0x18142A7D0
	private void LoadSchema(string uri) { }

	// RVA: 0x111BF90 Offset: 0x111A590 VA: 0x18111BF90
	private bool get_HasSchema() { }

	// RVA: 0x111BFC0 Offset: 0x111A5C0 VA: 0x18111BFC0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x142AD00 Offset: 0x1429300 VA: 0x18142AD00
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1429DA0 Offset: 0x14283A0 VA: 0x181429DA0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x14298D0 Offset: 0x1427ED0 VA: 0x1814298D0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1429390 Offset: 0x1427990 VA: 0x181429390
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x14292E0 Offset: 0x14278E0 VA: 0x1814292E0
	internal void AddID(string name, object node) { }

	// RVA: 0x11184B0 Offset: 0x1116AB0 VA: 0x1811184B0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x142AF80 Offset: 0x1429580 VA: 0x18142AF80
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x142A960 Offset: 0x1428F60 VA: 0x18142A960
	private void Pop() { }

	// RVA: 0x1429790 Offset: 0x1427D90 VA: 0x181429790
	private void CheckForwardRefs() { }

	// RVA: 0x142B0D0 Offset: 0x14296D0 VA: 0x18142B0D0
	private XmlQualifiedName QualifiedName(string name, string ns) { }

}

