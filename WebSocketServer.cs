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

	// RVA: 0x220C1E0 Offset: 0x220A7E0 VA: 0x18220C1E0
	public void .ctor(string location, bool supportDualStack = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public ISocket get_ListenerSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_ListenerSocket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_SupportDualStack() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public int get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	private void set_Port(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public X509Certificate2 get_Certificate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Certificate(X509Certificate2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public SslProtocols get_EnabledSslProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC20A70 Offset: 0xC1F070 VA: 0x180C20A70
	public bool get_RestartAfterListenError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC20A80 Offset: 0xC1F080 VA: 0x180C20A80
	public void set_RestartAfterListenError(bool value) { }

	// RVA: 0x220C3E0 Offset: 0x220A9E0 VA: 0x18220C3E0
	public bool get_IsSecure() { }

	// RVA: 0x220B630 Offset: 0x2209C30 VA: 0x18220B630 Slot: 4
	public void Dispose() { }

	// RVA: 0x220BB80 Offset: 0x220A180 VA: 0x18220BB80
	private IPAddress ParseIPAddress(Uri uri) { }

	// RVA: 0x220BCF0 Offset: 0x220A2F0 VA: 0x18220BCF0 Slot: 5
	public void Start(Action<IWebSocketConnection> config) { }

	// RVA: 0x220B680 Offset: 0x2209C80 VA: 0x18220B680
	private void ListenForClients() { }

	// RVA: 0x220B7A0 Offset: 0x2209DA0 VA: 0x18220B7A0
	private void OnClientConnect(ISocket clientSocket) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220C010 Offset: 0x220A610 VA: 0x18220C010
	private void <ListenForClients>b__35_0(Exception e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220C170 Offset: 0x220A770 VA: 0x18220C170
	private WebSocketHttpRequest <OnClientConnect>b__36_0(ArraySegment<byte> bytes) { }

}

private sealed class WebSocketServer.<>c // TypeDefIndex: 6932
{	// Fields
	public static readonly WebSocketServer.<>c <>9; // 0x0
	public static Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> <>9__36_1; // 0x8
	public static Action<Exception> <>9__36_2; // 0x10

	// Methods

	// RVA: 0x2209800 Offset: 0x2207E00 VA: 0x182209800
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2208BF0 Offset: 0x22071F0 VA: 0x182208BF0
	internal IHandler <OnClientConnect>b__36_1(IWebSocketConnection c, WebSocketHttpRequest r) { }

	// RVA: 0x2208C00 Offset: 0x2207200 VA: 0x182208C00
	internal void <OnClientConnect>b__36_2(Exception e) { }

}

