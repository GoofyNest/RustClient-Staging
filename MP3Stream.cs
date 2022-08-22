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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xABEE40 Offset: 0xABD440 VA: 0x180ABEE40
	public bool get_IsEOF() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22626C0 Offset: 0x2260CC0 VA: 0x1822626C0
	protected void set_IsEOF(bool value) { }

	// RVA: 0x2262310 Offset: 0x2260910 VA: 0x182262310
	public void .ctor(Stream sourceStream) { }

	// RVA: 0x2262320 Offset: 0x2260920 VA: 0x182262320
	public void .ctor(Stream sourceStream, int chunkSize) { }

	// RVA: 0x22625D0 Offset: 0x2260BD0 VA: 0x1822625D0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2262600 Offset: 0x2260C00 VA: 0x182262600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2262630 Offset: 0x2260C30 VA: 0x182262630 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2262660 Offset: 0x2260C60 VA: 0x182262660 Slot: 10
	public override long get_Length() { }

	// RVA: 0x2262690 Offset: 0x2260C90 VA: 0x182262690 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22626D0 Offset: 0x2260CD0 VA: 0x1822626D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public int get_Frequency() { }

	// RVA: 0x2261FE0 Offset: 0x22605E0 VA: 0x182261FE0 Slot: 18
	public override void Flush() { }

	// RVA: 0x2262240 Offset: 0x2260840 VA: 0x182262240 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2262270 Offset: 0x2260870 VA: 0x182262270 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x22622C0 Offset: 0x22608C0 VA: 0x1822622C0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262170 Offset: 0x2260770 VA: 0x182262170 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2261FC0 Offset: 0x22605C0 VA: 0x182261FC0 Slot: 16
	public override void Close() { }

	// RVA: 0x2262010 Offset: 0x2260610 VA: 0x182262010
	private bool ReadFrame() { }

}

