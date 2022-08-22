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

	// RVA: 0x12189F0 Offset: 0x1216FF0 VA: 0x1812189F0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 51
	public MonoTlsProvider get_Provider() { }

	// RVA: 0x12170A0 Offset: 0x12156A0 VA: 0x1812170A0
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x1217510 Offset: 0x1215B10 VA: 0x181217510
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x12173A0 Offset: 0x12159A0 VA: 0x1812173A0
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x1218620 Offset: 0x1216C20 VA: 0x181218620
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1216DD0 Offset: 0x12153D0 VA: 0x181216DD0 Slot: 32
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1216E20 Offset: 0x1215420 VA: 0x181216E20 Slot: 33
	public IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217350 Offset: 0x1215950 VA: 0x181217350 Slot: 34
	public void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 47
	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3670 Offset: 0xA2A70 VA: 0x1800A3670
	// RVA: 0x1217EB0 Offset: 0x12164B0 VA: 0x181217EB0
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert);

	// RVA: 0x1216ED0 Offset: 0x12154D0 VA: 0x181216ED0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217360 Offset: 0x1215960 VA: 0x181217360 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1216FB0 Offset: 0x12155B0 VA: 0x181216FB0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1217350 Offset: 0x1215950 VA: 0x181217350 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x12184E0 Offset: 0x1216AE0 VA: 0x1812184E0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x12188C0 Offset: 0x1216EC0 VA: 0x1812188C0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1218430 Offset: 0x1216A30 VA: 0x181218430 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1218810 Offset: 0x1216E10 VA: 0x181218810 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3730 Offset: 0xA2B30 VA: 0x1800A3730
	// RVA: 0x1218670 Offset: 0x1216C70 VA: 0x181218670
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x12178E0 Offset: 0x1215EE0 VA: 0x1812178E0
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1217AD0 Offset: 0x12160D0 VA: 0x181217AD0
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x1217DE0 Offset: 0x12163E0 VA: 0x181217DE0
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1217C20 Offset: 0x1216220 VA: 0x181217C20
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3840 Offset: 0xA2C40 VA: 0x1800A3840
	// RVA: 0x1217670 Offset: 0x1215C70 VA: 0x181217670
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3920 Offset: 0xA2D20 VA: 0x1800A3920
	// RVA: 0x12177B0 Offset: 0x1215DB0 VA: 0x1812177B0
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x1218010 Offset: 0x1216610 VA: 0x181218010
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0x12181F0 Offset: 0x12167F0 VA: 0x1812181F0
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x1218310 Offset: 0x1216910 VA: 0x181218310
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x1218D50 Offset: 0x1217350 VA: 0x181218D50 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1217180 Offset: 0x1215780 VA: 0x181217180 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA46E0 Offset: 0xBA2CE0 VA: 0x180BA46E0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1218C20 Offset: 0x1217220 VA: 0x181218C20 Slot: 50
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x12185D0 Offset: 0x1216BD0 VA: 0x1812185D0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA47A0 Offset: 0xBA2DA0 VA: 0x180BA47A0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1218B60 Offset: 0x1217160 VA: 0x181218B60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1218BB0 Offset: 0x12171B0 VA: 0x181218BB0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA4970 Offset: 0xBA2F70 VA: 0x180BA4970 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1218E70 Offset: 0x1217470 VA: 0x181218E70 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xE57B00 Offset: 0xE56100 VA: 0x180E57B00 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1218E40 Offset: 0x1217440 VA: 0x181218E40 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x12189B0 Offset: 0x1216FB0 VA: 0x1812189B0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12187C0 Offset: 0x1216DC0 VA: 0x1812187C0
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

	// RVA: 0x121E0C0 Offset: 0x121C6C0 VA: 0x18121E0C0
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

