public static class Output // TypeDefIndex: 11988
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string, string, LogType> OnMessage; // 0x0
	public static bool installed; // 0x8
	public static List<Output.Entry> HistoryOutput; // 0x10


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void add_OnMessage(Action<string, string, LogType> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void remove_OnMessage(Action<string, string, LogType> value) { }

	public static void Install() { }

	internal static void LogHandler(string log, string stacktrace, LogType type) { }

	private static void .cctor() { }

}

public struct Output.Entry // TypeDefIndex: 11989
{	public string Message; // 0x0
	public string Stacktrace; // 0x8
	public string Type; // 0x10
	public int Time; // 0x18

}

