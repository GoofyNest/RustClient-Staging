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

	// RVA: 0x226D300 Offset: 0x226B900 VA: 0x18226D300 Slot: 10
	public override long get_Length() { }

	// RVA: 0x226D310 Offset: 0x226B910 VA: 0x18226D310 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22120E0 Offset: 0x22106E0 VA: 0x1822120E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x226D1F0 Offset: 0x226B7F0 VA: 0x18226D1F0
	public void .ctor() { }

	// RVA: 0x226CE60 Offset: 0x226B460 VA: 0x18226CE60
	public void SetData(byte[] data, int offset, int length) { }

	// RVA: 0x226CC00 Offset: 0x226B200 VA: 0x18226CC00 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x226CBA0 Offset: 0x226B1A0 VA: 0x18226CBA0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x226D080 Offset: 0x226B680 VA: 0x18226D080 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x226CFD0 Offset: 0x226B5D0 VA: 0x18226CFD0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x226CDA0 Offset: 0x226B3A0 VA: 0x18226CDA0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x226CF80 Offset: 0x226B580 VA: 0x18226CF80 Slot: 26
	public override void SetLength(long value) { }

}
