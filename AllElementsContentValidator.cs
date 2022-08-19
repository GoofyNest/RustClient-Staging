internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 2173
{	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0xF41D00 Offset: 0xF40300 VA: 0x180F41D00
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0xF411A0 Offset: 0xF3F7A0 VA: 0x180F411A0
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0xF41E40 Offset: 0xF40440 VA: 0x180F41E40 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0xF41A50 Offset: 0xF40050 VA: 0x180F41A50 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xF41B30 Offset: 0xF40130 VA: 0x180F41B30 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xF41310 Offset: 0xF3F910 VA: 0x180F41310 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xF41360 Offset: 0xF3F960 VA: 0x180F41360 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xF416C0 Offset: 0xF3FCC0 VA: 0x180F416C0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

