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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public ISocket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Socket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IHandler get_Handler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Handler(IHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	public Action get_OnOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 4
	public void set_OnOpen(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 5
	public Action get_OnClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0 Slot: 6
	public void set_OnClose(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 7
	public Action<string> get_OnMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010 Slot: 8
	public void set_OnMessage(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 9
	public BinaryDataHandler get_OnBinary() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650 Slot: 18
	public void set_OnBinary(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 10
	public BinaryDataHandler get_OnPing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0 Slot: 19
	public void set_OnPing(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 11
	public BinaryDataHandler get_OnPong() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 20
	public void set_OnPong(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 21
	public Action<Exception> get_OnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 12
	public void set_OnError(Action<Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 15
	public IWebSocketConnectionInfo get_ConnectionInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	private void set_ConnectionInfo(IWebSocketConnectionInfo value) { }

	// RVA: 0x220BE40 Offset: 0x220A440 VA: 0x18220BE40 Slot: 16
	public bool get_IsAvailable() { }

	// RVA: 0x220B8B0 Offset: 0x2209EB0 VA: 0x18220B8B0
	public void .ctor(ISocket socket, Action<IWebSocketConnection> initialize, Func<ArraySegment<byte>, WebSocketHttpRequest> parseRequest, Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> handlerFactory) { }

	// RVA: 0x220B600 Offset: 0x2209C00 VA: 0x18220B600 Slot: 13
	public void Send(string message) { }

	// RVA: 0x220B4E0 Offset: 0x2209AE0 VA: 0x18220B4E0
	private void SendImpl(MemoryBuffer buffer) { }

	// RVA: 0x220A6C0 Offset: 0x2208CC0 VA: 0x18220A6C0 Slot: 14
	public void Close() { }

	// RVA: 0x220A6D0 Offset: 0x2208CD0 VA: 0x18220A6D0
	public void Close(ushort code) { }

	// RVA: 0x220A8F0 Offset: 0x2208EF0 VA: 0x18220A8F0
	public bool CreateHandler(ArraySegment<byte> data) { }

	// RVA: 0x220B7D0 Offset: 0x2209DD0 VA: 0x18220B7D0
	public void StartReceiving() { }

	// RVA: 0x220B030 Offset: 0x2209630 VA: 0x18220B030
	private void HandleReadSuccess(int bytesRead) { }

	// RVA: 0x220AD70 Offset: 0x2209370 VA: 0x18220AD70
	private void HandleReadError(Exception e) { }

	// RVA: 0x220B200 Offset: 0x2209800 VA: 0x18220B200
	private void Receive(byte[] buffer, int offset) { }

	// RVA: 0x220B1A0 Offset: 0x22097A0 VA: 0x18220B1A0
	private void HandleWriteError(Exception e) { }

	// RVA: 0x220B390 Offset: 0x2209990 VA: 0x18220B390
	private void SendBytes(MemoryBuffer bytes, Action<WebSocketConnection, bool> callback) { }

	// RVA: 0x220A5E0 Offset: 0x2208BE0 VA: 0x18220A5E0
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

	// RVA: 0x220A3A0 Offset: 0x22089A0 VA: 0x18220A3A0
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

	// RVA: 0x2209680 Offset: 0x2207C80 VA: 0x182209680
	internal void <Close>b__58_0(WebSocketConnection i, bool s) { }

	// RVA: 0x22096A0 Offset: 0x2207CA0 VA: 0x1822096A0
	internal void <CreateHandler>b__59_0(WebSocketConnection instance, bool success) { }

	// RVA: 0x2209740 Offset: 0x2207D40 VA: 0x182209740
	internal void <Receive>b__63_0(IAsyncResult result) { }

}

private sealed class WebSocketConnection.<>c__DisplayClass65_0 // TypeDefIndex: 6927
{	// Fields
	public MemoryBuffer bytes; // 0x10
	public Action<WebSocketConnection, bool> callback; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x220A040 Offset: 0x2208640 VA: 0x18220A040
	internal void <SendBytes>b__0(IAsyncResult result) { }

}

