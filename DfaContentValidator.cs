internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 2169
{	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1516ED0 Offset: 0x15154D0 VA: 0x181516ED0
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1516CF0 Offset: 0x15152F0 VA: 0x181516CF0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1516D80 Offset: 0x1515380 VA: 0x181516D80 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1516950 Offset: 0x1514F50 VA: 0x181516950 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1516970 Offset: 0x1514F70 VA: 0x181516970 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1516B50 Offset: 0x1515150 VA: 0x181516B50 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

