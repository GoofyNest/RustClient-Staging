public class WebSocketConnection : IWebSocketConnection // TypeDefIndex: 6925
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ISocket <Socket>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private IHandler <Handler>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action <OnOpen>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action <OnClose>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action<string> <OnMessage>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BinaryDataHandler <OnBinary>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BinaryDataHandler <OnPing>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BinaryDataHandler <OnPong>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action<Exception> <OnError>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ISocket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Socket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IHandler get_Handler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Handler(IHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	public Action get_OnOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 4
	public void set_OnOpen(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 5
	public Action get_OnClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 6
	public void set_OnClose(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 7
	public Action<string> get_OnMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 8
	public void set_OnMessage(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 9
	public BinaryDataHandler get_OnBinary() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0 Slot: 18
	public void set_OnBinary(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 10
	public BinaryDataHandler get_OnPing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610 Slot: 19
	public void set_OnPing(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 11
	public BinaryDataHandler get_OnPong() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 20
	public void set_OnPong(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 21
	public Action<Exception> get_OnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	public void set_OnError(Action<Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 15
	public IWebSocketConnectionInfo get_ConnectionInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	private void set_ConnectionInfo(IWebSocketConnectionInfo value) { }

	// RVA: 0x220B520 Offset: 0x2209B20 VA: 0x18220B520 Slot: 16
	public bool get_IsAvailable() { }

	// RVA: 0x220AF90 Offset: 0x2209590 VA: 0x18220AF90
	public void .ctor(ISocket socket, Action<IWebSocketConnection> initialize, Func<ArraySegment<byte>, WebSocketHttpRequest> parseRequest, Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> handlerFactory) { }

	// RVA: 0x220ACE0 Offset: 0x22092E0 VA: 0x18220ACE0 Slot: 13
	public void Send(string message) { }

	// RVA: 0x220ABC0 Offset: 0x22091C0 VA: 0x18220ABC0
	private void SendImpl(MemoryBuffer buffer) { }

	// RVA: 0x2209DA0 Offset: 0x22083A0 VA: 0x182209DA0 Slot: 14
	public void Close() { }

	// RVA: 0x2209DB0 Offset: 0x22083B0 VA: 0x182209DB0
	public void Close(ushort code) { }

	// RVA: 0x2209FD0 Offset: 0x22085D0 VA: 0x182209FD0
	public bool CreateHandler(ArraySegment<byte> data) { }

	// RVA: 0x220AEB0 Offset: 0x22094B0 VA: 0x18220AEB0
	public void StartReceiving() { }

	// RVA: 0x220A710 Offset: 0x2208D10 VA: 0x18220A710
	private void HandleReadSuccess(int bytesRead) { }

	// RVA: 0x220A450 Offset: 0x2208A50 VA: 0x18220A450
	private void HandleReadError(Exception e) { }

	// RVA: 0x220A8E0 Offset: 0x2208EE0 VA: 0x18220A8E0
	private void Receive(byte[] buffer, int offset) { }

	// RVA: 0x220A880 Offset: 0x2208E80 VA: 0x18220A880
	private void HandleWriteError(Exception e) { }

	// RVA: 0x220AA70 Offset: 0x2209070 VA: 0x18220AA70
	private void SendBytes(MemoryBuffer bytes, Action<WebSocketConnection, bool> callback) { }

	// RVA: 0x2209CC0 Offset: 0x22082C0 VA: 0x182209CC0
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

	// RVA: 0x2209A80 Offset: 0x2208080 VA: 0x182209A80
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

	// RVA: 0x2208D60 Offset: 0x2207360 VA: 0x182208D60
	internal void <Close>b__58_0(WebSocketConnection i, bool s) { }

	// RVA: 0x2208D80 Offset: 0x2207380 VA: 0x182208D80
	internal void <CreateHandler>b__59_0(WebSocketConnection instance, bool success) { }

	// RVA: 0x2208E20 Offset: 0x2207420 VA: 0x182208E20
	internal void <Receive>b__63_0(IAsyncResult result) { }

}

private sealed class WebSocketConnection.<>c__DisplayClass65_0 // TypeDefIndex: 6927
{	// Fields
	public MemoryBuffer bytes; // 0x10
	public Action<WebSocketConnection, bool> callback; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209720 Offset: 0x2207D20 VA: 0x182209720
	internal void <SendBytes>b__0(IAsyncResult result) { }

}

