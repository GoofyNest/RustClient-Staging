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

	// RVA: 0x2301910 Offset: 0x22FFF10 VA: 0x182301910 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2301940 Offset: 0x22FFF40 VA: 0x182301940 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2301970 Offset: 0x22FFF70 VA: 0x182301970 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFE09E0 Offset: 0xFDEFE0 VA: 0x180FE09E0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x23019A0 Offset: 0x22FFFA0 VA: 0x1823019A0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2301470 Offset: 0x22FFA70 VA: 0x182301470 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x23014D0 Offset: 0x22FFAD0 VA: 0x1823014D0 Slot: 26
	public override void SetLength(long val) { }

	// RVA: 0x23013B0 Offset: 0x22FF9B0 VA: 0x1823013B0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2301410 Offset: 0x22FFA10 VA: 0x182301410 Slot: 27
	public override int Read(byte[] b, int off, int len) { }

	// RVA: 0x2300D60 Offset: 0x22FF360 VA: 0x182300D60 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2300DC0 Offset: 0x22FF3C0 VA: 0x182300DC0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2300E80 Offset: 0x22FF480 VA: 0x182300E80
	protected void Deflate() { }

	// RVA: 0x2301780 Offset: 0x22FFD80 VA: 0x182301780
	public void .ctor(Stream baseOutputStream, Deflater deflater, int bufsize) { }

	// RVA: 0x2301360 Offset: 0x22FF960 VA: 0x182301360 Slot: 18
	public override void Flush() { }

	// RVA: 0x2301160 Offset: 0x22FF760 VA: 0x182301160 Slot: 31
	public virtual void Finish() { }

	// RVA: 0x2300E20 Offset: 0x22FF420 VA: 0x182300E20 Slot: 16
	public override void Close() { }

	// RVA: 0x23016A0 Offset: 0x22FFCA0 VA: 0x1823016A0 Slot: 30
	public override void WriteByte(byte bval) { }

	// RVA: 0x2301740 Offset: 0x22FFD40 VA: 0x182301740 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2301110 Offset: 0x22FF710 VA: 0x182301110
	protected byte EncryptByte() { }

	// RVA: 0x2301050 Offset: 0x22FF650 VA: 0x182301050
	protected void EncryptBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2301530 Offset: 0x22FFB30 VA: 0x182301530
	protected void UpdateKeys(byte ch) { }

}

