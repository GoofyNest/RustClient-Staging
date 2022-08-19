public class RCon // TypeDefIndex: 11990
{	// Fields
	public static string Password; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int Port; // 0x8
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string Ip; // 0x10
	[ServerVar] // RVA: 0xCA9E0 Offset: 0xC9DE0 VA: 0x1800CA9E0
	public static bool Web; // 0x18
	[ServerVar] // RVA: 0xCAC30 Offset: 0xCA030 VA: 0x1800CAC30
	public static bool Print; // 0x19
	internal static RCon.RConListener listener; // 0x20
	internal static Listener listenerNew; // 0x28
	private static Queue<RCon.Command> Commands; // 0x30
	private static float lastRunTime; // 0x38
	internal static List<RCon.BannedAddresses> bannedAddresses; // 0x40
	private static int responseIdentifier; // 0x48
	private static int responseConnection; // 0x4C
	private static bool isInput; // 0x50
	internal static int SERVERDATA_AUTH; // 0x54
	internal static int SERVERDATA_EXECCOMMAND; // 0x58
	internal static int SERVERDATA_AUTH_RESPONSE; // 0x5C
	internal static int SERVERDATA_RESPONSE_VALUE; // 0x60
	internal static int SERVERDATA_CONSOLE_LOG; // 0x64
	internal static int SERVERDATA_SWITCH_UTF8; // 0x68

	// Methods

	// RVA: 0x7970F0 Offset: 0x7956F0 VA: 0x1807970F0
	public static void Initialize() { }

	// RVA: 0x797F70 Offset: 0x796570 VA: 0x180797F70
	public static void Shutdown() { }

	// RVA: 0x796EA0 Offset: 0x7954A0 VA: 0x180796EA0
	public static void Broadcast(RCon.LogType type, object obj) { }

	// RVA: 0x7980F0 Offset: 0x7966F0 VA: 0x1807980F0
	public static void Update() { }

	// RVA: 0x796D80 Offset: 0x795380 VA: 0x180796D80
	public static void BanIP(IPAddress addr, float seconds) { }

	// RVA: 0x797750 Offset: 0x795D50 VA: 0x180797750
	public static bool IsBanned(IPAddress addr) { }

	// RVA: 0x797840 Offset: 0x795E40 VA: 0x180797840
	private static void OnCommand(RCon.Command cmd) { }

	// RVA: 0x797CB0 Offset: 0x7962B0 VA: 0x180797CB0
	private static void OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x798600 Offset: 0x796C00 VA: 0x180798600
	private static void .cctor() { }

}

public struct RCon.Command // TypeDefIndex: 11991
{	// Fields
	public IPAddress Ip; // 0x0
	public int ConnectionId; // 0x8
	public string Name; // 0x10
	public string Message; // 0x18
	public int Identifier; // 0x20

}

public enum RCon.LogType // TypeDefIndex: 11992
{	// Fields
	public int value__; // 0x0
	public const RCon.LogType Generic = 0;
	public const RCon.LogType Error = 1;
	public const RCon.LogType Warning = 2;
	public const RCon.LogType Chat = 3;
	public const RCon.LogType Report = 4;

}

public struct RCon.Response // TypeDefIndex: 11993
{	// Fields
	public string Message; // 0x0
	public int Identifier; // 0x8
	[JsonConverterAttribute] // RVA: 0xCACF0 Offset: 0xCA0F0 VA: 0x1800CACF0
	public RCon.LogType Type; // 0xC
	public string Stacktrace; // 0x10

}

internal struct RCon.BannedAddresses // TypeDefIndex: 11994
{	// Fields
	public IPAddress addr; // 0x0
	public float banTime; // 0x8

}

internal class RCon.RConClient // TypeDefIndex: 11995
{	// Fields
	private Socket socket; // 0x10
	private bool isAuthorised; // 0x18
	private string connectionName; // 0x20
	private int lastMessageID; // 0x28
	private bool runningConsoleCommand; // 0x2C
	private bool utf8Mode; // 0x2D

	// Methods

	// RVA: 0x796450 Offset: 0x794A50 VA: 0x180796450
	internal void .ctor(Socket cl) { }

	// RVA: 0x795BE0 Offset: 0x7941E0 VA: 0x180795BE0
	internal bool IsValid() { }

	// RVA: 0x7961E0 Offset: 0x7947E0 VA: 0x1807961E0
	internal void Update() { }

	// RVA: 0x7955E0 Offset: 0x793BE0 VA: 0x1807955E0
	internal bool HandleMessage(int type, string msg) { }

	// RVA: 0x795240 Offset: 0x793840 VA: 0x180795240
	internal bool HandleMessage_UnAuthed(int type, string msg) { }

	// RVA: 0x795BF0 Offset: 0x7941F0 VA: 0x180795BF0
	private void Output_OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x795E50 Offset: 0x794450 VA: 0x180795E50
	internal void Reply(int id, int type, string msg) { }

	// RVA: 0x795050 Offset: 0x793650 VA: 0x180795050
	internal void Close(string strReasn) { }

	// RVA: 0x795CF0 Offset: 0x7942F0 VA: 0x180795CF0
	internal string ReadNullTerminatedString(BinaryReader read) { }

}

internal class RCon.RConListener // TypeDefIndex: 11996
{	// Fields
	private TcpListener server; // 0x10
	private List<RCon.RConClient> clients; // 0x18

	// Methods

	// RVA: 0x796B50 Offset: 0x795150 VA: 0x180796B50
	internal void .ctor() { }

	// RVA: 0x796A00 Offset: 0x795000 VA: 0x180796A00
	internal void Shutdown() { }

	// RVA: 0x7964F0 Offset: 0x794AF0 VA: 0x1807964F0
	internal void Cycle() { }

	// RVA: 0x796620 Offset: 0x794C20 VA: 0x180796620
	private void ProcessConnections() { }

	// RVA: 0x796A40 Offset: 0x795040 VA: 0x180796A40
	private void UpdateClients() { }

	// RVA: 0x796900 Offset: 0x794F00 VA: 0x180796900
	private void RemoveDeadClients() { }

}

private sealed class RCon.RConListener.<>c // TypeDefIndex: 11997
{	// Fields
	public static readonly RCon.RConListener.<>c <>9; // 0x0
	public static Predicate<RCon.RConClient> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x79A340 Offset: 0x798940 VA: 0x18079A340
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A130 Offset: 0x798730 VA: 0x18079A130
	internal bool <RemoveDeadClients>b__7_0(RCon.RConClient x) { }

}

private sealed class RCon.<>c // TypeDefIndex: 11998
{	// Fields
	public static readonly RCon.<>c <>9; // 0x0
	public static Action<IPAddress, int, string> <>9__11_0; // 0x8
	public static Predicate<RCon.BannedAddresses> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x79A4C0 Offset: 0x798AC0 VA: 0x18079A4C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x799F10 Offset: 0x798510 VA: 0x180799F10
	internal void <Initialize>b__11_0(IPAddress ip, int id, string msg) { }

	// RVA: 0x79A190 Offset: 0x798790 VA: 0x18079A190
	internal bool <Update>b__15_0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass18_0 // TypeDefIndex: 11999
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A230 Offset: 0x798830 VA: 0x18079A230
	internal bool <BanIP>b__0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass19_0 // TypeDefIndex: 12000
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A240 Offset: 0x798840 VA: 0x18079A240
	internal bool <IsBanned>b__0(RCon.BannedAddresses x) { }

}

