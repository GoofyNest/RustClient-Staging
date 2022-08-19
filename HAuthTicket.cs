internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket> // TypeDefIndex: 5521
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static HAuthTicket op_Implicit(uint value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Implicit(HAuthTicket value) { }

	// RVA: 0x1D7D40 Offset: 0x1D7140 VA: 0x1801D7D40 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C550 Offset: 0x14B950 VA: 0x18014C550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E9570 Offset: 0x1E8970 VA: 0x1801E9570 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7D30 Offset: 0x1D7130 VA: 0x1801D7D30 Slot: 4
	public bool Equals(HAuthTicket p) { }

	// RVA: 0x1D7CB0 Offset: 0x1D70B0 VA: 0x1801D7CB0 Slot: 5
	public int CompareTo(HAuthTicket other) { }

}

