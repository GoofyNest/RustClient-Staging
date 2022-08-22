public class DefaultTraceListener : TraceListener // TypeDefIndex: 2655
{	// Fields
	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x38

	// Properties
	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string LogFileName { get; }

	// Methods

	// RVA: 0x17293F0 Offset: 0x17279F0 VA: 0x1817293F0
	private static void .cctor() { }

	// RVA: 0x1728C90 Offset: 0x1727290 VA: 0x181728C90
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x1729570 Offset: 0x1727B70 VA: 0x181729570
	public void .ctor() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_LogFileName() { }

	// RVA: 0x17293D0 Offset: 0x17279D0 VA: 0x1817293D0
	private static void WriteWindowsDebugString(string message) { }

	// RVA: 0x1728D00 Offset: 0x1727300 VA: 0x181728D00
	private void WriteDebugString(string message) { }

	// RVA: 0x1729120 Offset: 0x1727720 VA: 0x181729120
	private void WriteMonoTrace(string message) { }

	// RVA: 0x1729330 Offset: 0x1727930 VA: 0x181729330
	private void WritePrefix() { }

	// RVA: 0x1728DA0 Offset: 0x17273A0 VA: 0x181728DA0
	private void WriteImpl(string message) { }

	// RVA: 0x1728FB0 Offset: 0x17275B0 VA: 0x181728FB0
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x17293E0 Offset: 0x17279E0 VA: 0x1817293E0 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x1728F60 Offset: 0x1727560 VA: 0x181728F60 Slot: 12
	public override void WriteLine(string message) { }

}

