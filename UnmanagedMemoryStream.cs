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

	// RVA: 0x1687020 Offset: 0x1685620 VA: 0x181687020
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1687120 Offset: 0x1685720 VA: 0x181687120
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x1687080 Offset: 0x1685680 VA: 0x181687080
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x16859C0 Offset: 0x1683FC0 VA: 0x1816859C0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x16871C0 Offset: 0x16857C0 VA: 0x1816871C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x15F2140 Offset: 0x15F0740 VA: 0x1815F2140 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16871D0 Offset: 0x16857D0 VA: 0x1816871D0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1685980 Offset: 0x1683F80 VA: 0x181685980 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16859A0 Offset: 0x1683FA0 VA: 0x1816859A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x16871F0 Offset: 0x16857F0 VA: 0x1816871F0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1687300 Offset: 0x1685900 VA: 0x181687300 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1687340 Offset: 0x1685940 VA: 0x181687340 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1687220 Offset: 0x1685820 VA: 0x181687220
	public byte* get_PositionPointer() { }

	// RVA: 0x1686020 Offset: 0x1684620 VA: 0x181686020 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1685C00 Offset: 0x1684200 VA: 0x181685C00 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1685E90 Offset: 0x1684490 VA: 0x181685E90 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1686390 Offset: 0x1684990 VA: 0x181686390 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1686540 Offset: 0x1684B40 VA: 0x181686540 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1686BD0 Offset: 0x16851D0 VA: 0x181686BD0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1686700 Offset: 0x1684D00 VA: 0x181686700 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1686950 Offset: 0x1684F50 VA: 0x181686950 Slot: 30
	public override void WriteByte(byte value) { }

}

