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

	// RVA: 0x17C68B0 Offset: 0x17C4EB0 VA: 0x1817C68B0
	public void .ctor(int bufferSize) { }

	// RVA: 0x15D39F0 Offset: 0x15D1FF0 VA: 0x1815D39F0
	public void Clear() { }

	// RVA: 0x17C6520 Offset: 0x17C4B20 VA: 0x1817C6520 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17C6930 Offset: 0x17C4F30 VA: 0x1817C6930
	public byte[] get_Buffer() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x117C270 Offset: 0x117A870 VA: 0x18117C270 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x17C69B0 Offset: 0x17C4FB0 VA: 0x1817C69B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x17C6A20 Offset: 0x17C5020 VA: 0x1817C6A20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17C6A90 Offset: 0x17C5090 VA: 0x1817C6A90 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x17C6660 Offset: 0x17C4C60 VA: 0x1817C6660 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17C66D0 Offset: 0x17C4CD0 VA: 0x1817C66D0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x17C65F0 Offset: 0x17C4BF0 VA: 0x1817C65F0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x17C6740 Offset: 0x17C4D40 VA: 0x1817C6740 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

