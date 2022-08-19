public class SslStream : AuthenticatedStream // TypeDefIndex: 3072
{	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x100B210 Offset: 0x1009810 VA: 0x18100B210
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x100AC50 Offset: 0x1009250 VA: 0x18100AC50
	private static MonoTlsProvider GetProvider() { }

	// RVA: 0x100B030 Offset: 0x1009630 VA: 0x18100B030
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x100B0D0 Offset: 0x10096D0 VA: 0x18100B0D0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x100A7E0 Offset: 0x1008DE0 VA: 0x18100A7E0
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x100A470 Offset: 0x1008A70 VA: 0x18100A470 Slot: 32
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100AA10 Offset: 0x1009010 VA: 0x18100AA10 Slot: 33
	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x100B280 Offset: 0x1009880 VA: 0x18100B280 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x100B170 Offset: 0x1009770 VA: 0x18100B170 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x100B1C0 Offset: 0x10097C0 VA: 0x18100B1C0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x100B430 Offset: 0x1009A30 VA: 0x18100B430 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x100B4C0 Offset: 0x1009AC0 VA: 0x18100B4C0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x100B310 Offset: 0x1009910 VA: 0x18100B310 Slot: 10
	public override long get_Length() { }

	// RVA: 0x100B3A0 Offset: 0x10099A0 VA: 0x18100B3A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x100B550 Offset: 0x1009B50 VA: 0x18100B550 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x100AE00 Offset: 0x1009400 VA: 0x18100AE00 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x100AD90 Offset: 0x1009390 VA: 0x18100AD90 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA46E0 Offset: 0xBA2CE0 VA: 0x180BA46E0 Slot: 18
	public override void Flush() { }

	// RVA: 0x100A770 Offset: 0x1008D70 VA: 0x18100A770
	private void CheckDisposed() { }

	// RVA: 0x100A910 Offset: 0x1008F10 VA: 0x18100A910 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x100AC60 Offset: 0x1009260 VA: 0x18100AC60 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x100AF00 Offset: 0x1009500 VA: 0x18100AF00 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x100A5B0 Offset: 0x1008BB0 VA: 0x18100A5B0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100AAB0 Offset: 0x10090B0 VA: 0x18100AAB0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x100A690 Offset: 0x1008C90 VA: 0x18100A690 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100ABB0 Offset: 0x10091B0 VA: 0x18100ABB0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

}

