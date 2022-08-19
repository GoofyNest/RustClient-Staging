internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 2170
{	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0xB136D0 Offset: 0xB11CD0 VA: 0x180B136D0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0xB13300 Offset: 0xB11900 VA: 0x180B13300 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB13470 Offset: 0xB11A70 VA: 0x180B13470 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB12EB0 Offset: 0xB114B0 VA: 0x180B12EB0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB12F10 Offset: 0xB11510 VA: 0x180B12F10 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB13110 Offset: 0xB11710 VA: 0x180B13110 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

