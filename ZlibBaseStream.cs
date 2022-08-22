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

	// RVA: 0x21D8AD0 Offset: 0x21D70D0 VA: 0x1821D8AD0
	internal int get_Crc32() { }

	// RVA: 0x21D8030 Offset: 0x21D6630 VA: 0x1821D8030
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x21D8B60 Offset: 0x21D7160 VA: 0x1821D8B60
	protected internal bool get__wantCompress() { }

	// RVA: 0x21D8BD0 Offset: 0x21D71D0 VA: 0x1821D8BD0
	private ZlibCodec get_z() { }

	// RVA: 0x21D8B70 Offset: 0x21D7170 VA: 0x1821D8B70
	private byte[] get_workingBuffer() { }

	// RVA: 0x21D78A0 Offset: 0x21D5EA0 VA: 0x1821D78A0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D82D0 Offset: 0x21D68D0 VA: 0x1821D82D0
	private void finish() { }

	// RVA: 0x21D8150 Offset: 0x21D6750 VA: 0x1821D8150
	private void end() { }

	// RVA: 0x21D6BF0 Offset: 0x21D51F0 VA: 0x1821D6BF0 Slot: 16
	public override void Close() { }

	// RVA: 0x21D6F20 Offset: 0x21D5520 VA: 0x1821D6F20 Slot: 18
	public override void Flush() { }

	// RVA: 0x21D7610 Offset: 0x21D5C10 VA: 0x1821D7610 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21D7660 Offset: 0x21D5C60 VA: 0x1821D7660 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21D6F50 Offset: 0x21D5550 VA: 0x1821D6F50
	private string ReadZeroTerminatedString() { }

	// RVA: 0x21D7C40 Offset: 0x21D6240 VA: 0x1821D7C40
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x21D70D0 Offset: 0x21D56D0 VA: 0x1821D70D0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D8A40 Offset: 0x21D7040 VA: 0x1821D8A40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x21D8A70 Offset: 0x21D7070 VA: 0x1821D8A70 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21D8AA0 Offset: 0x21D70A0 VA: 0x1821D8AA0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21D8AE0 Offset: 0x21D70E0 VA: 0x1821D8AE0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21D8B10 Offset: 0x21D7110 VA: 0x1821D8B10 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21D8E80 Offset: 0x21D7480 VA: 0x1821D8E80 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21D6E30 Offset: 0x21D5430 VA: 0x1821D6E30
	public static void CompressBuffer(byte[] b, Stream compressor) { }

	// RVA: 0x21D7690 Offset: 0x21D5C90 VA: 0x1821D7690
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

}

internal enum ZlibBaseStream.StreamMode // TypeDefIndex: 6965
{	// Fields
	public int value__; // 0x0
	public const ZlibBaseStream.StreamMode Writer = 0;
	public const ZlibBaseStream.StreamMode Reader = 1;
	public const ZlibBaseStream.StreamMode Undefined = 2;

}

