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

	// RVA: 0x13A8480 Offset: 0x13A6A80 VA: 0x1813A8480
	public void .ctor(Stream stream, int bufferCapacity) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x13A8570 Offset: 0x13A6B70 VA: 0x1813A8570 Slot: 10
	public override long get_Length() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13A8580 Offset: 0x13A6B80 VA: 0x1813A8580 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x13A8110 Offset: 0x13A6710 VA: 0x1813A8110
	public bool IsEndReached() { }

	// RVA: 0x13A80C0 Offset: 0x13A66C0 VA: 0x1813A80C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x13A8180 Offset: 0x13A6780 VA: 0x1813A8180 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A82E0 Offset: 0x13A68E0 VA: 0x1813A82E0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x13A8330 Offset: 0x13A6930 VA: 0x1813A8330 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x13A8430 Offset: 0x13A6A30 VA: 0x1813A8430 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A8380 Offset: 0x13A6980 VA: 0x1813A8380
	private void SkipBytes(int count) { }

}

