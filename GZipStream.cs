public class GZipStream : Stream // TypeDefIndex: 2861
{	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1533350 Offset: 0x1531950 VA: 0x181533350
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1533410 Offset: 0x1531A10 VA: 0x181533410
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x15334E0 Offset: 0x1531AE0 VA: 0x1815334E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1533520 Offset: 0x1531B20 VA: 0x181533520 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1533500 Offset: 0x1531B00 VA: 0x181533500 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1533540 Offset: 0x1531B40 VA: 0x181533540 Slot: 10
	public override long get_Length() { }

	// RVA: 0x15335A0 Offset: 0x1531BA0 VA: 0x1815335A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1533600 Offset: 0x1531C00 VA: 0x181533600 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1533110 Offset: 0x1531710 VA: 0x181533110 Slot: 18
	public override void Flush() { }

	// RVA: 0x15331D0 Offset: 0x15317D0 VA: 0x1815331D0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1533230 Offset: 0x1531830 VA: 0x181533230 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1533170 Offset: 0x1531770 VA: 0x181533170 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1532E50 Offset: 0x1531450 VA: 0x181532E50 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x15330D0 Offset: 0x15316D0 VA: 0x1815330D0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x15331A0 Offset: 0x15317A0 VA: 0x1815331A0 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1532F00 Offset: 0x1531500 VA: 0x181532F00 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217350 Offset: 0x1215950 VA: 0x181217350 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1533320 Offset: 0x1531920 VA: 0x181533320 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1533000 Offset: 0x1531600 VA: 0x181533000 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1533140 Offset: 0x1531740 VA: 0x181533140 Slot: 21
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15332F0 Offset: 0x15318F0 VA: 0x1815332F0 Slot: 24
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1532FD0 Offset: 0x15315D0 VA: 0x181532FD0 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1532FB0 Offset: 0x15315B0 VA: 0x181532FB0
	private void CheckDeflateStream() { }

	// RVA: 0x1533290 Offset: 0x1531890 VA: 0x181533290
	private static void ThrowStreamClosedException() { }

}

public class GZipStream : Stream // TypeDefIndex: 6945
{	// Fields
	public Nullable<DateTime> LastModified; // 0x28
	private int _headerByteCount; // 0x38
	internal ZlibBaseStream _baseStream; // 0x40
	private bool _disposed; // 0x48
	private bool _firstReadDone; // 0x49
	private string _FileName; // 0x50
	private string _Comment; // 0x58
	private int _Crc32; // 0x60
	internal static readonly DateTime _unixEpoch; // 0x0
	internal static readonly Encoding iso8859dash1; // 0x8

	// Properties
	public string Comment { get; set; }
	public string FileName { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_Comment() { }

	// RVA: 0x21CF1B0 Offset: 0x21CD7B0 VA: 0x1821CF1B0
	public void set_Comment(string value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_FileName() { }

	// RVA: 0x21CF230 Offset: 0x21CD830 VA: 0x1821CF230
	public void set_FileName(string value) { }

	// RVA: 0x21CEFB0 Offset: 0x21CD5B0 VA: 0x1821CEFB0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x21CEF90 Offset: 0x21CD590 VA: 0x1821CEF90
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x21CEE00 Offset: 0x21CD400 VA: 0x1821CEE00
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x21CE1E0 Offset: 0x21CC7E0 VA: 0x1821CE1E0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21CEFE0 Offset: 0x21CD5E0 VA: 0x1821CEFE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21CF070 Offset: 0x21CD670 VA: 0x1821CF070 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21CE740 Offset: 0x21CCD40 VA: 0x1821CE740 Slot: 18
	public override void Flush() { }

	// RVA: 0x21CF100 Offset: 0x21CD700 VA: 0x1821CF100 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21CF150 Offset: 0x21CD750 VA: 0x1821CF150 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21CF3C0 Offset: 0x21CD9C0 VA: 0x1821CF3C0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21CE7C0 Offset: 0x21CCDC0 VA: 0x1821CE7C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CEA90 Offset: 0x21CD090 VA: 0x1821CEA90 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21CEAE0 Offset: 0x21CD0E0 VA: 0x1821CEAE0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21CEC50 Offset: 0x21CD250 VA: 0x1821CEC50 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CE2E0 Offset: 0x21CC8E0 VA: 0x1821CE2E0
	private int EmitHeader() { }

	// RVA: 0x21CE0A0 Offset: 0x21CC6A0 VA: 0x1821CE0A0
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x21CEB30 Offset: 0x21CD130 VA: 0x1821CEB30
	public static byte[] UncompressBuffer(byte[] compressed) { }

	// RVA: 0x21CED60 Offset: 0x21CD360 VA: 0x1821CED60
	private static void .cctor() { }

}

