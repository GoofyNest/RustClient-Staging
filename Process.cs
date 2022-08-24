public class Process : Component // TypeDefIndex: 2648
{	private bool haveProcessId; // 0x28
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

	[BrowsableAttribute] // RVA: 0xA7B50 Offset: 0xA6F50 VA: 0x1800A7B50
	[MonitoringDescriptionAttribute] // RVA: 0xA7B50 Offset: 0xA6F50 VA: 0x1800A7B50
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7B50 Offset: 0xA6F50 VA: 0x1800A7B50
	private bool Associated { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7CE0 Offset: 0xA70E0 VA: 0x1800A7CE0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7CE0 Offset: 0xA70E0 VA: 0x1800A7CE0
	[BrowsableAttribute] // RVA: 0xA7CE0 Offset: 0xA70E0 VA: 0x1800A7CE0
	public bool HasExited { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7DB0 Offset: 0xA71B0 VA: 0x1800A7DB0
	[MonitoringDescriptionAttribute] // RVA: 0xA7DB0 Offset: 0xA71B0 VA: 0x1800A7DB0
	public int Id { get; }
	[BrowsableAttribute] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	[DefaultValueAttribute] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	[MonitoringDescriptionAttribute] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	public ISynchronizeInvoke SynchronizingObject { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7FA0 Offset: 0xA73A0 VA: 0x1800A7FA0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7FA0 Offset: 0xA73A0 VA: 0x1800A7FA0
	public string ProcessName { get; }


	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	private bool get_Associated() { }

	public bool get_HasExited() { }

	public int get_Id() { }

	public ISynchronizeInvoke get_SynchronizingObject() { }

	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	protected override void Dispose(bool disposing) { }

	public void Close() { }

	private void EnsureState(Process.State state) { }

	public static Process GetCurrentProcess() { }

	protected void OnExited() { }

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	private SafeProcessHandle GetProcessHandle(int access) { }

	public void Refresh() { }

	private void StopWatchingForExit() { }

	public override string ToString() { }

	private static string ProcessName_internal(IntPtr handle) { }

	private static string ProcessName_internal(SafeProcessHandle handle) { }

	public string get_ProcessName() { }

	private void RaiseOnExited() { }

}

private enum Process.StreamReadMode // TypeDefIndex: 2649
{	public int value__; // 0x0
	public const Process.StreamReadMode undefined = 0;
	public const Process.StreamReadMode syncMode = 1;
	public const Process.StreamReadMode asyncMode = 2;

}

private enum Process.State // TypeDefIndex: 2650
{	public int value__; // 0x0
	public const Process.State HaveId = 1;
	public const Process.State IsLocal = 2;
	public const Process.State IsNt = 4;
	public const Process.State HaveProcessInfo = 8;
	public const Process.State Exited = 16;
	public const Process.State Associated = 32;
	public const Process.State IsWin2k = 64;
	public const Process.State HaveNtProcessInfo = 12;

}

