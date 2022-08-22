internal sealed class StreamWrapper : Stream // TypeDefIndex: 7636
{	// Fields
	private readonly Stream _stream; // 0x28
	private readonly CircularBuffer<byte> _buffer; // 0x30
	private readonly byte[] _peekBuffer; // 0x38
	private readonly byte[] _skipBytesBuffer; // 0x40
	private long _position; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x13A8740 Offset: 0x13A6D40 VA: 0x1813A8740
	public void .ctor(Stream stream, int bufferCapacity) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x13A8830 Offset: 0x13A6E30 VA: 0x1813A8830 Slot: 10
	public override long get_Length() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13A8840 Offset: 0x13A6E40 VA: 0x1813A8840 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x13A83D0 Offset: 0x13A69D0 VA: 0x1813A83D0
	public bool IsEndReached() { }

	// RVA: 0x13A8380 Offset: 0x13A6980 VA: 0x1813A8380 Slot: 18
	public override void Flush() { }

	// RVA: 0x13A8440 Offset: 0x13A6A40 VA: 0x1813A8440 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A85A0 Offset: 0x13A6BA0 VA: 0x1813A85A0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x13A85F0 Offset: 0x13A6BF0 VA: 0x1813A85F0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x13A86F0 Offset: 0x13A6CF0 VA: 0x1813A86F0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A8640 Offset: 0x13A6C40 VA: 0x1813A8640
	private void SkipBytes(int count) { }

}

