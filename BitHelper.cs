internal sealed class BitHelper // TypeDefIndex: 3253
{	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x2229540 Offset: 0x2227B40 VA: 0x182229540
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x2229580 Offset: 0x2227B80 VA: 0x182229580
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x22294A0 Offset: 0x2227AA0 VA: 0x1822294A0
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x2229410 Offset: 0x2227A10 VA: 0x182229410
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x2229520 Offset: 0x2227B20 VA: 0x182229520
	internal static int ToIntArrayLength(int n) { }

}

