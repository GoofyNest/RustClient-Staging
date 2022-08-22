internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 482
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE7EE0 Offset: 0xFE64E0 VA: 0x180FE7EE0 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE7E20 Offset: 0xFE6420 VA: 0x180FE7E20
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0xFE7AA0 Offset: 0xFE60A0 VA: 0x180FE7AA0
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

	// RVA: 0x160C730 Offset: 0x160AD30 VA: 0x18160C730
	public void .ctor(string fileName) { }

	// RVA: 0x160C2B0 Offset: 0x160A8B0 VA: 0x18160C2B0
	private void Init(string fileName, bool checkHost) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	private string GetDisplayPath(string originalPath) { }

	// RVA: 0x160C8D0 Offset: 0x160AED0 VA: 0x18160C8D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x160C630 Offset: 0x160AC30 VA: 0x18160C630
	internal void .ctor(string fullPath, bool ignoreThis) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x160CC30 Offset: 0x160B230 VA: 0x18160CC30
	public long get_Length() { }

	// RVA: 0x160CAA0 Offset: 0x160B0A0 VA: 0x18160CAA0
	public string get_DirectoryName() { }

	// RVA: 0x160CB00 Offset: 0x160B100 VA: 0x18160CB00
	public DirectoryInfo get_Directory() { }

	// RVA: 0x160C080 Offset: 0x160A680 VA: 0x18160C080
	public StreamWriter CreateText() { }

	// RVA: 0x160BE40 Offset: 0x160A440 VA: 0x18160BE40
	public StreamWriter AppendText() { }

	// RVA: 0x160BEA0 Offset: 0x160A4A0 VA: 0x18160BEA0
	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	// RVA: 0x160C0E0 Offset: 0x160A6E0 VA: 0x18160C0E0 Slot: 10
	public override void Delete() { }

	// RVA: 0x160CBB0 Offset: 0x160B1B0 VA: 0x18160CBB0 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x160C3A0 Offset: 0x160A9A0 VA: 0x18160C3A0
	public void MoveTo(string destFileName) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 3
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

	// RVA: 0x160D1A0 Offset: 0x160B7A0 VA: 0x18160D1A0
	public void .ctor() { }

	// RVA: 0x160D160 Offset: 0x160B760 VA: 0x18160D160
	public void .ctor(string message) { }

	// RVA: 0x160D300 Offset: 0x160B900 VA: 0x18160D300 Slot: 5
	public override string get_Message() { }

	// RVA: 0x160CE50 Offset: 0x160B450 VA: 0x18160CE50
	private void SetMessageField() { }

	// RVA: 0x160CEE0 Offset: 0x160B4E0 VA: 0x18160CEE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x160D210 Offset: 0x160B810 VA: 0x18160D210
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public string get_FusionLog() { }

	// RVA: 0x160CD10 Offset: 0x160B310 VA: 0x18160CD10 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x160CCA0 Offset: 0x160B2A0 VA: 0x18160CCA0
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

	// RVA: 0x160D7D0 Offset: 0x160BDD0 VA: 0x18160D7D0
	public void .ctor() { }

	// RVA: 0x160D840 Offset: 0x160BE40 VA: 0x18160D840
	public void .ctor(string message) { }

	// RVA: 0x160D880 Offset: 0x160BE80 VA: 0x18160D880
	public void .ctor(string message, string fileName) { }

	// RVA: 0x160D9D0 Offset: 0x160BFD0 VA: 0x18160D9D0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x160D4D0 Offset: 0x160BAD0 VA: 0x18160D4D0
	private void SetMessageField() { }

	// RVA: 0x160D550 Offset: 0x160BB50 VA: 0x18160D550 Slot: 3
	public override string ToString() { }

	// RVA: 0x160D8E0 Offset: 0x160BEE0 VA: 0x18160D8E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public string get_FusionLog() { }

	// RVA: 0x160D390 Offset: 0x160B990 VA: 0x18160D390 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

internal static class FileSystemEnumerableFactory // TypeDefIndex: 626
{	// Methods

	// RVA: 0x16117D0 Offset: 0x160FDD0 VA: 0x1816117D0
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
	|-RVA: 0x19E5B30 Offset: 0x19E4130 VA: 0x1819E5B30
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E4FF0 Offset: 0x19E35F0 VA: 0x1819E4FF0
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	// RVA: -1 Offset: -1
	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5E90 Offset: 0x19E4490 VA: 0x1819E5E90
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E4F20 Offset: 0x19E3520 VA: 0x1819E4F20
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5350 Offset: 0x19E3950 VA: 0x1819E5350
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E55F0 Offset: 0x19E3BF0 VA: 0x1819E55F0
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5270 Offset: 0x19E3870 VA: 0x1819E5270
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	// RVA: -1 Offset: -1
	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E55A0 Offset: 0x19E3BA0 VA: 0x1819E55A0
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	// RVA: -1 Offset: -1
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E4BD0 Offset: 0x19E31D0 VA: 0x1819E4BD0
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
	|-RVA: 0x19E5A70 Offset: 0x19E4070 VA: 0x1819E5A70
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	// RVA: -1 Offset: -1
	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5500 Offset: 0x19E3B00 VA: 0x1819E5500
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	// RVA: -1 Offset: -1
	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5420 Offset: 0x19E3A20 VA: 0x1819E5420
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/

}

internal static class FileSystemEnumerableHelpers // TypeDefIndex: 632
{	// Methods

	// RVA: 0x16118C0 Offset: 0x160FEC0 VA: 0x1816118C0
	internal static bool IsDir(Win32Native.WIN32_FIND_DATA data) { }

	// RVA: 0x1611940 Offset: 0x160FF40 VA: 0x181611940
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

	// RVA: 0x1611A70 Offset: 0x1610070 VA: 0x181611A70
	protected void .ctor() { }

	// RVA: 0x1611AC0 Offset: 0x16100C0 VA: 0x181611AC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 7
	public virtual string get_FullName() { }

	// RVA: 0x1611DA0 Offset: 0x16103A0 VA: 0x181611DA0
	public string get_Extension() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_Exists();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Delete();

	// RVA: 0x1611D00 Offset: 0x1610300 VA: 0x181611D00
	public DateTime get_CreationTime() { }

	// RVA: 0x16121E0 Offset: 0x16107E0 VA: 0x1816121E0
	public void set_CreationTime(DateTime value) { }

	// RVA: 0x1611C70 Offset: 0x1610270 VA: 0x181611C70
	public DateTime get_CreationTimeUtc() { }

	// RVA: 0x1612150 Offset: 0x1610750 VA: 0x181612150
	public void set_CreationTimeUtc(DateTime value) { }

	// RVA: 0x1611F80 Offset: 0x1610580 VA: 0x181611F80
	public DateTime get_LastAccessTime() { }

	// RVA: 0x1612310 Offset: 0x1610910 VA: 0x181612310
	public void set_LastAccessTime(DateTime value) { }

	// RVA: 0x1611EF0 Offset: 0x16104F0 VA: 0x181611EF0
	public DateTime get_LastAccessTimeUtc() { }

	// RVA: 0x1612280 Offset: 0x1610880 VA: 0x181612280
	public void set_LastAccessTimeUtc(DateTime value) { }

	// RVA: 0x16120B0 Offset: 0x16106B0 VA: 0x1816120B0
	public DateTime get_LastWriteTime() { }

	// RVA: 0x1612440 Offset: 0x1610A40 VA: 0x181612440
	public void set_LastWriteTime(DateTime value) { }

	// RVA: 0x1612020 Offset: 0x1610620 VA: 0x181612020
	public DateTime get_LastWriteTimeUtc() { }

	// RVA: 0x16123B0 Offset: 0x16109B0 VA: 0x1816123B0
	public void set_LastWriteTimeUtc(DateTime value) { }

	// RVA: 0x1611A40 Offset: 0x1610040 VA: 0x181611A40
	public void Refresh() { }

	// RVA: 0x1611C20 Offset: 0x1610220 VA: 0x181611C20
	public FileAttributes get_Attributes() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1611960 Offset: 0x160FF60 VA: 0x181611960 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal string get_DisplayPath() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	internal void set_DisplayPath(string value) { }

}

public static class File // TypeDefIndex: 663
{	// Fields
	private static Nullable<DateTime> defaultLocalFileTime; // 0x13BE2

	// Properties
	private static DateTime DefaultLocalFileTime { get; }

	// Methods

	// RVA: 0x137B060 Offset: 0x1379660 VA: 0x18137B060
	public static void AppendAllText(string path, string contents) { }

	// RVA: 0x137B820 Offset: 0x1379E20 VA: 0x18137B820
	public static void Copy(string sourceFileName, string destFileName) { }

	// RVA: 0x137B160 Offset: 0x1379760 VA: 0x18137B160
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	// RVA: 0x137C070 Offset: 0x137A670 VA: 0x18137C070
	internal static string InternalCopy(string sourceFileName, string destFileName, bool overwrite, bool checkHost) { }

	// RVA: 0x137B8B0 Offset: 0x1379EB0 VA: 0x18137B8B0
	public static FileStream Create(string path) { }

	// RVA: 0x137B830 Offset: 0x1379E30 VA: 0x18137B830
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x137B920 Offset: 0x1379F20 VA: 0x18137B920
	public static void Delete(string path) { }

	// RVA: 0x137BB60 Offset: 0x137A160 VA: 0x18137BB60
	public static bool Exists(string path) { }

	// RVA: 0x137BD30 Offset: 0x137A330 VA: 0x18137BD30
	public static FileAttributes GetAttributes(string path) { }

	// RVA: 0x137BE10 Offset: 0x137A410 VA: 0x18137BE10
	public static DateTime GetCreationTime(string path) { }

	// RVA: 0x137BF40 Offset: 0x137A540 VA: 0x18137BF40
	public static DateTime GetLastWriteTime(string path) { }

	// RVA: 0x137C1F0 Offset: 0x137A7F0 VA: 0x18137C1F0
	public static void Move(string sourceFileName, string destFileName) { }

	// RVA: 0x137C770 Offset: 0x137AD70 VA: 0x18137C770
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x137C6A0 Offset: 0x137ACA0 VA: 0x18137C6A0
	public static FileStream OpenRead(string path) { }

	// RVA: 0x137C710 Offset: 0x137AD10 VA: 0x18137C710
	public static StreamReader OpenText(string path) { }

	// RVA: 0x137CC10 Offset: 0x137B210 VA: 0x18137CC10
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x137AEB0 Offset: 0x13794B0 VA: 0x18137AEB0
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x137CD60 Offset: 0x137B360 VA: 0x18137CD60
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x137AEF0 Offset: 0x13794F0 VA: 0x18137AEF0
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x137CEB0 Offset: 0x137B4B0 VA: 0x18137CEB0
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x137AF30 Offset: 0x1379530 VA: 0x18137AF30
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x137C7F0 Offset: 0x137ADF0 VA: 0x18137C7F0
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x137C9E0 Offset: 0x137AFE0 VA: 0x18137C9E0
	public static string ReadAllText(string path) { }

	// RVA: 0x137D000 Offset: 0x137B600 VA: 0x18137D000
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x137D150 Offset: 0x137B750 VA: 0x18137D150
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x137D1C0 Offset: 0x137B7C0 VA: 0x18137D1C0
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x137D2C0 Offset: 0x137B8C0 VA: 0x18137D2C0
	private static DateTime get_DefaultLocalFileTime() { }

	// RVA: 0x137CAF0 Offset: 0x137B0F0 VA: 0x18137CAF0
	public static IEnumerable<string> ReadLines(string path) { }

	[IteratorStateMachineAttribute] // RVA: 0xA7340 Offset: 0xA6740 VA: 0x1800A7340
	// RVA: 0x137CBA0 Offset: 0x137B1A0 VA: 0x18137CBA0
	private static IEnumerable<string> ReadLines(StreamReader reader) { }

	// RVA: 0x137BC40 Offset: 0x137A240 VA: 0x18137BC40
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1624120 Offset: 0x1622720 VA: 0x181624120 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1623EF0 Offset: 0x16224F0 VA: 0x181623EF0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x16241D0 Offset: 0x16227D0 VA: 0x1816241D0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16240D0 Offset: 0x16226D0 VA: 0x1816240D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1624030 Offset: 0x1622630 VA: 0x181624030 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1624030 Offset: 0x1622630 VA: 0x181624030 Slot: 5
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

	// RVA: 0x16109C0 Offset: 0x160EFC0 VA: 0x1816109C0
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1610940 Offset: 0x160EF40 VA: 0x181610940
	public void .ctor(string path, FileMode mode) { }

	// RVA: 0x16106F0 Offset: 0x160ECF0 VA: 0x1816106F0
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x1610990 Offset: 0x160EF90 VA: 0x181610990
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x1610740 Offset: 0x160ED40 VA: 0x181610740
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x1610780 Offset: 0x160ED80 VA: 0x181610780
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x1611360 Offset: 0x160F960 VA: 0x181611360
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x16107D0 Offset: 0x160EDD0 VA: 0x1816107D0
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x1610880 Offset: 0x160EE80 VA: 0x181610880
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x16106D0 Offset: 0x160ECD0 VA: 0x1816106D0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	// RVA: 0x1610670 Offset: 0x160EC70 VA: 0x181610670
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x1610B40 Offset: 0x160F140 VA: 0x181610B40
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x160F000 Offset: 0x160D600 VA: 0x18160F000
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x16113A0 Offset: 0x160F9A0 VA: 0x1816113A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16113C0 Offset: 0x160F9C0 VA: 0x1816113C0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16113B0 Offset: 0x160F9B0 VA: 0x1816113B0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Name() { }

	// RVA: 0x16113E0 Offset: 0x160F9E0 VA: 0x1816113E0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1611560 Offset: 0x160FB60 VA: 0x181611560 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1611730 Offset: 0x160FD30 VA: 0x181611730 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16116F0 Offset: 0x160FCF0 VA: 0x1816116F0 Slot: 31
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x160E910 Offset: 0x160CF10 VA: 0x18160E910
	private void ExposeHandle() { }

	// RVA: 0x160F330 Offset: 0x160D930 VA: 0x18160F330 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x160FFA0 Offset: 0x160E5A0 VA: 0x18160FFA0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x160F770 Offset: 0x160DD70 VA: 0x18160F770 Slot: 27
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x160F5E0 Offset: 0x160DBE0 VA: 0x18160F5E0
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x160DC00 Offset: 0x160C200 VA: 0x18160DC00 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x160E610 Offset: 0x160CC10 VA: 0x18160E610 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16103D0 Offset: 0x160E9D0 VA: 0x1816103D0 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1610110 Offset: 0x160E710 VA: 0x181610110
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x160DEF0 Offset: 0x160C4F0 VA: 0x18160DEF0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x160E7A0 Offset: 0x160CDA0 VA: 0x18160E7A0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x160FAC0 Offset: 0x160E0C0 VA: 0x18160FAC0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x160FD50 Offset: 0x160E350 VA: 0x18160FD50 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x160EB50 Offset: 0x160D150 VA: 0x18160EB50 Slot: 18
	public override void Flush() { }

	// RVA: 0xFFB430 Offset: 0xFF9A30 VA: 0x180FFB430 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x160E2D0 Offset: 0x160C8D0 VA: 0x18160E2D0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x160F320 Offset: 0x160D920 VA: 0x18160F320 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x160FF90 Offset: 0x160E590 VA: 0x18160FF90 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x160F6B0 Offset: 0x160DCB0 VA: 0x18160F6B0
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x1610360 Offset: 0x160E960 VA: 0x181610360
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x160E950 Offset: 0x160CF50 VA: 0x18160E950
	private void FlushBuffer() { }

	// RVA: 0x160E940 Offset: 0x160CF40 VA: 0x18160E940
	private void FlushBufferIfDirty() { }

	// RVA: 0x160FA80 Offset: 0x160E080 VA: 0x18160FA80
	private void RefillBuffer() { }

	// RVA: 0x160F4A0 Offset: 0x160DAA0 VA: 0x18160F4A0
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x160ED70 Offset: 0x160D370 VA: 0x18160ED70
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x160EBD0 Offset: 0x160D1D0 VA: 0x18160EBD0
	private string GetSecureFileName(string filename) { }

	// RVA: 0x160ECB0 Offset: 0x160D2B0 VA: 0x18160ECB0
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x1610610 Offset: 0x160EC10 VA: 0x181610610
	private static void .cctor() { }

}

private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 671
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13482A0 Offset: 0x13468A0 VA: 0x1813482A0 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x161BAF0 Offset: 0x161A0F0 VA: 0x18161BAF0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 672
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1348FB0 Offset: 0x13475B0 VA: 0x181348FB0 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x1625AF0 Offset: 0x16240F0 VA: 0x181625AF0 Slot: 13
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

	// RVA: 0x160DB30 Offset: 0x160C130 VA: 0x18160DB30
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x160DA50 Offset: 0x160C050 VA: 0x18160DA50
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0 Slot: 4
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

	// RVA: 0x152EE10 Offset: 0x152D410 VA: 0x18152EE10
	public void .ctor(WatcherChangeTypes changeType, string directory, string name) { }

	// RVA: 0x152EEB0 Offset: 0x152D4B0 VA: 0x18152EEB0
	public string get_FullPath() { }

}

public sealed class FileSystemEventHandler : MulticastDelegate // TypeDefIndex: 2846
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, FileSystemEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
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

	// RVA: 0x152FBE0 Offset: 0x152E1E0 VA: 0x18152FBE0
	public void .ctor() { }

	// RVA: 0x152F2A0 Offset: 0x152D8A0 VA: 0x18152F2A0
	private void InitWatcher() { }

	// RVA: 0x1231370 Offset: 0x122F970 VA: 0x181231370
	internal bool get_Waiting() { }

	// RVA: 0x7CD3F0 Offset: 0x7CB9F0 VA: 0x1807CD3F0
	internal void set_Waiting(bool value) { }

	// RVA: 0x152FDC0 Offset: 0x152E3C0 VA: 0x18152FDC0
	internal string get_MangledFilter() { }

	// RVA: 0x152FE20 Offset: 0x152E420 VA: 0x18152FE20
	internal SearchPattern2 get_Pattern() { }

	// RVA: 0x152FD20 Offset: 0x152E320 VA: 0x18152FD20
	internal string get_FullPath() { }

	// RVA: 0x152FFB0 Offset: 0x152E5B0 VA: 0x18152FFB0
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x152FFD0 Offset: 0x152E5D0 VA: 0x18152FFD0
	public void set_Filter(string value) { }

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_IncludeSubdirectories() { }

	// RVA: 0x1530080 Offset: 0x152E680 VA: 0x181530080
	public void set_NotifyFilter(NotifyFilters value) { }

	// RVA: 0x15300C0 Offset: 0x152E6C0 VA: 0x1815300C0
	public void set_Path(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public override ISite get_Site() { }

	// RVA: 0x152F1C0 Offset: 0x152D7C0 VA: 0x18152F1C0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x152F200 Offset: 0x152D800 VA: 0x18152F200 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x152F670 Offset: 0x152DC70 VA: 0x18152F670
	private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype) { }

	// RVA: 0x152F5B0 Offset: 0x152DBB0 VA: 0x18152F5B0
	protected void OnChanged(FileSystemEventArgs e) { }

	// RVA: 0x152F5E0 Offset: 0x152DBE0 VA: 0x18152F5E0
	protected void OnCreated(FileSystemEventArgs e) { }

	// RVA: 0x152F610 Offset: 0x152DC10 VA: 0x18152F610
	protected void OnDeleted(FileSystemEventArgs e) { }

	// RVA: 0x152F640 Offset: 0x152DC40 VA: 0x18152F640
	protected void OnRenamed(RenamedEventArgs e) { }

	// RVA: 0x152EF20 Offset: 0x152D520 VA: 0x18152EF20
	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	// RVA: 0x152FA80 Offset: 0x152E080 VA: 0x18152FA80
	private void Start() { }

	// RVA: 0x152FB00 Offset: 0x152E100 VA: 0x18152FB00
	private void Stop() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x152FC80 Offset: 0x152E280 VA: 0x18152FC80
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x152FF10 Offset: 0x152E510 VA: 0x18152FF10
	public void remove_Changed(FileSystemEventHandler value) { }

	// RVA: 0x10DEAB0 Offset: 0x10DD0B0 VA: 0x1810DEAB0
	private static int InternalSupportsFSW() { }

	// RVA: 0x152FB80 Offset: 0x152E180 VA: 0x18152FB80
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

	// RVA: 0x1531DF0 Offset: 0x15303F0 VA: 0x181531DF0
	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB4400 Offset: 0xB3800 VA: 0x1800B4400
	// RVA: 0x1531B10 Offset: 0x1530110 VA: 0x181531B10
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1193130 Offset: 0x1191730 VA: 0x181193130 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1530EE0 Offset: 0x152F4E0 VA: 0x181530EE0 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1531F40 Offset: 0x1530540 VA: 0x181531F40
	internal bool get_Aborted() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x1531FE0 Offset: 0x15305E0 VA: 0x181531FE0 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x1531F50 Offset: 0x1530550 VA: 0x181531F50 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x1532070 Offset: 0x1530670 VA: 0x181532070 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x15320D0 Offset: 0x15306D0 VA: 0x1815320D0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1532190 Offset: 0x1530790 VA: 0x181532190 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB9BA10 Offset: 0xB9A010 VA: 0x180B9BA10 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1530450 Offset: 0x152EA50 VA: 0x181530450 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x15307A0 Offset: 0x152EDA0 VA: 0x1815307A0 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1530A10 Offset: 0x152F010 VA: 0x181530A10
	private bool CanGetRequestStream() { }

	// RVA: 0x1530A80 Offset: 0x152F080 VA: 0x181530A80 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1530CB0 Offset: 0x152F2B0 VA: 0x181530CB0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x15312B0 Offset: 0x152F8B0 VA: 0x1815312B0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x1531790 Offset: 0x152FD90 VA: 0x181531790 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x15310B0 Offset: 0x152F6B0 VA: 0x1815310B0
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x15314C0 Offset: 0x152FAC0 VA: 0x1815314C0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x15319A0 Offset: 0x152FFA0 VA: 0x1815319A0
	internal void UnblockReader() { }

	// RVA: 0x1531FA0 Offset: 0x15305A0 VA: 0x181531FA0 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x15321A0 Offset: 0x15307A0 VA: 0x1815321A0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1530200 Offset: 0x152E800 VA: 0x181530200 Slot: 35
	public override void Abort() { }

	// RVA: 0x1531A60 Offset: 0x1530060 VA: 0x181531A60
	private static void .cctor() { }

}

internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 2949
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x132F060 Offset: 0x132D660 VA: 0x18132F060 Slot: 4
	public WebRequest Create(Uri uri) { }

}

internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 2950
{	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x132FF70 Offset: 0x132E570 VA: 0x18132FF70
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x132FEB0 Offset: 0x132E4B0 VA: 0x18132FEB0
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x132FB60 Offset: 0x132E160 VA: 0x18132FB60 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x132FDC0 Offset: 0x132E3C0 VA: 0x18132FDC0 Slot: 32
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x132FD20 Offset: 0x132E320 VA: 0x18132FD20 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x132FE10 Offset: 0x132E410 VA: 0x18132FE10 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x132F960 Offset: 0x132DF60 VA: 0x18132F960 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x132FC20 Offset: 0x132E220 VA: 0x18132FC20 Slot: 20
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x132FA10 Offset: 0x132E010 VA: 0x18132FA10 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x132FCA0 Offset: 0x132E2A0 VA: 0x18132FCA0 Slot: 23
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x132FAC0 Offset: 0x132E0C0 VA: 0x18132FAC0
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

	// RVA: 0x132F670 Offset: 0x132DC70 VA: 0x18132F670
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0xB4400 Offset: 0xB3800 VA: 0x1800B4400
	// RVA: 0x132F4B0 Offset: 0x132DAB0 VA: 0x18132F4B0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1191B40 Offset: 0x1190140 VA: 0x181191B40 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x132F190 Offset: 0x132D790 VA: 0x18132F190 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x132F900 Offset: 0x132DF00 VA: 0x18132F900 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x132F920 Offset: 0x132DF20 VA: 0x18132F920 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x132F940 Offset: 0x132DF40 VA: 0x18132F940 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x132F0C0 Offset: 0x132D6C0 VA: 0x18132F0C0
	private void CheckDisposed() { }

	// RVA: 0x132F150 Offset: 0x132D750 VA: 0x18132F150 Slot: 9
	public override void Close() { }

	// RVA: 0x132F360 Offset: 0x132D960 VA: 0x18132F360 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x132F2D0 Offset: 0x132D8D0 VA: 0x18132F2D0 Slot: 12
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

	// RVA: 0x1E5B40 Offset: 0x1E4F40 VA: 0x1801E5B40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5B30 Offset: 0x1E4F30 VA: 0x1801E5B30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F7D0 Offset: 0x136DDD0 VA: 0x18136F7D0
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

	// RVA: 0x1D5A430 Offset: 0x1D58A30 VA: 0x181D5A430
	public static void ResetToPool(FileStorageCacheData instance) { }

	// RVA: 0x1D5A4E0 Offset: 0x1D58AE0 VA: 0x181D5A4E0
	public void ResetToPool() { }

	// RVA: 0x1D5A0C0 Offset: 0x1D586C0 VA: 0x181D5A0C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D58DB0 Offset: 0x1D573B0 VA: 0x181D58DB0
	public void CopyTo(FileStorageCacheData instance) { }

	// RVA: 0x1D58E70 Offset: 0x1D57470 VA: 0x181D58E70
	public FileStorageCacheData Copy() { }

	// RVA: 0x1D59860 Offset: 0x1D57E60 VA: 0x181D59860
	public static FileStorageCacheData Deserialize(Stream stream) { }

	// RVA: 0x1D59260 Offset: 0x1D57860 VA: 0x181D59260
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D592E0 Offset: 0x1D578E0 VA: 0x181D592E0
	public static FileStorageCacheData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D59AC0 Offset: 0x1D580C0 VA: 0x181D59AC0
	public static FileStorageCacheData Deserialize(byte[] buffer) { }

	// RVA: 0x1D5A1F0 Offset: 0x1D587F0 VA: 0x181D5A1F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5AB40 Offset: 0x1D59140 VA: 0x181D5AB40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5AB60 Offset: 0x1D59160 VA: 0x181D5AB60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FileStorageCacheData previous) { }

	// RVA: 0x1D5A410 Offset: 0x1D58A10 VA: 0x181D5A410 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D59DD0 Offset: 0x1D583D0 VA: 0x181D59DD0
	public static FileStorageCacheData Deserialize(byte[] buffer, FileStorageCacheData instance, bool isDelta = False) { }

	// RVA: 0x1D59640 Offset: 0x1D57C40 VA: 0x181D59640
	public static FileStorageCacheData Deserialize(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D58F70 Offset: 0x1D57570 VA: 0x181D58F70
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D59370 Offset: 0x1D57970 VA: 0x181D59370
	public static FileStorageCacheData DeserializeLength(Stream stream, int length, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D5A590 Offset: 0x1D58B90 VA: 0x181D5A590
	public static void SerializeDelta(Stream stream, FileStorageCacheData instance, FileStorageCacheData previous) { }

	// RVA: 0x1D5A980 Offset: 0x1D58F80 VA: 0x181D5A980
	public static void Serialize(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x1D5AB30 Offset: 0x1D59130 VA: 0x181D5AB30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5AB40 Offset: 0x1D59140 VA: 0x181D5AB40
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5A870 Offset: 0x1D58E70 VA: 0x181D5A870
	public static byte[] SerializeToBytes(FileStorageCacheData instance) { }

	// RVA: 0x1D5A7C0 Offset: 0x1D58DC0 VA: 0x181D5A7C0
	public static void SerializeLengthDelimited(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public static class FileSystem // TypeDefIndex: 6659
{	// Fields
	public static bool LogDebug; // 0x0
	public static bool LogTime; // 0x1
	public static FileSystemBackend Backend; // 0x8

	// Methods

	// RVA: 0x22BE7E0 Offset: 0x22BCDE0 VA: 0x1822BE7E0
	public static GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22BE6D0 Offset: 0x22BCCD0 VA: 0x1822BE6D0
	public static GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22BE640 Offset: 0x22BCC40 VA: 0x1822BE640
	public static string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A386A0 Offset: 0x1A36CA0 VA: 0x181A386A0
	|-FileSystem.LoadAll<Sprite>
	|-FileSystem.LoadAll<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A385E0 Offset: 0x1A36BE0 VA: 0x181A385E0
	|-FileSystem.LoadAllFromBundle<Skinnable>
	|-FileSystem.LoadAllFromBundle<GameObject>
	|-FileSystem.LoadAllFromBundle<object>
	*/

	// RVA: -1 Offset: -1
	public static T Load<T>(string filePath, bool complain = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD840 Offset: 0x5CBE40 VA: 0x1805CD840
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

	// RVA: 0x22BE950 Offset: 0x22BCF50 VA: 0x1822BE950
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

	// RVA: 0x22BDFA0 Offset: 0x22BC5A0 VA: 0x1822BDFA0
	public GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22BDEE0 Offset: 0x22BC4E0 VA: 0x1822BDEE0
	public GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22BDE40 Offset: 0x22BC440 VA: 0x1822BDE40
	public string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38480 Offset: 0x1A36A80 VA: 0x181A38480
	|-FileSystemBackend.LoadAll<object>
	|-FileSystemBackend.LoadAll<GameObject>
	*/

	// RVA: -1 Offset: -1
	public T Load<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD6B0 Offset: 0x5CBCB0 VA: 0x1805CD6B0
	|-FileSystemBackend.Load<object>
	|-FileSystemBackend.Load<GameObject>
	*/

	// RVA: 0x22BE0C0 Offset: 0x22BC6C0 VA: 0x1822BE0C0
	public AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BDE60 Offset: 0x22BC460 VA: 0x1822BDE60
	protected void LoadError(string err) { }

	// RVA: 0x22BE4F0 Offset: 0x22BCAF0 VA: 0x1822BE4F0 Slot: 4
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

	// RVA: 0x22BE540 Offset: 0x22BCB40 VA: 0x1822BE540
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
	// RVA: 0xFC03B0 Offset: 0xFBE9B0 VA: 0x180FC03B0
	public IEnumerator Open(string path, string allowedExtensions, string windowName = "OPEN FILE", Sprite windowIcon, long maxSize = -1, bool saveLastPath = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x78190 Offset: 0x77590 VA: 0x180078190
	// RVA: 0xFC0600 Offset: 0xFBEC00 VA: 0x180FC0600
	public IEnumerator Save(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x78300 Offset: 0x77700 VA: 0x180078300
	// RVA: 0xFC0490 Offset: 0xFBEA90 VA: 0x180FC0490
	public Task<string> SaveAsync(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void Hide() { }

	// RVA: 0xFBFF80 Offset: 0xFBE580 VA: 0x180FBFF80
	public void GoUp() { }

	// RVA: 0xFBFD00 Offset: 0xFBE300 VA: 0x180FBFD00
	public void GoTo(string newPath) { }

	// RVA: 0xFC06E0 Offset: 0xFBECE0 VA: 0x180FC06E0
	public void SelectFile(string file) { }

	// RVA: 0xFC0020 Offset: 0xFBE620 VA: 0x180FC0020
	public void OnCommitClick() { }

	// RVA: 0xFBFFD0 Offset: 0xFBE5D0 VA: 0x180FBFFD0
	public void OnCancelClick() { }

	// RVA: 0xFBFBB0 Offset: 0xFBE1B0 VA: 0x180FBFBB0
	public void ClearSelection() { }

	// RVA: 0xFC0230 Offset: 0xFBE830 VA: 0x180FC0230
	public void OnTypedFilename(string newName) { }

	// RVA: 0xFC0100 Offset: 0xFBE700 VA: 0x180FC0100
	public void OnTypedEnd(string newName) { }

	// RVA: 0xFC0BE0 Offset: 0xFBF1E0 VA: 0x180FC0BE0
	public void UpdateFileInfo() { }

	// RVA: 0xFC02C0 Offset: 0xFBE8C0 VA: 0x180FC02C0
	public void OpenDir(string path) { }

	// RVA: 0xFC0BB0 Offset: 0xFBF1B0 VA: 0x180FC0BB0
	private void UpdateElements() { }

	// RVA: 0xFC0850 Offset: 0xFBEE50 VA: 0x180FC0850
	private void UpdateDrivesList() { }

	// RVA: 0xFBFC10 Offset: 0xFBE210 VA: 0x180FBFC10
	private string GetFileSizeText(long size) { }

	// RVA: 0xFC0DA0 Offset: 0xFBF3A0 VA: 0x180FC0DA0
	private void UpdateFilesList() { }

	// RVA: 0xFC1F20 Offset: 0xFC0520 VA: 0x180FC1F20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC07D0 Offset: 0xFBEDD0 VA: 0x180FC07D0
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

	// RVA: 0xFD79E0 Offset: 0xFD5FE0 VA: 0x180FD79E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD7D30 Offset: 0xFD6330 VA: 0x180FD7D30 Slot: 8
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

	// RVA: 0xFD81F0 Offset: 0xFD67F0 VA: 0x180FD81F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD8530 Offset: 0xFD6B30 VA: 0x180FD8530 Slot: 8
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

	// RVA: 0x14B780 Offset: 0x14AB80 VA: 0x18014B780 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B790 Offset: 0x14AB90 VA: 0x18014B790 Slot: 5
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

	// RVA: 0xFC1F40 Offset: 0xFC0540 VA: 0x180FC1F40
	public void OnClick() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

internal static class FileUtilities // TypeDefIndex: 7615
{	// Methods

	// RVA: 0x1397A20 Offset: 0x1396020 VA: 0x181397A20
	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	// RVA: 0x1397CE0 Offset: 0x13962E0 VA: 0x181397CE0
	internal static FileStream OpenFileForRead(string filePath) { }

	// RVA: 0x1397B40 Offset: 0x1396140 VA: 0x181397B40
	private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition) { }

}

public class FileSystem_Warmup : MonoBehaviour // TypeDefIndex: 9371
{	// Fields
	public static bool ranInBackground; // 0x0
	private static bool run; // 0x1
	public static string[] ExcludeFilter; // 0x8

	// Methods

	// RVA: 0x788110 Offset: 0x786710 VA: 0x180788110
	public static void Run() { }

	// RVA: 0x788290 Offset: 0x786890 VA: 0x180788290
	public static IEnumerator Run(string[] assetList, Action<string> statusFunction, string format, int priority = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7C90 Offset: 0xE7090 VA: 0x1800E7C90
	// RVA: 0x787FC0 Offset: 0x7865C0 VA: 0x180787FC0
	private static IEnumerator RunAsyncImpl(string[] assetList, Action<string> statusFunction, string format, int priority) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7D60 Offset: 0xE7160 VA: 0x1800E7D60
	// RVA: 0x788070 Offset: 0x786670 VA: 0x180788070
	private static IEnumerator RunImpl(string[] assetList, Action<string> statusFunction, string format) { }

	// RVA: 0x787B30 Offset: 0x786130 VA: 0x180787B30
	private static float CalculateFrameBudget() { }

	// RVA: 0x788440 Offset: 0x786A40 VA: 0x180788440
	private static bool ShouldIgnore(string path) { }

	// RVA: 0x787B60 Offset: 0x786160 VA: 0x180787B60
	public static string[] GetAssetList(Nullable<bool> poolFilter) { }

	// RVA: 0x787F40 Offset: 0x786540 VA: 0x180787F40
	private static void PrefabWarmup(string path) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x788570 Offset: 0x786B70 VA: 0x180788570
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

	// RVA: 0x799690 Offset: 0x797C90 VA: 0x180799690 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x799AD0 Offset: 0x7980D0 VA: 0x180799AD0 Slot: 8
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

	// RVA: 0x799B20 Offset: 0x798120 VA: 0x180799B20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x799E80 Offset: 0x798480 VA: 0x180799E80 Slot: 8
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

	// RVA: 0x79A2C0 Offset: 0x7988C0 VA: 0x18079A2C0
	internal bool <GetAssetList>b__2(GameManifest.PrefabProperties x) { }

}

private sealed class FileSystem_Warmup.<>c // TypeDefIndex: 9375
{	// Fields
	public static readonly FileSystem_Warmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, string> <>9__9_0; // 0x8
	public static Func<string, bool> <>9__9_1; // 0x10
	public static Func<GameManifest.PrefabProperties, string> <>9__9_3; // 0x18

	// Methods

	// RVA: 0x79A480 Offset: 0x798A80 VA: 0x18079A480
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal string <GetAssetList>b__9_0(GameManifest.PrefabProperties x) { }

	// RVA: 0x799ED0 Offset: 0x7984D0 VA: 0x180799ED0
	internal bool <GetAssetList>b__9_1(string x) { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal string <GetAssetList>b__9_3(GameManifest.PrefabProperties x) { }

}

public class FileStorage : IDisposable // TypeDefIndex: 10719
{	// Fields
	private Database db; // 0x10
	private CRC32 crc; // 0x18
	private MruDictionary<uint, FileStorage.CacheData> _cache; // 0x20
	public static FileStorage client; // 0x0

	// Methods

	// RVA: 0x787A90 Offset: 0x786090 VA: 0x180787A90
	protected void .ctor(string name, bool server) { }

	// RVA: 0x786820 Offset: 0x784E20 VA: 0x180786820 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x7867E0 Offset: 0x784DE0 VA: 0x1807867E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x7868C0 Offset: 0x784EC0 VA: 0x1807868C0
	private uint GetCRC(byte[] data, FileStorage.Type type) { }

	// RVA: 0x7877C0 Offset: 0x785DC0 VA: 0x1807877C0
	public uint Store(byte[] data, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x786C40 Offset: 0x785240 VA: 0x180786C40
	public byte[] Get(uint crc, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x7874D0 Offset: 0x785AD0 VA: 0x1807874D0
	public void Remove(uint crc, FileStorage.Type type, uint entityID) { }

	// RVA: 0x787390 Offset: 0x785990 VA: 0x180787390
	public void RemoveExact(uint crc, FileStorage.Type type, uint entityID, uint numid) { }

	// RVA: 0x7870D0 Offset: 0x7856D0 VA: 0x1807870D0
	public void RemoveEntityNum(uint entityid, uint numid) { }

	// RVA: 0x786FE0 Offset: 0x7855E0 VA: 0x180786FE0
	internal void RemoveAllByEntity(uint entityid) { }

	// RVA: 0x786EE0 Offset: 0x7854E0 VA: 0x180786EE0
	public void ReassignEntityId(uint oldId, uint newId) { }

	// RVA: 0x786A30 Offset: 0x785030 VA: 0x180786A30
	public List<FileStorageCacheData> GetCacheData() { }

	// RVA: 0x787600 Offset: 0x785C00 VA: 0x180787600
	public void SetCache(List<FileStorageCacheData> data) { }

	// RVA: 0x786790 Offset: 0x784D90 VA: 0x180786790
	public void ClearCache() { }

	// RVA: 0x787980 Offset: 0x785F80 VA: 0x180787980
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

	// RVA: 0x79A1E0 Offset: 0x7987E0 VA: 0x18079A1E0
	internal bool <RemoveEntityNum>b__0(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

private sealed class FileStorage.<>c // TypeDefIndex: 10723
{	// Fields
	public static readonly FileStorage.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, FileStorage.CacheData>, uint> <>9__14_1; // 0x8

	// Methods

	// RVA: 0x79A3C0 Offset: 0x7989C0 VA: 0x18079A3C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A170 Offset: 0x798770 VA: 0x18079A170
	internal uint <RemoveEntityNum>b__14_1(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

public static class FileEx // TypeDefIndex: 11346
{	// Methods

	// RVA: 0x786370 Offset: 0x784970 VA: 0x180786370
	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7866E0 Offset: 0x784CE0 VA: 0x1807866E0
	public static bool MoveToSafe(FileInfo parent, string target, int retries = 10) { }

	// RVA: 0x7864A0 Offset: 0x784AA0 VA: 0x1807864A0
	public static void Backup(string[] names) { }

}

public class FileConVar : ConsoleSystem // TypeDefIndex: 11922
{	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool time { get; set; }

	// Methods

	// RVA: 0x6E0500 Offset: 0x6DEB00 VA: 0x1806E0500
	public static bool get_debug() { }

	// RVA: 0x6E05C0 Offset: 0x6DEBC0 VA: 0x1806E05C0
	public static void set_debug(bool value) { }

	// RVA: 0x6E0560 Offset: 0x6DEB60 VA: 0x1806E0560
	public static bool get_time() { }

	// RVA: 0x6E0620 Offset: 0x6DEC20 VA: 0x1806E0620
	public static void set_time(bool value) { }

	// RVA: 0x6E04A0 Offset: 0x6DEAA0 VA: 0x1806E04A0
	public void .ctor() { }

}

