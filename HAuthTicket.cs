internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket> // TypeDefIndex: 5521
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static HAuthTicket op_Implicit(uint value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Implicit(HAuthTicket value) { }

	// RVA: 0x1D7CC0 Offset: 0x1D70C0 VA: 0x1801D7CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E94F0 Offset: 0x1E88F0 VA: 0x1801E94F0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7CB0 Offset: 0x1D70B0 VA: 0x1801D7CB0 Slot: 4
	public bool Equals(HAuthTicket p) { }

	// RVA: 0x1D7C30 Offset: 0x1D7030 VA: 0x1801D7C30 Slot: 5
	public int CompareTo(HAuthTicket other) { }

}

