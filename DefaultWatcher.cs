internal class DefaultWatcher : IFileWatcher // TypeDefIndex: 2841
{	// Fields
	private static DefaultWatcher instance; // 0x0
	private static Thread thread; // 0x8
	private static Hashtable watches; // 0x10
	private static string[] NoStringsArray; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1528AB0 Offset: 0x15270B0 VA: 0x181528AB0
	public static bool GetInstance(out IFileWatcher watcher) { }

	// RVA: 0x152A060 Offset: 0x1528660 VA: 0x18152A060 Slot: 4
	public void StartDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x152A840 Offset: 0x1528E40 VA: 0x18152A840 Slot: 5
	public void StopDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x1529830 Offset: 0x1527E30 VA: 0x181529830
	private void Monitor() { }

	// RVA: 0x152AB00 Offset: 0x1529100 VA: 0x18152AB00
	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

	// RVA: 0x1528730 Offset: 0x1526D30 VA: 0x181528730
	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	// RVA: 0x1528830 Offset: 0x1526E30 VA: 0x181528830
	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	// RVA: 0x1528BC0 Offset: 0x15271C0 VA: 0x181528BC0
	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	// RVA: 0x1528660 Offset: 0x1526C60 VA: 0x181528660
	private static FileData CreateFileData(string directory, string filename) { }

	// RVA: 0x152AC20 Offset: 0x1529220 VA: 0x18152AC20
	private static void .cctor() { }

}

