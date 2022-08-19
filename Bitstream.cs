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

	// RVA: 0x5DBBC0 Offset: 0x5DA1C0 VA: 0x1805DBBC0
	internal void .ctor(PushbackStream stream) { }

	// RVA: 0x5DAFC0 Offset: 0x5D95C0 VA: 0x1805DAFC0
	private void InitBlock() { }

	// RVA: 0x5DAD80 Offset: 0x5D9380 VA: 0x1805DAD80
	internal void Close() { }

	// RVA: 0x5DB6E0 Offset: 0x5D9CE0 VA: 0x1805DB6E0
	internal Header ReadFrame() { }

	// RVA: 0x5DB8C0 Offset: 0x5D9EC0 VA: 0x1805DB8C0
	private Header ReadNextFrame() { }

	// RVA: 0x5DBB20 Offset: 0x5DA120 VA: 0x1805DBB20
	internal void UnreadFrame() { }

	// RVA: 0x5DAD60 Offset: 0x5D9360 VA: 0x1805DAD60
	internal void CloseFrame() { }

	// RVA: 0x5DB0B0 Offset: 0x5D96B0 VA: 0x1805DB0B0
	internal bool IsSyncCurrentPosition(int syncmode) { }

	// RVA: 0x5DB390 Offset: 0x5D9990 VA: 0x1805DB390
	internal BitstreamException NewBitstreamException(int errorcode) { }

	// RVA: 0x5DB3F0 Offset: 0x5D99F0 VA: 0x1805DB3F0
	internal BitstreamException NewBitstreamException(int errorcode, Exception throwable) { }

	// RVA: 0x5DB970 Offset: 0x5D9F70 VA: 0x1805DB970
	internal int SyncHeader(sbyte syncmode) { }

	// RVA: 0x5DB270 Offset: 0x5D9870 VA: 0x1805DB270
	internal bool IsSyncMark(int headerstring, int syncmode, int word) { }

	// RVA: 0x5DB900 Offset: 0x5D9F00 VA: 0x1805DB900
	internal void Read_frame_data(int bytesize) { }

	// RVA: 0x5DB460 Offset: 0x5D9A60 VA: 0x1805DB460
	internal void ParseFrame() { }

	// RVA: 0x5DAE10 Offset: 0x5D9410 VA: 0x1805DAE10
	internal int GetBitsFromBuffer(int countBits) { }

	// RVA: 0x5DB950 Offset: 0x5D9F50 VA: 0x1805DB950
	internal void SetSyncWord(int syncword0) { }

	// RVA: 0x5DB7C0 Offset: 0x5D9DC0 VA: 0x1805DB7C0
	private void ReadFully(sbyte[] b, int offs, int len) { }

	// RVA: 0x5DB610 Offset: 0x5D9C10 VA: 0x1805DB610
	private int ReadBytes(sbyte[] b, int offs, int len) { }

}

