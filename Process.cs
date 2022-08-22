public class Process : Component // TypeDefIndex: 2648
{	// Fields
	private bool haveProcessId; // 0x28
	private int processId; // 0x2C
	private bool haveProcessHandle; // 0x30
	private SafeProcessHandle m_processHandle; // 0x38
	private bool isRemoteMachine; // 0x40
	private string machineName; // 0x48
	private int m_processAccess; // 0x50
	private ProcessThreadCollection threads; // 0x58
	private ProcessModuleCollection modules; // 0x60
	private bool haveWorkingSetLimits; // 0x68
	private bool havePriorityClass; // 0x69
	private bool watchForExit; // 0x6A
	private bool watchingForExit; // 0x6B
	private EventHandler onExited; // 0x70
	private bool exited; // 0x78
	private int exitCode; // 0x7C
	private bool signaled; // 0x80
	private bool haveExitTime; // 0x81
	private bool raisedOnExited; // 0x82
	private RegisteredWaitHandle registeredWaitHandle; // 0x88
	private WaitHandle waitHandle; // 0x90
	private ISynchronizeInvoke synchronizingObject; // 0x98
	private StreamReader standardOutput; // 0xA0
	private StreamWriter standardInput; // 0xA8
	private StreamReader standardError; // 0xB0
	private bool disposed; // 0xB8
	private Process.StreamReadMode outputStreamReadMode; // 0xBC
	private Process.StreamReadMode errorStreamReadMode; // 0xC0
	private Process.StreamReadMode inputStreamReadMode; // 0xC4
	internal AsyncStreamReader output; // 0xC8
	internal AsyncStreamReader error; // 0xD0
	private string process_name; // 0xD8

	// Properties
	[BrowsableAttribute] // RVA: 0xA7A30 Offset: 0xA6E30 VA: 0x1800A7A30
	[MonitoringDescriptionAttribute] // RVA: 0xA7A30 Offset: 0xA6E30 VA: 0x1800A7A30
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7A30 Offset: 0xA6E30 VA: 0x1800A7A30
	private bool Associated { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7C00 Offset: 0xA7000 VA: 0x1800A7C00
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7C00 Offset: 0xA7000 VA: 0x1800A7C00
	[BrowsableAttribute] // RVA: 0xA7C00 Offset: 0xA7000 VA: 0x1800A7C00
	public bool HasExited { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7CC0 Offset: 0xA70C0 VA: 0x1800A7CC0
	[MonitoringDescriptionAttribute] // RVA: 0xA7CC0 Offset: 0xA70C0 VA: 0x1800A7CC0
	public int Id { get; }
	[BrowsableAttribute] // RVA: 0xA7DA0 Offset: 0xA71A0 VA: 0x1800A7DA0
	[DefaultValueAttribute] // RVA: 0xA7DA0 Offset: 0xA71A0 VA: 0x1800A7DA0
	[MonitoringDescriptionAttribute] // RVA: 0xA7DA0 Offset: 0xA71A0 VA: 0x1800A7DA0
	public ISynchronizeInvoke SynchronizingObject { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	public string ProcessName { get; }

	// Methods

	// RVA: 0x172D900 Offset: 0x172BF00 VA: 0x18172D900
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x172D9B0 Offset: 0x172BFB0 VA: 0x18172D9B0
	private bool get_Associated() { }

	// RVA: 0x172D9C0 Offset: 0x172BFC0 VA: 0x18172D9C0
	public bool get_HasExited() { }

	// RVA: 0x172DCA0 Offset: 0x172C2A0 VA: 0x18172DCA0
	public int get_Id() { }

	// RVA: 0x172DEA0 Offset: 0x172C4A0 VA: 0x18172DEA0
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x172D6B0 Offset: 0x172BCB0 VA: 0x18172D6B0
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x172CA80 Offset: 0x172B080 VA: 0x18172CA80 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x172C890 Offset: 0x172AE90 VA: 0x18172C890
	public void Close() { }

	// RVA: 0x172CAD0 Offset: 0x172B0D0 VA: 0x18172CAD0
	private void EnsureState(Process.State state) { }

	// RVA: 0x172CCF0 Offset: 0x172B2F0 VA: 0x18172CCF0
	public static Process GetCurrentProcess() { }

	// RVA: 0x172D230 Offset: 0x172B830 VA: 0x18172D230
	protected void OnExited() { }

	// RVA: 0x172CDD0 Offset: 0x172B3D0 VA: 0x18172CDD0
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x172CDC0 Offset: 0x172B3C0 VA: 0x18172CDC0
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x172D660 Offset: 0x172BC60 VA: 0x18172D660
	public void Refresh() { }

	// RVA: 0x172D6D0 Offset: 0x172BCD0 VA: 0x18172D6D0
	private void StopWatchingForExit() { }

	// RVA: 0x172D800 Offset: 0x172BE00 VA: 0x18172D800 Slot: 3
	public override string ToString() { }

	// RVA: 0x172D580 Offset: 0x172BB80 VA: 0x18172D580
	private static string ProcessName_internal(IntPtr handle) { }

	// RVA: 0x172D4A0 Offset: 0x172BAA0 VA: 0x18172D4A0
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x172DCC0 Offset: 0x172C2C0 VA: 0x18172DCC0
	public string get_ProcessName() { }

	// RVA: 0x172D590 Offset: 0x172BB90 VA: 0x18172D590
	private void RaiseOnExited() { }

}

private enum Process.StreamReadMode // TypeDefIndex: 2649
{	// Fields
	public int value__; // 0x0
	public const Process.StreamReadMode undefined = 0;
	public const Process.StreamReadMode syncMode = 1;
	public const Process.StreamReadMode asyncMode = 2;

}

private enum Process.State // TypeDefIndex: 2650
{	// Fields
	public int value__; // 0x0
	public const Process.State HaveId = 1;
	public const Process.State IsLocal = 2;
	public const Process.State IsNt = 4;
	public const Process.State HaveProcessInfo = 8;
	public const Process.State Exited = 16;
	public const Process.State Associated = 32;
	public const Process.State IsWin2k = 64;
	public const Process.State HaveNtProcessInfo = 12;

}

