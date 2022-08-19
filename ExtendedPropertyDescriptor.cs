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

	// RVA: 0x15C5680 Offset: 0x15C3C80 VA: 0x1815C5680
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x15C5890 Offset: 0x15C3E90 VA: 0x1815C5890 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15C5BF0 Offset: 0x15C41F0 VA: 0x1815C5BF0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x15C5CE0 Offset: 0x15C42E0 VA: 0x1815C5CE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15C58C0 Offset: 0x15C3EC0 VA: 0x1815C58C0 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x15C55E0 Offset: 0x15C3BE0 VA: 0x1815C55E0 Slot: 17
	public override object GetValue(object comp) { }

	// RVA: 0x15C5610 Offset: 0x15C3C10 VA: 0x1815C5610 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15C5650 Offset: 0x15C3C50 VA: 0x1815C5650 Slot: 20
	public override bool ShouldSerializeValue(object comp) { }

}

