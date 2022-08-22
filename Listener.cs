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

	// RVA: 0x23121B0 Offset: 0x23107B0 VA: 0x1823121B0
	public void Start() { }

	// RVA: 0x2312170 Offset: 0x2310770 VA: 0x182312170
	public void Shutdown() { }

	// RVA: 0x2311BB0 Offset: 0x23101B0 VA: 0x182311BB0
	public void BroadcastMessage(string str) { }

	// RVA: 0x2311FC0 Offset: 0x23105C0 VA: 0x182311FC0
	public void SendMessage(int target, string str) { }

	// RVA: 0x2312520 Offset: 0x2310B20 VA: 0x182312520
	public void .ctor() { }

}

private sealed class Listener.<>c__DisplayClass10_0 // TypeDefIndex: 7339
{	// Fields
	public string requiredPath; // 0x10
	public Listener <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2312630 Offset: 0x2310C30 VA: 0x182312630
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

	// RVA: 0x2312AD0 Offset: 0x23110D0 VA: 0x182312AD0
	internal void <Start>b__1() { }

	// RVA: 0x2312BF0 Offset: 0x23111F0 VA: 0x182312BF0
	internal void <Start>b__2() { }

	// RVA: 0x2312D10 Offset: 0x2311310 VA: 0x182312D10
	internal void <Start>b__3(string s) { }

}

private sealed class Listener.<>c // TypeDefIndex: 7341
{	// Fields
	public static readonly Listener.<>c <>9; // 0x0
	public static Action<Exception> <>9__10_4; // 0x8

	// Methods

	// RVA: 0x2312D90 Offset: 0x2311390 VA: 0x182312D90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x23125C0 Offset: 0x2310BC0 VA: 0x1823125C0
	internal void <Start>b__10_4(Exception e) { }

}

