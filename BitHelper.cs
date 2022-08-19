internal sealed class BitHelper // TypeDefIndex: 3253
{	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x2229440 Offset: 0x2227A40 VA: 0x182229440
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x2229480 Offset: 0x2227A80 VA: 0x182229480
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x22293A0 Offset: 0x22279A0 VA: 0x1822293A0
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x2229310 Offset: 0x2227910 VA: 0x182229310
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x2229420 Offset: 0x2227A20 VA: 0x182229420
	internal static int ToIntArrayLength(int n) { }

}

