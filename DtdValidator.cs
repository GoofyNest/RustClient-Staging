internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 2243
{	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1519930 Offset: 0x1517F30 VA: 0x181519930
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1517C00 Offset: 0x1516200 VA: 0x181517C00
	private void Init() { }

	// RVA: 0x1519440 Offset: 0x1517A40 VA: 0x181519440 Slot: 5
	public override void Validate() { }

	// RVA: 0x1517D50 Offset: 0x1516350 VA: 0x181517D50
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1518F80 Offset: 0x1517580 VA: 0x181518F80
	private void ValidatePIComment() { }

	// RVA: 0x15187E0 Offset: 0x1516DE0 VA: 0x1815187E0
	private void ValidateElement() { }

	// RVA: 0x1518630 Offset: 0x1516C30 VA: 0x181518630
	private void ValidateChildElement() { }

	// RVA: 0x1519030 Offset: 0x1517630 VA: 0x181519030
	private void ValidateStartElement() { }

	// RVA: 0x1518DB0 Offset: 0x15173B0 VA: 0x181518DB0
	private void ValidateEndStartElement() { }

	// RVA: 0x1517E80 Offset: 0x1516480 VA: 0x181517E80
	private void ProcessElement() { }

	// RVA: 0x15177E0 Offset: 0x1515DE0 VA: 0x1815177E0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1518BC0 Offset: 0x15171C0 VA: 0x181518BC0
	private void ValidateEndElement() { }

	// RVA: 0x1519B20 Offset: 0x1518120 VA: 0x181519B20 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1517FD0 Offset: 0x15165D0 VA: 0x181517FD0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1517350 Offset: 0x1515950 VA: 0x181517350
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1516E90 Offset: 0x1515490 VA: 0x181516E90
	internal void AddID(string name, object node) { }

	// RVA: 0x1517950 Offset: 0x1515F50 VA: 0x181517950 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1517970 Offset: 0x1515F70 VA: 0x181517970
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1517B30 Offset: 0x1516130 VA: 0x181517B30
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x1517210 Offset: 0x1515810 VA: 0x181517210
	private void CheckForwardRefs() { }

	// RVA: 0x1518270 Offset: 0x1516870 VA: 0x181518270
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1517DE0 Offset: 0x15163E0 VA: 0x181517DE0
	private bool Pop() { }

	// RVA: 0x15183C0 Offset: 0x15169C0 VA: 0x1815183C0
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1516F40 Offset: 0x1515540 VA: 0x181516F40
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x15198D0 Offset: 0x1517ED0 VA: 0x1815198D0
	private static void .cctor() { }

}

private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 2244
{	// Methods

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

