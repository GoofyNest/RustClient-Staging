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

	// RVA: 0x100BF70 Offset: 0x100A570 VA: 0x18100BF70
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x100B9B0 Offset: 0x1009FB0 VA: 0x18100B9B0
	private static MonoTlsProvider GetProvider() { }

	// RVA: 0x100BD90 Offset: 0x100A390 VA: 0x18100BD90
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x100BE30 Offset: 0x100A430 VA: 0x18100BE30
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x100B540 Offset: 0x1009B40 VA: 0x18100B540
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x100B1D0 Offset: 0x10097D0 VA: 0x18100B1D0 Slot: 32
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100B770 Offset: 0x1009D70 VA: 0x18100B770 Slot: 33
	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x100BFE0 Offset: 0x100A5E0 VA: 0x18100BFE0 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x100BED0 Offset: 0x100A4D0 VA: 0x18100BED0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x100BF20 Offset: 0x100A520 VA: 0x18100BF20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x100C190 Offset: 0x100A790 VA: 0x18100C190 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x100C220 Offset: 0x100A820 VA: 0x18100C220 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x100C070 Offset: 0x100A670 VA: 0x18100C070 Slot: 10
	public override long get_Length() { }

	// RVA: 0x100C100 Offset: 0x100A700 VA: 0x18100C100 Slot: 11
	public override long get_Position() { }

	// RVA: 0x100C2B0 Offset: 0x100A8B0 VA: 0x18100C2B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x100BB60 Offset: 0x100A160 VA: 0x18100BB60 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x100BAF0 Offset: 0x100A0F0 VA: 0x18100BAF0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4E70 Offset: 0xBA3470 VA: 0x180BA4E70 Slot: 18
	public override void Flush() { }

	// RVA: 0x100B4D0 Offset: 0x1009AD0 VA: 0x18100B4D0
	private void CheckDisposed() { }

	// RVA: 0x100B670 Offset: 0x1009C70 VA: 0x18100B670 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x100B9C0 Offset: 0x1009FC0 VA: 0x18100B9C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x100BC60 Offset: 0x100A260 VA: 0x18100BC60 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x100B310 Offset: 0x1009910 VA: 0x18100B310 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100B810 Offset: 0x1009E10 VA: 0x18100B810 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x100B3F0 Offset: 0x10099F0 VA: 0x18100B3F0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100B910 Offset: 0x1009F10 VA: 0x18100B910 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

}

