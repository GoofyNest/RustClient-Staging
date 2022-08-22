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

	// RVA: 0x1726FB0 Offset: 0x17255B0 VA: 0x181726FB0
	private static void .cctor() { }

	// RVA: 0x1726850 Offset: 0x1724E50 VA: 0x181726850
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x1727130 Offset: 0x1725730 VA: 0x181727130
	public void .ctor() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_LogFileName() { }

	// RVA: 0x1726F90 Offset: 0x1725590 VA: 0x181726F90
	private static void WriteWindowsDebugString(string message) { }

	// RVA: 0x17268C0 Offset: 0x1724EC0 VA: 0x1817268C0
	private void WriteDebugString(string message) { }

	// RVA: 0x1726CE0 Offset: 0x17252E0 VA: 0x181726CE0
	private void WriteMonoTrace(string message) { }

	// RVA: 0x1726EF0 Offset: 0x17254F0 VA: 0x181726EF0
	private void WritePrefix() { }

	// RVA: 0x1726960 Offset: 0x1724F60 VA: 0x181726960
	private void WriteImpl(string message) { }

	// RVA: 0x1726B70 Offset: 0x1725170 VA: 0x181726B70
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x1726FA0 Offset: 0x17255A0 VA: 0x181726FA0 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x1726B20 Offset: 0x1725120 VA: 0x181726B20 Slot: 12
	public override void WriteLine(string message) { }

}

