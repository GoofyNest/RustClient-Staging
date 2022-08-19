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

	// RVA: 0x22074E0 Offset: 0x2205AE0 VA: 0x1822074E0
	public void .ctor(WebSocketHttpRequest request, IWebSocketConnection connection) { }

	// RVA: 0x2206020 Offset: 0x2204620 VA: 0x182206020 Slot: 8
	public void Dispose() { }

	// RVA: 0x22072C0 Offset: 0x22058C0 VA: 0x1822072C0 Slot: 4
	public void Receive(Span<byte> newData) { }

	// RVA: 0x2205CE0 Offset: 0x22042E0 VA: 0x182205CE0 Slot: 5
	public MemoryBuffer CreateHandshake() { }

	// RVA: 0x2206590 Offset: 0x2204B90 VA: 0x182206590 Slot: 6
	public MemoryBuffer FrameText(string text) { }

	// RVA: 0x22067F0 Offset: 0x2204DF0 VA: 0x1822067F0 Slot: 9
	public MemoryBuffer FrameText(MemoryBuffer utf8StringBytes) { }

	// RVA: 0x22060F0 Offset: 0x22046F0 VA: 0x1822060F0 Slot: 7
	public MemoryBuffer FrameClose(ushort code) { }

	// RVA: 0x2206490 Offset: 0x2204A90 VA: 0x182206490
	private static MemoryBuffer FrameData(MemoryBuffer payload, FrameType frameType) { }

	// RVA: 0x22062E0 Offset: 0x22048E0 VA: 0x1822062E0
	private static MemoryBuffer FrameData(Span<byte> payload, FrameType frameType) { }

	// RVA: 0x2206E30 Offset: 0x2205430 VA: 0x182206E30
	private void ReceiveData() { }

	// RVA: 0x22069B0 Offset: 0x2204FB0 VA: 0x1822069B0
	private void ProcessFrame(FrameType frameType, ArraySegment<byte> buffer) { }

	// RVA: 0x2205CD0 Offset: 0x22042D0 VA: 0x182205CD0
	private void Clear() { }

	// RVA: 0x2205F40 Offset: 0x2204540 VA: 0x182205F40
	internal static string CreateResponseKey(string requestKey) { }

	// RVA: 0x2206D60 Offset: 0x2205360 VA: 0x182206D60
	internal static string ReadUTF8PayloadData(ArraySegment<byte> bytes) { }

	// RVA: 0x22073B0 Offset: 0x22059B0 VA: 0x1822073B0
	private static void .cctor() { }

}

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6936
{	// Fields
	public static readonly Hybi13Handler.<>c <>9; // 0x3903

	// Methods

	// RVA: 0x2209A20 Offset: 0x2208020 VA: 0x182209A20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209070 Offset: 0x2207670 VA: 0x182209070
	internal StringBuilder <.cctor>b__28_0() { }

}

