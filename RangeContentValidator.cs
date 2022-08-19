internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 2172
{	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0xB28760 Offset: 0xB26D60 VA: 0x180B28760
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0xB27BE0 Offset: 0xB261E0 VA: 0x180B27BE0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB27D40 Offset: 0xB26340 VA: 0x180B27D40 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB27680 Offset: 0xB25C80 VA: 0x180B27680 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB276A0 Offset: 0xB25CA0 VA: 0x180B276A0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB27950 Offset: 0xB25F50 VA: 0x180B27950 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

