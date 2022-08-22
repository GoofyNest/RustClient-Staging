internal class BufferOffsetSize // TypeDefIndex: 2530
{	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Properties
	public int EndOffset { get; }
	public int Remaining { get; }

	// Methods

	// RVA: 0x79B650 Offset: 0x799C50 VA: 0x18079B650
	public int get_EndOffset() { }

	// RVA: 0x1210520 Offset: 0x120EB20 VA: 0x181210520
	public int get_Remaining() { }

	// RVA: 0x12103F0 Offset: 0x120E9F0 VA: 0x1812103F0
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x1210370 Offset: 0x120E970 VA: 0x181210370 Slot: 3
	public override string ToString() { }

}

internal class BufferOffsetSize // TypeDefIndex: 2913
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x1520130 Offset: 0x151E730 VA: 0x181520130
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

}

