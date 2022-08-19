internal struct IPv6AddressFormatter // TypeDefIndex: 3012
{
// Namespace: System.Net
internal struct IPv6AddressFormatter // TypeDefIndex: 3012
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x14C6A0 Offset: 0x14BAA0 VA: 0x18014C6A0
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x1344CD0 Offset: 0x13432D0 VA: 0x181344CD0
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x1E1740 Offset: 0x1E0B40 VA: 0x1801E1740
	private uint AsIPv4Int() { }

	// RVA: 0x1E17A0 Offset: 0x1E0BA0 VA: 0x1801E17A0
	private bool IsIPv4Compatible() { }

	// RVA: 0x1E17B0 Offset: 0x1E0BB0 VA: 0x1801E17B0
	private bool IsIPv4Mapped() { }

	// RVA: 0x1E17C0 Offset: 0x1E0BC0 VA: 0x1801E17C0 Slot: 3
	public override string ToString() { }

}

