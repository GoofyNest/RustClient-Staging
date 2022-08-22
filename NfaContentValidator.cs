internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 2170
{	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0xB13E60 Offset: 0xB12460 VA: 0x180B13E60
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0xB13A90 Offset: 0xB12090 VA: 0x180B13A90 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB13C00 Offset: 0xB12200 VA: 0x180B13C00 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB13640 Offset: 0xB11C40 VA: 0x180B13640 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB136A0 Offset: 0xB11CA0 VA: 0x180B136A0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB138A0 Offset: 0xB11EA0 VA: 0x180B138A0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

