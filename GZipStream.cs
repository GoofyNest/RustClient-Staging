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

	// RVA: 0x1533610 Offset: 0x1531C10 VA: 0x181533610
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x15336D0 Offset: 0x1531CD0 VA: 0x1815336D0
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x15337A0 Offset: 0x1531DA0 VA: 0x1815337A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x15337E0 Offset: 0x1531DE0 VA: 0x1815337E0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x15337C0 Offset: 0x1531DC0 VA: 0x1815337C0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1533800 Offset: 0x1531E00 VA: 0x181533800 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1533860 Offset: 0x1531E60 VA: 0x181533860 Slot: 11
	public override long get_Position() { }

	// RVA: 0x15338C0 Offset: 0x1531EC0 VA: 0x1815338C0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x15333D0 Offset: 0x15319D0 VA: 0x1815333D0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1533490 Offset: 0x1531A90 VA: 0x181533490 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x15334F0 Offset: 0x1531AF0 VA: 0x1815334F0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1533430 Offset: 0x1531A30 VA: 0x181533430 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1533110 Offset: 0x1531710 VA: 0x181533110 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1533390 Offset: 0x1531990 VA: 0x181533390 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1533460 Offset: 0x1531A60 VA: 0x181533460 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x15331C0 Offset: 0x15317C0 VA: 0x1815331C0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217610 Offset: 0x1215C10 VA: 0x181217610 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x15335E0 Offset: 0x1531BE0 VA: 0x1815335E0 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x15332C0 Offset: 0x15318C0 VA: 0x1815332C0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1533400 Offset: 0x1531A00 VA: 0x181533400 Slot: 21
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15335B0 Offset: 0x1531BB0 VA: 0x1815335B0 Slot: 24
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1533290 Offset: 0x1531890 VA: 0x181533290 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1533270 Offset: 0x1531870 VA: 0x181533270
	private void CheckDeflateStream() { }

	// RVA: 0x1533550 Offset: 0x1531B50 VA: 0x181533550
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

	// RVA: 0x21CF2B0 Offset: 0x21CD8B0 VA: 0x1821CF2B0
	public void set_Comment(string value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_FileName() { }

	// RVA: 0x21CF330 Offset: 0x21CD930 VA: 0x1821CF330
	public void set_FileName(string value) { }

	// RVA: 0x21CF0B0 Offset: 0x21CD6B0 VA: 0x1821CF0B0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x21CF090 Offset: 0x21CD690 VA: 0x1821CF090
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x21CEF00 Offset: 0x21CD500 VA: 0x1821CEF00
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x21CE2E0 Offset: 0x21CC8E0 VA: 0x1821CE2E0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21CF0E0 Offset: 0x21CD6E0 VA: 0x1821CF0E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21CF170 Offset: 0x21CD770 VA: 0x1821CF170 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21CE840 Offset: 0x21CCE40 VA: 0x1821CE840 Slot: 18
	public override void Flush() { }

	// RVA: 0x21CF200 Offset: 0x21CD800 VA: 0x1821CF200 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21CF250 Offset: 0x21CD850 VA: 0x1821CF250 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21CF4C0 Offset: 0x21CDAC0 VA: 0x1821CF4C0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21CE8C0 Offset: 0x21CCEC0 VA: 0x1821CE8C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CEB90 Offset: 0x21CD190 VA: 0x1821CEB90 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21CEBE0 Offset: 0x21CD1E0 VA: 0x1821CEBE0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21CED50 Offset: 0x21CD350 VA: 0x1821CED50 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21CE3E0 Offset: 0x21CC9E0 VA: 0x1821CE3E0
	private int EmitHeader() { }

	// RVA: 0x21CE1A0 Offset: 0x21CC7A0 VA: 0x1821CE1A0
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x21CEC30 Offset: 0x21CD230 VA: 0x1821CEC30
	public static byte[] UncompressBuffer(byte[] compressed) { }

	// RVA: 0x21CEE60 Offset: 0x21CD460 VA: 0x1821CEE60
	private static void .cctor() { }

}

