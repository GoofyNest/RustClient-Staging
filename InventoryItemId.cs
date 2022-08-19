public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId> // TypeDefIndex: 5537
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static InventoryItemId op_Implicit(ulong value) { }

	// RVA: 0x123240 Offset: 0x122640 VA: 0x180123240 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8C30 Offset: 0x1D8030 VA: 0x1801D8C30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EAEF0 Offset: 0x1EA2F0 VA: 0x1801EAEF0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D8BB0 Offset: 0x1D7FB0 VA: 0x1801D8BB0 Slot: 4
	public bool Equals(InventoryItemId p) { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940
	public static bool op_Equality(InventoryItemId a, InventoryItemId b) { }

	// RVA: 0x1D8BA0 Offset: 0x1D7FA0 VA: 0x1801D8BA0 Slot: 5
	public int CompareTo(InventoryItemId other) { }

}

