internal struct IPv6AddressFormatter // TypeDefIndex: 3012
{
// Namespace: System.Net
internal struct IPv6AddressFormatter // TypeDefIndex: 3012
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x14C440 Offset: 0x14B840 VA: 0x18014C440
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x1344090 Offset: 0x1342690 VA: 0x181344090
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x1E1AE0 Offset: 0x1E0EE0 VA: 0x1801E1AE0
	private uint AsIPv4Int() { }

	// RVA: 0x1E1B40 Offset: 0x1E0F40 VA: 0x1801E1B40
	private bool IsIPv4Compatible() { }

	// RVA: 0x1E1B50 Offset: 0x1E0F50 VA: 0x1801E1B50
	private bool IsIPv4Mapped() { }

	// RVA: 0x1E1B60 Offset: 0x1E0F60 VA: 0x1801E1B60 Slot: 3
	public override string ToString() { }

}

