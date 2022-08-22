internal sealed class BitSet // TypeDefIndex: 2141
{	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0xF47DD0 Offset: 0xF463D0 VA: 0x180F47DD0
	public void .ctor(int count) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Count() { }

	// RVA: 0xF47A90 Offset: 0xF46090 VA: 0x180F47A90
	public bool get_Item(int index) { }

	// RVA: 0xF47730 Offset: 0xF45D30 VA: 0x180F47730
	public void Clear() { }

	// RVA: 0xF47D50 Offset: 0xF46350 VA: 0x180F47D50
	public void Set(int index) { }

	// RVA: 0xF47A90 Offset: 0xF46090 VA: 0x180F47A90
	public bool Get(int index) { }

	// RVA: 0xF47BF0 Offset: 0xF461F0 VA: 0x180F47BF0
	public int NextSet(int startFrom) { }

	// RVA: 0xF47640 Offset: 0xF45C40 VA: 0x180F47640
	public void And(BitSet other) { }

	// RVA: 0xF47CA0 Offset: 0xF462A0 VA: 0x180F47CA0
	public void Or(BitSet other) { }

	// RVA: 0xF47A50 Offset: 0xF46050 VA: 0x180F47A50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF478E0 Offset: 0xF45EE0 VA: 0x180F478E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF47790 Offset: 0xF45D90 VA: 0x180F47790
	public BitSet Clone() { }

	// RVA: 0xF47E40 Offset: 0xF46440 VA: 0x180F47E40
	public bool get_IsEmpty() { }

	// RVA: 0xF47AF0 Offset: 0xF460F0 VA: 0x180F47AF0
	public bool Intersects(BitSet other) { }

	// RVA: 0xF47DC0 Offset: 0xF463C0 VA: 0x180F47DC0
	private int Subscript(int bitIndex) { }

	// RVA: 0xF47850 Offset: 0xF45E50 VA: 0x180F47850
	private void EnsureLength(int nRequiredLength) { }

}

