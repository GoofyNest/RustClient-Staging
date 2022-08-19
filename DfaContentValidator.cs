internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 2169
{	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1516C10 Offset: 0x1515210 VA: 0x181516C10
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1516A30 Offset: 0x1515030 VA: 0x181516A30 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1516AC0 Offset: 0x15150C0 VA: 0x181516AC0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1516690 Offset: 0x1514C90 VA: 0x181516690 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x15166B0 Offset: 0x1514CB0 VA: 0x1815166B0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1516890 Offset: 0x1514E90 VA: 0x181516890 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

