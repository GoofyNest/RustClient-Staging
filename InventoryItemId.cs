public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId> // TypeDefIndex: 5537
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static InventoryItemId op_Implicit(ulong value) { }

	// RVA: 0x1231C0 Offset: 0x1225C0 VA: 0x1801231C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8BB0 Offset: 0x1D7FB0 VA: 0x1801D8BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EAE70 Offset: 0x1EA270 VA: 0x1801EAE70 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D8B30 Offset: 0x1D7F30 VA: 0x1801D8B30 Slot: 4
	public bool Equals(InventoryItemId p) { }

	// RVA: 0x1291C00 Offset: 0x1290200 VA: 0x181291C00
	public static bool op_Equality(InventoryItemId a, InventoryItemId b) { }

	// RVA: 0x1D8B20 Offset: 0x1D7F20 VA: 0x1801D8B20 Slot: 5
	public int CompareTo(InventoryItemId other) { }

}

