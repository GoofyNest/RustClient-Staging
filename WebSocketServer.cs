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

	// RVA: 0x220C4A0 Offset: 0x220AAA0 VA: 0x18220C4A0
	public void .ctor(string location, bool supportDualStack = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public ISocket get_ListenerSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_ListenerSocket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_SupportDualStack() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public int get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1180 Offset: 0x8BF780 VA: 0x1808C1180
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
	// RVA: 0xC20D30 Offset: 0xC1F330 VA: 0x180C20D30
	public bool get_RestartAfterListenError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC20D40 Offset: 0xC1F340 VA: 0x180C20D40
	public void set_RestartAfterListenError(bool value) { }

	// RVA: 0x220C6A0 Offset: 0x220ACA0 VA: 0x18220C6A0
	public bool get_IsSecure() { }

	// RVA: 0x220B8F0 Offset: 0x2209EF0 VA: 0x18220B8F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x220BE40 Offset: 0x220A440 VA: 0x18220BE40
	private IPAddress ParseIPAddress(Uri uri) { }

	// RVA: 0x220BFB0 Offset: 0x220A5B0 VA: 0x18220BFB0 Slot: 5
	public void Start(Action<IWebSocketConnection> config) { }

	// RVA: 0x220B940 Offset: 0x2209F40 VA: 0x18220B940
	private void ListenForClients() { }

	// RVA: 0x220BA60 Offset: 0x220A060 VA: 0x18220BA60
	private void OnClientConnect(ISocket clientSocket) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220C2D0 Offset: 0x220A8D0 VA: 0x18220C2D0
	private void <ListenForClients>b__35_0(Exception e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220C430 Offset: 0x220AA30 VA: 0x18220C430
	private WebSocketHttpRequest <OnClientConnect>b__36_0(ArraySegment<byte> bytes) { }

}

private sealed class WebSocketServer.<>c // TypeDefIndex: 6932
{	// Fields
	public static readonly WebSocketServer.<>c <>9; // 0x0
	public static Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> <>9__36_1; // 0x8
	public static Action<Exception> <>9__36_2; // 0x10

	// Methods

	// RVA: 0x2209AC0 Offset: 0x22080C0 VA: 0x182209AC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2208EB0 Offset: 0x22074B0 VA: 0x182208EB0
	internal IHandler <OnClientConnect>b__36_1(IWebSocketConnection c, WebSocketHttpRequest r) { }

	// RVA: 0x2208EC0 Offset: 0x22074C0 VA: 0x182208EC0
	internal void <OnClientConnect>b__36_2(Exception e) { }

}

