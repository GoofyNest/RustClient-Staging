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

	// RVA: 0x2312370 Offset: 0x2310970 VA: 0x182312370
	public void Start() { }

	// RVA: 0x2312330 Offset: 0x2310930 VA: 0x182312330
	public void Shutdown() { }

	// RVA: 0x2311D70 Offset: 0x2310370 VA: 0x182311D70
	public void BroadcastMessage(string str) { }

	// RVA: 0x2312180 Offset: 0x2310780 VA: 0x182312180
	public void SendMessage(int target, string str) { }

	// RVA: 0x23126E0 Offset: 0x2310CE0 VA: 0x1823126E0
	public void .ctor() { }

}

private sealed class Listener.<>c__DisplayClass10_0 // TypeDefIndex: 7339
{	// Fields
	public string requiredPath; // 0x10
	public Listener <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x23127F0 Offset: 0x2310DF0 VA: 0x1823127F0
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

	// RVA: 0x2312C90 Offset: 0x2311290 VA: 0x182312C90
	internal void <Start>b__1() { }

	// RVA: 0x2312DB0 Offset: 0x23113B0 VA: 0x182312DB0
	internal void <Start>b__2() { }

	// RVA: 0x2312ED0 Offset: 0x23114D0 VA: 0x182312ED0
	internal void <Start>b__3(string s) { }

}

private sealed class Listener.<>c // TypeDefIndex: 7341
{	// Fields
	public static readonly Listener.<>c <>9; // 0x0
	public static Action<Exception> <>9__10_4; // 0x8

	// Methods

	// RVA: 0x2312F50 Offset: 0x2311550 VA: 0x182312F50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2312780 Offset: 0x2310D80 VA: 0x182312780
	internal void <Start>b__10_4(Exception e) { }

}

