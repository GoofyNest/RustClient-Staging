public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 661
{	// Fields
	private string current; // 0x60
	private string parent; // 0x68

	// Properties
	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x137A2C0 Offset: 0x13788C0 VA: 0x18137A2C0
	public void .ctor(string path) { }

	// RVA: 0x137A300 Offset: 0x1378900 VA: 0x18137A300
	internal void .ctor(string path, bool simpleOriginalPath) { }

	// RVA: 0x137A2D0 Offset: 0x13788D0 VA: 0x18137A2D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1379EE0 Offset: 0x13784E0 VA: 0x181379EE0
	private void Initialize() { }

	// RVA: 0x137A400 Offset: 0x1378A00 VA: 0x18137A400 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 8
	public override string get_Name() { }

	// RVA: 0x137A440 Offset: 0x1378A40 VA: 0x18137A440
	public DirectoryInfo get_Parent() { }

	// RVA: 0x13797C0 Offset: 0x1377DC0 VA: 0x1813797C0
	public void Create() { }

	// RVA: 0x1379710 Offset: 0x1377D10 VA: 0x181379710
	public DirectoryInfo CreateSubdirectory(string path) { }

	// RVA: 0x1379C90 Offset: 0x1378290 VA: 0x181379C90
	public FileInfo[] GetFiles() { }

	// RVA: 0x1379CD0 Offset: 0x13782D0 VA: 0x181379CD0
	public FileInfo[] GetFiles(string searchPattern) { }

	// RVA: 0x13799C0 Offset: 0x1377FC0 VA: 0x1813799C0
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x1379A00 Offset: 0x1378000 VA: 0x181379A00
	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	// RVA: 0x1379860 Offset: 0x1377E60 VA: 0x181379860 Slot: 10
	public override void Delete() { }

	// RVA: 0x13797D0 Offset: 0x1377DD0 VA: 0x1813797D0
	public void Delete(bool recursive) { }

	// RVA: 0x137A190 Offset: 0x1378790 VA: 0x18137A190
	public void MoveTo(string destDirName) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 3
	public override string ToString() { }

	// RVA: 0x13798D0 Offset: 0x1377ED0 VA: 0x1813798D0
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption) { }

	[IteratorStateMachineAttribute] // RVA: 0xA5680 Offset: 0xA4A80 VA: 0x1800A5680
	// RVA: 0x1379670 Offset: 0x1377C70 VA: 0x181379670
	private IEnumerable<FileInfo> CreateEnumerateFilesIterator(string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1379500 Offset: 0x1377B00 VA: 0x181379500
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1391D80 Offset: 0x1390380 VA: 0x181391D80 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1391880 Offset: 0x138FE80 VA: 0x181391880 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1391E30 Offset: 0x1390430 VA: 0x181391E30
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1391D30 Offset: 0x1390330 VA: 0x181391D30 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1391C70 Offset: 0x1390270 VA: 0x181391C70 Slot: 4
	private IEnumerator<FileInfo> System.Collections.Generic.IEnumerable<System.IO.FileInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1391C70 Offset: 0x1390270 VA: 0x181391C70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

