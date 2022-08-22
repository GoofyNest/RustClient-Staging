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

	// RVA: 0x226D140 Offset: 0x226B740 VA: 0x18226D140 Slot: 10
	public override long get_Length() { }

	// RVA: 0x226D150 Offset: 0x226B750 VA: 0x18226D150 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2211F20 Offset: 0x2210520 VA: 0x182211F20 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x226D030 Offset: 0x226B630 VA: 0x18226D030
	public void .ctor() { }

	// RVA: 0x226CCA0 Offset: 0x226B2A0 VA: 0x18226CCA0
	public void SetData(byte[] data, int offset, int length) { }

	// RVA: 0x226CA40 Offset: 0x226B040 VA: 0x18226CA40 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x226C9E0 Offset: 0x226AFE0 VA: 0x18226C9E0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x226CEC0 Offset: 0x226B4C0 VA: 0x18226CEC0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x226CE10 Offset: 0x226B410 VA: 0x18226CE10 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x226CBE0 Offset: 0x226B1E0 VA: 0x18226CBE0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x226CDC0 Offset: 0x226B3C0 VA: 0x18226CDC0 Slot: 26
	public override void SetLength(long value) { }

}

