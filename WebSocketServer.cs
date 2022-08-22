public class WebSocketServer : IDisposable // TypeDefIndex: 6931
{	// Fields
	private readonly string _scheme; // 0x10
	private readonly IPAddress _locationIP; // 0x18
	private Action<IWebSocketConnection> _config; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ISocket <ListenerSocket>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <Location>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <SupportDualStack>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Port>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private X509Certificate2 <Certificate>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SslProtocols <EnabledSslProtocols>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <RestartAfterListenError>k__BackingField; // 0x4C

	// Properties
	public ISocket ListenerSocket { get; set; }
	public bool SupportDualStack { get; }
	public int Port { get; set; }
	public X509Certificate2 Certificate { get; set; }
	public SslProtocols EnabledSslProtocols { get; }
	public bool RestartAfterListenError { get; set; }
	public bool IsSecure { get; }

	// Methods

	// RVA: 0x220CCC0 Offset: 0x220B2C0 VA: 0x18220CCC0
	public void .ctor(string location, bool supportDualStack = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public ISocket get_ListenerSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_ListenerSocket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_SupportDualStack() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public int get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	private void set_Port(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public X509Certificate2 get_Certificate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_Certificate(X509Certificate2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public SslProtocols get_EnabledSslProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC21200 Offset: 0xC1F800 VA: 0x180C21200
	public bool get_RestartAfterListenError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC21210 Offset: 0xC1F810 VA: 0x180C21210
	public void set_RestartAfterListenError(bool value) { }

	// RVA: 0x220CEC0 Offset: 0x220B4C0 VA: 0x18220CEC0
	public bool get_IsSecure() { }

	// RVA: 0x220C110 Offset: 0x220A710 VA: 0x18220C110 Slot: 4
	public void Dispose() { }

	// RVA: 0x220C660 Offset: 0x220AC60 VA: 0x18220C660
	private IPAddress ParseIPAddress(Uri uri) { }

	// RVA: 0x220C7D0 Offset: 0x220ADD0 VA: 0x18220C7D0 Slot: 5
	public void Start(Action<IWebSocketConnection> config) { }

	// RVA: 0x220C160 Offset: 0x220A760 VA: 0x18220C160
	private void ListenForClients() { }

	// RVA: 0x220C280 Offset: 0x220A880 VA: 0x18220C280
	private void OnClientConnect(ISocket clientSocket) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220CAF0 Offset: 0x220B0F0 VA: 0x18220CAF0
	private void <ListenForClients>b__35_0(Exception e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220CC50 Offset: 0x220B250 VA: 0x18220CC50
	private WebSocketHttpRequest <OnClientConnect>b__36_0(ArraySegment<byte> bytes) { }

}

private sealed class WebSocketServer.<>c // TypeDefIndex: 6932
{	// Fields
	public static readonly WebSocketServer.<>c <>9; // 0x0
	public static Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> <>9__36_1; // 0x8
	public static Action<Exception> <>9__36_2; // 0x10

	// Methods

	// RVA: 0x220A2E0 Offset: 0x22088E0 VA: 0x18220A2E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22096D0 Offset: 0x2207CD0 VA: 0x1822096D0
	internal IHandler <OnClientConnect>b__36_1(IWebSocketConnection c, WebSocketHttpRequest r) { }

	// RVA: 0x22096E0 Offset: 0x2207CE0 VA: 0x1822096E0
	internal void <OnClientConnect>b__36_2(Exception e) { }

}

