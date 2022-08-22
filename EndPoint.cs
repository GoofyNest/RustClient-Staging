public abstract class EndPoint // TypeDefIndex: 2873
{	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x152EC10 Offset: 0x152D210 VA: 0x18152EC10 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x152EBD0 Offset: 0x152D1D0 VA: 0x18152EBD0 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x152EB90 Offset: 0x152D190 VA: 0x18152EB90 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

