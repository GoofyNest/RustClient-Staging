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

	// RVA: 0x1626FF0 Offset: 0x16255F0 VA: 0x181626FF0
	public void .ctor() { }

	// RVA: 0x1626F10 Offset: 0x1625510 VA: 0x181626F10
	public void .ctor(int capacity) { }

	// RVA: 0x1626E30 Offset: 0x1625430 VA: 0x181626E30
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1626B70 Offset: 0x1625170 VA: 0x181626B70
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x1626B40 Offset: 0x1625140 VA: 0x181626B40
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x1627070 Offset: 0x1625670 VA: 0x181627070
	public void .ctor(byte[] buffer, int index, int count, bool writable) { }

	// RVA: 0x1626C50 Offset: 0x1625250 VA: 0x181626C50
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0xEE7140 Offset: 0xEE5740 VA: 0x180EE7140 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xEE7140 Offset: 0xEE5740 VA: 0x180EE7140 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16258A0 Offset: 0x1623EA0 VA: 0x1816258A0
	private void EnsureWriteable() { }

	// RVA: 0x1625740 Offset: 0x1623D40 VA: 0x181625740 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16257D0 Offset: 0x1623DD0 VA: 0x1816257D0
	private bool EnsureCapacity(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x16258D0 Offset: 0x1623ED0 VA: 0x1816258D0 Slot: 31
	public virtual byte[] GetBuffer() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x16259A0 Offset: 0x1623FA0 VA: 0x1816259A0
	internal int InternalGetPosition() { }

	// RVA: 0x16259D0 Offset: 0x1623FD0 VA: 0x1816259D0
	internal int InternalReadInt32() { }

	// RVA: 0x1625950 Offset: 0x1623F50 VA: 0x181625950
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x16270A0 Offset: 0x16256A0 VA: 0x1816270A0 Slot: 32
	public virtual int get_Capacity() { }

	// RVA: 0x1627130 Offset: 0x1625730 VA: 0x181627130 Slot: 33
	public virtual void set_Capacity(int value) { }

	// RVA: 0x16270D0 Offset: 0x16256D0 VA: 0x1816270D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1627100 Offset: 0x1625700 VA: 0x181627100 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1627260 Offset: 0x1625860 VA: 0x181627260 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1625DD0 Offset: 0x16243D0 VA: 0x181625DD0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1625AB0 Offset: 0x16240B0 VA: 0x181625AB0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1625D70 Offset: 0x1624370 VA: 0x181625D70 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x16252D0 Offset: 0x16238D0 VA: 0x1816252D0 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1626020 Offset: 0x1624620 VA: 0x181626020 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1626230 Offset: 0x1624830 VA: 0x181626230 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1626370 Offset: 0x1624970 VA: 0x181626370 Slot: 34
	public virtual byte[] ToArray() { }

	// RVA: 0x1626850 Offset: 0x1624E50 VA: 0x181626850 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1626420 Offset: 0x1624A20 VA: 0x181626420 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16266B0 Offset: 0x1624CB0 VA: 0x1816266B0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1626790 Offset: 0x1624D90 VA: 0x181626790 Slot: 35
	public virtual void WriteTo(Stream stream) { }

}

