public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 661
{	// Fields
	private string current; // 0x60
	private string parent; // 0x68

	// Properties
	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x137A000 Offset: 0x1378600 VA: 0x18137A000
	public void .ctor(string path) { }

	// RVA: 0x137A040 Offset: 0x1378640 VA: 0x18137A040
	internal void .ctor(string path, bool simpleOriginalPath) { }

	// RVA: 0x137A010 Offset: 0x1378610 VA: 0x18137A010
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1379C20 Offset: 0x1378220 VA: 0x181379C20
	private void Initialize() { }

	// RVA: 0x137A140 Offset: 0x1378740 VA: 0x18137A140 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 8
	public override string get_Name() { }

	// RVA: 0x137A180 Offset: 0x1378780 VA: 0x18137A180
	public DirectoryInfo get_Parent() { }

	// RVA: 0x1379500 Offset: 0x1377B00 VA: 0x181379500
	public void Create() { }

	// RVA: 0x1379450 Offset: 0x1377A50 VA: 0x181379450
	public DirectoryInfo CreateSubdirectory(string path) { }

	// RVA: 0x13799D0 Offset: 0x1377FD0 VA: 0x1813799D0
	public FileInfo[] GetFiles() { }

	// RVA: 0x1379A10 Offset: 0x1378010 VA: 0x181379A10
	public FileInfo[] GetFiles(string searchPattern) { }

	// RVA: 0x1379700 Offset: 0x1377D00 VA: 0x181379700
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x1379740 Offset: 0x1377D40 VA: 0x181379740
	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	// RVA: 0x13795A0 Offset: 0x1377BA0 VA: 0x1813795A0 Slot: 10
	public override void Delete() { }

	// RVA: 0x1379510 Offset: 0x1377B10 VA: 0x181379510
	public void Delete(bool recursive) { }

	// RVA: 0x1379ED0 Offset: 0x13784D0 VA: 0x181379ED0
	public void MoveTo(string destDirName) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 3
	public override string ToString() { }

	// RVA: 0x1379610 Offset: 0x1377C10 VA: 0x181379610
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption) { }

	[IteratorStateMachineAttribute] // RVA: 0xA5680 Offset: 0xA4A80 VA: 0x1800A5680
	// RVA: 0x13793B0 Offset: 0x13779B0 VA: 0x1813793B0
	private IEnumerable<FileInfo> CreateEnumerateFilesIterator(string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1379240 Offset: 0x1377840 VA: 0x181379240
	internal void CheckPath(string path) { }

}

private sealed class DirectoryInfo.<CreateEnumerateFilesIterator>d__43 : IEnumerable<FileInfo>, IEnumerable, IEnumerator<FileInfo>, IDisposable, IEnumerator // TypeDefIndex: 662
{	// Fields
	private int <>1__state; // 0x10
	private FileInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public DirectoryInfo <>4__this; // 0x28
	private string searchPattern; // 0x30
	public string <>3__searchPattern; // 0x38
	private SearchOption searchOption; // 0x40
	public SearchOption <>3__searchOption; // 0x44
	private IEnumerator<string> <>7__wrap1; // 0x48

	// Properties
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1391AC0 Offset: 0x13900C0 VA: 0x181391AC0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13915C0 Offset: 0x138FBC0 VA: 0x1813915C0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1391B70 Offset: 0x1390170 VA: 0x181391B70
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1391A70 Offset: 0x1390070 VA: 0x181391A70 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13919B0 Offset: 0x138FFB0 VA: 0x1813919B0 Slot: 4
	private IEnumerator<FileInfo> System.Collections.Generic.IEnumerable<System.IO.FileInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13919B0 Offset: 0x138FFB0 VA: 0x1813919B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

