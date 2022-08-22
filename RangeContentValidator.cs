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

	// RVA: 0xB28A20 Offset: 0xB27020 VA: 0x180B28A20
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0xB27EA0 Offset: 0xB264A0 VA: 0x180B27EA0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB28000 Offset: 0xB26600 VA: 0x180B28000 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB27940 Offset: 0xB25F40 VA: 0x180B27940 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB27960 Offset: 0xB25F60 VA: 0x180B27960 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB27C10 Offset: 0xB26210 VA: 0x180B27C10 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

