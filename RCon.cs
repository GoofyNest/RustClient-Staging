public class RCon // TypeDefIndex: 13795
{
	public static string Password;
	[ServerVar]
	public static int Port;
	[ServerVar]
	public static string Ip;
	[ServerVar]
	public static bool Web;
	[ServerVar]
	public static bool Print;
	internal static RCon.RConListener listener;
	internal static Listener listenerNew;
	private static Queue<RCon.Command> Commands;
	private static float lastRunTime;
	internal static List<RCon.BannedAddresses> bannedAddresses;
	private static int responseIdentifier;
	private static int responseConnection;
	private static bool isInput;
	internal static int SERVERDATA_AUTH;
	internal static int SERVERDATA_EXECCOMMAND;
	internal static int SERVERDATA_AUTH_RESPONSE;
	internal static int SERVERDATA_RESPONSE_VALUE;
	internal static int SERVERDATA_CONSOLE_LOG;
	internal static int SERVERDATA_SWITCH_UTF8;


	public static void Initialize() { }

	public static void Shutdown() { }

	public static void Broadcast(RCon.LogType type, object obj) { }

	public static void Broadcast(RCon.LogType type, string message) { }

	public static void Update() { }

	public static void BanIP(IPAddress addr, float seconds) { }

	public static bool IsBanned(IPAddress addr) { }

	private static void OnCommand(RCon.Command cmd) { }

	private static void OnMessage(string message, string stacktrace, LogType type) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct RCon.Command // TypeDefIndex: 13796
{
	public IPAddress Ip;
	public int ConnectionId;
	public string Name;
	public string Message;
	public int Identifier;

}

public enum RCon.LogType // TypeDefIndex: 13797
{
	public int value__;
	public const RCon.LogType Generic = 0;
	public const RCon.LogType Error = 1;
	public const RCon.LogType Warning = 2;
	public const RCon.LogType Chat = 3;
	public const RCon.LogType Report = 4;
	public const RCon.LogType ClientPerf = 5;

}

public struct RCon.Response // TypeDefIndex: 13798
{
	public string Message;
	public int Identifier;
	[JsonConverterAttribute]
	public RCon.LogType Type;
	public string Stacktrace;

}

internal struct RCon.BannedAddresses // TypeDefIndex: 13799
{
	public IPAddress addr;
	public float banTime;

}

internal class RCon.RConClient // TypeDefIndex: 13800
{
	private Socket socket;
	private bool isAuthorised;
	private string connectionName;
	private int lastMessageID;
	private bool runningConsoleCommand;
	private bool utf8Mode;


	internal void .ctor(Socket cl) { }

	internal bool IsValid() { }

	internal void Update() { }

	internal bool HandleMessage(int type, string msg) { }

	internal bool HandleMessage_UnAuthed(int type, string msg) { }

	private void Output_OnMessage(string message, string stacktrace, LogType type) { }

	internal void Reply(int id, int type, string msg) { }

	internal void Close(string strReasn) { }

	internal string ReadNullTerminatedString(BinaryReader read) { }

}

internal class RCon.RConListener // TypeDefIndex: 13801
{
	private TcpListener server;
	private List<RCon.RConClient> clients;


	internal void .ctor() { }

	internal void Shutdown() { }

	internal void Cycle() { }

	private void ProcessConnections() { }

	private void UpdateClients() { }

	private void RemoveDeadClients() { }

}

private sealed class RCon.RConListener.<>c // TypeDefIndex: 13802
{
	public static readonly RCon.RConListener.<>c <>9;
	public static Predicate<RCon.RConClient> <>9__7_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RemoveDeadClients>

}

private sealed class RCon.<>c // TypeDefIndex: 13803
{
	public static readonly RCon.<>c <>9;
	public static Action<IPAddress, int, string> <>9__11_0;
	public static Predicate<RCon.BannedAddresses> <>9__16_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Initialize>

	internal bool <Update>

}

private sealed class RCon.<>c__DisplayClass19_0 // TypeDefIndex: 13804
{
	public IPAddress addr;


	public void .ctor() { }

	internal bool <BanIP>

}

private sealed class RCon.<>c__DisplayClass20_0 // TypeDefIndex: 13805
{
	public IPAddress addr;


	public void .ctor() { }

	internal bool <IsBanned>

}

