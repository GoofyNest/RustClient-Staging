internal class CircularByteBuffer // TypeDefIndex: 7386
{	// Fields
	private byte[] _DataArray; // 0x10
	private int _Index; // 0x18
	private int _Length; // 0x1C
	private int _NumValid; // 0x20

	// Properties
	internal byte Item { get; }
	internal int NumValid { get; }

	// Methods

	// RVA: 0x5DC920 Offset: 0x5DAF20 VA: 0x1805DC920
	internal void .ctor(int size) { }

	// RVA: 0x5DC980 Offset: 0x5DAF80 VA: 0x1805DC980
	internal byte get_Item(int index) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_NumValid() { }

	// RVA: 0x5DC4E0 Offset: 0x5DAAE0 VA: 0x1805DC4E0
	internal byte Push(byte newValue) { }

	// RVA: 0x5DC480 Offset: 0x5DAA80 VA: 0x1805DC480
	private byte InternalGet(int offset) { }

	// RVA: 0x5DC630 Offset: 0x5DAC30 VA: 0x1805DC630 Slot: 3
	public override string ToString() { }

}

