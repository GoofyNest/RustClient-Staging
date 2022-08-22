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

	// RVA: 0x1519BF0 Offset: 0x15181F0 VA: 0x181519BF0
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1517EC0 Offset: 0x15164C0 VA: 0x181517EC0
	private void Init() { }

	// RVA: 0x1519700 Offset: 0x1517D00 VA: 0x181519700 Slot: 5
	public override void Validate() { }

	// RVA: 0x1518010 Offset: 0x1516610 VA: 0x181518010
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1519240 Offset: 0x1517840 VA: 0x181519240
	private void ValidatePIComment() { }

	// RVA: 0x1518AA0 Offset: 0x15170A0 VA: 0x181518AA0
	private void ValidateElement() { }

	// RVA: 0x15188F0 Offset: 0x1516EF0 VA: 0x1815188F0
	private void ValidateChildElement() { }

	// RVA: 0x15192F0 Offset: 0x15178F0 VA: 0x1815192F0
	private void ValidateStartElement() { }

	// RVA: 0x1519070 Offset: 0x1517670 VA: 0x181519070
	private void ValidateEndStartElement() { }

	// RVA: 0x1518140 Offset: 0x1516740 VA: 0x181518140
	private void ProcessElement() { }

	// RVA: 0x1517AA0 Offset: 0x15160A0 VA: 0x181517AA0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1518E80 Offset: 0x1517480 VA: 0x181518E80
	private void ValidateEndElement() { }

	// RVA: 0x1519DE0 Offset: 0x15183E0 VA: 0x181519DE0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1518290 Offset: 0x1516890 VA: 0x181518290
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1517610 Offset: 0x1515C10 VA: 0x181517610
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1517150 Offset: 0x1515750 VA: 0x181517150
	internal void AddID(string name, object node) { }

	// RVA: 0x1517C10 Offset: 0x1516210 VA: 0x181517C10 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1517C30 Offset: 0x1516230 VA: 0x181517C30
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1517DF0 Offset: 0x15163F0 VA: 0x181517DF0
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x15174D0 Offset: 0x1515AD0 VA: 0x1815174D0
	private void CheckForwardRefs() { }

	// RVA: 0x1518530 Offset: 0x1516B30 VA: 0x181518530
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x15180A0 Offset: 0x15166A0 VA: 0x1815180A0
	private bool Pop() { }

	// RVA: 0x1518680 Offset: 0x1516C80 VA: 0x181518680
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1517200 Offset: 0x1515800 VA: 0x181517200
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1519B90 Offset: 0x1518190 VA: 0x181519B90
	private static void .cctor() { }

}

private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 2244
{	// Methods

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

