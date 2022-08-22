public class WebSocketConnection : IWebSocketConnection // TypeDefIndex: 6925
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ISocket <Socket>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IHandler <Handler>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action <OnOpen>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action <OnClose>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<string> <OnMessage>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BinaryDataHandler <OnBinary>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BinaryDataHandler <OnPing>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BinaryDataHandler <OnPong>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<Exception> <OnError>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IWebSocketConnectionInfo <ConnectionInfo>k__BackingField; // 0x58
	private readonly Action<IWebSocketConnection> _initialize; // 0x60
	private readonly Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> _handlerFactory; // 0x68
	private readonly Func<ArraySegment<byte>, WebSocketHttpRequest> _parseRequest; // 0x70
	private byte[] _receiveBuffer; // 0x78
	private int _receiveOffset; // 0x80
	private bool _closing; // 0x84
	private bool _closed; // 0x85

	// Properties
	public ISocket Socket { get; set; }
	public IHandler Handler { get; set; }
	public Action OnOpen { get; set; }
	public Action OnClose { get; set; }
	public Action<string> OnMessage { get; set; }
	public BinaryDataHandler OnBinary { get; set; }
	public BinaryDataHandler OnPing { get; set; }
	public BinaryDataHandler OnPong { get; set; }
	public Action<Exception> OnError { get; set; }
	public IWebSocketConnectionInfo ConnectionInfo { get; set; }
	public bool IsAvailable { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ISocket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Socket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IHandler get_Handler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Handler(IHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	public Action get_OnOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 4
	public void set_OnOpen(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 5
	public Action get_OnClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 6
	public void set_OnClose(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 7
	public Action<string> get_OnMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 8
	public void set_OnMessage(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 9
	public BinaryDataHandler get_OnBinary() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0 Slot: 18
	public void set_OnBinary(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 10
	public BinaryDataHandler get_OnPing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610 Slot: 19
	public void set_OnPing(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 11
	public BinaryDataHandler get_OnPong() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 20
	public void set_OnPong(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 21
	public Action<Exception> get_OnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	public void set_OnError(Action<Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 15
	public IWebSocketConnectionInfo get_ConnectionInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	private void set_ConnectionInfo(IWebSocketConnectionInfo value) { }

	// RVA: 0x220B360 Offset: 0x2209960 VA: 0x18220B360 Slot: 16
	public bool get_IsAvailable() { }

	// RVA: 0x220ADD0 Offset: 0x22093D0 VA: 0x18220ADD0
	public void .ctor(ISocket socket, Action<IWebSocketConnection> initialize, Func<ArraySegment<byte>, WebSocketHttpRequest> parseRequest, Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> handlerFactory) { }

	// RVA: 0x220AB20 Offset: 0x2209120 VA: 0x18220AB20 Slot: 13
	public void Send(string message) { }

	// RVA: 0x220AA00 Offset: 0x2209000 VA: 0x18220AA00
	private void SendImpl(MemoryBuffer buffer) { }

	// RVA: 0x2209BE0 Offset: 0x22081E0 VA: 0x182209BE0 Slot: 14
	public void Close() { }

	// RVA: 0x2209BF0 Offset: 0x22081F0 VA: 0x182209BF0
	public void Close(ushort code) { }

	// RVA: 0x2209E10 Offset: 0x2208410 VA: 0x182209E10
	public bool CreateHandler(ArraySegment<byte> data) { }

	// RVA: 0x220ACF0 Offset: 0x22092F0 VA: 0x18220ACF0
	public void StartReceiving() { }

	// RVA: 0x220A550 Offset: 0x2208B50 VA: 0x18220A550
	private void HandleReadSuccess(int bytesRead) { }

	// RVA: 0x220A290 Offset: 0x2208890 VA: 0x18220A290
	private void HandleReadError(Exception e) { }

	// RVA: 0x220A720 Offset: 0x2208D20 VA: 0x18220A720
	private void Receive(byte[] buffer, int offset) { }

	// RVA: 0x220A6C0 Offset: 0x2208CC0 VA: 0x18220A6C0
	private void HandleWriteError(Exception e) { }

	// RVA: 0x220A8B0 Offset: 0x2208EB0 VA: 0x18220A8B0
	private void SendBytes(MemoryBuffer bytes, Action<WebSocketConnection, bool> callback) { }

	// RVA: 0x2209B00 Offset: 0x2208100 VA: 0x182209B00
	private void CloseSocket() { }

}

private sealed class WebSocketConnection.<>c // TypeDefIndex: 6926
{	// Fields
	public static readonly WebSocketConnection.<>c <>9; // 0x0
	public static Action <>9__50_0; // 0x8
	public static Action <>9__50_1; // 0x10
	public static Action<string> <>9__50_2; // 0x18
	public static BinaryDataHandler <>9__50_3; // 0x20
	public static BinaryDataHandler <>9__50_4; // 0x28
	public static BinaryDataHandler <>9__50_5; // 0x30
	public static Action<Exception> <>9__50_6; // 0x38
	public static Action<WebSocketConnection, bool> <>9__58_0; // 0x40
	public static Action<WebSocketConnection, bool> <>9__59_0; // 0x48
	public static AsyncCallback <>9__63_0; // 0x50

	// Methods

	// RVA: 0x22098C0 Offset: 0x2207EC0 VA: 0x1822098C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_0() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_1() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_2(string x) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_3(Span<byte> x) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_4(Span<byte> x) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_5(Span<byte> x) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__50_6(Exception x) { }

	// RVA: 0x2208BA0 Offset: 0x22071A0 VA: 0x182208BA0
	internal void <Close>b__58_0(WebSocketConnection i, bool s) { }

	// RVA: 0x2208BC0 Offset: 0x22071C0 VA: 0x182208BC0
	internal void <CreateHandler>b__59_0(WebSocketConnection instance, bool success) { }

	// RVA: 0x2208C60 Offset: 0x2207260 VA: 0x182208C60
	internal void <Receive>b__63_0(IAsyncResult result) { }

}

private sealed class WebSocketConnection.<>c__DisplayClass65_0 // TypeDefIndex: 6927
{	// Fields
	public MemoryBuffer bytes; // 0x10
	public Action<WebSocketConnection, bool> callback; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209560 Offset: 0x2207B60 VA: 0x182209560
	internal void <SendBytes>b__0(IAsyncResult result) { }

}

