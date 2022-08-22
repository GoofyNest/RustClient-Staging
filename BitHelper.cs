internal sealed class BitHelper // TypeDefIndex: 3253
{	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x2229D60 Offset: 0x2228360 VA: 0x182229D60
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x2229DA0 Offset: 0x22283A0 VA: 0x182229DA0
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x2229CC0 Offset: 0x22282C0 VA: 0x182229CC0
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x2229C30 Offset: 0x2228230 VA: 0x182229C30
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x2229D40 Offset: 0x2228340 VA: 0x182229D40
	internal static int ToIntArrayLength(int n) { }

}

