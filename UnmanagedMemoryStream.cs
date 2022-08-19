public class UnmanagedMemoryStream : Stream // TypeDefIndex: 659
{	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x1686D60 Offset: 0x1685360 VA: 0x181686D60
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1686E60 Offset: 0x1685460 VA: 0x181686E60
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x1686DC0 Offset: 0x16853C0 VA: 0x181686DC0
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x1685700 Offset: 0x1683D00 VA: 0x181685700
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x1686F00 Offset: 0x1685500 VA: 0x181686F00 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x15F1E80 Offset: 0x15F0480 VA: 0x1815F1E80 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1686F10 Offset: 0x1685510 VA: 0x181686F10 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16856C0 Offset: 0x1683CC0 VA: 0x1816856C0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16856E0 Offset: 0x1683CE0 VA: 0x1816856E0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1686F30 Offset: 0x1685530 VA: 0x181686F30 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1687040 Offset: 0x1685640 VA: 0x181687040 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1687080 Offset: 0x1685680 VA: 0x181687080 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1686F60 Offset: 0x1685560 VA: 0x181686F60
	public byte* get_PositionPointer() { }

	// RVA: 0x1685D60 Offset: 0x1684360 VA: 0x181685D60 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1685940 Offset: 0x1683F40 VA: 0x181685940 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1685BD0 Offset: 0x16841D0 VA: 0x181685BD0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x16860D0 Offset: 0x16846D0 VA: 0x1816860D0 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1686280 Offset: 0x1684880 VA: 0x181686280 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1686910 Offset: 0x1684F10 VA: 0x181686910 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1686440 Offset: 0x1684A40 VA: 0x181686440 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1686690 Offset: 0x1684C90 VA: 0x181686690 Slot: 30
	public override void WriteByte(byte value) { }

}

