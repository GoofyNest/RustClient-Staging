internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 2169
{	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1515FA0 Offset: 0x15145A0 VA: 0x181515FA0
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1515DC0 Offset: 0x15143C0 VA: 0x181515DC0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1515E50 Offset: 0x1514450 VA: 0x181515E50 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1515A20 Offset: 0x1514020 VA: 0x181515A20 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1515A40 Offset: 0x1514040 VA: 0x181515A40 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1515C20 Offset: 0x1514220 VA: 0x181515C20 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

