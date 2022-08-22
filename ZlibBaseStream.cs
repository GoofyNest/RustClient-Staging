internal class ZlibBaseStream : Stream // TypeDefIndex: 6964
{	// Fields
	protected internal ZlibCodec _z; // 0x28
	protected internal ZlibBaseStream.StreamMode _streamMode; // 0x30
	protected internal FlushType _flushMode; // 0x34
	protected internal ZlibStreamFlavor _flavor; // 0x38
	protected internal CompressionMode _compressionMode; // 0x3C
	protected internal CompressionLevel _level; // 0x40
	protected internal bool _leaveOpen; // 0x44
	protected internal byte[] _workingBuffer; // 0x48
	protected internal int _bufferSize; // 0x50
	protected internal byte[] _buf1; // 0x58
	protected internal Stream _stream; // 0x60
	protected internal CompressionStrategy Strategy; // 0x68
	private CRC32 crc; // 0x70
	protected internal string _GzipFileName; // 0x78
	protected internal string _GzipComment; // 0x80
	protected internal DateTime _GzipMtime; // 0x88
	protected internal int _gzipHeaderByteCount; // 0x90
	private bool nomoreinput; // 0x94

	// Properties
	internal int Crc32 { get; }
	protected internal bool _wantCompress { get; }
	private ZlibCodec z { get; }
	private byte[] workingBuffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x21D7FF0 Offset: 0x21D65F0 VA: 0x1821D7FF0
	internal int get_Crc32() { }

	// RVA: 0x21D7550 Offset: 0x21D5B50 VA: 0x1821D7550
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x21D8080 Offset: 0x21D6680 VA: 0x1821D8080
	protected internal bool get__wantCompress() { }

	// RVA: 0x21D80F0 Offset: 0x21D66F0 VA: 0x1821D80F0
	private ZlibCodec get_z() { }

	// RVA: 0x21D8090 Offset: 0x21D6690 VA: 0x1821D8090
	private byte[] get_workingBuffer() { }

	// RVA: 0x21D6DC0 Offset: 0x21D53C0 VA: 0x1821D6DC0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D77F0 Offset: 0x21D5DF0 VA: 0x1821D77F0
	private void finish() { }

	// RVA: 0x21D7670 Offset: 0x21D5C70 VA: 0x1821D7670
	private void end() { }

	// RVA: 0x21D6110 Offset: 0x21D4710 VA: 0x1821D6110 Slot: 16
	public override void Close() { }

	// RVA: 0x21D6440 Offset: 0x21D4A40 VA: 0x1821D6440 Slot: 18
	public override void Flush() { }

	// RVA: 0x21D6B30 Offset: 0x21D5130 VA: 0x1821D6B30 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21D6B80 Offset: 0x21D5180 VA: 0x1821D6B80 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21D6470 Offset: 0x21D4A70 VA: 0x1821D6470
	private string ReadZeroTerminatedString() { }

	// RVA: 0x21D7160 Offset: 0x21D5760 VA: 0x1821D7160
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x21D65F0 Offset: 0x21D4BF0 VA: 0x1821D65F0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D7F60 Offset: 0x21D6560 VA: 0x1821D7F60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x21D7F90 Offset: 0x21D6590 VA: 0x1821D7F90 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21D7FC0 Offset: 0x21D65C0 VA: 0x1821D7FC0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21D8000 Offset: 0x21D6600 VA: 0x1821D8000 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21D8030 Offset: 0x21D6630 VA: 0x1821D8030 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21D83A0 Offset: 0x21D69A0 VA: 0x1821D83A0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21D6350 Offset: 0x21D4950 VA: 0x1821D6350
	public static void CompressBuffer(byte[] b, Stream compressor) { }

	// RVA: 0x21D6BB0 Offset: 0x21D51B0 VA: 0x1821D6BB0
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

}

internal enum ZlibBaseStream.StreamMode // TypeDefIndex: 6965
{	// Fields
	public int value__; // 0x0
	public const ZlibBaseStream.StreamMode Writer = 0;
	public const ZlibBaseStream.StreamMode Reader = 1;
	public const ZlibBaseStream.StreamMode Undefined = 2;

}

