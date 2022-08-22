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

	// RVA: 0x22075E0 Offset: 0x2205BE0 VA: 0x1822075E0
	public void .ctor(WebSocketHttpRequest request, IWebSocketConnection connection) { }

	// RVA: 0x2206120 Offset: 0x2204720 VA: 0x182206120 Slot: 8
	public void Dispose() { }

	// RVA: 0x22073C0 Offset: 0x22059C0 VA: 0x1822073C0 Slot: 4
	public void Receive(Span<byte> newData) { }

	// RVA: 0x2205DE0 Offset: 0x22043E0 VA: 0x182205DE0 Slot: 5
	public MemoryBuffer CreateHandshake() { }

	// RVA: 0x2206690 Offset: 0x2204C90 VA: 0x182206690 Slot: 6
	public MemoryBuffer FrameText(string text) { }

	// RVA: 0x22068F0 Offset: 0x2204EF0 VA: 0x1822068F0 Slot: 9
	public MemoryBuffer FrameText(MemoryBuffer utf8StringBytes) { }

	// RVA: 0x22061F0 Offset: 0x22047F0 VA: 0x1822061F0 Slot: 7
	public MemoryBuffer FrameClose(ushort code) { }

	// RVA: 0x2206590 Offset: 0x2204B90 VA: 0x182206590
	private static MemoryBuffer FrameData(MemoryBuffer payload, FrameType frameType) { }

	// RVA: 0x22063E0 Offset: 0x22049E0 VA: 0x1822063E0
	private static MemoryBuffer FrameData(Span<byte> payload, FrameType frameType) { }

	// RVA: 0x2206F30 Offset: 0x2205530 VA: 0x182206F30
	private void ReceiveData() { }

	// RVA: 0x2206AB0 Offset: 0x22050B0 VA: 0x182206AB0
	private void ProcessFrame(FrameType frameType, ArraySegment<byte> buffer) { }

	// RVA: 0x2205DD0 Offset: 0x22043D0 VA: 0x182205DD0
	private void Clear() { }

	// RVA: 0x2206040 Offset: 0x2204640 VA: 0x182206040
	internal static string CreateResponseKey(string requestKey) { }

	// RVA: 0x2206E60 Offset: 0x2205460 VA: 0x182206E60
	internal static string ReadUTF8PayloadData(ArraySegment<byte> bytes) { }

	// RVA: 0x22074B0 Offset: 0x2205AB0 VA: 0x1822074B0
	private static void .cctor() { }

}

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6936
{	// Fields
	public static readonly Hybi13Handler.<>c <>9; // 0x3903

	// Methods

	// RVA: 0x2209B20 Offset: 0x2208120 VA: 0x182209B20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209170 Offset: 0x2207770 VA: 0x182209170
	internal StringBuilder <.cctor>b__28_0() { }

}

