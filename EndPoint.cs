public abstract class EndPoint // TypeDefIndex: 2873
{	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x152FB40 Offset: 0x152E140 VA: 0x18152FB40 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x152FB00 Offset: 0x152E100 VA: 0x18152FB00 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x152FAC0 Offset: 0x152E0C0 VA: 0x18152FAC0 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

