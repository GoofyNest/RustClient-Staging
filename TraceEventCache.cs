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

	// RVA: 0x17340B0 Offset: 0x17326B0 VA: 0x1817340B0
	public string get_Callstack() { }

	// RVA: 0x17341A0 Offset: 0x17327A0 VA: 0x1817341A0
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x17340F0 Offset: 0x17326F0 VA: 0x1817340F0
	public DateTime get_DateTime() { }

	// RVA: 0x1733E10 Offset: 0x1732410 VA: 0x181733E10
	public int get_ProcessId() { }

	// RVA: 0x17342E0 Offset: 0x17328E0 VA: 0x1817342E0
	public string get_ThreadId() { }

	// RVA: 0x1734360 Offset: 0x1732960 VA: 0x181734360
	public long get_Timestamp() { }

	// RVA: 0x1733E60 Offset: 0x1732460 VA: 0x181733E60
	private static void InitProcessInfo() { }

	// RVA: 0x1733E10 Offset: 0x1732410 VA: 0x181733E10
	internal static int GetProcessId() { }

	// RVA: 0x10DC300 Offset: 0x10DA900 VA: 0x1810DC300
	internal static int GetThreadId() { }

	// RVA: 0x1734030 Offset: 0x1732630 VA: 0x181734030
	public void .ctor() { }

}

