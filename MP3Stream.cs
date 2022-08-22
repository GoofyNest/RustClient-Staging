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
	// RVA: 0xABF5D0 Offset: 0xABDBD0 VA: 0x180ABF5D0
	public bool get_IsEOF() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22631A0 Offset: 0x22617A0 VA: 0x1822631A0
	protected void set_IsEOF(bool value) { }

	// RVA: 0x2262DF0 Offset: 0x22613F0 VA: 0x182262DF0
	public void .ctor(Stream sourceStream) { }

	// RVA: 0x2262E00 Offset: 0x2261400 VA: 0x182262E00
	public void .ctor(Stream sourceStream, int chunkSize) { }

	// RVA: 0x22630B0 Offset: 0x22616B0 VA: 0x1822630B0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x22630E0 Offset: 0x22616E0 VA: 0x1822630E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2263110 Offset: 0x2261710 VA: 0x182263110 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2263140 Offset: 0x2261740 VA: 0x182263140 Slot: 10
	public override long get_Length() { }

	// RVA: 0x2263170 Offset: 0x2261770 VA: 0x182263170 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22631B0 Offset: 0x22617B0 VA: 0x1822631B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public int get_Frequency() { }

	// RVA: 0x2262AC0 Offset: 0x22610C0 VA: 0x182262AC0 Slot: 18
	public override void Flush() { }

	// RVA: 0x2262D20 Offset: 0x2261320 VA: 0x182262D20 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2262D50 Offset: 0x2261350 VA: 0x182262D50 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2262DA0 Offset: 0x22613A0 VA: 0x182262DA0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262C50 Offset: 0x2261250 VA: 0x182262C50 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262AA0 Offset: 0x22610A0 VA: 0x182262AA0 Slot: 16
	public override void Close() { }

	// RVA: 0x2262AF0 Offset: 0x22610F0 VA: 0x182262AF0
	private bool ReadFrame() { }

}

