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

	// RVA: 0x21D81B0 Offset: 0x21D67B0 VA: 0x1821D81B0
	internal int get_Crc32() { }

	// RVA: 0x21D7710 Offset: 0x21D5D10 VA: 0x1821D7710
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x21D8240 Offset: 0x21D6840 VA: 0x1821D8240
	protected internal bool get__wantCompress() { }

	// RVA: 0x21D82B0 Offset: 0x21D68B0 VA: 0x1821D82B0
	private ZlibCodec get_z() { }

	// RVA: 0x21D8250 Offset: 0x21D6850 VA: 0x1821D8250
	private byte[] get_workingBuffer() { }

	// RVA: 0x21D6F80 Offset: 0x21D5580 VA: 0x1821D6F80 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D79B0 Offset: 0x21D5FB0 VA: 0x1821D79B0
	private void finish() { }

	// RVA: 0x21D7830 Offset: 0x21D5E30 VA: 0x1821D7830
	private void end() { }

	// RVA: 0x21D62D0 Offset: 0x21D48D0 VA: 0x1821D62D0 Slot: 16
	public override void Close() { }

	// RVA: 0x21D6600 Offset: 0x21D4C00 VA: 0x1821D6600 Slot: 18
	public override void Flush() { }

	// RVA: 0x21D6CF0 Offset: 0x21D52F0 VA: 0x1821D6CF0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21D6D40 Offset: 0x21D5340 VA: 0x1821D6D40 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21D6630 Offset: 0x21D4C30 VA: 0x1821D6630
	private string ReadZeroTerminatedString() { }

	// RVA: 0x21D7320 Offset: 0x21D5920 VA: 0x1821D7320
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x21D67B0 Offset: 0x21D4DB0 VA: 0x1821D67B0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D8120 Offset: 0x21D6720 VA: 0x1821D8120 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x21D8150 Offset: 0x21D6750 VA: 0x1821D8150 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21D8180 Offset: 0x21D6780 VA: 0x1821D8180 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21D81C0 Offset: 0x21D67C0 VA: 0x1821D81C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21D81F0 Offset: 0x21D67F0 VA: 0x1821D81F0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21D8560 Offset: 0x21D6B60 VA: 0x1821D8560 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21D6510 Offset: 0x21D4B10 VA: 0x1821D6510
	public static void CompressBuffer(byte[] b, Stream compressor) { }

	// RVA: 0x21D6D70 Offset: 0x21D5370 VA: 0x1821D6D70
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

}

internal enum ZlibBaseStream.StreamMode // TypeDefIndex: 6965
{	// Fields
	public int value__; // 0x0
	public const ZlibBaseStream.StreamMode Writer = 0;
	public const ZlibBaseStream.StreamMode Reader = 1;
	public const ZlibBaseStream.StreamMode Undefined = 2;

}

