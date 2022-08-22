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

	// RVA: 0xB28EF0 Offset: 0xB274F0 VA: 0x180B28EF0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0xB28370 Offset: 0xB26970 VA: 0x180B28370 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB284D0 Offset: 0xB26AD0 VA: 0x180B284D0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB27E10 Offset: 0xB26410 VA: 0x180B27E10 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB27E30 Offset: 0xB26430 VA: 0x180B27E30 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB280E0 Offset: 0xB266E0 VA: 0x180B280E0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

