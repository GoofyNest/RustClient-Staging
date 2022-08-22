internal struct IPv6AddressFormatter // TypeDefIndex: 3012
{
// Namespace: System.Net
internal struct IPv6AddressFormatter // TypeDefIndex: 3012
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x14C620 Offset: 0x14BA20 VA: 0x18014C620
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x1344F90 Offset: 0x1343590 VA: 0x181344F90
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x1E16C0 Offset: 0x1E0AC0 VA: 0x1801E16C0
	private uint AsIPv4Int() { }

	// RVA: 0x1E1720 Offset: 0x1E0B20 VA: 0x1801E1720
	private bool IsIPv4Compatible() { }

	// RVA: 0x1E1730 Offset: 0x1E0B30 VA: 0x1801E1730
	private bool IsIPv4Mapped() { }

	// RVA: 0x1E1740 Offset: 0x1E0B40 VA: 0x1801E1740 Slot: 3
	public override string ToString() { }

}

