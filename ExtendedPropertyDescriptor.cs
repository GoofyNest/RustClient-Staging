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

	// RVA: 0x15C4A10 Offset: 0x15C3010 VA: 0x1815C4A10
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x15C4C20 Offset: 0x15C3220 VA: 0x1815C4C20 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15C4F80 Offset: 0x15C3580 VA: 0x1815C4F80 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x15C5070 Offset: 0x15C3670 VA: 0x1815C5070 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15C4C50 Offset: 0x15C3250 VA: 0x1815C4C50 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x15C4970 Offset: 0x15C2F70 VA: 0x1815C4970 Slot: 17
	public override object GetValue(object comp) { }

	// RVA: 0x15C49A0 Offset: 0x15C2FA0 VA: 0x1815C49A0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15C49E0 Offset: 0x15C2FE0 VA: 0x1815C49E0 Slot: 20
	public override bool ShouldSerializeValue(object comp) { }

}

