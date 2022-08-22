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

	// RVA: 0x15326E0 Offset: 0x1530CE0 VA: 0x1815326E0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x15327A0 Offset: 0x1530DA0 VA: 0x1815327A0
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1532870 Offset: 0x1530E70 VA: 0x181532870 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x15328B0 Offset: 0x1530EB0 VA: 0x1815328B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1532890 Offset: 0x1530E90 VA: 0x181532890 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x15328D0 Offset: 0x1530ED0 VA: 0x1815328D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1532930 Offset: 0x1530F30 VA: 0x181532930 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1532990 Offset: 0x1530F90 VA: 0x181532990 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x15324A0 Offset: 0x1530AA0 VA: 0x1815324A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1532560 Offset: 0x1530B60 VA: 0x181532560 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x15325C0 Offset: 0x1530BC0 VA: 0x1815325C0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1532500 Offset: 0x1530B00 VA: 0x181532500 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x15321E0 Offset: 0x15307E0 VA: 0x1815321E0 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1532460 Offset: 0x1530A60 VA: 0x181532460 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1532530 Offset: 0x1530B30 VA: 0x181532530 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1532290 Offset: 0x1530890 VA: 0x181532290 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217CB0 Offset: 0x12162B0 VA: 0x181217CB0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x15326B0 Offset: 0x1530CB0 VA: 0x1815326B0 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1532390 Offset: 0x1530990 VA: 0x181532390 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15324D0 Offset: 0x1530AD0 VA: 0x1815324D0 Slot: 21
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1532680 Offset: 0x1530C80 VA: 0x181532680 Slot: 24
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1532360 Offset: 0x1530960 VA: 0x181532360 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1532340 Offset: 0x1530940 VA: 0x181532340
	private void CheckDeflateStream() { }

	// RVA: 0x1532620 Offset: 0x1530C20 VA: 0x181532620
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

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public string get_Comment() { }

	// RVA: 0x21CFAD0 Offset: 0x21CE0D0 VA: 0x1821CFAD0
	public void set_Comment(string value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_FileName() { }

	// RVA: 0x21CFB50 Offset: 0x21CE150 VA: 0x1821CFB50
	public void set_FileName(string value) { }

	// RVA: 0x21CF8D0 Offset: 0x21CDED0 VA: 0x1821CF8D0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x21CF8B0 Offset: 0x21CDEB0 VA: 0x1821CF8B0
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x21CF720 Offset: 0x21CDD20 VA: 0x1821CF720
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x21CEB00 Offset: 0x21CD100 VA: 0x1821CEB00 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21CF900 Offset: 0x21CDF00 VA: 0x1821CF900 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21CF990 Offset: 0x21CDF90 VA: 0x1821CF990 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21CF060 Offset: 0x21CD660 VA: 0x1821CF060 Slot: 18
	public override void Flush() { }

	// RVA: 0x21CFA20 Offset: 0x21CE020 VA: 0x1821CFA20 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21CFA70 Offset: 0x21CE070 VA: 0x1821CFA70 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21CFCE0 Offset: 0x21CE2E0 VA: 0x1821CFCE0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21CF0E0 Offset: 0x21CD6E0 VA: 0x1821CF0E0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CF3B0 Offset: 0x21CD9B0 VA: 0x1821CF3B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21CF400 Offset: 0x21CDA00 VA: 0x1821CF400 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21CF570 Offset: 0x21CDB70 VA: 0x1821CF570 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CEC00 Offset: 0x21CD200 VA: 0x1821CEC00
	private int EmitHeader() { }

	// RVA: 0x21CE9C0 Offset: 0x21CCFC0 VA: 0x1821CE9C0
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x21CF450 Offset: 0x21CDA50 VA: 0x1821CF450
	public static byte[] UncompressBuffer(byte[] compressed) { }

	// RVA: 0x21CF680 Offset: 0x21CDC80 VA: 0x1821CF680
	private static void .cctor() { }

}

