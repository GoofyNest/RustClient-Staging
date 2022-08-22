internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IMonoSslStream, IDisposable // TypeDefIndex: 2544
{	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private static int uniqueNameInteger; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly SslStream <SslStream>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MonoTlsProvider <Provider>k__BackingField; // 0x90
	private static int nextId; // 0x4
	internal readonly int ID; // 0x98

	// Properties
	public MonoTlsSettings Settings { get; }
	public MonoTlsProvider Provider { get; }
	public AuthenticatedStream AuthenticatedStream { get; }
	public override bool IsAuthenticated { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }

	// Methods

	// RVA: 0x1219350 Offset: 0x1217950 VA: 0x181219350
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 51
	public MonoTlsProvider get_Provider() { }

	// RVA: 0x1217A00 Offset: 0x1216000 VA: 0x181217A00
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x1217E70 Offset: 0x1216470 VA: 0x181217E70
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x1217D00 Offset: 0x1216300 VA: 0x181217D00
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x1218F80 Offset: 0x1217580 VA: 0x181218F80
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1217730 Offset: 0x1215D30 VA: 0x181217730 Slot: 32
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1217780 Offset: 0x1215D80 VA: 0x181217780 Slot: 33
	public IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217CB0 Offset: 0x12162B0 VA: 0x181217CB0 Slot: 34
	public void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 47
	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3670 Offset: 0xA2A70 VA: 0x1800A3670
	// RVA: 0x1218810 Offset: 0x1216E10 VA: 0x181218810
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert);

	// RVA: 0x1217830 Offset: 0x1215E30 VA: 0x181217830 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217CC0 Offset: 0x12162C0 VA: 0x181217CC0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1217910 Offset: 0x1215F10 VA: 0x181217910 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217CB0 Offset: 0x12162B0 VA: 0x181217CB0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1218E40 Offset: 0x1217440 VA: 0x181218E40 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1219220 Offset: 0x1217820 VA: 0x181219220 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1218D90 Offset: 0x1217390 VA: 0x181218D90 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1219170 Offset: 0x1217770 VA: 0x181219170 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3730 Offset: 0xA2B30 VA: 0x1800A3730
	// RVA: 0x1218FD0 Offset: 0x12175D0 VA: 0x181218FD0
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x1218240 Offset: 0x1216840 VA: 0x181218240
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1218430 Offset: 0x1216A30 VA: 0x181218430
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x1218740 Offset: 0x1216D40 VA: 0x181218740
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1218580 Offset: 0x1216B80 VA: 0x181218580
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3840 Offset: 0xA2C40 VA: 0x1800A3840
	// RVA: 0x1217FD0 Offset: 0x12165D0 VA: 0x181217FD0
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3920 Offset: 0xA2D20 VA: 0x1800A3920
	// RVA: 0x1218110 Offset: 0x1216710 VA: 0x181218110
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x1218970 Offset: 0x1216F70 VA: 0x181218970
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0x1218B50 Offset: 0x1217150 VA: 0x181218B50
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x1218C70 Offset: 0x1217270 VA: 0x181218C70
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x12196B0 Offset: 0x1217CB0 VA: 0x1812196B0 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1217AE0 Offset: 0x12160E0 VA: 0x181217AE0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA4E70 Offset: 0xBA3470 VA: 0x180BA4E70 Slot: 18
	public override void Flush() { }

	// RVA: 0x1219580 Offset: 0x1217B80 VA: 0x181219580 Slot: 50
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x1218F30 Offset: 0x1217530 VA: 0x181218F30 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4F30 Offset: 0xBA3530 VA: 0x180BA4F30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x12194C0 Offset: 0x1217AC0 VA: 0x1812194C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1219510 Offset: 0x1217B10 VA: 0x181219510 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA5100 Offset: 0xBA3700 VA: 0x180BA5100 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA5130 Offset: 0xBA3730 VA: 0x180BA5130 Slot: 11
	public override long get_Position() { }

	// RVA: 0x12197D0 Offset: 0x1217DD0 VA: 0x1812197D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xE58870 Offset: 0xE56E70 VA: 0x180E58870 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x12197A0 Offset: 0x1217DA0 VA: 0x1812197A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x1219310 Offset: 0x1217910 VA: 0x181219310
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1219120 Offset: 0x1217720 VA: 0x181219120
	private void <InnerWrite>b__67_0() { }

}

private enum MobileAuthenticatedStream.OperationType // TypeDefIndex: 2545
{	// Fields
	public int value__; // 0x0
	public const MobileAuthenticatedStream.OperationType Read = 0;
	public const MobileAuthenticatedStream.OperationType Write = 1;
	public const MobileAuthenticatedStream.OperationType Shutdown = 2;

}

private struct MobileAuthenticatedStream.<ProcessAuthentication>d__47 : IAsyncStateMachine // TypeDefIndex: 2546
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public bool serverMode; // 0x20
	public X509Certificate serverCertificate; // 0x28
	public string targetHost; // 0x30
	public MobileAuthenticatedStream <>4__this; // 0x38
	public bool runSynchronously; // 0x40
	public SslProtocols enabledProtocols; // 0x44
	public X509CertificateCollection clientCertificates; // 0x48
	public bool clientCertRequired; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x58

	// Methods

	// RVA: 0x1D24F0 Offset: 0x1D18F0 VA: 0x1801D24F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct MobileAuthenticatedStream.<StartOperation>d__58 : IAsyncStateMachine // TypeDefIndex: 2547
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public MobileAuthenticatedStream.OperationType type; // 0x28
	public AsyncProtocolRequest asyncRequest; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x40

	// Methods

	// RVA: 0x1D2570 Offset: 0x1D1970 VA: 0x1801D2570 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D2580 Offset: 0x1D1980 VA: 0x1801D2580 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class MobileAuthenticatedStream.<>c__DisplayClass66_0 // TypeDefIndex: 2548
{	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121EA20 Offset: 0x121D020 VA: 0x18121EA20
	internal int <InnerRead>b__0() { }

}

private struct MobileAuthenticatedStream.<InnerRead>d__66 : IAsyncStateMachine // TypeDefIndex: 2549
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public int requestedSize; // 0x30
	public bool sync; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x1D2480 Offset: 0x1D1880 VA: 0x1801D2480 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D2490 Offset: 0x1D1890 VA: 0x1801D2490 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct MobileAuthenticatedStream.<InnerWrite>d__67 : IAsyncStateMachine // TypeDefIndex: 2550
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public MobileAuthenticatedStream <>4__this; // 0x28
	public bool sync; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1D24E0 Offset: 0x1D18E0 VA: 0x1801D24E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

