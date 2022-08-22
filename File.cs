internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 482
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE7440 Offset: 0xFE5A40 VA: 0x180FE7440 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE7380 Offset: 0xFE5980 VA: 0x180FE7380
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0xFE7000 Offset: 0xFE5600 VA: 0x180FE7000
	private ResourceSet CreateResourceSet(string file) { }

}

public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 623
{	// Fields
	private string _name; // 0x60

	// Properties
	public override string Name { get; }
	public long Length { get; }
	public string DirectoryName { get; }
	public DirectoryInfo Directory { get; }
	public override bool Exists { get; }

	// Methods

	// RVA: 0x161F410 Offset: 0x161DA10 VA: 0x18161F410
	public void .ctor(string fileName) { }

	// RVA: 0x161EF90 Offset: 0x161D590 VA: 0x18161EF90
	private void Init(string fileName, bool checkHost) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	private string GetDisplayPath(string originalPath) { }

	// RVA: 0x161F5B0 Offset: 0x161DBB0 VA: 0x18161F5B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161F310 Offset: 0x161D910 VA: 0x18161F310
	internal void .ctor(string fullPath, bool ignoreThis) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 8
	public override string get_Name() { }

	// RVA: 0x161F910 Offset: 0x161DF10 VA: 0x18161F910
	public long get_Length() { }

	// RVA: 0x161F780 Offset: 0x161DD80 VA: 0x18161F780
	public string get_DirectoryName() { }

	// RVA: 0x161F7E0 Offset: 0x161DDE0 VA: 0x18161F7E0
	public DirectoryInfo get_Directory() { }

	// RVA: 0x161ED60 Offset: 0x161D360 VA: 0x18161ED60
	public StreamWriter CreateText() { }

	// RVA: 0x161EB20 Offset: 0x161D120 VA: 0x18161EB20
	public StreamWriter AppendText() { }

	// RVA: 0x161EB80 Offset: 0x161D180 VA: 0x18161EB80
	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	// RVA: 0x161EDC0 Offset: 0x161D3C0 VA: 0x18161EDC0 Slot: 10
	public override void Delete() { }

	// RVA: 0x161F890 Offset: 0x161DE90 VA: 0x18161F890 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x161F080 Offset: 0x161D680 VA: 0x18161F080
	public void MoveTo(string destFileName) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 3
	public override string ToString() { }

}

public class FileLoadException : IOException // TypeDefIndex: 624
{	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x161FE80 Offset: 0x161E480 VA: 0x18161FE80
	public void .ctor() { }

	// RVA: 0x161FE40 Offset: 0x161E440 VA: 0x18161FE40
	public void .ctor(string message) { }

	// RVA: 0x161FFE0 Offset: 0x161E5E0 VA: 0x18161FFE0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x161FB30 Offset: 0x161E130 VA: 0x18161FB30
	private void SetMessageField() { }

	// RVA: 0x161FBC0 Offset: 0x161E1C0 VA: 0x18161FBC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x161FEF0 Offset: 0x161E4F0 VA: 0x18161FEF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_FusionLog() { }

	// RVA: 0x161F9F0 Offset: 0x161DFF0 VA: 0x18161F9F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161F980 Offset: 0x161DF80 VA: 0x18161F980
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

}

public class FileNotFoundException : IOException // TypeDefIndex: 625
{	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x16204B0 Offset: 0x161EAB0 VA: 0x1816204B0
	public void .ctor() { }

	// RVA: 0x1620520 Offset: 0x161EB20 VA: 0x181620520
	public void .ctor(string message) { }

	// RVA: 0x1620560 Offset: 0x161EB60 VA: 0x181620560
	public void .ctor(string message, string fileName) { }

	// RVA: 0x16206B0 Offset: 0x161ECB0 VA: 0x1816206B0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x16201B0 Offset: 0x161E7B0 VA: 0x1816201B0
	private void SetMessageField() { }

	// RVA: 0x1620230 Offset: 0x161E830 VA: 0x181620230 Slot: 3
	public override string ToString() { }

	// RVA: 0x16205C0 Offset: 0x161EBC0 VA: 0x1816205C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_FusionLog() { }

	// RVA: 0x1620070 Offset: 0x161E670 VA: 0x181620070 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

internal static class FileSystemEnumerableFactory // TypeDefIndex: 626
{	// Methods

	// RVA: 0x16244B0 Offset: 0x1622AB0 VA: 0x1816244B0
	internal static IEnumerable<string> CreateFileNameIterator(string path, string originalUserPath, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

}

internal class FileSystemEnumerableIterator<TSource> : Iterator<TSource> // TypeDefIndex: 628
{	// Fields
	private SearchResultHandler<TSource> _resultHandler; // 0x0
	private List<Directory.SearchData> searchStack; // 0x0
	private Directory.SearchData searchData; // 0x0
	private string searchCriteria; // 0x0
	private SafeFindHandle _hnd; // 0x0
	private bool needsParentPathDiscoveryDemand; // 0x0
	private bool empty; // 0x0
	private string userPath; // 0x0
	private SearchOption searchOption; // 0x0
	private string fullPath; // 0x0
	private string normalizedSearchPath; // 0x0
	private bool _checkHost; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F8730 Offset: 0x19F6D30 VA: 0x1819F8730
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7BF0 Offset: 0x19F61F0 VA: 0x1819F7BF0
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	// RVA: -1 Offset: -1
	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F8A90 Offset: 0x19F7090 VA: 0x1819F8A90
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7B20 Offset: 0x19F6120 VA: 0x1819F7B20
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7F50 Offset: 0x19F6550 VA: 0x1819F7F50
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F81F0 Offset: 0x19F67F0 VA: 0x1819F81F0
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7E70 Offset: 0x19F6470 VA: 0x1819F7E70
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	// RVA: -1 Offset: -1
	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F81A0 Offset: 0x19F67A0 VA: 0x1819F81A0
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	// RVA: -1 Offset: -1
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F77D0 Offset: 0x19F5DD0 VA: 0x1819F77D0
	|-FileSystemEnumerableIterator<object>.AddSearchableDirsToStack
	*/

	// RVA: -1 Offset: -1
	internal void DoDemand(string fullPathToDemand) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-FileSystemEnumerableIterator<object>.DoDemand
	*/

	// RVA: -1 Offset: -1
	private static string NormalizeSearchPattern(string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F8670 Offset: 0x19F6C70 VA: 0x1819F8670
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	// RVA: -1 Offset: -1
	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F8100 Offset: 0x19F6700 VA: 0x1819F8100
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	// RVA: -1 Offset: -1
	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F8020 Offset: 0x19F6620 VA: 0x1819F8020
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/

}

internal static class FileSystemEnumerableHelpers // TypeDefIndex: 632
{	// Methods

	// RVA: 0x16245A0 Offset: 0x1622BA0 VA: 0x1816245A0
	internal static bool IsDir(Win32Native.WIN32_FIND_DATA data) { }

	// RVA: 0x1624620 Offset: 0x1622C20 VA: 0x181624620
	internal static bool IsFile(Win32Native.WIN32_FIND_DATA data) { }

}

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 633
{	// Fields
	internal MonoIOStat _data; // 0x18
	internal int _dataInitialised; // 0x40
	protected string FullPath; // 0x48
	protected string OriginalPath; // 0x50
	private string _displayPath; // 0x58

	// Properties
	public virtual string FullName { get; }
	public string Extension { get; }
	public abstract string Name { get; }
	public abstract bool Exists { get; }
	public DateTime CreationTime { get; set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public DateTime CreationTimeUtc { get; set; }
	public DateTime LastAccessTime { get; set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public DateTime LastAccessTimeUtc { get; set; }
	public DateTime LastWriteTime { get; set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public DateTime LastWriteTimeUtc { get; set; }
	public FileAttributes Attributes { get; }
	internal string DisplayPath { get; set; }

	// Methods

	// RVA: 0x1624750 Offset: 0x1622D50 VA: 0x181624750
	protected void .ctor() { }

	// RVA: 0x16247A0 Offset: 0x1622DA0 VA: 0x1816247A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 7
	public virtual string get_FullName() { }

	// RVA: 0x1624A80 Offset: 0x1623080 VA: 0x181624A80
	public string get_Extension() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_Exists();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Delete();

	// RVA: 0x16249E0 Offset: 0x1622FE0 VA: 0x1816249E0
	public DateTime get_CreationTime() { }

	// RVA: 0x1624EC0 Offset: 0x16234C0 VA: 0x181624EC0
	public void set_CreationTime(DateTime value) { }

	// RVA: 0x1624950 Offset: 0x1622F50 VA: 0x181624950
	public DateTime get_CreationTimeUtc() { }

	// RVA: 0x1624E30 Offset: 0x1623430 VA: 0x181624E30
	public void set_CreationTimeUtc(DateTime value) { }

	// RVA: 0x1624C60 Offset: 0x1623260 VA: 0x181624C60
	public DateTime get_LastAccessTime() { }

	// RVA: 0x1624FF0 Offset: 0x16235F0 VA: 0x181624FF0
	public void set_LastAccessTime(DateTime value) { }

	// RVA: 0x1624BD0 Offset: 0x16231D0 VA: 0x181624BD0
	public DateTime get_LastAccessTimeUtc() { }

	// RVA: 0x1624F60 Offset: 0x1623560 VA: 0x181624F60
	public void set_LastAccessTimeUtc(DateTime value) { }

	// RVA: 0x1624D90 Offset: 0x1623390 VA: 0x181624D90
	public DateTime get_LastWriteTime() { }

	// RVA: 0x1625120 Offset: 0x1623720 VA: 0x181625120
	public void set_LastWriteTime(DateTime value) { }

	// RVA: 0x1624D00 Offset: 0x1623300 VA: 0x181624D00
	public DateTime get_LastWriteTimeUtc() { }

	// RVA: 0x1625090 Offset: 0x1623690 VA: 0x181625090
	public void set_LastWriteTimeUtc(DateTime value) { }

	// RVA: 0x1624720 Offset: 0x1622D20 VA: 0x181624720
	public void Refresh() { }

	// RVA: 0x1624900 Offset: 0x1622F00 VA: 0x181624900
	public FileAttributes get_Attributes() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1624640 Offset: 0x1622C40 VA: 0x181624640 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal string get_DisplayPath() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	internal void set_DisplayPath(string value) { }

}

public static class File // TypeDefIndex: 663
{	// Fields
	private static Nullable<DateTime> defaultLocalFileTime; // 0x2B111C8

	// Properties
	private static DateTime DefaultLocalFileTime { get; }

	// Methods

	// RVA: 0x137BF60 Offset: 0x137A560 VA: 0x18137BF60
	public static void AppendAllText(string path, string contents) { }

	// RVA: 0x137C720 Offset: 0x137AD20 VA: 0x18137C720
	public static void Copy(string sourceFileName, string destFileName) { }

	// RVA: 0x137C060 Offset: 0x137A660 VA: 0x18137C060
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	// RVA: 0x137CF70 Offset: 0x137B570 VA: 0x18137CF70
	internal static string InternalCopy(string sourceFileName, string destFileName, bool overwrite, bool checkHost) { }

	// RVA: 0x137C7B0 Offset: 0x137ADB0 VA: 0x18137C7B0
	public static FileStream Create(string path) { }

	// RVA: 0x137C730 Offset: 0x137AD30 VA: 0x18137C730
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x137C820 Offset: 0x137AE20 VA: 0x18137C820
	public static void Delete(string path) { }

	// RVA: 0x137CA60 Offset: 0x137B060 VA: 0x18137CA60
	public static bool Exists(string path) { }

	// RVA: 0x137CC30 Offset: 0x137B230 VA: 0x18137CC30
	public static FileAttributes GetAttributes(string path) { }

	// RVA: 0x137CD10 Offset: 0x137B310 VA: 0x18137CD10
	public static DateTime GetCreationTime(string path) { }

	// RVA: 0x137CE40 Offset: 0x137B440 VA: 0x18137CE40
	public static DateTime GetLastWriteTime(string path) { }

	// RVA: 0x137D0F0 Offset: 0x137B6F0 VA: 0x18137D0F0
	public static void Move(string sourceFileName, string destFileName) { }

	// RVA: 0x137D670 Offset: 0x137BC70 VA: 0x18137D670
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x137D5A0 Offset: 0x137BBA0 VA: 0x18137D5A0
	public static FileStream OpenRead(string path) { }

	// RVA: 0x137D610 Offset: 0x137BC10 VA: 0x18137D610
	public static StreamReader OpenText(string path) { }

	// RVA: 0x137DB10 Offset: 0x137C110 VA: 0x18137DB10
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x137BDB0 Offset: 0x137A3B0 VA: 0x18137BDB0
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x137DC60 Offset: 0x137C260 VA: 0x18137DC60
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x137BDF0 Offset: 0x137A3F0 VA: 0x18137BDF0
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x137DDB0 Offset: 0x137C3B0 VA: 0x18137DDB0
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x137BE30 Offset: 0x137A430 VA: 0x18137BE30
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x137D6F0 Offset: 0x137BCF0 VA: 0x18137D6F0
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x137D8E0 Offset: 0x137BEE0 VA: 0x18137D8E0
	public static string ReadAllText(string path) { }

	// RVA: 0x137DF00 Offset: 0x137C500 VA: 0x18137DF00
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x137E050 Offset: 0x137C650 VA: 0x18137E050
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x137E0C0 Offset: 0x137C6C0 VA: 0x18137E0C0
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x137E1C0 Offset: 0x137C7C0 VA: 0x18137E1C0
	private static DateTime get_DefaultLocalFileTime() { }

	// RVA: 0x137D9F0 Offset: 0x137BFF0 VA: 0x18137D9F0
	public static IEnumerable<string> ReadLines(string path) { }

	[IteratorStateMachineAttribute] // RVA: 0xA7340 Offset: 0xA6740 VA: 0x1800A7340
	// RVA: 0x137DAA0 Offset: 0x137C0A0 VA: 0x18137DAA0
	private static IEnumerable<string> ReadLines(StreamReader reader) { }

	// RVA: 0x137CB40 Offset: 0x137B140 VA: 0x18137CB40
	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }

}

private sealed class File.<ReadLines>d__58 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 664
{	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private StreamReader reader; // 0x28
	public StreamReader <>3__reader; // 0x30
	private string <s>5__1; // 0x38
	private StreamReader <>7__wrap1; // 0x40

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636E00 Offset: 0x1635400 VA: 0x181636E00 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1636BD0 Offset: 0x16351D0 VA: 0x181636BD0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1636EB0 Offset: 0x16354B0 VA: 0x181636EB0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636DB0 Offset: 0x16353B0 VA: 0x181636DB0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636D10 Offset: 0x1635310 VA: 0x181636D10 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636D10 Offset: 0x1635310 VA: 0x181636D10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public enum FileAccess // TypeDefIndex: 665
{	// Fields
	public int value__; // 0x0
	public const FileAccess Read = 1;
	public const FileAccess Write = 2;
	public const FileAccess ReadWrite = 3;

}

public enum FileAttributes // TypeDefIndex: 666
{	// Fields
	public int value__; // 0x0
	public const FileAttributes Archive = 32;
	public const FileAttributes Compressed = 2048;
	public const FileAttributes Device = 64;
	public const FileAttributes Directory = 16;
	public const FileAttributes Encrypted = 16384;
	public const FileAttributes Hidden = 2;
	public const FileAttributes Normal = 128;
	public const FileAttributes NotContentIndexed = 8192;
	public const FileAttributes Offline = 4096;
	public const FileAttributes ReadOnly = 1;
	public const FileAttributes ReparsePoint = 1024;
	public const FileAttributes SparseFile = 512;
	public const FileAttributes System = 4;
	public const FileAttributes Temporary = 256;
	public const FileAttributes IntegrityStream = 32768;
	public const FileAttributes NoScrubData = 131072;

}

public enum FileMode // TypeDefIndex: 667
{	// Fields
	public int value__; // 0x0
	public const FileMode CreateNew = 1;
	public const FileMode Create = 2;
	public const FileMode Open = 3;
	public const FileMode OpenOrCreate = 4;
	public const FileMode Truncate = 5;
	public const FileMode Append = 6;

}

public enum FileOptions // TypeDefIndex: 668
{	// Fields
	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions Encrypted = 16384;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions WriteThrough = -2147483648;

}

public enum FileShare // TypeDefIndex: 669
{	// Fields
	public int value__; // 0x0
	public const FileShare None = 0;
	public const FileShare Read = 1;
	public const FileShare Write = 2;
	public const FileShare ReadWrite = 3;
	public const FileShare Delete = 4;
	public const FileShare Inheritable = 16;

}

public class FileStream : Stream // TypeDefIndex: 670
{	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	// RVA: 0x16236A0 Offset: 0x1621CA0 VA: 0x1816236A0
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1623620 Offset: 0x1621C20 VA: 0x181623620
	public void .ctor(string path, FileMode mode) { }

	// RVA: 0x16233D0 Offset: 0x16219D0 VA: 0x1816233D0
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x1623670 Offset: 0x1621C70 VA: 0x181623670
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x1623420 Offset: 0x1621A20 VA: 0x181623420
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x1623460 Offset: 0x1621A60 VA: 0x181623460
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x1624040 Offset: 0x1622640 VA: 0x181624040
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x16234B0 Offset: 0x1621AB0 VA: 0x1816234B0
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x1623560 Offset: 0x1621B60 VA: 0x181623560
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x16233B0 Offset: 0x16219B0 VA: 0x1816233B0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	// RVA: 0x1623350 Offset: 0x1621950 VA: 0x181623350
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x1623820 Offset: 0x1621E20 VA: 0x181623820
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x1621CE0 Offset: 0x16202E0 VA: 0x181621CE0
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1624080 Offset: 0x1622680 VA: 0x181624080 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16240A0 Offset: 0x16226A0 VA: 0x1816240A0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1624090 Offset: 0x1622690 VA: 0x181624090 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	// RVA: 0x16240C0 Offset: 0x16226C0 VA: 0x1816240C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1624240 Offset: 0x1622840 VA: 0x181624240 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1624410 Offset: 0x1622A10 VA: 0x181624410 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16243D0 Offset: 0x16229D0 VA: 0x1816243D0 Slot: 31
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x16215F0 Offset: 0x161FBF0 VA: 0x1816215F0
	private void ExposeHandle() { }

	// RVA: 0x1622010 Offset: 0x1620610 VA: 0x181622010 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1622C80 Offset: 0x1621280 VA: 0x181622C80 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1622450 Offset: 0x1620A50 VA: 0x181622450 Slot: 27
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x16222C0 Offset: 0x16208C0 VA: 0x1816222C0
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x16208E0 Offset: 0x161EEE0 VA: 0x1816208E0 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x16212F0 Offset: 0x161F8F0 VA: 0x1816212F0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16230B0 Offset: 0x16216B0 VA: 0x1816230B0 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1622DF0 Offset: 0x16213F0 VA: 0x181622DF0
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x1620BD0 Offset: 0x161F1D0 VA: 0x181620BD0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x1621480 Offset: 0x161FA80 VA: 0x181621480 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x16227A0 Offset: 0x1620DA0 VA: 0x1816227A0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1622A30 Offset: 0x1621030 VA: 0x181622A30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1621830 Offset: 0x161FE30 VA: 0x181621830 Slot: 18
	public override void Flush() { }

	// RVA: 0xFFA990 Offset: 0xFF8F90 VA: 0x180FFA990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1620FB0 Offset: 0x161F5B0 VA: 0x181620FB0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1622000 Offset: 0x1620600 VA: 0x181622000 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1622C70 Offset: 0x1621270 VA: 0x181622C70 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1622390 Offset: 0x1620990 VA: 0x181622390
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x1623040 Offset: 0x1621640 VA: 0x181623040
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x1621630 Offset: 0x161FC30 VA: 0x181621630
	private void FlushBuffer() { }

	// RVA: 0x1621620 Offset: 0x161FC20 VA: 0x181621620
	private void FlushBufferIfDirty() { }

	// RVA: 0x1622760 Offset: 0x1620D60 VA: 0x181622760
	private void RefillBuffer() { }

	// RVA: 0x1622180 Offset: 0x1620780 VA: 0x181622180
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x1621A50 Offset: 0x1620050 VA: 0x181621A50
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x16218B0 Offset: 0x161FEB0 VA: 0x1816218B0
	private string GetSecureFileName(string filename) { }

	// RVA: 0x1621990 Offset: 0x161FF90 VA: 0x181621990
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x16232F0 Offset: 0x16218F0 VA: 0x1816232F0
	private static void .cctor() { }

}

private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 671
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13491A0 Offset: 0x13477A0 VA: 0x1813491A0 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x162E7D0 Offset: 0x162CDD0 VA: 0x18162E7D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 672
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349EB0 Offset: 0x13484B0 VA: 0x181349EB0 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x16387D0 Offset: 0x1636DD0 VA: 0x1816387D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 673
{	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1620810 Offset: 0x161EE10 VA: 0x181620810
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x1620730 Offset: 0x161ED30 VA: 0x181620730
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0 Slot: 4
	public bool get_IsCompleted() { }

}

internal class FileData // TypeDefIndex: 2840
{	// Fields
	public string Directory; // 0x10
	public FileAttributes Attributes; // 0x18
	public bool NotExists; // 0x1C
	public DateTime CreationTime; // 0x20
	public DateTime LastWriteTime; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal enum FileAction // TypeDefIndex: 2844
{	// Fields
	public int value__; // 0x0
	public const FileAction Added = 1;
	public const FileAction Removed = 2;
	public const FileAction Modified = 3;
	public const FileAction RenamedOldName = 4;
	public const FileAction RenamedNewName = 5;

}

public class FileSystemEventArgs : EventArgs // TypeDefIndex: 2845
{	// Fields
	private WatcherChangeTypes changeType; // 0x10
	private string directory; // 0x18
	private string name; // 0x20

	// Properties
	public string FullPath { get; }

	// Methods

	// RVA: 0x152FD40 Offset: 0x152E340 VA: 0x18152FD40
	public void .ctor(WatcherChangeTypes changeType, string directory, string name) { }

	// RVA: 0x152FDE0 Offset: 0x152E3E0 VA: 0x18152FDE0
	public string get_FullPath() { }

}

public sealed class FileSystemEventHandler : MulticastDelegate // TypeDefIndex: 2846
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, FileSystemEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, FileSystemEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class FileSystemWatcher : Component // TypeDefIndex: 2847
{	// Fields
	private bool enableRaisingEvents; // 0x28
	private string filter; // 0x30
	private bool includeSubdirectories; // 0x38
	private int internalBufferSize; // 0x3C
	private NotifyFilters notifyFilter; // 0x40
	private string path; // 0x48
	private string fullpath; // 0x50
	private ISynchronizeInvoke synchronizingObject; // 0x58
	private WaitForChangedResult lastData; // 0x60
	private bool waiting; // 0x80
	private SearchPattern2 pattern; // 0x88
	private bool disposed; // 0x90
	private string mangledFilter; // 0x98
	private static IFileWatcher watcher; // 0x0
	private static object lockobj; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FileSystemEventHandler Changed; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FileSystemEventHandler Created; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FileSystemEventHandler Deleted; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ErrorEventHandler Error; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RenamedEventHandler Renamed; // 0xC0

	// Properties
	internal bool Waiting { get; set; }
	internal string MangledFilter { get; }
	internal SearchPattern2 Pattern { get; }
	internal string FullPath { get; }
	[IODescriptionAttribute] // RVA: 0xB1FC0 Offset: 0xB13C0 VA: 0x1800B1FC0
	[DefaultValueAttribute] // RVA: 0xB1FC0 Offset: 0xB13C0 VA: 0x1800B1FC0
	public bool EnableRaisingEvents { set; }
	[SettingsBindableAttribute] // RVA: 0xB2180 Offset: 0xB1580 VA: 0x1800B2180
	[TypeConverterAttribute] // RVA: 0xB2180 Offset: 0xB1580 VA: 0x1800B2180
	[DefaultValueAttribute] // RVA: 0xB2180 Offset: 0xB1580 VA: 0x1800B2180
	[IODescriptionAttribute] // RVA: 0xB2180 Offset: 0xB1580 VA: 0x1800B2180
	public string Filter { set; }
	[DefaultValueAttribute] // RVA: 0xB24C0 Offset: 0xB18C0 VA: 0x1800B24C0
	[IODescriptionAttribute] // RVA: 0xB24C0 Offset: 0xB18C0 VA: 0x1800B24C0
	public bool IncludeSubdirectories { get; }
	[IODescriptionAttribute] // RVA: 0xB25D0 Offset: 0xB19D0 VA: 0x1800B25D0
	[DefaultValueAttribute] // RVA: 0xB25D0 Offset: 0xB19D0 VA: 0x1800B25D0
	public NotifyFilters NotifyFilter { set; }
	[DefaultValueAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[IODescriptionAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[EditorAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[SettingsBindableAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	[TypeConverterAttribute] // RVA: 0xB2960 Offset: 0xB1D60 VA: 0x1800B2960
	public string Path { set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public override ISite Site { get; }

	// Methods

	// RVA: 0x1530B10 Offset: 0x152F110 VA: 0x181530B10
	public void .ctor() { }

	// RVA: 0x15301D0 Offset: 0x152E7D0 VA: 0x1815301D0
	private void InitWatcher() { }

	// RVA: 0x1230CD0 Offset: 0x122F2D0 VA: 0x181230CD0
	internal bool get_Waiting() { }

	// RVA: 0x7AF000 Offset: 0x7AD600 VA: 0x1807AF000
	internal void set_Waiting(bool value) { }

	// RVA: 0x1530CF0 Offset: 0x152F2F0 VA: 0x181530CF0
	internal string get_MangledFilter() { }

	// RVA: 0x1530D50 Offset: 0x152F350 VA: 0x181530D50
	internal SearchPattern2 get_Pattern() { }

	// RVA: 0x1530C50 Offset: 0x152F250 VA: 0x181530C50
	internal string get_FullPath() { }

	// RVA: 0x1530EE0 Offset: 0x152F4E0 VA: 0x181530EE0
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x1530F00 Offset: 0x152F500 VA: 0x181530F00
	public void set_Filter(string value) { }

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_IncludeSubdirectories() { }

	// RVA: 0x1530FB0 Offset: 0x152F5B0 VA: 0x181530FB0
	public void set_NotifyFilter(NotifyFilters value) { }

	// RVA: 0x1530FF0 Offset: 0x152F5F0 VA: 0x181530FF0
	public void set_Path(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public override ISite get_Site() { }

	// RVA: 0x15300F0 Offset: 0x152E6F0 VA: 0x1815300F0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1530130 Offset: 0x152E730 VA: 0x181530130 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15305A0 Offset: 0x152EBA0 VA: 0x1815305A0
	private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype) { }

	// RVA: 0x15304E0 Offset: 0x152EAE0 VA: 0x1815304E0
	protected void OnChanged(FileSystemEventArgs e) { }

	// RVA: 0x1530510 Offset: 0x152EB10 VA: 0x181530510
	protected void OnCreated(FileSystemEventArgs e) { }

	// RVA: 0x1530540 Offset: 0x152EB40 VA: 0x181530540
	protected void OnDeleted(FileSystemEventArgs e) { }

	// RVA: 0x1530570 Offset: 0x152EB70 VA: 0x181530570
	protected void OnRenamed(RenamedEventArgs e) { }

	// RVA: 0x152FE50 Offset: 0x152E450 VA: 0x18152FE50
	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	// RVA: 0x15309B0 Offset: 0x152EFB0 VA: 0x1815309B0
	private void Start() { }

	// RVA: 0x1530A30 Offset: 0x152F030 VA: 0x181530A30
	private void Stop() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1530BB0 Offset: 0x152F1B0 VA: 0x181530BB0
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1530E40 Offset: 0x152F440 VA: 0x181530E40
	public void remove_Changed(FileSystemEventHandler value) { }

	// RVA: 0x10DE040 Offset: 0x10DC640 VA: 0x1810DE040
	private static int InternalSupportsFSW() { }

	// RVA: 0x1530AB0 Offset: 0x152F0B0 VA: 0x181530AB0
	private static void .cctor() { }

}

private enum FileSystemWatcher.EventType // TypeDefIndex: 2848
{	// Fields
	public int value__; // 0x0
	public const FileSystemWatcher.EventType FileSystemEvent = 0;
	public const FileSystemWatcher.EventType ErrorEvent = 1;
	public const FileSystemWatcher.EventType RenameEvent = 2;

}

public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 2948
{	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private bool m_preauthenticate; // 0x68
	private IWebProxy m_proxy; // 0x70
	private ManualResetEvent m_readerEvent; // 0x78
	private bool m_readPending; // 0x80
	private WebResponse m_response; // 0x88
	private Stream m_stream; // 0x90
	private bool m_syncHint; // 0x98
	private int m_timeout; // 0x9C
	private Uri m_uri; // 0xA0
	private bool m_writePending; // 0xA8
	private bool m_writing; // 0xA9
	private LazyAsyncResult m_WriteAResult; // 0xB0
	private LazyAsyncResult m_ReadAResult; // 0xB8
	private int m_Aborted; // 0xC0

	// Properties
	internal bool Aborted { get; }
	public override string ConnectionGroupName { set; }
	public override long ContentLength { get; set; }
	public override string ContentType { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; set; }

	// Methods

	// RVA: 0x1532D20 Offset: 0x1531320 VA: 0x181532D20
	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB4400 Offset: 0xB3800 VA: 0x1800B4400
	// RVA: 0x1532A40 Offset: 0x1531040 VA: 0x181532A40
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118E810 Offset: 0x118CE10 VA: 0x18118E810 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1531E10 Offset: 0x1530410 VA: 0x181531E10 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1532E70 Offset: 0x1531470 VA: 0x181532E70
	internal bool get_Aborted() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x1532F10 Offset: 0x1531510 VA: 0x181532F10 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x1532E80 Offset: 0x1531480 VA: 0x181532E80 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x1532FA0 Offset: 0x15315A0 VA: 0x181532FA0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1533000 Offset: 0x1531600 VA: 0x181533000 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x15330C0 Offset: 0x15316C0 VA: 0x1815330C0 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB9B540 Offset: 0xB99B40 VA: 0x180B9B540 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1531380 Offset: 0x152F980 VA: 0x181531380 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x15316D0 Offset: 0x152FCD0 VA: 0x1815316D0 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1531940 Offset: 0x152FF40 VA: 0x181531940
	private bool CanGetRequestStream() { }

	// RVA: 0x15319B0 Offset: 0x152FFB0 VA: 0x1815319B0 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1531BE0 Offset: 0x15301E0 VA: 0x181531BE0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x15321E0 Offset: 0x15307E0 VA: 0x1815321E0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x15326C0 Offset: 0x1530CC0 VA: 0x1815326C0 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x1531FE0 Offset: 0x15305E0 VA: 0x181531FE0
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x15323F0 Offset: 0x15309F0 VA: 0x1815323F0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x15328D0 Offset: 0x1530ED0 VA: 0x1815328D0
	internal void UnblockReader() { }

	// RVA: 0x1532ED0 Offset: 0x15314D0 VA: 0x181532ED0 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x15330D0 Offset: 0x15316D0 VA: 0x1815330D0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1531130 Offset: 0x152F730 VA: 0x181531130 Slot: 35
	public override void Abort() { }

	// RVA: 0x1532990 Offset: 0x1530F90 VA: 0x181532990
	private static void .cctor() { }

}

internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 2949
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x132FF60 Offset: 0x132E560 VA: 0x18132FF60 Slot: 4
	public WebRequest Create(Uri uri) { }

}

internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 2950
{	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1330E70 Offset: 0x132F470 VA: 0x181330E70
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1330DB0 Offset: 0x132F3B0 VA: 0x181330DB0
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1330A60 Offset: 0x132F060 VA: 0x181330A60 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1330CC0 Offset: 0x132F2C0 VA: 0x181330CC0 Slot: 32
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1330C20 Offset: 0x132F220 VA: 0x181330C20 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1330D10 Offset: 0x132F310 VA: 0x181330D10 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1330860 Offset: 0x132EE60 VA: 0x181330860 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1330B20 Offset: 0x132F120 VA: 0x181330B20 Slot: 20
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1330910 Offset: 0x132EF10 VA: 0x181330910 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1330BA0 Offset: 0x132F1A0 VA: 0x181330BA0 Slot: 23
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x13309C0 Offset: 0x132EFC0 VA: 0x1813309C0
	private void CheckError() { }

}

public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 2951
{	// Fields
	private bool m_closed; // 0x18
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x1330570 Offset: 0x132EB70 VA: 0x181330570
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0xB4400 Offset: 0xB3800 VA: 0x1800B4400
	// RVA: 0x13303B0 Offset: 0x132E9B0 VA: 0x1813303B0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1330090 Offset: 0x132E690 VA: 0x181330090 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1330800 Offset: 0x132EE00 VA: 0x181330800 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x1330820 Offset: 0x132EE20 VA: 0x181330820 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1330840 Offset: 0x132EE40 VA: 0x181330840 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x132FFC0 Offset: 0x132E5C0 VA: 0x18132FFC0
	private void CheckDisposed() { }

	// RVA: 0x1330050 Offset: 0x132E650 VA: 0x181330050 Slot: 9
	public override void Close() { }

	// RVA: 0x1330260 Offset: 0x132E860 VA: 0x181330260 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x13301D0 Offset: 0x132E7D0 VA: 0x1813301D0 Slot: 12
	public override Stream GetResponseStream() { }

}

internal struct FileDetailsResult_t : ICallbackData // TypeDefIndex: 5402
{	// Fields
	internal Result Result; // 0x0
	internal ulong FileSize; // 0x8
	internal byte[] FileSHA; // 0x10
	internal uint Flags; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5720 Offset: 0x1E4B20 VA: 0x1801E5720 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5710 Offset: 0x1E4B10 VA: 0x1801E5710 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13706D0 Offset: 0x136ECD0 VA: 0x1813706D0
	private static void .cctor() { }

}

public class FileStorageCacheData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6465
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public byte[] data; // 0x18
	public uint entityId; // 0x20
	public uint numId; // 0x24
	public uint crc; // 0x28

	// Methods

	// RVA: 0x1D59C40 Offset: 0x1D58240 VA: 0x181D59C40
	public static void ResetToPool(FileStorageCacheData instance) { }

	// RVA: 0x1D59CF0 Offset: 0x1D582F0 VA: 0x181D59CF0
	public void ResetToPool() { }

	// RVA: 0x1D598D0 Offset: 0x1D57ED0 VA: 0x181D598D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D585C0 Offset: 0x1D56BC0 VA: 0x181D585C0
	public void CopyTo(FileStorageCacheData instance) { }

	// RVA: 0x1D58680 Offset: 0x1D56C80 VA: 0x181D58680
	public FileStorageCacheData Copy() { }

	// RVA: 0x1D59070 Offset: 0x1D57670 VA: 0x181D59070
	public static FileStorageCacheData Deserialize(Stream stream) { }

	// RVA: 0x1D58A70 Offset: 0x1D57070 VA: 0x181D58A70
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D58AF0 Offset: 0x1D570F0 VA: 0x181D58AF0
	public static FileStorageCacheData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D592D0 Offset: 0x1D578D0 VA: 0x181D592D0
	public static FileStorageCacheData Deserialize(byte[] buffer) { }

	// RVA: 0x1D59A00 Offset: 0x1D58000 VA: 0x181D59A00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5A350 Offset: 0x1D58950 VA: 0x181D5A350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5A370 Offset: 0x1D58970 VA: 0x181D5A370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FileStorageCacheData previous) { }

	// RVA: 0x1D59C20 Offset: 0x1D58220 VA: 0x181D59C20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D595E0 Offset: 0x1D57BE0 VA: 0x181D595E0
	public static FileStorageCacheData Deserialize(byte[] buffer, FileStorageCacheData instance, bool isDelta = False) { }

	// RVA: 0x1D58E50 Offset: 0x1D57450 VA: 0x181D58E50
	public static FileStorageCacheData Deserialize(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D58780 Offset: 0x1D56D80 VA: 0x181D58780
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D58B80 Offset: 0x1D57180 VA: 0x181D58B80
	public static FileStorageCacheData DeserializeLength(Stream stream, int length, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D59DA0 Offset: 0x1D583A0 VA: 0x181D59DA0
	public static void SerializeDelta(Stream stream, FileStorageCacheData instance, FileStorageCacheData previous) { }

	// RVA: 0x1D5A190 Offset: 0x1D58790 VA: 0x181D5A190
	public static void Serialize(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x1D5A340 Offset: 0x1D58940 VA: 0x181D5A340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5A350 Offset: 0x1D58950 VA: 0x181D5A350
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5A080 Offset: 0x1D58680 VA: 0x181D5A080
	public static byte[] SerializeToBytes(FileStorageCacheData instance) { }

	// RVA: 0x1D59FD0 Offset: 0x1D585D0 VA: 0x181D59FD0
	public static void SerializeLengthDelimited(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public static class FileSystem // TypeDefIndex: 6659
{	// Fields
	public static bool LogDebug; // 0x0
	public static bool LogTime; // 0x1
	public static FileSystemBackend Backend; // 0x8

	// Methods

	// RVA: 0x22BDFC0 Offset: 0x22BC5C0 VA: 0x1822BDFC0
	public static GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22BDEB0 Offset: 0x22BC4B0 VA: 0x1822BDEB0
	public static GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22BDE20 Offset: 0x22BC420 VA: 0x1822BDE20
	public static string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38F80 Offset: 0x1A37580 VA: 0x181A38F80
	|-FileSystem.LoadAll<Sprite>
	|-FileSystem.LoadAll<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38EC0 Offset: 0x1A374C0 VA: 0x181A38EC0
	|-FileSystem.LoadAllFromBundle<Skinnable>
	|-FileSystem.LoadAllFromBundle<GameObject>
	|-FileSystem.LoadAllFromBundle<object>
	*/

	// RVA: -1 Offset: -1
	public static T Load<T>(string filePath, bool complain = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD8B0 Offset: 0x5CBEB0 VA: 0x1805CD8B0
	|-FileSystem.Load<GameManifest>
	|-FileSystem.Load<ItemSkin>
	|-FileSystem.Load<ItemSkinDirectory>
	|-FileSystem.Load<SoundDefinition>
	|-FileSystem.Load<SteamInventoryItem>
	|-FileSystem.Load<Font>
	|-FileSystem.Load<GameObject>
	|-FileSystem.Load<Material>
	|-FileSystem.Load<Object>
	|-FileSystem.Load<Sprite>
	|-FileSystem.Load<TextAsset>
	|-FileSystem.Load<Texture>
	|-FileSystem.Load<object>
	*/

	// RVA: 0x22BE130 Offset: 0x22BC730 VA: 0x1822BE130
	public static AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority = 0) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public abstract class FileSystemBackend // TypeDefIndex: 6660
{	// Fields
	public bool isError; // 0x10
	public string loadingError; // 0x18
	public Dictionary<string, Object> cache; // 0x20

	// Methods

	// RVA: 0x22BD780 Offset: 0x22BBD80 VA: 0x1822BD780
	public GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22BD6C0 Offset: 0x22BBCC0 VA: 0x1822BD6C0
	public GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22BD620 Offset: 0x22BBC20 VA: 0x1822BD620
	public string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38D60 Offset: 0x1A37360 VA: 0x181A38D60
	|-FileSystemBackend.LoadAll<object>
	|-FileSystemBackend.LoadAll<GameObject>
	*/

	// RVA: -1 Offset: -1
	public T Load<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD720 Offset: 0x5CBD20 VA: 0x1805CD720
	|-FileSystemBackend.Load<object>
	|-FileSystemBackend.Load<GameObject>
	*/

	// RVA: 0x22BD8A0 Offset: 0x22BBEA0 VA: 0x1822BD8A0
	public AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BD640 Offset: 0x22BBC40 VA: 0x1822BD640
	protected void LoadError(string err) { }

	// RVA: 0x22BDCD0 Offset: 0x22BC2D0 VA: 0x1822BDCD0 Slot: 4
	public virtual List<string> UnloadBundles(string partialName) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract T LoadAsset<T>(string filePath);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemBackend.LoadAsset<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string[] LoadAssetList(string folder, string search);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract T[] LoadAllFromBundle<T>(string bundleName, string editorSearch);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemBackend.LoadAllFromBundle<object>
	*/

	// RVA: 0x22BDD20 Offset: 0x22BC320 VA: 0x1822BDD20
	protected void .ctor() { }

}

public class FileDialog : MonoBehaviour // TypeDefIndex: 7066
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string result; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FileDialog.FileDialogMode mode; // 0x20
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool finished; // 0x24
	[HeaderAttribute] // RVA: 0x77BD0 Offset: 0x76FD0 VA: 0x180077BD0
	public Image windowIcon; // 0x28
	public Text windowName; // 0x30
	public InputField currentPath; // 0x38
	public InputField fileName; // 0x40
	public Button up; // 0x48
	public Button commit; // 0x50
	public Button cancel; // 0x58
	public GameObject filesScrollRectContent; // 0x60
	public GameObject drivesScrollRectContent; // 0x68
	[HeaderAttribute] // RVA: 0x77D40 Offset: 0x77140 VA: 0x180077D40
	public GameObject filesScrollRectElement; // 0x70
	public GameObject drivesScrollRectElement; // 0x78
	[HeaderAttribute] // RVA: 0x77E30 Offset: 0x77230 VA: 0x180077E30
	public Sprite folderIcon; // 0x80
	public Sprite fileIcon; // 0x88
	private string workingPath; // 0x90
	private string workingFile; // 0x98
	private string[] allowedExtensions; // 0xA0
	private long maxSize; // 0xA8
	private bool saveLastPath; // 0xB0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x77F90 Offset: 0x77390 VA: 0x180077F90
	// RVA: 0xFBF910 Offset: 0xFBDF10 VA: 0x180FBF910
	public IEnumerator Open(string path, string allowedExtensions, string windowName = "OPEN FILE", Sprite windowIcon, long maxSize = -1, bool saveLastPath = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x78190 Offset: 0x77590 VA: 0x180078190
	// RVA: 0xFBFB60 Offset: 0xFBE160 VA: 0x180FBFB60
	public IEnumerator Save(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x78300 Offset: 0x77700 VA: 0x180078300
	// RVA: 0xFBF9F0 Offset: 0xFBDFF0 VA: 0x180FBF9F0
	public Task<string> SaveAsync(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void Hide() { }

	// RVA: 0xFBF4E0 Offset: 0xFBDAE0 VA: 0x180FBF4E0
	public void GoUp() { }

	// RVA: 0xFBF260 Offset: 0xFBD860 VA: 0x180FBF260
	public void GoTo(string newPath) { }

	// RVA: 0xFBFC40 Offset: 0xFBE240 VA: 0x180FBFC40
	public void SelectFile(string file) { }

	// RVA: 0xFBF580 Offset: 0xFBDB80 VA: 0x180FBF580
	public void OnCommitClick() { }

	// RVA: 0xFBF530 Offset: 0xFBDB30 VA: 0x180FBF530
	public void OnCancelClick() { }

	// RVA: 0xFBF110 Offset: 0xFBD710 VA: 0x180FBF110
	public void ClearSelection() { }

	// RVA: 0xFBF790 Offset: 0xFBDD90 VA: 0x180FBF790
	public void OnTypedFilename(string newName) { }

	// RVA: 0xFBF660 Offset: 0xFBDC60 VA: 0x180FBF660
	public void OnTypedEnd(string newName) { }

	// RVA: 0xFC0140 Offset: 0xFBE740 VA: 0x180FC0140
	public void UpdateFileInfo() { }

	// RVA: 0xFBF820 Offset: 0xFBDE20 VA: 0x180FBF820
	public void OpenDir(string path) { }

	// RVA: 0xFC0110 Offset: 0xFBE710 VA: 0x180FC0110
	private void UpdateElements() { }

	// RVA: 0xFBFDB0 Offset: 0xFBE3B0 VA: 0x180FBFDB0
	private void UpdateDrivesList() { }

	// RVA: 0xFBF170 Offset: 0xFBD770 VA: 0x180FBF170
	private string GetFileSizeText(long size) { }

	// RVA: 0xFC0300 Offset: 0xFBE900 VA: 0x180FC0300
	private void UpdateFilesList() { }

	// RVA: 0xFC1480 Offset: 0xFBFA80 VA: 0x180FC1480
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFBFD30 Offset: 0xFBE330 VA: 0x180FBFD30
	private bool <UpdateFilesList>b__39_0(FileInfo f) { }

}

public enum FileDialog.FileDialogMode // TypeDefIndex: 7067
{	// Fields
	public int value__; // 0x0
	public const FileDialog.FileDialogMode Open = 0;
	public const FileDialog.FileDialogMode Save = 1;

}

private sealed class FileDialog.<Open>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7068
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FileDialog <>4__this; // 0x20
	public long maxSize; // 0x28
	public bool saveLastPath; // 0x30
	public string allowedExtensions; // 0x38
	public string path; // 0x40
	public string windowName; // 0x48
	public Sprite windowIcon; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFD6F40 Offset: 0xFD5540 VA: 0x180FD6F40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD7290 Offset: 0xFD5890 VA: 0x180FD7290 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FileDialog.<Save>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7069
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FileDialog <>4__this; // 0x20
	public bool saveLastPath; // 0x28
	public string allowedExtensions; // 0x30
	public string path; // 0x38
	public string windowName; // 0x40
	public Sprite windowIcon; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFD7750 Offset: 0xFD5D50 VA: 0x180FD7750 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD7A90 Offset: 0xFD6090 VA: 0x180FD7A90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct FileDialog.<SaveAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 7070
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public FileDialog <>4__this; // 0x20
	public bool saveLastPath; // 0x28
	public string allowedExtensions; // 0x30
	public string path; // 0x38
	public string windowName; // 0x40
	public Sprite windowIcon; // 0x48
	private TaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x14B960 Offset: 0x14AD60 VA: 0x18014B960 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B970 Offset: 0x14AD70 VA: 0x18014B970 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class FileListElement : MonoBehaviour // TypeDefIndex: 7071
{	// Fields
	public Image icon; // 0x18
	public Text elementName; // 0x20
	public Text size; // 0x28
	public FileDialog instance; // 0x30
	public bool isFile; // 0x38
	public string data; // 0x40

	// Methods

	// RVA: 0xFC14A0 Offset: 0xFBFAA0 VA: 0x180FC14A0
	public void OnClick() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

internal static class FileUtilities // TypeDefIndex: 7615
{	// Methods

	// RVA: 0x1398920 Offset: 0x1396F20 VA: 0x181398920
	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	// RVA: 0x1398BE0 Offset: 0x13971E0 VA: 0x181398BE0
	internal static FileStream OpenFileForRead(string filePath) { }

	// RVA: 0x1398A40 Offset: 0x1397040 VA: 0x181398A40
	private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition) { }

}

public class FileSystem_Warmup : MonoBehaviour // TypeDefIndex: 9371
{	// Fields
	public static bool ranInBackground; // 0x0
	private static bool run; // 0x1
	public static string[] ExcludeFilter; // 0x8

	// Methods

	// RVA: 0x7881C0 Offset: 0x7867C0 VA: 0x1807881C0
	public static void Run() { }

	// RVA: 0x788340 Offset: 0x786940 VA: 0x180788340
	public static IEnumerator Run(string[] assetList, Action<string> statusFunction, string format, int priority = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7C90 Offset: 0xE7090 VA: 0x1800E7C90
	// RVA: 0x788070 Offset: 0x786670 VA: 0x180788070
	private static IEnumerator RunAsyncImpl(string[] assetList, Action<string> statusFunction, string format, int priority) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7D60 Offset: 0xE7160 VA: 0x1800E7D60
	// RVA: 0x788120 Offset: 0x786720 VA: 0x180788120
	private static IEnumerator RunImpl(string[] assetList, Action<string> statusFunction, string format) { }

	// RVA: 0x787BE0 Offset: 0x7861E0 VA: 0x180787BE0
	private static float CalculateFrameBudget() { }

	// RVA: 0x7884F0 Offset: 0x786AF0 VA: 0x1807884F0
	private static bool ShouldIgnore(string path) { }

	// RVA: 0x787C10 Offset: 0x786210 VA: 0x180787C10
	public static string[] GetAssetList(Nullable<bool> poolFilter) { }

	// RVA: 0x787FF0 Offset: 0x7865F0 VA: 0x180787FF0
	private static void PrefabWarmup(string path) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x788620 Offset: 0x786C20 VA: 0x180788620
	private static void .cctor() { }

}

private sealed class FileSystem_Warmup.<RunAsyncImpl>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9372
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string[] assetList; // 0x20
	public int priority; // 0x28
	public Action<string> statusFunction; // 0x30
	public string format; // 0x38
	private Stopwatch <sw>5__2; // 0x40
	private AssetPreloadResult <preload>5__3; // 0x48
	private int <warmupIndex>5__4; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x799780 Offset: 0x797D80 VA: 0x180799780 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x799BC0 Offset: 0x7981C0 VA: 0x180799BC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FileSystem_Warmup.<RunImpl>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9373
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string[] assetList; // 0x20
	public Action<string> statusFunction; // 0x28
	public string format; // 0x30
	private Stopwatch <sw>5__2; // 0x38
	private int <i>5__3; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x799C10 Offset: 0x798210 VA: 0x180799C10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x799F70 Offset: 0x798570 VA: 0x180799F70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FileSystem_Warmup.<>c__DisplayClass9_0 // TypeDefIndex: 9374
{	// Fields
	public Nullable<bool> poolFilter; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A3B0 Offset: 0x7989B0 VA: 0x18079A3B0
	internal bool <GetAssetList>b__2(GameManifest.PrefabProperties x) { }

}

private sealed class FileSystem_Warmup.<>c // TypeDefIndex: 9375
{	// Fields
	public static readonly FileSystem_Warmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, string> <>9__9_0; // 0x8
	public static Func<string, bool> <>9__9_1; // 0x10
	public static Func<GameManifest.PrefabProperties, string> <>9__9_3; // 0x18

	// Methods

	// RVA: 0x79A570 Offset: 0x798B70 VA: 0x18079A570
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal string <GetAssetList>b__9_0(GameManifest.PrefabProperties x) { }

	// RVA: 0x799FC0 Offset: 0x7985C0 VA: 0x180799FC0
	internal bool <GetAssetList>b__9_1(string x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal string <GetAssetList>b__9_3(GameManifest.PrefabProperties x) { }

}

public class FileStorage : IDisposable // TypeDefIndex: 10719
{	// Fields
	private Database db; // 0x10
	private CRC32 crc; // 0x18
	private MruDictionary<uint, FileStorage.CacheData> _cache; // 0x20
	public static FileStorage client; // 0x0

	// Methods

	// RVA: 0x787B40 Offset: 0x786140 VA: 0x180787B40
	protected void .ctor(string name, bool server) { }

	// RVA: 0x7868D0 Offset: 0x784ED0 VA: 0x1807868D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x786890 Offset: 0x784E90 VA: 0x180786890 Slot: 4
	public void Dispose() { }

	// RVA: 0x786970 Offset: 0x784F70 VA: 0x180786970
	private uint GetCRC(byte[] data, FileStorage.Type type) { }

	// RVA: 0x787870 Offset: 0x785E70 VA: 0x180787870
	public uint Store(byte[] data, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x786CF0 Offset: 0x7852F0 VA: 0x180786CF0
	public byte[] Get(uint crc, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x787580 Offset: 0x785B80 VA: 0x180787580
	public void Remove(uint crc, FileStorage.Type type, uint entityID) { }

	// RVA: 0x787440 Offset: 0x785A40 VA: 0x180787440
	public void RemoveExact(uint crc, FileStorage.Type type, uint entityID, uint numid) { }

	// RVA: 0x787180 Offset: 0x785780 VA: 0x180787180
	public void RemoveEntityNum(uint entityid, uint numid) { }

	// RVA: 0x787090 Offset: 0x785690 VA: 0x180787090
	internal void RemoveAllByEntity(uint entityid) { }

	// RVA: 0x786F90 Offset: 0x785590 VA: 0x180786F90
	public void ReassignEntityId(uint oldId, uint newId) { }

	// RVA: 0x786AE0 Offset: 0x7850E0 VA: 0x180786AE0
	public List<FileStorageCacheData> GetCacheData() { }

	// RVA: 0x7876B0 Offset: 0x785CB0 VA: 0x1807876B0
	public void SetCache(List<FileStorageCacheData> data) { }

	// RVA: 0x786840 Offset: 0x784E40 VA: 0x180786840
	public void ClearCache() { }

	// RVA: 0x787A30 Offset: 0x786030 VA: 0x180787A30
	private static void .cctor() { }

}

private class FileStorage.CacheData // TypeDefIndex: 10720
{	// Fields
	public byte[] data; // 0x10
	public uint entityID; // 0x18
	public uint numID; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum FileStorage.Type // TypeDefIndex: 10721
{	// Fields
	public int value__; // 0x0
	public const FileStorage.Type png = 0;
	public const FileStorage.Type jpg = 1;
	public const FileStorage.Type ogg = 2;

}

private sealed class FileStorage.<>c__DisplayClass14_0 // TypeDefIndex: 10722
{	// Fields
	public uint entityid; // 0x10
	public uint numid; // 0x14
	public Func<KeyValuePair<uint, FileStorage.CacheData>, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A2D0 Offset: 0x7988D0 VA: 0x18079A2D0
	internal bool <RemoveEntityNum>b__0(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

private sealed class FileStorage.<>c // TypeDefIndex: 10723
{	// Fields
	public static readonly FileStorage.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, FileStorage.CacheData>, uint> <>9__14_1; // 0x8

	// Methods

	// RVA: 0x79A4B0 Offset: 0x798AB0 VA: 0x18079A4B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A260 Offset: 0x798860 VA: 0x18079A260
	internal uint <RemoveEntityNum>b__14_1(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

public static class FileEx // TypeDefIndex: 11346
{	// Methods

	// RVA: 0x786420 Offset: 0x784A20 VA: 0x180786420
	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x786790 Offset: 0x784D90 VA: 0x180786790
	public static bool MoveToSafe(FileInfo parent, string target, int retries = 10) { }

	// RVA: 0x786550 Offset: 0x784B50 VA: 0x180786550
	public static void Backup(string[] names) { }

}

public class FileConVar : ConsoleSystem // TypeDefIndex: 11922
{	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool time { get; set; }

	// Methods

	// RVA: 0x6E0570 Offset: 0x6DEB70 VA: 0x1806E0570
	public static bool get_debug() { }

	// RVA: 0x6E0630 Offset: 0x6DEC30 VA: 0x1806E0630
	public static void set_debug(bool value) { }

	// RVA: 0x6E05D0 Offset: 0x6DEBD0 VA: 0x1806E05D0
	public static bool get_time() { }

	// RVA: 0x6E0690 Offset: 0x6DEC90 VA: 0x1806E0690
	public static void set_time(bool value) { }

	// RVA: 0x6E0510 Offset: 0x6DEB10 VA: 0x1806E0510
	public void .ctor() { }

}

