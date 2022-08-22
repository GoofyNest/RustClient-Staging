internal class Hybi13Handler : IHandler, IDisposable // TypeDefIndex: 6935
{	// Fields
	private static readonly Encoding UTF8; // 0x0
	private static readonly SHA1 SHA1; // 0x8
	private static readonly ThreadLocal<StringBuilder> StringBuilder; // 0x10
	private readonly WebSocketHttpRequest _request; // 0x10
	private readonly IWebSocketConnection _connection; // 0x18
	private byte[] _data; // 0x20
	private int _dataLen; // 0x28
	private Nullable<FrameType> _frameType; // 0x2C
	private byte[] _message; // 0x30
	private int _messageLen; // 0x38

	// Methods

	// RVA: 0x2207320 Offset: 0x2205920 VA: 0x182207320
	public void .ctor(WebSocketHttpRequest request, IWebSocketConnection connection) { }

	// RVA: 0x2205E60 Offset: 0x2204460 VA: 0x182205E60 Slot: 8
	public void Dispose() { }

	// RVA: 0x2207100 Offset: 0x2205700 VA: 0x182207100 Slot: 4
	public void Receive(Span<byte> newData) { }

	// RVA: 0x2205B20 Offset: 0x2204120 VA: 0x182205B20 Slot: 5
	public MemoryBuffer CreateHandshake() { }

	// RVA: 0x22063D0 Offset: 0x22049D0 VA: 0x1822063D0 Slot: 6
	public MemoryBuffer FrameText(string text) { }

	// RVA: 0x2206630 Offset: 0x2204C30 VA: 0x182206630 Slot: 9
	public MemoryBuffer FrameText(MemoryBuffer utf8StringBytes) { }

	// RVA: 0x2205F30 Offset: 0x2204530 VA: 0x182205F30 Slot: 7
	public MemoryBuffer FrameClose(ushort code) { }

	// RVA: 0x22062D0 Offset: 0x22048D0 VA: 0x1822062D0
	private static MemoryBuffer FrameData(MemoryBuffer payload, FrameType frameType) { }

	// RVA: 0x2206120 Offset: 0x2204720 VA: 0x182206120
	private static MemoryBuffer FrameData(Span<byte> payload, FrameType frameType) { }

	// RVA: 0x2206C70 Offset: 0x2205270 VA: 0x182206C70
	private void ReceiveData() { }

	// RVA: 0x22067F0 Offset: 0x2204DF0 VA: 0x1822067F0
	private void ProcessFrame(FrameType frameType, ArraySegment<byte> buffer) { }

	// RVA: 0x2205B10 Offset: 0x2204110 VA: 0x182205B10
	private void Clear() { }

	// RVA: 0x2205D80 Offset: 0x2204380 VA: 0x182205D80
	internal static string CreateResponseKey(string requestKey) { }

	// RVA: 0x2206BA0 Offset: 0x22051A0 VA: 0x182206BA0
	internal static string ReadUTF8PayloadData(ArraySegment<byte> bytes) { }

	// RVA: 0x22071F0 Offset: 0x22057F0 VA: 0x1822071F0
	private static void .cctor() { }

}

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6936
{	// Fields
	public static readonly Hybi13Handler.<>c <>9; // 0x3903

	// Methods

	// RVA: 0x2209860 Offset: 0x2207E60 VA: 0x182209860
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2208EB0 Offset: 0x22074B0 VA: 0x182208EB0
	internal StringBuilder <.cctor>b__28_0() { }

}

