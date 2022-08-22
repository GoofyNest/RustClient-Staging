internal class DeflaterOutputStream : Stream // TypeDefIndex: 5664
{	// Fields
	protected byte[] buf; // 0x28
	protected Deflater def; // 0x30
	protected Stream baseOutputStream; // 0x38
	private bool isClosed; // 0x40
	private bool isStreamOwner; // 0x41
	private uint[] keys; // 0x48

	// Properties
	public bool IsStreamOwner { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00
	public bool get_IsStreamOwner() { }

	// RVA: 0x2302230 Offset: 0x2300830 VA: 0x182302230 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2302260 Offset: 0x2300860 VA: 0x182302260 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2302290 Offset: 0x2300890 VA: 0x182302290 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFE1740 Offset: 0xFDFD40 VA: 0x180FE1740 Slot: 11
	public override long get_Position() { }

	// RVA: 0x23022C0 Offset: 0x23008C0 VA: 0x1823022C0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2301D90 Offset: 0x2300390 VA: 0x182301D90 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2301DF0 Offset: 0x23003F0 VA: 0x182301DF0 Slot: 26
	public override void SetLength(long val) { }

	// RVA: 0x2301CD0 Offset: 0x23002D0 VA: 0x182301CD0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2301D30 Offset: 0x2300330 VA: 0x182301D30 Slot: 27
	public override int Read(byte[] b, int off, int len) { }

	// RVA: 0x2301680 Offset: 0x22FFC80 VA: 0x182301680 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x23016E0 Offset: 0x22FFCE0 VA: 0x1823016E0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x23017A0 Offset: 0x22FFDA0 VA: 0x1823017A0
	protected void Deflate() { }

	// RVA: 0x23020A0 Offset: 0x23006A0 VA: 0x1823020A0
	public void .ctor(Stream baseOutputStream, Deflater deflater, int bufsize) { }

	// RVA: 0x2301C80 Offset: 0x2300280 VA: 0x182301C80 Slot: 18
	public override void Flush() { }

	// RVA: 0x2301A80 Offset: 0x2300080 VA: 0x182301A80 Slot: 31
	public virtual void Finish() { }

	// RVA: 0x2301740 Offset: 0x22FFD40 VA: 0x182301740 Slot: 16
	public override void Close() { }

	// RVA: 0x2301FC0 Offset: 0x23005C0 VA: 0x182301FC0 Slot: 30
	public override void WriteByte(byte bval) { }

	// RVA: 0x2302060 Offset: 0x2300660 VA: 0x182302060 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2301A30 Offset: 0x2300030 VA: 0x182301A30
	protected byte EncryptByte() { }

	// RVA: 0x2301970 Offset: 0x22FFF70 VA: 0x182301970
	protected void EncryptBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2301E50 Offset: 0x2300450 VA: 0x182301E50
	protected void UpdateKeys(byte ch) { }

}

