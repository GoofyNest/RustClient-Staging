public abstract class MarshalByRefObject // TypeDefIndex: 371
{	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	protected void .ctor() { }

	// RVA: 0x1674890 Offset: 0x1672E90 VA: 0x181674890
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x16748E0 Offset: 0x1672EE0 VA: 0x1816748E0
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x16747F0 Offset: 0x1672DF0 VA: 0x1816747F0 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1674840 Offset: 0x1672E40 VA: 0x181674840 Slot: 5
	public virtual object InitializeLifetimeService() { }

}

