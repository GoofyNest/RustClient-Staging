internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2707
{
// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2707
	// Fields
	private readonly ReflectPropertyDescriptor extenderInfo; // 0x88
	private readonly IExtenderProvider provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x15C5940 Offset: 0x15C3F40 VA: 0x1815C5940
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x15C5B50 Offset: 0x15C4150 VA: 0x1815C5B50 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15C5EB0 Offset: 0x15C44B0 VA: 0x1815C5EB0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x15C5FA0 Offset: 0x15C45A0 VA: 0x1815C5FA0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15C5B80 Offset: 0x15C4180 VA: 0x1815C5B80 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x15C58A0 Offset: 0x15C3EA0 VA: 0x1815C58A0 Slot: 17
	public override object GetValue(object comp) { }

	// RVA: 0x15C58D0 Offset: 0x15C3ED0 VA: 0x1815C58D0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15C5910 Offset: 0x15C3F10 VA: 0x1815C5910 Slot: 20
	public override bool ShouldSerializeValue(object comp) { }

}

