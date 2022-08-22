public class Listener // TypeDefIndex: 7338
{
// Namespace: Facepunch.Rcon
public class Listener // TypeDefIndex: 7338
	// Fields
	public string Password; // 0x10
	public int Port; // 0x18
	public string Address; // 0x20
	public string SslCertificate; // 0x28
	public string SslCertificatePassword; // 0x30
	public Action<IPAddress, int, string> OnMessage; // 0x38
	private int nextClientId; // 0x40
	private readonly Dictionary<int, IWebSocketConnection> clients; // 0x48
	private readonly List<int> deadClients; // 0x50
	private WebSocketServer server; // 0x58

	// Methods

	// RVA: 0x2312470 Offset: 0x2310A70 VA: 0x182312470
	public void Start() { }

	// RVA: 0x2312430 Offset: 0x2310A30 VA: 0x182312430
	public void Shutdown() { }

	// RVA: 0x2311E70 Offset: 0x2310470 VA: 0x182311E70
	public void BroadcastMessage(string str) { }

	// RVA: 0x2312280 Offset: 0x2310880 VA: 0x182312280
	public void SendMessage(int target, string str) { }

	// RVA: 0x23127E0 Offset: 0x2310DE0 VA: 0x1823127E0
	public void .ctor() { }

}

private sealed class Listener.<>c__DisplayClass10_0 // TypeDefIndex: 7339
{	// Fields
	public string requiredPath; // 0x10
	public Listener <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x23128F0 Offset: 0x2310EF0 VA: 0x1823128F0
	internal void <Start>b__0(IWebSocketConnection socket) { }

}

private sealed class Listener.<>c__DisplayClass10_1 // TypeDefIndex: 7340
{	// Fields
	public int id; // 0x10
	public IWebSocketConnection socket; // 0x18
	public IPAddress ipAddress; // 0x20
	public Listener.<>c__DisplayClass10_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2312D90 Offset: 0x2311390 VA: 0x182312D90
	internal void <Start>b__1() { }

	// RVA: 0x2312EB0 Offset: 0x23114B0 VA: 0x182312EB0
	internal void <Start>b__2() { }

	// RVA: 0x2312FD0 Offset: 0x23115D0 VA: 0x182312FD0
	internal void <Start>b__3(string s) { }

}

private sealed class Listener.<>c // TypeDefIndex: 7341
{	// Fields
	public static readonly Listener.<>c <>9; // 0x0
	public static Action<Exception> <>9__10_4; // 0x8

	// Methods

	// RVA: 0x2313050 Offset: 0x2311650 VA: 0x182313050
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2312880 Offset: 0x2310E80 VA: 0x182312880
	internal void <Start>b__10_4(Exception e) { }

}

