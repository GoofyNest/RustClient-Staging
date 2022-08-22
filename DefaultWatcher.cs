internal class DefaultWatcher : IFileWatcher // TypeDefIndex: 2841
{	// Fields
	private static DefaultWatcher instance; // 0x0
	private static Thread thread; // 0x8
	private static Hashtable watches; // 0x10
	private static string[] NoStringsArray; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x15299E0 Offset: 0x1527FE0 VA: 0x1815299E0
	public static bool GetInstance(out IFileWatcher watcher) { }

	// RVA: 0x152AF90 Offset: 0x1529590 VA: 0x18152AF90 Slot: 4
	public void StartDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x152B770 Offset: 0x1529D70 VA: 0x18152B770 Slot: 5
	public void StopDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x152A760 Offset: 0x1528D60 VA: 0x18152A760
	private void Monitor() { }

	// RVA: 0x152BA30 Offset: 0x152A030 VA: 0x18152BA30
	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

	// RVA: 0x1529660 Offset: 0x1527C60 VA: 0x181529660
	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	// RVA: 0x1529760 Offset: 0x1527D60 VA: 0x181529760
	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	// RVA: 0x1529AF0 Offset: 0x15280F0 VA: 0x181529AF0
	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	// RVA: 0x1529590 Offset: 0x1527B90 VA: 0x181529590
	private static FileData CreateFileData(string directory, string filename) { }

	// RVA: 0x152BB50 Offset: 0x152A150 VA: 0x18152BB50
	private static void .cctor() { }

}

