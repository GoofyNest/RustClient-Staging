internal class DefaultWatcher : IFileWatcher // TypeDefIndex: 2841
{	// Fields
	private static DefaultWatcher instance; // 0x0
	private static Thread thread; // 0x8
	private static Hashtable watches; // 0x10
	private static string[] NoStringsArray; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1529720 Offset: 0x1527D20 VA: 0x181529720
	public static bool GetInstance(out IFileWatcher watcher) { }

	// RVA: 0x152ACD0 Offset: 0x15292D0 VA: 0x18152ACD0 Slot: 4
	public void StartDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x152B4B0 Offset: 0x1529AB0 VA: 0x18152B4B0 Slot: 5
	public void StopDispatching(FileSystemWatcher fsw) { }

	// RVA: 0x152A4A0 Offset: 0x1528AA0 VA: 0x18152A4A0
	private void Monitor() { }

	// RVA: 0x152B770 Offset: 0x1529D70 VA: 0x18152B770
	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

	// RVA: 0x15293A0 Offset: 0x15279A0 VA: 0x1815293A0
	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	// RVA: 0x15294A0 Offset: 0x1527AA0 VA: 0x1815294A0
	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	// RVA: 0x1529830 Offset: 0x1527E30 VA: 0x181529830
	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	// RVA: 0x15292D0 Offset: 0x15278D0 VA: 0x1815292D0
	private static FileData CreateFileData(string directory, string filename) { }

	// RVA: 0x152B890 Offset: 0x1529E90 VA: 0x18152B890
	private static void .cctor() { }

}

