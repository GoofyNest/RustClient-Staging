public class MemoryStream : Stream // TypeDefIndex: 635
{	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48
	private const int MemStreamMaxLength = 2147483647;

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1626D30 Offset: 0x1625330 VA: 0x181626D30
	public void .ctor() { }

	// RVA: 0x1626C50 Offset: 0x1625250 VA: 0x181626C50
	public void .ctor(int capacity) { }

	// RVA: 0x1626B70 Offset: 0x1625170 VA: 0x181626B70
	public void .ctor(byte[] buffer) { }

	// RVA: 0x16268B0 Offset: 0x1624EB0 VA: 0x1816268B0
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x1626880 Offset: 0x1624E80 VA: 0x181626880
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x1626DB0 Offset: 0x16253B0 VA: 0x181626DB0
	public void .ctor(byte[] buffer, int index, int count, bool writable) { }

	// RVA: 0x1626990 Offset: 0x1624F90 VA: 0x181626990
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0xEE6E80 Offset: 0xEE5480 VA: 0x180EE6E80 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xEE6E80 Offset: 0xEE5480 VA: 0x180EE6E80 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16255E0 Offset: 0x1623BE0 VA: 0x1816255E0
	private void EnsureWriteable() { }

	// RVA: 0x1625480 Offset: 0x1623A80 VA: 0x181625480 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1625510 Offset: 0x1623B10 VA: 0x181625510
	private bool EnsureCapacity(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1625610 Offset: 0x1623C10 VA: 0x181625610 Slot: 31
	public virtual byte[] GetBuffer() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x16256E0 Offset: 0x1623CE0 VA: 0x1816256E0
	internal int InternalGetPosition() { }

	// RVA: 0x1625710 Offset: 0x1623D10 VA: 0x181625710
	internal int InternalReadInt32() { }

	// RVA: 0x1625690 Offset: 0x1623C90 VA: 0x181625690
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x1626DE0 Offset: 0x16253E0 VA: 0x181626DE0 Slot: 32
	public virtual int get_Capacity() { }

	// RVA: 0x1626E70 Offset: 0x1625470 VA: 0x181626E70 Slot: 33
	public virtual void set_Capacity(int value) { }

	// RVA: 0x1626E10 Offset: 0x1625410 VA: 0x181626E10 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1626E40 Offset: 0x1625440 VA: 0x181626E40 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1626FA0 Offset: 0x16255A0 VA: 0x181626FA0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1625B10 Offset: 0x1624110 VA: 0x181625B10 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16257F0 Offset: 0x1623DF0 VA: 0x1816257F0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1625AB0 Offset: 0x16240B0 VA: 0x181625AB0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1625010 Offset: 0x1623610 VA: 0x181625010 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1625D60 Offset: 0x1624360 VA: 0x181625D60 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1625F70 Offset: 0x1624570 VA: 0x181625F70 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16260B0 Offset: 0x16246B0 VA: 0x1816260B0 Slot: 34
	public virtual byte[] ToArray() { }

	// RVA: 0x1626590 Offset: 0x1624B90 VA: 0x181626590 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1626160 Offset: 0x1624760 VA: 0x181626160 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16263F0 Offset: 0x16249F0 VA: 0x1816263F0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x16264D0 Offset: 0x1624AD0 VA: 0x1816264D0 Slot: 35
	public virtual void WriteTo(Stream stream) { }

}

