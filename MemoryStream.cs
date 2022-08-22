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

	// RVA: 0x1614310 Offset: 0x1612910 VA: 0x181614310
	public void .ctor() { }

	// RVA: 0x1614230 Offset: 0x1612830 VA: 0x181614230
	public void .ctor(int capacity) { }

	// RVA: 0x1614150 Offset: 0x1612750 VA: 0x181614150
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1613E90 Offset: 0x1612490 VA: 0x181613E90
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x1613E60 Offset: 0x1612460 VA: 0x181613E60
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x1614390 Offset: 0x1612990 VA: 0x181614390
	public void .ctor(byte[] buffer, int index, int count, bool writable) { }

	// RVA: 0x1613F70 Offset: 0x1612570 VA: 0x181613F70
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0xEE7BF0 Offset: 0xEE61F0 VA: 0x180EE7BF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xEE7BF0 Offset: 0xEE61F0 VA: 0x180EE7BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1612BC0 Offset: 0x16111C0 VA: 0x181612BC0
	private void EnsureWriteable() { }

	// RVA: 0x1612A60 Offset: 0x1611060 VA: 0x181612A60 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1612AF0 Offset: 0x16110F0 VA: 0x181612AF0
	private bool EnsureCapacity(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1612BF0 Offset: 0x16111F0 VA: 0x181612BF0 Slot: 31
	public virtual byte[] GetBuffer() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x1612CC0 Offset: 0x16112C0 VA: 0x181612CC0
	internal int InternalGetPosition() { }

	// RVA: 0x1612CF0 Offset: 0x16112F0 VA: 0x181612CF0
	internal int InternalReadInt32() { }

	// RVA: 0x1612C70 Offset: 0x1611270 VA: 0x181612C70
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x16143C0 Offset: 0x16129C0 VA: 0x1816143C0 Slot: 32
	public virtual int get_Capacity() { }

	// RVA: 0x1614450 Offset: 0x1612A50 VA: 0x181614450 Slot: 33
	public virtual void set_Capacity(int value) { }

	// RVA: 0x16143F0 Offset: 0x16129F0 VA: 0x1816143F0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1614420 Offset: 0x1612A20 VA: 0x181614420 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1614580 Offset: 0x1612B80 VA: 0x181614580 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16130F0 Offset: 0x16116F0 VA: 0x1816130F0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1612DD0 Offset: 0x16113D0 VA: 0x181612DD0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1613090 Offset: 0x1611690 VA: 0x181613090 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x16125F0 Offset: 0x1610BF0 VA: 0x1816125F0 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1613340 Offset: 0x1611940 VA: 0x181613340 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1613550 Offset: 0x1611B50 VA: 0x181613550 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1613690 Offset: 0x1611C90 VA: 0x181613690 Slot: 34
	public virtual byte[] ToArray() { }

	// RVA: 0x1613B70 Offset: 0x1612170 VA: 0x181613B70 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1613740 Offset: 0x1611D40 VA: 0x181613740 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16139D0 Offset: 0x1611FD0 VA: 0x1816139D0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1613AB0 Offset: 0x16120B0 VA: 0x181613AB0 Slot: 35
	public virtual void WriteTo(Stream stream) { }

}

