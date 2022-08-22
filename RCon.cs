public class RCon // TypeDefIndex: 11990
{	// Fields
	public static string Password; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int Port; // 0x8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string Ip; // 0x10
	[ServerVar] // RVA: 0xCAAA0 Offset: 0xC9EA0 VA: 0x1800CAAA0
	public static bool Web; // 0x18
	[ServerVar] // RVA: 0xCACF0 Offset: 0xCA0F0 VA: 0x1800CACF0
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

	// RVA: 0x797110 Offset: 0x795710 VA: 0x180797110
	public static void Initialize() { }

	// RVA: 0x797F90 Offset: 0x796590 VA: 0x180797F90
	public static void Shutdown() { }

	// RVA: 0x796EC0 Offset: 0x7954C0 VA: 0x180796EC0
	public static void Broadcast(RCon.LogType type, object obj) { }

	// RVA: 0x798110 Offset: 0x796710 VA: 0x180798110
	public static void Update() { }

	// RVA: 0x796DA0 Offset: 0x7953A0 VA: 0x180796DA0
	public static void BanIP(IPAddress addr, float seconds) { }

	// RVA: 0x797770 Offset: 0x795D70 VA: 0x180797770
	public static bool IsBanned(IPAddress addr) { }

	// RVA: 0x797860 Offset: 0x795E60 VA: 0x180797860
	private static void OnCommand(RCon.Command cmd) { }

	// RVA: 0x797CD0 Offset: 0x7962D0 VA: 0x180797CD0
	private static void OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x798620 Offset: 0x796C20 VA: 0x180798620
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
	[JsonConverterAttribute] // RVA: 0xCAE70 Offset: 0xCA270 VA: 0x1800CAE70
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

	// RVA: 0x796470 Offset: 0x794A70 VA: 0x180796470
	internal void .ctor(Socket cl) { }

	// RVA: 0x795C00 Offset: 0x794200 VA: 0x180795C00
	internal bool IsValid() { }

	// RVA: 0x796200 Offset: 0x794800 VA: 0x180796200
	internal void Update() { }

	// RVA: 0x795600 Offset: 0x793C00 VA: 0x180795600
	internal bool HandleMessage(int type, string msg) { }

	// RVA: 0x795260 Offset: 0x793860 VA: 0x180795260
	internal bool HandleMessage_UnAuthed(int type, string msg) { }

	// RVA: 0x795C10 Offset: 0x794210 VA: 0x180795C10
	private void Output_OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x795E70 Offset: 0x794470 VA: 0x180795E70
	internal void Reply(int id, int type, string msg) { }

	// RVA: 0x795070 Offset: 0x793670 VA: 0x180795070
	internal void Close(string strReasn) { }

	// RVA: 0x795D10 Offset: 0x794310 VA: 0x180795D10
	internal string ReadNullTerminatedString(BinaryReader read) { }

}

internal class RCon.RConListener // TypeDefIndex: 11996
{	// Fields
	private TcpListener server; // 0x10
	private List<RCon.RConClient> clients; // 0x18

	// Methods

	// RVA: 0x796B70 Offset: 0x795170 VA: 0x180796B70
	internal void .ctor() { }

	// RVA: 0x796A20 Offset: 0x795020 VA: 0x180796A20
	internal void Shutdown() { }

	// RVA: 0x796510 Offset: 0x794B10 VA: 0x180796510
	internal void Cycle() { }

	// RVA: 0x796640 Offset: 0x794C40 VA: 0x180796640
	private void ProcessConnections() { }

	// RVA: 0x796A60 Offset: 0x795060 VA: 0x180796A60
	private void UpdateClients() { }

	// RVA: 0x796920 Offset: 0x794F20 VA: 0x180796920
	private void RemoveDeadClients() { }

}

private sealed class RCon.RConListener.<>c // TypeDefIndex: 11997
{	// Fields
	public static readonly RCon.RConListener.<>c <>9; // 0x0
	public static Predicate<RCon.RConClient> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x79A360 Offset: 0x798960 VA: 0x18079A360
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A150 Offset: 0x798750 VA: 0x18079A150
	internal bool <RemoveDeadClients>b__7_0(RCon.RConClient x) { }

}

private sealed class RCon.<>c // TypeDefIndex: 11998
{	// Fields
	public static readonly RCon.<>c <>9; // 0x0
	public static Action<IPAddress, int, string> <>9__11_0; // 0x8
	public static Predicate<RCon.BannedAddresses> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x79A4E0 Offset: 0x798AE0 VA: 0x18079A4E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x799F30 Offset: 0x798530 VA: 0x180799F30
	internal void <Initialize>b__11_0(IPAddress ip, int id, string msg) { }

	// RVA: 0x79A1B0 Offset: 0x7987B0 VA: 0x18079A1B0
	internal bool <Update>b__15_0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass18_0 // TypeDefIndex: 11999
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A250 Offset: 0x798850 VA: 0x18079A250
	internal bool <BanIP>b__0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass19_0 // TypeDefIndex: 12000
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A260 Offset: 0x798860 VA: 0x18079A260
	internal bool <IsBanned>b__0(RCon.BannedAddresses x) { }

}

