public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 2708
{	// Fields
	private PropertyDescriptor extenderProperty; // 0x10
	private IExtenderProvider provider; // 0x18
	private Type receiverType; // 0x20

	// Properties
	public IExtenderProvider Provider { get; }
	public Type ReceiverType { get; }

	// Methods

	// RVA: 0x15C5FD0 Offset: 0x15C45D0 VA: 0x1815C5FD0
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IExtenderProvider get_Provider() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_ReceiverType() { }

	// RVA: 0x15C6080 Offset: 0x15C4680 VA: 0x1815C6080 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0830 Offset: 0x15BEE30 VA: 0x1815C0830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C6170 Offset: 0x15C4770 VA: 0x1815C6170 Slot: 6
	public override bool IsDefaultAttribute() { }

}

