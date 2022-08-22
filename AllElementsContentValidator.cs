internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 2173
{	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0xF41FC0 Offset: 0xF405C0 VA: 0x180F41FC0
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0xF41460 Offset: 0xF3FA60 VA: 0x180F41460
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0xF42100 Offset: 0xF40700 VA: 0x180F42100 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0xF41D10 Offset: 0xF40310 VA: 0x180F41D10 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xF41DF0 Offset: 0xF403F0 VA: 0x180F41DF0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xF415D0 Offset: 0xF3FBD0 VA: 0x180F415D0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xF41620 Offset: 0xF3FC20 VA: 0x180F41620 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xF41980 Offset: 0xF3FF80 VA: 0x180F41980 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

