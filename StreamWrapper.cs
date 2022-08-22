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

	// RVA: 0x13A7840 Offset: 0x13A5E40 VA: 0x1813A7840
	public void .ctor(Stream stream, int bufferCapacity) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x13A7930 Offset: 0x13A5F30 VA: 0x1813A7930 Slot: 10
	public override long get_Length() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13A7940 Offset: 0x13A5F40 VA: 0x1813A7940 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x13A74D0 Offset: 0x13A5AD0 VA: 0x1813A74D0
	public bool IsEndReached() { }

	// RVA: 0x13A7480 Offset: 0x13A5A80 VA: 0x1813A7480 Slot: 18
	public override void Flush() { }

	// RVA: 0x13A7540 Offset: 0x13A5B40 VA: 0x1813A7540 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A76A0 Offset: 0x13A5CA0 VA: 0x1813A76A0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x13A76F0 Offset: 0x13A5CF0 VA: 0x1813A76F0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x13A77F0 Offset: 0x13A5DF0 VA: 0x1813A77F0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A7740 Offset: 0x13A5D40 VA: 0x1813A7740
	private void SkipBytes(int count) { }

}

