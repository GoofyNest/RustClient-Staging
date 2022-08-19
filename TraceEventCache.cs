public class TraceEventCache // TypeDefIndex: 2638
{	// Fields
	private static int processId; // 0x0
	private static string processName; // 0x8
	private long timeStamp; // 0x10
	private DateTime dateTime; // 0x18
	private string stackTrace; // 0x20

	// Properties
	public string Callstack { get; }
	public Stack LogicalOperationStack { get; }
	public DateTime DateTime { get; }
	public int ProcessId { get; }
	public string ThreadId { get; }
	public long Timestamp { get; }

	// Methods

	// RVA: 0x1736230 Offset: 0x1734830 VA: 0x181736230
	public string get_Callstack() { }

	// RVA: 0x1736320 Offset: 0x1734920 VA: 0x181736320
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x1736270 Offset: 0x1734870 VA: 0x181736270
	public DateTime get_DateTime() { }

	// RVA: 0x1735F90 Offset: 0x1734590 VA: 0x181735F90
	public int get_ProcessId() { }

	// RVA: 0x1736460 Offset: 0x1734A60 VA: 0x181736460
	public string get_ThreadId() { }

	// RVA: 0x17364E0 Offset: 0x1734AE0 VA: 0x1817364E0
	public long get_Timestamp() { }

	// RVA: 0x1735FE0 Offset: 0x17345E0 VA: 0x181735FE0
	private static void InitProcessInfo() { }

	// RVA: 0x1735F90 Offset: 0x1734590 VA: 0x181735F90
	internal static int GetProcessId() { }

	// RVA: 0x10DB5D0 Offset: 0x10D9BD0 VA: 0x1810DB5D0
	internal static int GetThreadId() { }

	// RVA: 0x17361B0 Offset: 0x17347B0 VA: 0x1817361B0
	public void .ctor() { }

}

