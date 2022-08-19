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

	// RVA: 0x142D2F0 Offset: 0x142B8F0 VA: 0x18142D2F0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x142D230 Offset: 0x142B830 VA: 0x18142D230
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x142ABD0 Offset: 0x14291D0 VA: 0x18142ABD0
	private void Init() { }

	// RVA: 0x142D160 Offset: 0x142B760 VA: 0x18142D160 Slot: 5
	public override void Validate() { }

	// RVA: 0x142C330 Offset: 0x142A930 VA: 0x18142C330
	private void ValidateElement() { }

	// RVA: 0x142C180 Offset: 0x142A780 VA: 0x18142C180
	private void ValidateChildElement() { }

	// RVA: 0x111B280 Offset: 0x1119880 VA: 0x18111B280
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x142B740 Offset: 0x1429D40 VA: 0x18142B740
	private void ProcessInlineSchema() { }

	// RVA: 0x142B660 Offset: 0x1429C60 VA: 0x18142B660
	private void ProcessElement() { }

	// RVA: 0x142C740 Offset: 0x142AD40 VA: 0x18142C740
	private void ValidateEndElement() { }

	// RVA: 0x142BDD0 Offset: 0x142A3D0 VA: 0x18142BDD0
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x142CD10 Offset: 0x142B310 VA: 0x18142CD10
	private void ValidateStartElement() { }

	// RVA: 0x142C9F0 Offset: 0x142AFF0 VA: 0x18142C9F0
	private void ValidateEndStartElement() { }

	// RVA: 0x142ADB0 Offset: 0x14293B0 VA: 0x18142ADB0
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x142B430 Offset: 0x1429A30 VA: 0x18142B430
	private void LoadSchema(string uri) { }

	// RVA: 0x111B260 Offset: 0x1119860 VA: 0x18111B260
	private bool get_HasSchema() { }

	// RVA: 0x111B290 Offset: 0x1119890 VA: 0x18111B290 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x142B960 Offset: 0x1429F60 VA: 0x18142B960
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x142AA00 Offset: 0x1429000 VA: 0x18142AA00 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x142A530 Offset: 0x1428B30 VA: 0x18142A530
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1429FF0 Offset: 0x14285F0 VA: 0x181429FF0
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x1429F40 Offset: 0x1428540 VA: 0x181429F40
	internal void AddID(string name, object node) { }

	// RVA: 0x1117780 Offset: 0x1115D80 VA: 0x181117780 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x142BBE0 Offset: 0x142A1E0 VA: 0x18142BBE0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x142B5C0 Offset: 0x1429BC0 VA: 0x18142B5C0
	private void Pop() { }

	// RVA: 0x142A3F0 Offset: 0x14289F0 VA: 0x18142A3F0
	private void CheckForwardRefs() { }

	// RVA: 0x142BD30 Offset: 0x142A330 VA: 0x18142BD30
	private XmlQualifiedName QualifiedName(string name, string ns) { }

}

