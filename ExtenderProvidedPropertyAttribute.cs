public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 2708
{	// Fields
	private PropertyDescriptor extenderProperty; // 0x10
	private IExtenderProvider provider; // 0x18
	private Type receiverType; // 0x20

	// Properties
	public IExtenderProvider Provider { get; }
	public Type ReceiverType { get; }

	// Methods

	// RVA: 0x15C50A0 Offset: 0x15C36A0 VA: 0x1815C50A0
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IExtenderProvider get_Provider() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ReceiverType() { }

	// RVA: 0x15C5150 Offset: 0x15C3750 VA: 0x1815C5150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15BF900 Offset: 0x15BDF00 VA: 0x1815BF900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C5240 Offset: 0x15C3840 VA: 0x1815C5240 Slot: 6
	public override bool IsDefaultAttribute() { }

}

