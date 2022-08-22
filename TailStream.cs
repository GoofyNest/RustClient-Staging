internal sealed class TailStream : Stream // TypeDefIndex: 970
{	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17C4400 Offset: 0x17C2A00 VA: 0x1817C4400
	public void .ctor(int bufferSize) { }

	// RVA: 0x15D2AC0 Offset: 0x15D10C0 VA: 0x1815D2AC0
	public void Clear() { }

	// RVA: 0x17C4070 Offset: 0x17C2670 VA: 0x1817C4070 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17C4480 Offset: 0x17C2A80 VA: 0x1817C4480
	public byte[] get_Buffer() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1180B90 Offset: 0x117F190 VA: 0x181180B90 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x17C4500 Offset: 0x17C2B00 VA: 0x1817C4500 Slot: 10
	public override long get_Length() { }

	// RVA: 0x17C4570 Offset: 0x17C2B70 VA: 0x1817C4570 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17C45E0 Offset: 0x17C2BE0 VA: 0x1817C45E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x17C41B0 Offset: 0x17C27B0 VA: 0x1817C41B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17C4220 Offset: 0x17C2820 VA: 0x1817C4220 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x17C4140 Offset: 0x17C2740 VA: 0x1817C4140 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x17C4290 Offset: 0x17C2890 VA: 0x1817C4290 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

