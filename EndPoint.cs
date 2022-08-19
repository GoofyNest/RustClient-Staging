public abstract class EndPoint // TypeDefIndex: 2873
{	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x152F880 Offset: 0x152DE80 VA: 0x18152F880 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x152F840 Offset: 0x152DE40 VA: 0x18152F840 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x152F800 Offset: 0x152DE00 VA: 0x18152F800 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

