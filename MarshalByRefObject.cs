public abstract class MarshalByRefObject // TypeDefIndex: 371
{	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	protected void .ctor() { }

	// RVA: 0x1672740 Offset: 0x1670D40 VA: 0x181672740
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x1672790 Offset: 0x1670D90 VA: 0x181672790
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x16726A0 Offset: 0x1670CA0 VA: 0x1816726A0 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x16726F0 Offset: 0x1670CF0 VA: 0x1816726F0 Slot: 5
	public virtual object InitializeLifetimeService() { }

}

