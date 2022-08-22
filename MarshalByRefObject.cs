public abstract class MarshalByRefObject // TypeDefIndex: 371
{	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	protected void .ctor() { }

	// RVA: 0x1674B50 Offset: 0x1673150 VA: 0x181674B50
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x1674BA0 Offset: 0x16731A0 VA: 0x181674BA0
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x1674AB0 Offset: 0x16730B0 VA: 0x181674AB0 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1674B00 Offset: 0x1673100 VA: 0x181674B00 Slot: 5
	public virtual object InitializeLifetimeService() { }

}

