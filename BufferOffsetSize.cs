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

	// RVA: 0x79B540 Offset: 0x799B40 VA: 0x18079B540
	public int get_EndOffset() { }

	// RVA: 0x1210260 Offset: 0x120E860 VA: 0x181210260
	public int get_Remaining() { }

	// RVA: 0x1210130 Offset: 0x120E730 VA: 0x181210130
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x12100B0 Offset: 0x120E6B0 VA: 0x1812100B0 Slot: 3
	public override string ToString() { }

}

internal class BufferOffsetSize // TypeDefIndex: 2913
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x151FE70 Offset: 0x151E470 VA: 0x18151FE70
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

}

