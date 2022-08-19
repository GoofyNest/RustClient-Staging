public class DefaultTraceListener : TraceListener // TypeDefIndex: 2655
{	// Fields
	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x38

	// Properties
	[MonoTODOAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string LogFileName { get; }

	// Methods

	// RVA: 0x1729130 Offset: 0x1727730 VA: 0x181729130
	private static void .cctor() { }

	// RVA: 0x17289D0 Offset: 0x1726FD0 VA: 0x1817289D0
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x17292B0 Offset: 0x17278B0 VA: 0x1817292B0
	public void .ctor() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_LogFileName() { }

	// RVA: 0x1729110 Offset: 0x1727710 VA: 0x181729110
	private static void WriteWindowsDebugString(string message) { }

	// RVA: 0x1728A40 Offset: 0x1727040 VA: 0x181728A40
	private void WriteDebugString(string message) { }

	// RVA: 0x1728E60 Offset: 0x1727460 VA: 0x181728E60
	private void WriteMonoTrace(string message) { }

	// RVA: 0x1729070 Offset: 0x1727670 VA: 0x181729070
	private void WritePrefix() { }

	// RVA: 0x1728AE0 Offset: 0x17270E0 VA: 0x181728AE0
	private void WriteImpl(string message) { }

	// RVA: 0x1728CF0 Offset: 0x17272F0 VA: 0x181728CF0
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x1729120 Offset: 0x1727720 VA: 0x181729120 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x1728CA0 Offset: 0x17272A0 VA: 0x181728CA0 Slot: 12
	public override void WriteLine(string message) { }

}

