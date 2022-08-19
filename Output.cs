public static class Output // TypeDefIndex: 11988
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Action<string, string, LogType> OnMessage; // 0x0
	public static bool installed; // 0x8
	public static List<Output.Entry> HistoryOutput; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x794E70 Offset: 0x793470 VA: 0x180794E70
	public static void add_OnMessage(Action<string, string, LogType> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x794F60 Offset: 0x793560 VA: 0x180794F60
	public static void remove_OnMessage(Action<string, string, LogType> value) { }

	// RVA: 0x794750 Offset: 0x792D50 VA: 0x180794750
	public static void Install() { }

	// RVA: 0x794820 Offset: 0x792E20 VA: 0x180794820
	internal static void LogHandler(string log, string stacktrace, LogType type) { }

	// RVA: 0x794DF0 Offset: 0x7933F0 VA: 0x180794DF0
	private static void .cctor() { }

}

public struct Output.Entry // TypeDefIndex: 11989
{	// Fields
	public string Message; // 0x0
	public string Stacktrace; // 0x8
	public string Type; // 0x10
	public int Time; // 0x18

}

