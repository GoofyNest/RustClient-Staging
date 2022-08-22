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

	// RVA: 0x21D82B0 Offset: 0x21D68B0 VA: 0x1821D82B0
	internal int get_Crc32() { }

	// RVA: 0x21D7810 Offset: 0x21D5E10 VA: 0x1821D7810
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x21D8340 Offset: 0x21D6940 VA: 0x1821D8340
	protected internal bool get__wantCompress() { }

	// RVA: 0x21D83B0 Offset: 0x21D69B0 VA: 0x1821D83B0
	private ZlibCodec get_z() { }

	// RVA: 0x21D8350 Offset: 0x21D6950 VA: 0x1821D8350
	private byte[] get_workingBuffer() { }

	// RVA: 0x21D7080 Offset: 0x21D5680 VA: 0x1821D7080 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D7AB0 Offset: 0x21D60B0 VA: 0x1821D7AB0
	private void finish() { }

	// RVA: 0x21D7930 Offset: 0x21D5F30 VA: 0x1821D7930
	private void end() { }

	// RVA: 0x21D63D0 Offset: 0x21D49D0 VA: 0x1821D63D0 Slot: 16
	public override void Close() { }

	// RVA: 0x21D6700 Offset: 0x21D4D00 VA: 0x1821D6700 Slot: 18
	public override void Flush() { }

	// RVA: 0x21D6DF0 Offset: 0x21D53F0 VA: 0x1821D6DF0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21D6E40 Offset: 0x21D5440 VA: 0x1821D6E40 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21D6730 Offset: 0x21D4D30 VA: 0x1821D6730
	private string ReadZeroTerminatedString() { }

	// RVA: 0x21D7420 Offset: 0x21D5A20 VA: 0x1821D7420
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x21D68B0 Offset: 0x21D4EB0 VA: 0x1821D68B0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D8220 Offset: 0x21D6820 VA: 0x1821D8220 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x21D8250 Offset: 0x21D6850 VA: 0x1821D8250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21D8280 Offset: 0x21D6880 VA: 0x1821D8280 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21D82C0 Offset: 0x21D68C0 VA: 0x1821D82C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21D82F0 Offset: 0x21D68F0 VA: 0x1821D82F0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21D8660 Offset: 0x21D6C60 VA: 0x1821D8660 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21D6610 Offset: 0x21D4C10 VA: 0x1821D6610
	public static void CompressBuffer(byte[] b, Stream compressor) { }

	// RVA: 0x21D6E70 Offset: 0x21D5470 VA: 0x1821D6E70
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

}

internal enum ZlibBaseStream.StreamMode // TypeDefIndex: 6965
{	// Fields
	public int value__; // 0x0
	public const ZlibBaseStream.StreamMode Writer = 0;
	public const ZlibBaseStream.StreamMode Reader = 1;
	public const ZlibBaseStream.StreamMode Undefined = 2;

}

