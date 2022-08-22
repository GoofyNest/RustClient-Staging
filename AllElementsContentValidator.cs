internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 2173
{	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0xF42A60 Offset: 0xF41060 VA: 0x180F42A60
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0xF41F00 Offset: 0xF40500 VA: 0x180F41F00
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0xF42BA0 Offset: 0xF411A0 VA: 0x180F42BA0 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0xF427B0 Offset: 0xF40DB0 VA: 0x180F427B0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xF42890 Offset: 0xF40E90 VA: 0x180F42890 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xF42070 Offset: 0xF40670 VA: 0x180F42070 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xF420C0 Offset: 0xF406C0 VA: 0x180F420C0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xF42420 Offset: 0xF40A20 VA: 0x180F42420 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

