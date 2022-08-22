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
	// RVA: 0xABF100 Offset: 0xABD700 VA: 0x180ABF100
	public bool get_IsEOF() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2262980 Offset: 0x2260F80 VA: 0x182262980
	protected void set_IsEOF(bool value) { }

	// RVA: 0x22625D0 Offset: 0x2260BD0 VA: 0x1822625D0
	public void .ctor(Stream sourceStream) { }

	// RVA: 0x22625E0 Offset: 0x2260BE0 VA: 0x1822625E0
	public void .ctor(Stream sourceStream, int chunkSize) { }

	// RVA: 0x2262890 Offset: 0x2260E90 VA: 0x182262890 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x22628C0 Offset: 0x2260EC0 VA: 0x1822628C0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x22628F0 Offset: 0x2260EF0 VA: 0x1822628F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2262920 Offset: 0x2260F20 VA: 0x182262920 Slot: 10
	public override long get_Length() { }

	// RVA: 0x2262950 Offset: 0x2260F50 VA: 0x182262950 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2262990 Offset: 0x2260F90 VA: 0x182262990 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	public int get_Frequency() { }

	// RVA: 0x22622A0 Offset: 0x22608A0 VA: 0x1822622A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x2262500 Offset: 0x2260B00 VA: 0x182262500 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2262530 Offset: 0x2260B30 VA: 0x182262530 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2262580 Offset: 0x2260B80 VA: 0x182262580 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262430 Offset: 0x2260A30 VA: 0x182262430 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2262280 Offset: 0x2260880 VA: 0x182262280 Slot: 16
	public override void Close() { }

	// RVA: 0x22622D0 Offset: 0x22608D0 VA: 0x1822622D0
	private bool ReadFrame() { }

}

