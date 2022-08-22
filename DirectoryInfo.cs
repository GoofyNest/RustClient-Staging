public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 661
{	// Fields
	private string current; // 0x60
	private string parent; // 0x68

	// Properties
	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x13793C0 Offset: 0x13779C0 VA: 0x1813793C0
	public void .ctor(string path) { }

	// RVA: 0x1379400 Offset: 0x1377A00 VA: 0x181379400
	internal void .ctor(string path, bool simpleOriginalPath) { }

	// RVA: 0x13793D0 Offset: 0x13779D0 VA: 0x1813793D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1378FE0 Offset: 0x13775E0 VA: 0x181378FE0
	private void Initialize() { }

	// RVA: 0x1379500 Offset: 0x1377B00 VA: 0x181379500 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1379540 Offset: 0x1377B40 VA: 0x181379540
	public DirectoryInfo get_Parent() { }

	// RVA: 0x13788C0 Offset: 0x1376EC0 VA: 0x1813788C0
	public void Create() { }

	// RVA: 0x1378810 Offset: 0x1376E10 VA: 0x181378810
	public DirectoryInfo CreateSubdirectory(string path) { }

	// RVA: 0x1378D90 Offset: 0x1377390 VA: 0x181378D90
	public FileInfo[] GetFiles() { }

	// RVA: 0x1378DD0 Offset: 0x13773D0 VA: 0x181378DD0
	public FileInfo[] GetFiles(string searchPattern) { }

	// RVA: 0x1378AC0 Offset: 0x13770C0 VA: 0x181378AC0
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x1378B00 Offset: 0x1377100 VA: 0x181378B00
	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	// RVA: 0x1378960 Offset: 0x1376F60 VA: 0x181378960 Slot: 10
	public override void Delete() { }

	// RVA: 0x13788D0 Offset: 0x1376ED0 VA: 0x1813788D0
	public void Delete(bool recursive) { }

	// RVA: 0x1379290 Offset: 0x1377890 VA: 0x181379290
	public void MoveTo(string destDirName) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 3
	public override string ToString() { }

	// RVA: 0x13789D0 Offset: 0x1376FD0 VA: 0x1813789D0
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption) { }

	[IteratorStateMachineAttribute] // RVA: 0xA5680 Offset: 0xA4A80 VA: 0x1800A5680
	// RVA: 0x1378770 Offset: 0x1376D70 VA: 0x181378770
	private IEnumerable<FileInfo> CreateEnumerateFilesIterator(string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1378600 Offset: 0x1376C00 VA: 0x181378600
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1390E80 Offset: 0x138F480 VA: 0x181390E80 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1390980 Offset: 0x138EF80 VA: 0x181390980 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1390F30 Offset: 0x138F530 VA: 0x181390F30
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private FileInfo System.Collections.Generic.IEnumerator<System.IO.FileInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1390E30 Offset: 0x138F430 VA: 0x181390E30 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1390D70 Offset: 0x138F370 VA: 0x181390D70 Slot: 4
	private IEnumerator<FileInfo> System.Collections.Generic.IEnumerable<System.IO.FileInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1390D70 Offset: 0x138F370 VA: 0x181390D70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

