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

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90
	public bool get_IsStreamOwner() { }

	// RVA: 0x2301750 Offset: 0x22FFD50 VA: 0x182301750 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2301780 Offset: 0x22FFD80 VA: 0x182301780 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x23017B0 Offset: 0x22FFDB0 VA: 0x1823017B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFE09E0 Offset: 0xFDEFE0 VA: 0x180FE09E0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x23017E0 Offset: 0x22FFDE0 VA: 0x1823017E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x23012B0 Offset: 0x22FF8B0 VA: 0x1823012B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2301310 Offset: 0x22FF910 VA: 0x182301310 Slot: 26
	public override void SetLength(long val) { }

	// RVA: 0x23011F0 Offset: 0x22FF7F0 VA: 0x1823011F0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2301250 Offset: 0x22FF850 VA: 0x182301250 Slot: 27
	public override int Read(byte[] b, int off, int len) { }

	// RVA: 0x2300BA0 Offset: 0x22FF1A0 VA: 0x182300BA0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2300C00 Offset: 0x22FF200 VA: 0x182300C00 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2300CC0 Offset: 0x22FF2C0 VA: 0x182300CC0
	protected void Deflate() { }

	// RVA: 0x23015C0 Offset: 0x22FFBC0 VA: 0x1823015C0
	public void .ctor(Stream baseOutputStream, Deflater deflater, int bufsize) { }

	// RVA: 0x23011A0 Offset: 0x22FF7A0 VA: 0x1823011A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x2300FA0 Offset: 0x22FF5A0 VA: 0x182300FA0 Slot: 31
	public virtual void Finish() { }

	// RVA: 0x2300C60 Offset: 0x22FF260 VA: 0x182300C60 Slot: 16
	public override void Close() { }

	// RVA: 0x23014E0 Offset: 0x22FFAE0 VA: 0x1823014E0 Slot: 30
	public override void WriteByte(byte bval) { }

	// RVA: 0x2301580 Offset: 0x22FFB80 VA: 0x182301580 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2300F50 Offset: 0x22FF550 VA: 0x182300F50
	protected byte EncryptByte() { }

	// RVA: 0x2300E90 Offset: 0x22FF490 VA: 0x182300E90
	protected void EncryptBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2301370 Offset: 0x22FF970 VA: 0x182301370
	protected void UpdateKeys(byte ch) { }

}

