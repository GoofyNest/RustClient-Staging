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

	// RVA: 0x100B4D0 Offset: 0x1009AD0 VA: 0x18100B4D0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x100AF10 Offset: 0x1009510 VA: 0x18100AF10
	private static MonoTlsProvider GetProvider() { }

	// RVA: 0x100B2F0 Offset: 0x10098F0 VA: 0x18100B2F0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x100B390 Offset: 0x1009990 VA: 0x18100B390
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x100AAA0 Offset: 0x10090A0 VA: 0x18100AAA0
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x100A730 Offset: 0x1008D30 VA: 0x18100A730 Slot: 32
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100ACD0 Offset: 0x10092D0 VA: 0x18100ACD0 Slot: 33
	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x100B540 Offset: 0x1009B40 VA: 0x18100B540 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x100B430 Offset: 0x1009A30 VA: 0x18100B430 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x100B480 Offset: 0x1009A80 VA: 0x18100B480 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x100B6F0 Offset: 0x1009CF0 VA: 0x18100B6F0 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x100B780 Offset: 0x1009D80 VA: 0x18100B780 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x100B5D0 Offset: 0x1009BD0 VA: 0x18100B5D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x100B660 Offset: 0x1009C60 VA: 0x18100B660 Slot: 11
	public override long get_Position() { }

	// RVA: 0x100B810 Offset: 0x1009E10 VA: 0x18100B810 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x100B0C0 Offset: 0x10096C0 VA: 0x18100B0C0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x100B050 Offset: 0x1009650 VA: 0x18100B050 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x100AA30 Offset: 0x1009030 VA: 0x18100AA30
	private void CheckDisposed() { }

	// RVA: 0x100ABD0 Offset: 0x10091D0 VA: 0x18100ABD0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x100AF20 Offset: 0x1009520 VA: 0x18100AF20 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x100B1C0 Offset: 0x10097C0 VA: 0x18100B1C0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x100A870 Offset: 0x1008E70 VA: 0x18100A870 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100AD70 Offset: 0x1009370 VA: 0x18100AD70 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x100A950 Offset: 0x1008F50 VA: 0x18100A950 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x100AE70 Offset: 0x1009470 VA: 0x18100AE70 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

}

