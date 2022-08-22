public class ByteArrayStream : Stream // TypeDefIndex: 4833
{	// Fields
	private byte[] _data; // 0x28
	private int _base; // 0x30
	private int _length; // 0x34
	private int _position; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x226DC20 Offset: 0x226C220 VA: 0x18226DC20 Slot: 10
	public override long get_Length() { }

	// RVA: 0x226DC30 Offset: 0x226C230 VA: 0x18226DC30 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2212A00 Offset: 0x2211000 VA: 0x182212A00 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x226DB10 Offset: 0x226C110 VA: 0x18226DB10
	public void .ctor() { }

	// RVA: 0x226D780 Offset: 0x226BD80 VA: 0x18226D780
	public void SetData(byte[] data, int offset, int length) { }

	// RVA: 0x226D520 Offset: 0x226BB20 VA: 0x18226D520 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x226D4C0 Offset: 0x226BAC0 VA: 0x18226D4C0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x226D9A0 Offset: 0x226BFA0 VA: 0x18226D9A0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x226D8F0 Offset: 0x226BEF0 VA: 0x18226D8F0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x226D6C0 Offset: 0x226BCC0 VA: 0x18226D6C0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x226D8A0 Offset: 0x226BEA0 VA: 0x18226D8A0 Slot: 26
	public override void SetLength(long value) { }

}

