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

	// RVA: 0x797200 Offset: 0x795800 VA: 0x180797200
	public static void Initialize() { }

	// RVA: 0x798080 Offset: 0x796680 VA: 0x180798080
	public static void Shutdown() { }

	// RVA: 0x796FB0 Offset: 0x7955B0 VA: 0x180796FB0
	public static void Broadcast(RCon.LogType type, object obj) { }

	// RVA: 0x798200 Offset: 0x796800 VA: 0x180798200
	public static void Update() { }

	// RVA: 0x796E90 Offset: 0x795490 VA: 0x180796E90
	public static void BanIP(IPAddress addr, float seconds) { }

	// RVA: 0x797860 Offset: 0x795E60 VA: 0x180797860
	public static bool IsBanned(IPAddress addr) { }

	// RVA: 0x797950 Offset: 0x795F50 VA: 0x180797950
	private static void OnCommand(RCon.Command cmd) { }

	// RVA: 0x797DC0 Offset: 0x7963C0 VA: 0x180797DC0
	private static void OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x798710 Offset: 0x796D10 VA: 0x180798710
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

	// RVA: 0x796560 Offset: 0x794B60 VA: 0x180796560
	internal void .ctor(Socket cl) { }

	// RVA: 0x795CF0 Offset: 0x7942F0 VA: 0x180795CF0
	internal bool IsValid() { }

	// RVA: 0x7962F0 Offset: 0x7948F0 VA: 0x1807962F0
	internal void Update() { }

	// RVA: 0x7956F0 Offset: 0x793CF0 VA: 0x1807956F0
	internal bool HandleMessage(int type, string msg) { }

	// RVA: 0x795350 Offset: 0x793950 VA: 0x180795350
	internal bool HandleMessage_UnAuthed(int type, string msg) { }

	// RVA: 0x795D00 Offset: 0x794300 VA: 0x180795D00
	private void Output_OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x795F60 Offset: 0x794560 VA: 0x180795F60
	internal void Reply(int id, int type, string msg) { }

	// RVA: 0x795160 Offset: 0x793760 VA: 0x180795160
	internal void Close(string strReasn) { }

	// RVA: 0x795E00 Offset: 0x794400 VA: 0x180795E00
	internal string ReadNullTerminatedString(BinaryReader read) { }

}

internal class RCon.RConListener // TypeDefIndex: 11996
{	// Fields
	private TcpListener server; // 0x10
	private List<RCon.RConClient> clients; // 0x18

	// Methods

	// RVA: 0x796C60 Offset: 0x795260 VA: 0x180796C60
	internal void .ctor() { }

	// RVA: 0x796B10 Offset: 0x795110 VA: 0x180796B10
	internal void Shutdown() { }

	// RVA: 0x796600 Offset: 0x794C00 VA: 0x180796600
	internal void Cycle() { }

	// RVA: 0x796730 Offset: 0x794D30 VA: 0x180796730
	private void ProcessConnections() { }

	// RVA: 0x796B50 Offset: 0x795150 VA: 0x180796B50
	private void UpdateClients() { }

	// RVA: 0x796A10 Offset: 0x795010 VA: 0x180796A10
	private void RemoveDeadClients() { }

}

private sealed class RCon.RConListener.<>c // TypeDefIndex: 11997
{	// Fields
	public static readonly RCon.RConListener.<>c <>9; // 0x0
	public static Predicate<RCon.RConClient> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x79A450 Offset: 0x798A50 VA: 0x18079A450
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A240 Offset: 0x798840 VA: 0x18079A240
	internal bool <RemoveDeadClients>b__7_0(RCon.RConClient x) { }

}

private sealed class RCon.<>c // TypeDefIndex: 11998
{	// Fields
	public static readonly RCon.<>c <>9; // 0x0
	public static Action<IPAddress, int, string> <>9__11_0; // 0x8
	public static Predicate<RCon.BannedAddresses> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x79A5D0 Offset: 0x798BD0 VA: 0x18079A5D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A020 Offset: 0x798620 VA: 0x18079A020
	internal void <Initialize>b__11_0(IPAddress ip, int id, string msg) { }

	// RVA: 0x79A2A0 Offset: 0x7988A0 VA: 0x18079A2A0
	internal bool <Update>b__15_0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass18_0 // TypeDefIndex: 11999
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A340 Offset: 0x798940 VA: 0x18079A340
	internal bool <BanIP>b__0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass19_0 // TypeDefIndex: 12000
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A350 Offset: 0x798950 VA: 0x18079A350
	internal bool <IsBanned>b__0(RCon.BannedAddresses x) { }

}

