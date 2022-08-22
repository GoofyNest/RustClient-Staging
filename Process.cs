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

	// RVA: 0x172B4C0 Offset: 0x1729AC0 VA: 0x18172B4C0
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x172B570 Offset: 0x1729B70 VA: 0x18172B570
	private bool get_Associated() { }

	// RVA: 0x172B580 Offset: 0x1729B80 VA: 0x18172B580
	public bool get_HasExited() { }

	// RVA: 0x172B860 Offset: 0x1729E60 VA: 0x18172B860
	public int get_Id() { }

	// RVA: 0x172BA60 Offset: 0x172A060 VA: 0x18172BA60
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x172B270 Offset: 0x1729870 VA: 0x18172B270
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x172A640 Offset: 0x1728C40 VA: 0x18172A640 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x172A450 Offset: 0x1728A50 VA: 0x18172A450
	public void Close() { }

	// RVA: 0x172A690 Offset: 0x1728C90 VA: 0x18172A690
	private void EnsureState(Process.State state) { }

	// RVA: 0x172A8B0 Offset: 0x1728EB0 VA: 0x18172A8B0
	public static Process GetCurrentProcess() { }

	// RVA: 0x172ADF0 Offset: 0x17293F0 VA: 0x18172ADF0
	protected void OnExited() { }

	// RVA: 0x172A990 Offset: 0x1728F90 VA: 0x18172A990
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x172A980 Offset: 0x1728F80 VA: 0x18172A980
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x172B220 Offset: 0x1729820 VA: 0x18172B220
	public void Refresh() { }

	// RVA: 0x172B290 Offset: 0x1729890 VA: 0x18172B290
	private void StopWatchingForExit() { }

	// RVA: 0x172B3C0 Offset: 0x17299C0 VA: 0x18172B3C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x172B140 Offset: 0x1729740 VA: 0x18172B140
	private static string ProcessName_internal(IntPtr handle) { }

	// RVA: 0x172B060 Offset: 0x1729660 VA: 0x18172B060
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x172B880 Offset: 0x1729E80 VA: 0x18172B880
	public string get_ProcessName() { }

	// RVA: 0x172B150 Offset: 0x1729750 VA: 0x18172B150
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

