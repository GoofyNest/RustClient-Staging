public static class Output // TypeDefIndex: 11988
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string, string, LogType> OnMessage; // 0x0
	public static bool installed; // 0x8
	public static List<Output.Entry> HistoryOutput; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x794F80 Offset: 0x793580 VA: 0x180794F80
	public static void add_OnMessage(Action<string, string, LogType> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x795070 Offset: 0x793670 VA: 0x180795070
	public static void remove_OnMessage(Action<string, string, LogType> value) { }

	// RVA: 0x794860 Offset: 0x792E60 VA: 0x180794860
	public static void Install() { }

	// RVA: 0x794930 Offset: 0x792F30 VA: 0x180794930
	internal static void LogHandler(string log, string stacktrace, LogType type) { }

	// RVA: 0x794F00 Offset: 0x793500 VA: 0x180794F00
	private static void .cctor() { }

}

public struct Output.Entry // TypeDefIndex: 11989
{	// Fields
	public string Message; // 0x0
	public string Stacktrace; // 0x8
	public string Type; // 0x10
	public int Time; // 0x18

}

