internal sealed class BitHelper // TypeDefIndex: 3253
{	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x2229280 Offset: 0x2227880 VA: 0x182229280
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x22292C0 Offset: 0x22278C0 VA: 0x1822292C0
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x22291E0 Offset: 0x22277E0 VA: 0x1822291E0
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x2229150 Offset: 0x2227750 VA: 0x182229150
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x2229260 Offset: 0x2227860 VA: 0x182229260
	internal static int ToIntArrayLength(int n) { }

}

