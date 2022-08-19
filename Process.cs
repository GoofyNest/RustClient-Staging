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
	[BrowsableAttribute] // RVA: 0xA7A40 Offset: 0xA6E40 VA: 0x1800A7A40
	[MonitoringDescriptionAttribute] // RVA: 0xA7A40 Offset: 0xA6E40 VA: 0x1800A7A40
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7A40 Offset: 0xA6E40 VA: 0x1800A7A40
	private bool Associated { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7BA0 Offset: 0xA6FA0 VA: 0x1800A7BA0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7BA0 Offset: 0xA6FA0 VA: 0x1800A7BA0
	[BrowsableAttribute] // RVA: 0xA7BA0 Offset: 0xA6FA0 VA: 0x1800A7BA0
	public bool HasExited { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7C70 Offset: 0xA7070 VA: 0x1800A7C70
	[MonitoringDescriptionAttribute] // RVA: 0xA7C70 Offset: 0xA7070 VA: 0x1800A7C70
	public int Id { get; }
	[BrowsableAttribute] // RVA: 0xA7D90 Offset: 0xA7190 VA: 0x1800A7D90
	[DefaultValueAttribute] // RVA: 0xA7D90 Offset: 0xA7190 VA: 0x1800A7D90
	[MonitoringDescriptionAttribute] // RVA: 0xA7D90 Offset: 0xA7190 VA: 0x1800A7D90
	public ISynchronizeInvoke SynchronizingObject { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7E30 Offset: 0xA7230 VA: 0x1800A7E30
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7E30 Offset: 0xA7230 VA: 0x1800A7E30
	public string ProcessName { get; }

	// Methods

	// RVA: 0x172D640 Offset: 0x172BC40 VA: 0x18172D640
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x172D6F0 Offset: 0x172BCF0 VA: 0x18172D6F0
	private bool get_Associated() { }

	// RVA: 0x172D700 Offset: 0x172BD00 VA: 0x18172D700
	public bool get_HasExited() { }

	// RVA: 0x172D9E0 Offset: 0x172BFE0 VA: 0x18172D9E0
	public int get_Id() { }

	// RVA: 0x172DBE0 Offset: 0x172C1E0 VA: 0x18172DBE0
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x172D3F0 Offset: 0x172B9F0 VA: 0x18172D3F0
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x172C7C0 Offset: 0x172ADC0 VA: 0x18172C7C0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x172C5D0 Offset: 0x172ABD0 VA: 0x18172C5D0
	public void Close() { }

	// RVA: 0x172C810 Offset: 0x172AE10 VA: 0x18172C810
	private void EnsureState(Process.State state) { }

	// RVA: 0x172CA30 Offset: 0x172B030 VA: 0x18172CA30
	public static Process GetCurrentProcess() { }

	// RVA: 0x172CF70 Offset: 0x172B570 VA: 0x18172CF70
	protected void OnExited() { }

	// RVA: 0x172CB10 Offset: 0x172B110 VA: 0x18172CB10
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x172CB00 Offset: 0x172B100 VA: 0x18172CB00
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x172D3A0 Offset: 0x172B9A0 VA: 0x18172D3A0
	public void Refresh() { }

	// RVA: 0x172D410 Offset: 0x172BA10 VA: 0x18172D410
	private void StopWatchingForExit() { }

	// RVA: 0x172D540 Offset: 0x172BB40 VA: 0x18172D540 Slot: 3
	public override string ToString() { }

	// RVA: 0x172D2C0 Offset: 0x172B8C0 VA: 0x18172D2C0
	private static string ProcessName_internal(IntPtr handle) { }

	// RVA: 0x172D1E0 Offset: 0x172B7E0 VA: 0x18172D1E0
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x172DA00 Offset: 0x172C000 VA: 0x18172DA00
	public string get_ProcessName() { }

	// RVA: 0x172D2D0 Offset: 0x172B8D0 VA: 0x18172D2D0
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

