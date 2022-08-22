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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x226D400 Offset: 0x226BA00 VA: 0x18226D400 Slot: 10
	public override long get_Length() { }

	// RVA: 0x226D410 Offset: 0x226BA10 VA: 0x18226D410 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22121E0 Offset: 0x22107E0 VA: 0x1822121E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x226D2F0 Offset: 0x226B8F0 VA: 0x18226D2F0
	public void .ctor() { }

	// RVA: 0x226CF60 Offset: 0x226B560 VA: 0x18226CF60
	public void SetData(byte[] data, int offset, int length) { }

	// RVA: 0x226CD00 Offset: 0x226B300 VA: 0x18226CD00 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x226CCA0 Offset: 0x226B2A0 VA: 0x18226CCA0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x226D180 Offset: 0x226B780 VA: 0x18226D180 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x226D0D0 Offset: 0x226B6D0 VA: 0x18226D0D0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x226CEA0 Offset: 0x226B4A0 VA: 0x18226CEA0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x226D080 Offset: 0x226B680 VA: 0x18226D080 Slot: 26
	public override void SetLength(long value) { }

}

