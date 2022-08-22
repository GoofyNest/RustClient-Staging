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

	// RVA: 0x5DC8B0 Offset: 0x5DAEB0 VA: 0x1805DC8B0
	internal void .ctor(int size) { }

	// RVA: 0x5DC910 Offset: 0x5DAF10 VA: 0x1805DC910
	internal byte get_Item(int index) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_NumValid() { }

	// RVA: 0x5DC470 Offset: 0x5DAA70 VA: 0x1805DC470
	internal byte Push(byte newValue) { }

	// RVA: 0x5DC410 Offset: 0x5DAA10 VA: 0x1805DC410
	private byte InternalGet(int offset) { }

	// RVA: 0x5DC5C0 Offset: 0x5DABC0 VA: 0x1805DC5C0 Slot: 3
	public override string ToString() { }

}

