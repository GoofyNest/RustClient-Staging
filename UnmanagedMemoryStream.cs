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
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x1684C10 Offset: 0x1683210 VA: 0x181684C10
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1684D10 Offset: 0x1683310 VA: 0x181684D10
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x1684C70 Offset: 0x1683270 VA: 0x181684C70
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x16835B0 Offset: 0x1681BB0 VA: 0x1816835B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x1684DB0 Offset: 0x16833B0 VA: 0x181684DB0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x15DF460 Offset: 0x15DDA60 VA: 0x1815DF460 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1684DC0 Offset: 0x16833C0 VA: 0x181684DC0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1683570 Offset: 0x1681B70 VA: 0x181683570 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1683590 Offset: 0x1681B90 VA: 0x181683590 Slot: 18
	public override void Flush() { }

	// RVA: 0x1684DE0 Offset: 0x16833E0 VA: 0x181684DE0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1684EF0 Offset: 0x16834F0 VA: 0x181684EF0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1684F30 Offset: 0x1683530 VA: 0x181684F30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1684E10 Offset: 0x1683410 VA: 0x181684E10
	public byte* get_PositionPointer() { }

	// RVA: 0x1683C10 Offset: 0x1682210 VA: 0x181683C10 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16837F0 Offset: 0x1681DF0 VA: 0x1816837F0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1683A80 Offset: 0x1682080 VA: 0x181683A80 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1683F80 Offset: 0x1682580 VA: 0x181683F80 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1684130 Offset: 0x1682730 VA: 0x181684130 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16847C0 Offset: 0x1682DC0 VA: 0x1816847C0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16842F0 Offset: 0x16828F0 VA: 0x1816842F0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1684540 Offset: 0x1682B40 VA: 0x181684540 Slot: 30
	public override void WriteByte(byte value) { }

}

