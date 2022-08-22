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

	// RVA: 0x79B560 Offset: 0x799B60 VA: 0x18079B560
	public int get_EndOffset() { }

	// RVA: 0x1210BC0 Offset: 0x120F1C0 VA: 0x181210BC0
	public int get_Remaining() { }

	// RVA: 0x1210A90 Offset: 0x120F090 VA: 0x181210A90
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x1210A10 Offset: 0x120F010 VA: 0x181210A10 Slot: 3
	public override string ToString() { }

}

internal class BufferOffsetSize // TypeDefIndex: 2913
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x151F200 Offset: 0x151D800 VA: 0x18151F200
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

}

