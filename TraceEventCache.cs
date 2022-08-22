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

	// RVA: 0x17364F0 Offset: 0x1734AF0 VA: 0x1817364F0
	public string get_Callstack() { }

	// RVA: 0x17365E0 Offset: 0x1734BE0 VA: 0x1817365E0
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x1736530 Offset: 0x1734B30 VA: 0x181736530
	public DateTime get_DateTime() { }

	// RVA: 0x1736250 Offset: 0x1734850 VA: 0x181736250
	public int get_ProcessId() { }

	// RVA: 0x1736720 Offset: 0x1734D20 VA: 0x181736720
	public string get_ThreadId() { }

	// RVA: 0x17367A0 Offset: 0x1734DA0 VA: 0x1817367A0
	public long get_Timestamp() { }

	// RVA: 0x17362A0 Offset: 0x17348A0 VA: 0x1817362A0
	private static void InitProcessInfo() { }

	// RVA: 0x1736250 Offset: 0x1734850 VA: 0x181736250
	internal static int GetProcessId() { }

	// RVA: 0x10DB890 Offset: 0x10D9E90 VA: 0x1810DB890
	internal static int GetThreadId() { }

	// RVA: 0x1736470 Offset: 0x1734A70 VA: 0x181736470
	public void .ctor() { }

}

