public sealed class Bitstream // TypeDefIndex: 7384
{	// Fields
	private const int BUFFER_INT_SIZE = 433;
	internal const sbyte INITIAL_SYNC = 0;
	internal const sbyte STRICT_SYNC = 1;
	private readonly int[] _Bitmask; // 0x10
	private readonly PushbackStream _SourceStream; // 0x18
	private int _BitIndex; // 0x20
	private Crc16[] _CRC; // 0x28
	private sbyte[] _FrameBytes; // 0x30
	private int[] _FrameBuffer; // 0x38
	private int _FrameSize; // 0x40
	private Header _Header; // 0x48
	private bool _SingleChMode; // 0x50
	private sbyte[] _SyncBuffer; // 0x58
	private int _SyncWord; // 0x60
	private int _WordPointer; // 0x64

	// Methods

	// RVA: 0x5DBB50 Offset: 0x5DA150 VA: 0x1805DBB50
	internal void .ctor(PushbackStream stream) { }

	// RVA: 0x5DAF50 Offset: 0x5D9550 VA: 0x1805DAF50
	private void InitBlock() { }

	// RVA: 0x5DAD10 Offset: 0x5D9310 VA: 0x1805DAD10
	internal void Close() { }

	// RVA: 0x5DB670 Offset: 0x5D9C70 VA: 0x1805DB670
	internal Header ReadFrame() { }

	// RVA: 0x5DB850 Offset: 0x5D9E50 VA: 0x1805DB850
	private Header ReadNextFrame() { }

	// RVA: 0x5DBAB0 Offset: 0x5DA0B0 VA: 0x1805DBAB0
	internal void UnreadFrame() { }

	// RVA: 0x5DACF0 Offset: 0x5D92F0 VA: 0x1805DACF0
	internal void CloseFrame() { }

	// RVA: 0x5DB040 Offset: 0x5D9640 VA: 0x1805DB040
	internal bool IsSyncCurrentPosition(int syncmode) { }

	// RVA: 0x5DB320 Offset: 0x5D9920 VA: 0x1805DB320
	internal BitstreamException NewBitstreamException(int errorcode) { }

	// RVA: 0x5DB380 Offset: 0x5D9980 VA: 0x1805DB380
	internal BitstreamException NewBitstreamException(int errorcode, Exception throwable) { }

	// RVA: 0x5DB900 Offset: 0x5D9F00 VA: 0x1805DB900
	internal int SyncHeader(sbyte syncmode) { }

	// RVA: 0x5DB200 Offset: 0x5D9800 VA: 0x1805DB200
	internal bool IsSyncMark(int headerstring, int syncmode, int word) { }

	// RVA: 0x5DB890 Offset: 0x5D9E90 VA: 0x1805DB890
	internal void Read_frame_data(int bytesize) { }

	// RVA: 0x5DB3F0 Offset: 0x5D99F0 VA: 0x1805DB3F0
	internal void ParseFrame() { }

	// RVA: 0x5DADA0 Offset: 0x5D93A0 VA: 0x1805DADA0
	internal int GetBitsFromBuffer(int countBits) { }

	// RVA: 0x5DB8E0 Offset: 0x5D9EE0 VA: 0x1805DB8E0
	internal void SetSyncWord(int syncword0) { }

	// RVA: 0x5DB750 Offset: 0x5D9D50 VA: 0x1805DB750
	private void ReadFully(sbyte[] b, int offs, int len) { }

	// RVA: 0x5DB5A0 Offset: 0x5D9BA0 VA: 0x1805DB5A0
	private int ReadBytes(sbyte[] b, int offs, int len) { }

}

