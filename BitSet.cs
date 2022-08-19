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

	// RVA: 0xF47070 Offset: 0xF45670 VA: 0x180F47070
	public void .ctor(int count) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Count() { }

	// RVA: 0xF46D30 Offset: 0xF45330 VA: 0x180F46D30
	public bool get_Item(int index) { }

	// RVA: 0xF469D0 Offset: 0xF44FD0 VA: 0x180F469D0
	public void Clear() { }

	// RVA: 0xF46FF0 Offset: 0xF455F0 VA: 0x180F46FF0
	public void Set(int index) { }

	// RVA: 0xF46D30 Offset: 0xF45330 VA: 0x180F46D30
	public bool Get(int index) { }

	// RVA: 0xF46E90 Offset: 0xF45490 VA: 0x180F46E90
	public int NextSet(int startFrom) { }

	// RVA: 0xF468E0 Offset: 0xF44EE0 VA: 0x180F468E0
	public void And(BitSet other) { }

	// RVA: 0xF46F40 Offset: 0xF45540 VA: 0x180F46F40
	public void Or(BitSet other) { }

	// RVA: 0xF46CF0 Offset: 0xF452F0 VA: 0x180F46CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF46B80 Offset: 0xF45180 VA: 0x180F46B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF46A30 Offset: 0xF45030 VA: 0x180F46A30
	public BitSet Clone() { }

	// RVA: 0xF470E0 Offset: 0xF456E0 VA: 0x180F470E0
	public bool get_IsEmpty() { }

	// RVA: 0xF46D90 Offset: 0xF45390 VA: 0x180F46D90
	public bool Intersects(BitSet other) { }

	// RVA: 0xF47060 Offset: 0xF45660 VA: 0x180F47060
	private int Subscript(int bitIndex) { }

	// RVA: 0xF46AF0 Offset: 0xF450F0 VA: 0x180F46AF0
	private void EnsureLength(int nRequiredLength) { }

}

