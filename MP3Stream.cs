public class MP3Stream : Stream // TypeDefIndex: 7379
{	// Fields
	private readonly Bitstream _BitStream; // 0x28
	private readonly Decoder _Decoder; // 0x30
	private readonly Buffer16BitStereo _Buffer; // 0x38
	private readonly Stream _SourceStream; // 0x40
	private const int BACK_STREAM_BYTE_COUNT_REP = 0;
	private short _ChannelCountRep; // 0x48
	private readonly SoundFormat FormatRep; // 0x4C
	private int _FrequencyRep; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsEOF>k__BackingField; // 0x54

	// Properties
	public bool IsEOF { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public int Frequency { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xABEE40 Offset: 0xABD440 VA: 0x180ABEE40
	public bool get_IsEOF() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2262880 Offset: 0x2260E80 VA: 0x182262880
	protected void set_IsEOF(bool value) { }

	// RVA: 0x22624D0 Offset: 0x2260AD0 VA: 0x1822624D0
	public void .ctor(Stream sourceStream) { }

	// RVA: 0x22624E0 Offset: 0x2260AE0 VA: 0x1822624E0
	public void .ctor(Stream sourceStream, int chunkSize) { }

	// RVA: 0x2262790 Offset: 0x2260D90 VA: 0x182262790 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x22627C0 Offset: 0x2260DC0 VA: 0x1822627C0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x22627F0 Offset: 0x2260DF0 VA: 0x1822627F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2262820 Offset: 0x2260E20 VA: 0x182262820 Slot: 10
	public override long get_Length() { }

	// RVA: 0x2262850 Offset: 0x2260E50 VA: 0x182262850 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2262890 Offset: 0x2260E90 VA: 0x182262890 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public int get_Frequency() { }

	// RVA: 0x22621A0 Offset: 0x22607A0 VA: 0x1822621A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x2262400 Offset: 0x2260A00 VA: 0x182262400 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2262430 Offset: 0x2260A30 VA: 0x182262430 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2262480 Offset: 0x2260A80 VA: 0x182262480 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262330 Offset: 0x2260930 VA: 0x182262330 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262180 Offset: 0x2260780 VA: 0x182262180 Slot: 16
	public override void Close() { }

	// RVA: 0x22621D0 Offset: 0x22607D0 VA: 0x1822621D0
	private bool ReadFrame() { }

}

