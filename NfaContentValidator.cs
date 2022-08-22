internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 2170
{	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0xB13990 Offset: 0xB11F90 VA: 0x180B13990
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0xB135C0 Offset: 0xB11BC0 VA: 0x180B135C0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB13730 Offset: 0xB11D30 VA: 0x180B13730 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB13170 Offset: 0xB11770 VA: 0x180B13170 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB131D0 Offset: 0xB117D0 VA: 0x180B131D0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB133D0 Offset: 0xB119D0 VA: 0x180B133D0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

