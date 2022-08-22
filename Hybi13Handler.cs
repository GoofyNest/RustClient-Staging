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

	// RVA: 0x2207E00 Offset: 0x2206400 VA: 0x182207E00
	public void .ctor(WebSocketHttpRequest request, IWebSocketConnection connection) { }

	// RVA: 0x2206940 Offset: 0x2204F40 VA: 0x182206940 Slot: 8
	public void Dispose() { }

	// RVA: 0x2207BE0 Offset: 0x22061E0 VA: 0x182207BE0 Slot: 4
	public void Receive(Span<byte> newData) { }

	// RVA: 0x2206600 Offset: 0x2204C00 VA: 0x182206600 Slot: 5
	public MemoryBuffer CreateHandshake() { }

	// RVA: 0x2206EB0 Offset: 0x22054B0 VA: 0x182206EB0 Slot: 6
	public MemoryBuffer FrameText(string text) { }

	// RVA: 0x2207110 Offset: 0x2205710 VA: 0x182207110 Slot: 9
	public MemoryBuffer FrameText(MemoryBuffer utf8StringBytes) { }

	// RVA: 0x2206A10 Offset: 0x2205010 VA: 0x182206A10 Slot: 7
	public MemoryBuffer FrameClose(ushort code) { }

	// RVA: 0x2206DB0 Offset: 0x22053B0 VA: 0x182206DB0
	private static MemoryBuffer FrameData(MemoryBuffer payload, FrameType frameType) { }

	// RVA: 0x2206C00 Offset: 0x2205200 VA: 0x182206C00
	private static MemoryBuffer FrameData(Span<byte> payload, FrameType frameType) { }

	// RVA: 0x2207750 Offset: 0x2205D50 VA: 0x182207750
	private void ReceiveData() { }

	// RVA: 0x22072D0 Offset: 0x22058D0 VA: 0x1822072D0
	private void ProcessFrame(FrameType frameType, ArraySegment<byte> buffer) { }

	// RVA: 0x22065F0 Offset: 0x2204BF0 VA: 0x1822065F0
	private void Clear() { }

	// RVA: 0x2206860 Offset: 0x2204E60 VA: 0x182206860
	internal static string CreateResponseKey(string requestKey) { }

	// RVA: 0x2207680 Offset: 0x2205C80 VA: 0x182207680
	internal static string ReadUTF8PayloadData(ArraySegment<byte> bytes) { }

	// RVA: 0x2207CD0 Offset: 0x22062D0 VA: 0x182207CD0
	private static void .cctor() { }

}

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6936
{	// Fields
	public static readonly Hybi13Handler.<>c <>9; // 0x36F0

	// Methods

	// RVA: 0x220A340 Offset: 0x2208940 VA: 0x18220A340
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209990 Offset: 0x2207F90 VA: 0x182209990
	internal StringBuilder <.cctor>b__28_0() { }

}

