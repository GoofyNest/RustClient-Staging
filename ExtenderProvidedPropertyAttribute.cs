public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 2708
{	// Fields
	private PropertyDescriptor extenderProperty; // 0x10
	private IExtenderProvider provider; // 0x18
	private Type receiverType; // 0x20

	// Properties
	public IExtenderProvider Provider { get; }
	public Type ReceiverType { get; }

	// Methods

	// RVA: 0x15C5D10 Offset: 0x15C4310 VA: 0x1815C5D10
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IExtenderProvider get_Provider() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ReceiverType() { }

	// RVA: 0x15C5DC0 Offset: 0x15C43C0 VA: 0x1815C5DC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0570 Offset: 0x15BEB70 VA: 0x1815C0570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C5EB0 Offset: 0x15C44B0 VA: 0x1815C5EB0 Slot: 6
	public override bool IsDefaultAttribute() { }

}

