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

	// RVA: 0xF47330 Offset: 0xF45930 VA: 0x180F47330
	public void .ctor(int count) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Count() { }

	// RVA: 0xF46FF0 Offset: 0xF455F0 VA: 0x180F46FF0
	public bool get_Item(int index) { }

	// RVA: 0xF46C90 Offset: 0xF45290 VA: 0x180F46C90
	public void Clear() { }

	// RVA: 0xF472B0 Offset: 0xF458B0 VA: 0x180F472B0
	public void Set(int index) { }

	// RVA: 0xF46FF0 Offset: 0xF455F0 VA: 0x180F46FF0
	public bool Get(int index) { }

	// RVA: 0xF47150 Offset: 0xF45750 VA: 0x180F47150
	public int NextSet(int startFrom) { }

	// RVA: 0xF46BA0 Offset: 0xF451A0 VA: 0x180F46BA0
	public void And(BitSet other) { }

	// RVA: 0xF47200 Offset: 0xF45800 VA: 0x180F47200
	public void Or(BitSet other) { }

	// RVA: 0xF46FB0 Offset: 0xF455B0 VA: 0x180F46FB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF46E40 Offset: 0xF45440 VA: 0x180F46E40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF46CF0 Offset: 0xF452F0 VA: 0x180F46CF0
	public BitSet Clone() { }

	// RVA: 0xF473A0 Offset: 0xF459A0 VA: 0x180F473A0
	public bool get_IsEmpty() { }

	// RVA: 0xF47050 Offset: 0xF45650 VA: 0x180F47050
	public bool Intersects(BitSet other) { }

	// RVA: 0xF47320 Offset: 0xF45920 VA: 0x180F47320
	private int Subscript(int bitIndex) { }

	// RVA: 0xF46DB0 Offset: 0xF453B0 VA: 0x180F46DB0
	private void EnsureLength(int nRequiredLength) { }

}

