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

	// RVA: 0x1218CB0 Offset: 0x12172B0 VA: 0x181218CB0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 51
	public MonoTlsProvider get_Provider() { }

	// RVA: 0x1217360 Offset: 0x1215960 VA: 0x181217360
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x12177D0 Offset: 0x1215DD0 VA: 0x1812177D0
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x1217660 Offset: 0x1215C60 VA: 0x181217660
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x12188E0 Offset: 0x1216EE0 VA: 0x1812188E0
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1217090 Offset: 0x1215690 VA: 0x181217090 Slot: 32
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x12170E0 Offset: 0x12156E0 VA: 0x1812170E0 Slot: 33
	public IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217610 Offset: 0x1215C10 VA: 0x181217610 Slot: 34
	public void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 47
	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3670 Offset: 0xA2A70 VA: 0x1800A3670
	// RVA: 0x1218170 Offset: 0x1216770 VA: 0x181218170
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert);

	// RVA: 0x1217190 Offset: 0x1215790 VA: 0x181217190 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217620 Offset: 0x1215C20 VA: 0x181217620 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1217270 Offset: 0x1215870 VA: 0x181217270 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217610 Offset: 0x1215C10 VA: 0x181217610 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x12187A0 Offset: 0x1216DA0 VA: 0x1812187A0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1218B80 Offset: 0x1217180 VA: 0x181218B80 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x12186F0 Offset: 0x1216CF0 VA: 0x1812186F0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1218AD0 Offset: 0x12170D0 VA: 0x181218AD0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3730 Offset: 0xA2B30 VA: 0x1800A3730
	// RVA: 0x1218930 Offset: 0x1216F30 VA: 0x181218930
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x1217BA0 Offset: 0x12161A0 VA: 0x181217BA0
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1217D90 Offset: 0x1216390 VA: 0x181217D90
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x12180A0 Offset: 0x12166A0 VA: 0x1812180A0
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1217EE0 Offset: 0x12164E0 VA: 0x181217EE0
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3840 Offset: 0xA2C40 VA: 0x1800A3840
	// RVA: 0x1217930 Offset: 0x1215F30 VA: 0x181217930
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3920 Offset: 0xA2D20 VA: 0x1800A3920
	// RVA: 0x1217A70 Offset: 0x1216070 VA: 0x181217A70
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x12182D0 Offset: 0x12168D0 VA: 0x1812182D0
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0x12184B0 Offset: 0x1216AB0 VA: 0x1812184B0
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x12185D0 Offset: 0x1216BD0 VA: 0x1812185D0
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x1219010 Offset: 0x1217610 VA: 0x181219010 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1217440 Offset: 0x1215A40 VA: 0x181217440 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1218EE0 Offset: 0x12174E0 VA: 0x181218EE0 Slot: 50
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x1218890 Offset: 0x1216E90 VA: 0x181218890 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4A60 Offset: 0xBA3060 VA: 0x180BA4A60 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1218E20 Offset: 0x1217420 VA: 0x181218E20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1218E70 Offset: 0x1217470 VA: 0x181218E70 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA4C30 Offset: 0xBA3230 VA: 0x180BA4C30 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA4C60 Offset: 0xBA3260 VA: 0x180BA4C60 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1219130 Offset: 0x1217730 VA: 0x181219130 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xE57DC0 Offset: 0xE563C0 VA: 0x180E57DC0 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1219100 Offset: 0x1217700 VA: 0x181219100 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x1218C70 Offset: 0x1217270 VA: 0x181218C70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1218A80 Offset: 0x1217080 VA: 0x181218A80
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

	// RVA: 0x1D1E80 Offset: 0x1D1280 VA: 0x1801D1E80 Slot: 4
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

	// RVA: 0x1D1F00 Offset: 0x1D1300 VA: 0x1801D1F00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D1F10 Offset: 0x1D1310 VA: 0x1801D1F10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class MobileAuthenticatedStream.<>c__DisplayClass66_0 // TypeDefIndex: 2548
{	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x121E380 Offset: 0x121C980 VA: 0x18121E380
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

	// RVA: 0x1D1E10 Offset: 0x1D1210 VA: 0x1801D1E10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D1E20 Offset: 0x1D1220 VA: 0x1801D1E20 Slot: 5
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

	// RVA: 0x1D1E70 Offset: 0x1D1270 VA: 0x1801D1E70 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

