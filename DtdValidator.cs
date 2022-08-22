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

	// RVA: 0x1518CC0 Offset: 0x15172C0 VA: 0x181518CC0
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1516F90 Offset: 0x1515590 VA: 0x181516F90
	private void Init() { }

	// RVA: 0x15187D0 Offset: 0x1516DD0 VA: 0x1815187D0 Slot: 5
	public override void Validate() { }

	// RVA: 0x15170E0 Offset: 0x15156E0 VA: 0x1815170E0
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1518310 Offset: 0x1516910 VA: 0x181518310
	private void ValidatePIComment() { }

	// RVA: 0x1517B70 Offset: 0x1516170 VA: 0x181517B70
	private void ValidateElement() { }

	// RVA: 0x15179C0 Offset: 0x1515FC0 VA: 0x1815179C0
	private void ValidateChildElement() { }

	// RVA: 0x15183C0 Offset: 0x15169C0 VA: 0x1815183C0
	private void ValidateStartElement() { }

	// RVA: 0x1518140 Offset: 0x1516740 VA: 0x181518140
	private void ValidateEndStartElement() { }

	// RVA: 0x1517210 Offset: 0x1515810 VA: 0x181517210
	private void ProcessElement() { }

	// RVA: 0x1516B70 Offset: 0x1515170 VA: 0x181516B70 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1517F50 Offset: 0x1516550 VA: 0x181517F50
	private void ValidateEndElement() { }

	// RVA: 0x1518EB0 Offset: 0x15174B0 VA: 0x181518EB0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1517360 Offset: 0x1515960 VA: 0x181517360
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x15166E0 Offset: 0x1514CE0 VA: 0x1815166E0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1516220 Offset: 0x1514820 VA: 0x181516220
	internal void AddID(string name, object node) { }

	// RVA: 0x1516CE0 Offset: 0x15152E0 VA: 0x181516CE0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1516D00 Offset: 0x1515300 VA: 0x181516D00
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1516EC0 Offset: 0x15154C0 VA: 0x181516EC0
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x15165A0 Offset: 0x1514BA0 VA: 0x1815165A0
	private void CheckForwardRefs() { }

	// RVA: 0x1517600 Offset: 0x1515C00 VA: 0x181517600
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1517170 Offset: 0x1515770 VA: 0x181517170
	private bool Pop() { }

	// RVA: 0x1517750 Offset: 0x1515D50 VA: 0x181517750
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x15162D0 Offset: 0x15148D0 VA: 0x1815162D0
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1518C60 Offset: 0x1517260 VA: 0x181518C60
	private static void .cctor() { }

}

private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 2244
{	// Methods

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

