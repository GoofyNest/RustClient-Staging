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

	// RVA: 0x17C65F0 Offset: 0x17C4BF0 VA: 0x1817C65F0
	public void .ctor(int bufferSize) { }

	// RVA: 0x15D3730 Offset: 0x15D1D30 VA: 0x1815D3730
	public void Clear() { }

	// RVA: 0x17C6260 Offset: 0x17C4860 VA: 0x1817C6260 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17C6670 Offset: 0x17C4C70 VA: 0x1817C6670
	public byte[] get_Buffer() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x117BFB0 Offset: 0x117A5B0 VA: 0x18117BFB0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x17C66F0 Offset: 0x17C4CF0 VA: 0x1817C66F0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x17C6760 Offset: 0x17C4D60 VA: 0x1817C6760 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17C67D0 Offset: 0x17C4DD0 VA: 0x1817C67D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x17C63A0 Offset: 0x17C49A0 VA: 0x1817C63A0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17C6410 Offset: 0x17C4A10 VA: 0x1817C6410 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x17C6330 Offset: 0x17C4930 VA: 0x1817C6330 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x17C6480 Offset: 0x17C4A80 VA: 0x1817C6480 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

