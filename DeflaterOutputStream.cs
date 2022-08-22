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

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150
	public bool get_IsStreamOwner() { }

	// RVA: 0x2301A10 Offset: 0x2300010 VA: 0x182301A10 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2301A40 Offset: 0x2300040 VA: 0x182301A40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2301A70 Offset: 0x2300070 VA: 0x182301A70 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFE0CA0 Offset: 0xFDF2A0 VA: 0x180FE0CA0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2301AA0 Offset: 0x23000A0 VA: 0x182301AA0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2301570 Offset: 0x22FFB70 VA: 0x182301570 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x23015D0 Offset: 0x22FFBD0 VA: 0x1823015D0 Slot: 26
	public override void SetLength(long val) { }

	// RVA: 0x23014B0 Offset: 0x22FFAB0 VA: 0x1823014B0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2301510 Offset: 0x22FFB10 VA: 0x182301510 Slot: 27
	public override int Read(byte[] b, int off, int len) { }

	// RVA: 0x2300E60 Offset: 0x22FF460 VA: 0x182300E60 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2300EC0 Offset: 0x22FF4C0 VA: 0x182300EC0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2300F80 Offset: 0x22FF580 VA: 0x182300F80
	protected void Deflate() { }

	// RVA: 0x2301880 Offset: 0x22FFE80 VA: 0x182301880
	public void .ctor(Stream baseOutputStream, Deflater deflater, int bufsize) { }

	// RVA: 0x2301460 Offset: 0x22FFA60 VA: 0x182301460 Slot: 18
	public override void Flush() { }

	// RVA: 0x2301260 Offset: 0x22FF860 VA: 0x182301260 Slot: 31
	public virtual void Finish() { }

	// RVA: 0x2300F20 Offset: 0x22FF520 VA: 0x182300F20 Slot: 16
	public override void Close() { }

	// RVA: 0x23017A0 Offset: 0x22FFDA0 VA: 0x1823017A0 Slot: 30
	public override void WriteByte(byte bval) { }

	// RVA: 0x2301840 Offset: 0x22FFE40 VA: 0x182301840 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2301210 Offset: 0x22FF810 VA: 0x182301210
	protected byte EncryptByte() { }

	// RVA: 0x2301150 Offset: 0x22FF750 VA: 0x182301150
	protected void EncryptBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2301630 Offset: 0x22FFC30 VA: 0x182301630
	protected void UpdateKeys(byte ch) { }

}

