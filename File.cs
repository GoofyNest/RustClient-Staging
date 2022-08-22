internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 482
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE7180 Offset: 0xFE5780 VA: 0x180FE7180 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE70C0 Offset: 0xFE56C0 VA: 0x180FE70C0
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0xFE6D40 Offset: 0xFE5340 VA: 0x180FE6D40
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

	// RVA: 0x161F150 Offset: 0x161D750 VA: 0x18161F150
	public void .ctor(string fileName) { }

	// RVA: 0x161ECD0 Offset: 0x161D2D0 VA: 0x18161ECD0
	private void Init(string fileName, bool checkHost) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	private string GetDisplayPath(string originalPath) { }

	// RVA: 0x161F2F0 Offset: 0x161D8F0 VA: 0x18161F2F0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161F050 Offset: 0x161D650 VA: 0x18161F050
	internal void .ctor(string fullPath, bool ignoreThis) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 8
	public override string get_Name() { }

	// RVA: 0x161F650 Offset: 0x161DC50 VA: 0x18161F650
	public long get_Length() { }

	// RVA: 0x161F4C0 Offset: 0x161DAC0 VA: 0x18161F4C0
	public string get_DirectoryName() { }

	// RVA: 0x161F520 Offset: 0x161DB20 VA: 0x18161F520
	public DirectoryInfo get_Directory() { }

	// RVA: 0x161EAA0 Offset: 0x161D0A0 VA: 0x18161EAA0
	public StreamWriter CreateText() { }

	// RVA: 0x161E860 Offset: 0x161CE60 VA: 0x18161E860
	public StreamWriter AppendText() { }

	// RVA: 0x161E8C0 Offset: 0x161CEC0 VA: 0x18161E8C0
	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	// RVA: 0x161EB00 Offset: 0x161D100 VA: 0x18161EB00 Slot: 10
	public override void Delete() { }

	// RVA: 0x161F5D0 Offset: 0x161DBD0 VA: 0x18161F5D0 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x161EDC0 Offset: 0x161D3C0 VA: 0x18161EDC0
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

	// RVA: 0x161FBC0 Offset: 0x161E1C0 VA: 0x18161FBC0
	public void .ctor() { }

	// RVA: 0x161FB80 Offset: 0x161E180 VA: 0x18161FB80
	public void .ctor(string message) { }

	// RVA: 0x161FD20 Offset: 0x161E320 VA: 0x18161FD20 Slot: 5
	public override string get_Message() { }

	// RVA: 0x161F870 Offset: 0x161DE70 VA: 0x18161F870
	private void SetMessageField() { }

	// RVA: 0x161F900 Offset: 0x161DF00 VA: 0x18161F900 Slot: 3
	public override string ToString() { }

	// RVA: 0x161FC30 Offset: 0x161E230 VA: 0x18161FC30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_FusionLog() { }

	// RVA: 0x161F730 Offset: 0x161DD30 VA: 0x18161F730 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161F6C0 Offset: 0x161DCC0 VA: 0x18161F6C0
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

	// RVA: 0x16201F0 Offset: 0x161E7F0 VA: 0x1816201F0
	public void .ctor() { }

	// RVA: 0x1620260 Offset: 0x161E860 VA: 0x181620260
	public void .ctor(string message) { }

	// RVA: 0x16202A0 Offset: 0x161E8A0 VA: 0x1816202A0
	public void .ctor(string message, string fileName) { }

	// RVA: 0x16203F0 Offset: 0x161E9F0 VA: 0x1816203F0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x161FEF0 Offset: 0x161E4F0 VA: 0x18161FEF0
	private void SetMessageField() { }

	// RVA: 0x161FF70 Offset: 0x161E570 VA: 0x18161FF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1620300 Offset: 0x161E900 VA: 0x181620300
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_FusionLog() { }

	// RVA: 0x161FDB0 Offset: 0x161E3B0 VA: 0x18161FDB0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

internal static class FileSystemEnumerableFactory // TypeDefIndex: 626
{	// Methods

	// RVA: 0x16241F0 Offset: 0x16227F0 VA: 0x1816241F0
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
	|-RVA: 0x19F8470 Offset: 0x19F6A70 VA: 0x1819F8470
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7930 Offset: 0x19F5F30 VA: 0x1819F7930
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	// RVA: -1 Offset: -1
	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F87D0 Offset: 0x19F6DD0 VA: 0x1819F87D0
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7860 Offset: 0x19F5E60 VA: 0x1819F7860
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7C90 Offset: 0x19F6290 VA: 0x1819F7C90
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7F30 Offset: 0x19F6530 VA: 0x1819F7F30
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7BB0 Offset: 0x19F61B0 VA: 0x1819F7BB0
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	// RVA: -1 Offset: -1
	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7EE0 Offset: 0x19F64E0 VA: 0x1819F7EE0
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	// RVA: -1 Offset: -1
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7510 Offset: 0x19F5B10 VA: 0x1819F7510
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
	|-RVA: 0x19F83B0 Offset: 0x19F69B0 VA: 0x1819F83B0
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	// RVA: -1 Offset: -1
	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7E40 Offset: 0x19F6440 VA: 0x1819F7E40
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	// RVA: -1 Offset: -1
	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F7D60 Offset: 0x19F6360 VA: 0x1819F7D60
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/

}

internal static class FileSystemEnumerableHelpers // TypeDefIndex: 632
{	// Methods

	// RVA: 0x16242E0 Offset: 0x16228E0 VA: 0x1816242E0
	internal static bool IsDir(Win32Native.WIN32_FIND_DATA data) { }

	// RVA: 0x1624360 Offset: 0x1622960 VA: 0x181624360
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

	// RVA: 0x1624490 Offset: 0x1622A90 VA: 0x181624490
	protected void .ctor() { }

	// RVA: 0x16244E0 Offset: 0x1622AE0 VA: 0x1816244E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 7
	public virtual string get_FullName() { }

	// RVA: 0x16247C0 Offset: 0x1622DC0 VA: 0x1816247C0
	public string get_Extension() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_Exists();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Delete();

	// RVA: 0x1624720 Offset: 0x1622D20 VA: 0x181624720
	public DateTime get_CreationTime() { }

	// RVA: 0x1624C00 Offset: 0x1623200 VA: 0x181624C00
	public void set_CreationTime(DateTime value) { }

	// RVA: 0x1624690 Offset: 0x1622C90 VA: 0x181624690
	public DateTime get_CreationTimeUtc() { }

	// RVA: 0x1624B70 Offset: 0x1623170 VA: 0x181624B70
	public void set_CreationTimeUtc(DateTime value) { }

	// RVA: 0x16249A0 Offset: 0x1622FA0 VA: 0x1816249A0
	public DateTime get_LastAccessTime() { }

	// RVA: 0x1624D30 Offset: 0x1623330 VA: 0x181624D30
	public void set_LastAccessTime(DateTime value) { }

	// RVA: 0x1624910 Offset: 0x1622F10 VA: 0x181624910
	public DateTime get_LastAccessTimeUtc() { }

	// RVA: 0x1624CA0 Offset: 0x16232A0 VA: 0x181624CA0
	public void set_LastAccessTimeUtc(DateTime value) { }

	// RVA: 0x1624AD0 Offset: 0x16230D0 VA: 0x181624AD0
	public DateTime get_LastWriteTime() { }

	// RVA: 0x1624E60 Offset: 0x1623460 VA: 0x181624E60
	public void set_LastWriteTime(DateTime value) { }

	// RVA: 0x1624A40 Offset: 0x1623040 VA: 0x181624A40
	public DateTime get_LastWriteTimeUtc() { }

	// RVA: 0x1624DD0 Offset: 0x16233D0 VA: 0x181624DD0
	public void set_LastWriteTimeUtc(DateTime value) { }

	// RVA: 0x1624460 Offset: 0x1622A60 VA: 0x181624460
	public void Refresh() { }

	// RVA: 0x1624640 Offset: 0x1622C40 VA: 0x181624640
	public FileAttributes get_Attributes() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1624380 Offset: 0x1622980 VA: 0x181624380 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal string get_DisplayPath() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	internal void set_DisplayPath(string value) { }

}

public static class File // TypeDefIndex: 663
{	// Fields
	private static Nullable<DateTime> defaultLocalFileTime; // 0x2B10188

	// Properties
	private static DateTime DefaultLocalFileTime { get; }

	// Methods

	// RVA: 0x137BCA0 Offset: 0x137A2A0 VA: 0x18137BCA0
	public static void AppendAllText(string path, string contents) { }

	// RVA: 0x137C460 Offset: 0x137AA60 VA: 0x18137C460
	public static void Copy(string sourceFileName, string destFileName) { }

	// RVA: 0x137BDA0 Offset: 0x137A3A0 VA: 0x18137BDA0
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	// RVA: 0x137CCB0 Offset: 0x137B2B0 VA: 0x18137CCB0
	internal static string InternalCopy(string sourceFileName, string destFileName, bool overwrite, bool checkHost) { }

	// RVA: 0x137C4F0 Offset: 0x137AAF0 VA: 0x18137C4F0
	public static FileStream Create(string path) { }

	// RVA: 0x137C470 Offset: 0x137AA70 VA: 0x18137C470
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x137C560 Offset: 0x137AB60 VA: 0x18137C560
	public static void Delete(string path) { }

	// RVA: 0x137C7A0 Offset: 0x137ADA0 VA: 0x18137C7A0
	public static bool Exists(string path) { }

	// RVA: 0x137C970 Offset: 0x137AF70 VA: 0x18137C970
	public static FileAttributes GetAttributes(string path) { }

	// RVA: 0x137CA50 Offset: 0x137B050 VA: 0x18137CA50
	public static DateTime GetCreationTime(string path) { }

	// RVA: 0x137CB80 Offset: 0x137B180 VA: 0x18137CB80
	public static DateTime GetLastWriteTime(string path) { }

	// RVA: 0x137CE30 Offset: 0x137B430 VA: 0x18137CE30
	public static void Move(string sourceFileName, string destFileName) { }

	// RVA: 0x137D3B0 Offset: 0x137B9B0 VA: 0x18137D3B0
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x137D2E0 Offset: 0x137B8E0 VA: 0x18137D2E0
	public static FileStream OpenRead(string path) { }

	// RVA: 0x137D350 Offset: 0x137B950 VA: 0x18137D350
	public static StreamReader OpenText(string path) { }

	// RVA: 0x137D850 Offset: 0x137BE50 VA: 0x18137D850
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x137BAF0 Offset: 0x137A0F0 VA: 0x18137BAF0
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x137D9A0 Offset: 0x137BFA0 VA: 0x18137D9A0
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x137BB30 Offset: 0x137A130 VA: 0x18137BB30
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x137DAF0 Offset: 0x137C0F0 VA: 0x18137DAF0
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x137BB70 Offset: 0x137A170 VA: 0x18137BB70
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x137D430 Offset: 0x137BA30 VA: 0x18137D430
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x137D620 Offset: 0x137BC20 VA: 0x18137D620
	public static string ReadAllText(string path) { }

	// RVA: 0x137DC40 Offset: 0x137C240 VA: 0x18137DC40
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x137DD90 Offset: 0x137C390 VA: 0x18137DD90
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x137DE00 Offset: 0x137C400 VA: 0x18137DE00
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x137DF00 Offset: 0x137C500 VA: 0x18137DF00
	private static DateTime get_DefaultLocalFileTime() { }

	// RVA: 0x137D730 Offset: 0x137BD30 VA: 0x18137D730
	public static IEnumerable<string> ReadLines(string path) { }

	[IteratorStateMachineAttribute] // RVA: 0xA7340 Offset: 0xA6740 VA: 0x1800A7340
	// RVA: 0x137D7E0 Offset: 0x137BDE0 VA: 0x18137D7E0
	private static IEnumerable<string> ReadLines(StreamReader reader) { }

	// RVA: 0x137C880 Offset: 0x137AE80 VA: 0x18137C880
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636B40 Offset: 0x1635140 VA: 0x181636B40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1636910 Offset: 0x1634F10 VA: 0x181636910 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1636BF0 Offset: 0x16351F0 VA: 0x181636BF0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636AF0 Offset: 0x16350F0 VA: 0x181636AF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636A50 Offset: 0x1635050 VA: 0x181636A50 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1636A50 Offset: 0x1635050 VA: 0x181636A50 Slot: 5
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

	// RVA: 0x16233E0 Offset: 0x16219E0 VA: 0x1816233E0
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1623360 Offset: 0x1621960 VA: 0x181623360
	public void .ctor(string path, FileMode mode) { }

	// RVA: 0x1623110 Offset: 0x1621710 VA: 0x181623110
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x16233B0 Offset: 0x16219B0 VA: 0x1816233B0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x1623160 Offset: 0x1621760 VA: 0x181623160
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x16231A0 Offset: 0x16217A0 VA: 0x1816231A0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x1623D80 Offset: 0x1622380 VA: 0x181623D80
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x16231F0 Offset: 0x16217F0 VA: 0x1816231F0
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x16232A0 Offset: 0x16218A0 VA: 0x1816232A0
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x16230F0 Offset: 0x16216F0 VA: 0x1816230F0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	// RVA: 0x1623090 Offset: 0x1621690 VA: 0x181623090
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x1623560 Offset: 0x1621B60 VA: 0x181623560
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x1621A20 Offset: 0x1620020 VA: 0x181621A20
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x1623DC0 Offset: 0x16223C0 VA: 0x181623DC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1623DE0 Offset: 0x16223E0 VA: 0x181623DE0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1623DD0 Offset: 0x16223D0 VA: 0x181623DD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	// RVA: 0x1623E00 Offset: 0x1622400 VA: 0x181623E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1623F80 Offset: 0x1622580 VA: 0x181623F80 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1624150 Offset: 0x1622750 VA: 0x181624150 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1624110 Offset: 0x1622710 VA: 0x181624110 Slot: 31
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x1621330 Offset: 0x161F930 VA: 0x181621330
	private void ExposeHandle() { }

	// RVA: 0x1621D50 Offset: 0x1620350 VA: 0x181621D50 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x16229C0 Offset: 0x1620FC0 VA: 0x1816229C0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1622190 Offset: 0x1620790 VA: 0x181622190 Slot: 27
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x1622000 Offset: 0x1620600 VA: 0x181622000
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x1620620 Offset: 0x161EC20 VA: 0x181620620 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x1621030 Offset: 0x161F630 VA: 0x181621030 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1622DF0 Offset: 0x16213F0 VA: 0x181622DF0 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1622B30 Offset: 0x1621130 VA: 0x181622B30
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x1620910 Offset: 0x161EF10 VA: 0x181620910 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x16211C0 Offset: 0x161F7C0 VA: 0x1816211C0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x16224E0 Offset: 0x1620AE0 VA: 0x1816224E0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1622770 Offset: 0x1620D70 VA: 0x181622770 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1621570 Offset: 0x161FB70 VA: 0x181621570 Slot: 18
	public override void Flush() { }

	// RVA: 0xFFA6D0 Offset: 0xFF8CD0 VA: 0x180FFA6D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1620CF0 Offset: 0x161F2F0 VA: 0x181620CF0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1621D40 Offset: 0x1620340 VA: 0x181621D40 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16229B0 Offset: 0x1620FB0 VA: 0x1816229B0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16220D0 Offset: 0x16206D0 VA: 0x1816220D0
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x1622D80 Offset: 0x1621380 VA: 0x181622D80
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x1621370 Offset: 0x161F970 VA: 0x181621370
	private void FlushBuffer() { }

	// RVA: 0x1621360 Offset: 0x161F960 VA: 0x181621360
	private void FlushBufferIfDirty() { }

	// RVA: 0x16224A0 Offset: 0x1620AA0 VA: 0x1816224A0
	private void RefillBuffer() { }

	// RVA: 0x1621EC0 Offset: 0x16204C0 VA: 0x181621EC0
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x1621790 Offset: 0x161FD90 VA: 0x181621790
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x16215F0 Offset: 0x161FBF0 VA: 0x1816215F0
	private string GetSecureFileName(string filename) { }

	// RVA: 0x16216D0 Offset: 0x161FCD0 VA: 0x1816216D0
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x1623030 Offset: 0x1621630 VA: 0x181623030
	private static void .cctor() { }

}

private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 671
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1348EE0 Offset: 0x13474E0 VA: 0x181348EE0 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x162E510 Offset: 0x162CB10 VA: 0x18162E510 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 672
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349BF0 Offset: 0x13481F0 VA: 0x181349BF0 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x1638510 Offset: 0x1636B10 VA: 0x181638510 Slot: 13
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

	// RVA: 0x1620550 Offset: 0x161EB50 VA: 0x181620550
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x1620470 Offset: 0x161EA70 VA: 0x181620470
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 4
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

	// RVA: 0x152FA80 Offset: 0x152E080 VA: 0x18152FA80
	public void .ctor(WatcherChangeTypes changeType, string directory, string name) { }

	// RVA: 0x152FB20 Offset: 0x152E120 VA: 0x18152FB20
	public string get_FullPath() { }

}

public sealed class FileSystemEventHandler : MulticastDelegate // TypeDefIndex: 2846
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, FileSystemEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x1530850 Offset: 0x152EE50 VA: 0x181530850
	public void .ctor() { }

	// RVA: 0x152FF10 Offset: 0x152E510 VA: 0x18152FF10
	private void InitWatcher() { }

	// RVA: 0x1230A10 Offset: 0x122F010 VA: 0x181230A10
	internal bool get_Waiting() { }

	// RVA: 0x7AEEF0 Offset: 0x7AD4F0 VA: 0x1807AEEF0
	internal void set_Waiting(bool value) { }

	// RVA: 0x1530A30 Offset: 0x152F030 VA: 0x181530A30
	internal string get_MangledFilter() { }

	// RVA: 0x1530A90 Offset: 0x152F090 VA: 0x181530A90
	internal SearchPattern2 get_Pattern() { }

	// RVA: 0x1530990 Offset: 0x152EF90 VA: 0x181530990
	internal string get_FullPath() { }

	// RVA: 0x1530C20 Offset: 0x152F220 VA: 0x181530C20
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x1530C40 Offset: 0x152F240 VA: 0x181530C40
	public void set_Filter(string value) { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_IncludeSubdirectories() { }

	// RVA: 0x1530CF0 Offset: 0x152F2F0 VA: 0x181530CF0
	public void set_NotifyFilter(NotifyFilters value) { }

	// RVA: 0x1530D30 Offset: 0x152F330 VA: 0x181530D30
	public void set_Path(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public override ISite get_Site() { }

	// RVA: 0x152FE30 Offset: 0x152E430 VA: 0x18152FE30 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x152FE70 Offset: 0x152E470 VA: 0x18152FE70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15302E0 Offset: 0x152E8E0 VA: 0x1815302E0
	private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype) { }

	// RVA: 0x1530220 Offset: 0x152E820 VA: 0x181530220
	protected void OnChanged(FileSystemEventArgs e) { }

	// RVA: 0x1530250 Offset: 0x152E850 VA: 0x181530250
	protected void OnCreated(FileSystemEventArgs e) { }

	// RVA: 0x1530280 Offset: 0x152E880 VA: 0x181530280
	protected void OnDeleted(FileSystemEventArgs e) { }

	// RVA: 0x15302B0 Offset: 0x152E8B0 VA: 0x1815302B0
	protected void OnRenamed(RenamedEventArgs e) { }

	// RVA: 0x152FB90 Offset: 0x152E190 VA: 0x18152FB90
	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	// RVA: 0x15306F0 Offset: 0x152ECF0 VA: 0x1815306F0
	private void Start() { }

	// RVA: 0x1530770 Offset: 0x152ED70 VA: 0x181530770
	private void Stop() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15308F0 Offset: 0x152EEF0 VA: 0x1815308F0
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1530B80 Offset: 0x152F180 VA: 0x181530B80
	public void remove_Changed(FileSystemEventHandler value) { }

	// RVA: 0x10DDD80 Offset: 0x10DC380 VA: 0x1810DDD80
	private static int InternalSupportsFSW() { }

	// RVA: 0x15307F0 Offset: 0x152EDF0 VA: 0x1815307F0
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

	// RVA: 0x1532A60 Offset: 0x1531060 VA: 0x181532A60
	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB4400 Offset: 0xB3800 VA: 0x1800B4400
	// RVA: 0x1532780 Offset: 0x1530D80 VA: 0x181532780
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118E550 Offset: 0x118CB50 VA: 0x18118E550 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1531B50 Offset: 0x1530150 VA: 0x181531B50 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1532BB0 Offset: 0x15311B0 VA: 0x181532BB0
	internal bool get_Aborted() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x1532C50 Offset: 0x1531250 VA: 0x181532C50 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x1532BC0 Offset: 0x15311C0 VA: 0x181532BC0 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x1532CE0 Offset: 0x15312E0 VA: 0x181532CE0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1532D40 Offset: 0x1531340 VA: 0x181532D40 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1532E00 Offset: 0x1531400 VA: 0x181532E00 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB9B280 Offset: 0xB99880 VA: 0x180B9B280 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x15310C0 Offset: 0x152F6C0 VA: 0x1815310C0 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1531410 Offset: 0x152FA10 VA: 0x181531410 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1531680 Offset: 0x152FC80 VA: 0x181531680
	private bool CanGetRequestStream() { }

	// RVA: 0x15316F0 Offset: 0x152FCF0 VA: 0x1815316F0 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1531920 Offset: 0x152FF20 VA: 0x181531920 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1531F20 Offset: 0x1530520 VA: 0x181531F20 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x1532400 Offset: 0x1530A00 VA: 0x181532400 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x1531D20 Offset: 0x1530320 VA: 0x181531D20
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1532130 Offset: 0x1530730 VA: 0x181532130
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1532610 Offset: 0x1530C10 VA: 0x181532610
	internal void UnblockReader() { }

	// RVA: 0x1532C10 Offset: 0x1531210 VA: 0x181532C10 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1532E10 Offset: 0x1531410 VA: 0x181532E10 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1530E70 Offset: 0x152F470 VA: 0x181530E70 Slot: 35
	public override void Abort() { }

	// RVA: 0x15326D0 Offset: 0x1530CD0 VA: 0x1815326D0
	private static void .cctor() { }

}

internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 2949
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x132FCA0 Offset: 0x132E2A0 VA: 0x18132FCA0 Slot: 4
	public WebRequest Create(Uri uri) { }

}

internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 2950
{	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1330BB0 Offset: 0x132F1B0 VA: 0x181330BB0
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1330AF0 Offset: 0x132F0F0 VA: 0x181330AF0
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x13307A0 Offset: 0x132EDA0 VA: 0x1813307A0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1330A00 Offset: 0x132F000 VA: 0x181330A00 Slot: 32
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1330960 Offset: 0x132EF60 VA: 0x181330960 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1330A50 Offset: 0x132F050 VA: 0x181330A50 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x13305A0 Offset: 0x132EBA0 VA: 0x1813305A0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1330860 Offset: 0x132EE60 VA: 0x181330860 Slot: 20
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1330650 Offset: 0x132EC50 VA: 0x181330650 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x13308E0 Offset: 0x132EEE0 VA: 0x1813308E0 Slot: 23
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1330700 Offset: 0x132ED00 VA: 0x181330700
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

	// RVA: 0x13302B0 Offset: 0x132E8B0 VA: 0x1813302B0
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0xB4400 Offset: 0xB3800 VA: 0x1800B4400
	// RVA: 0x13300F0 Offset: 0x132E6F0 VA: 0x1813300F0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118CF60 Offset: 0x118B560 VA: 0x18118CF60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x132FDD0 Offset: 0x132E3D0 VA: 0x18132FDD0 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1330540 Offset: 0x132EB40 VA: 0x181330540 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x1330560 Offset: 0x132EB60 VA: 0x181330560 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1330580 Offset: 0x132EB80 VA: 0x181330580 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x132FD00 Offset: 0x132E300 VA: 0x18132FD00
	private void CheckDisposed() { }

	// RVA: 0x132FD90 Offset: 0x132E390 VA: 0x18132FD90 Slot: 9
	public override void Close() { }

	// RVA: 0x132FFA0 Offset: 0x132E5A0 VA: 0x18132FFA0 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x132FF10 Offset: 0x132E510 VA: 0x18132FF10 Slot: 12
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

	// RVA: 0x1370410 Offset: 0x136EA10 VA: 0x181370410
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

	// RVA: 0x1D59980 Offset: 0x1D57F80 VA: 0x181D59980
	public static void ResetToPool(FileStorageCacheData instance) { }

	// RVA: 0x1D59A30 Offset: 0x1D58030 VA: 0x181D59A30
	public void ResetToPool() { }

	// RVA: 0x1D59610 Offset: 0x1D57C10 VA: 0x181D59610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D58300 Offset: 0x1D56900 VA: 0x181D58300
	public void CopyTo(FileStorageCacheData instance) { }

	// RVA: 0x1D583C0 Offset: 0x1D569C0 VA: 0x181D583C0
	public FileStorageCacheData Copy() { }

	// RVA: 0x1D58DB0 Offset: 0x1D573B0 VA: 0x181D58DB0
	public static FileStorageCacheData Deserialize(Stream stream) { }

	// RVA: 0x1D587B0 Offset: 0x1D56DB0 VA: 0x181D587B0
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D58830 Offset: 0x1D56E30 VA: 0x181D58830
	public static FileStorageCacheData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D59010 Offset: 0x1D57610 VA: 0x181D59010
	public static FileStorageCacheData Deserialize(byte[] buffer) { }

	// RVA: 0x1D59740 Offset: 0x1D57D40 VA: 0x181D59740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5A090 Offset: 0x1D58690 VA: 0x181D5A090 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5A0B0 Offset: 0x1D586B0 VA: 0x181D5A0B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FileStorageCacheData previous) { }

	// RVA: 0x1D59960 Offset: 0x1D57F60 VA: 0x181D59960 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D59320 Offset: 0x1D57920 VA: 0x181D59320
	public static FileStorageCacheData Deserialize(byte[] buffer, FileStorageCacheData instance, bool isDelta = False) { }

	// RVA: 0x1D58B90 Offset: 0x1D57190 VA: 0x181D58B90
	public static FileStorageCacheData Deserialize(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D584C0 Offset: 0x1D56AC0 VA: 0x181D584C0
	public static FileStorageCacheData DeserializeLengthDelimited(Stream stream, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D588C0 Offset: 0x1D56EC0 VA: 0x181D588C0
	public static FileStorageCacheData DeserializeLength(Stream stream, int length, FileStorageCacheData instance, bool isDelta) { }

	// RVA: 0x1D59AE0 Offset: 0x1D580E0 VA: 0x181D59AE0
	public static void SerializeDelta(Stream stream, FileStorageCacheData instance, FileStorageCacheData previous) { }

	// RVA: 0x1D59ED0 Offset: 0x1D584D0 VA: 0x181D59ED0
	public static void Serialize(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x1D5A080 Offset: 0x1D58680 VA: 0x181D5A080
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5A090 Offset: 0x1D58690 VA: 0x181D5A090
	public void ToProto(Stream stream) { }

	// RVA: 0x1D59DC0 Offset: 0x1D583C0 VA: 0x181D59DC0
	public static byte[] SerializeToBytes(FileStorageCacheData instance) { }

	// RVA: 0x1D59D10 Offset: 0x1D58310 VA: 0x181D59D10
	public static void SerializeLengthDelimited(Stream stream, FileStorageCacheData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public static class FileSystem // TypeDefIndex: 6659
{	// Fields
	public static bool LogDebug; // 0x0
	public static bool LogTime; // 0x1
	public static FileSystemBackend Backend; // 0x8

	// Methods

	// RVA: 0x22BDD00 Offset: 0x22BC300 VA: 0x1822BDD00
	public static GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22BDBF0 Offset: 0x22BC1F0 VA: 0x1822BDBF0
	public static GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22BDB60 Offset: 0x22BC160 VA: 0x1822BDB60
	public static string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38CC0 Offset: 0x1A372C0 VA: 0x181A38CC0
	|-FileSystem.LoadAll<Sprite>
	|-FileSystem.LoadAll<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38C00 Offset: 0x1A37200 VA: 0x181A38C00
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

	// RVA: 0x22BDE70 Offset: 0x22BC470 VA: 0x1822BDE70
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

	// RVA: 0x22BD4C0 Offset: 0x22BBAC0 VA: 0x1822BD4C0
	public GameObject[] LoadPrefabs(string folder) { }

	// RVA: 0x22BD400 Offset: 0x22BBA00 VA: 0x1822BD400
	public GameObject LoadPrefab(string filePath) { }

	// RVA: 0x22BD360 Offset: 0x22BB960 VA: 0x1822BD360
	public string[] FindAll(string folder, string search = "") { }

	// RVA: -1 Offset: -1
	public T[] LoadAll<T>(string folder, string search = "") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38AA0 Offset: 0x1A370A0 VA: 0x181A38AA0
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

	// RVA: 0x22BD5E0 Offset: 0x22BBBE0 VA: 0x1822BD5E0
	public AssetPreloadResult PreloadAssets(IEnumerable<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BD380 Offset: 0x22BB980 VA: 0x1822BD380
	protected void LoadError(string err) { }

	// RVA: 0x22BDA10 Offset: 0x22BC010 VA: 0x1822BDA10 Slot: 4
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

	// RVA: 0x22BDA60 Offset: 0x22BC060 VA: 0x1822BDA60
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
	// RVA: 0xFBF650 Offset: 0xFBDC50 VA: 0x180FBF650
	public IEnumerator Open(string path, string allowedExtensions, string windowName = "OPEN FILE", Sprite windowIcon, long maxSize = -1, bool saveLastPath = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x78190 Offset: 0x77590 VA: 0x180078190
	// RVA: 0xFBF8A0 Offset: 0xFBDEA0 VA: 0x180FBF8A0
	public IEnumerator Save(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x78300 Offset: 0x77700 VA: 0x180078300
	// RVA: 0xFBF730 Offset: 0xFBDD30 VA: 0x180FBF730
	public Task<string> SaveAsync(string path, string allowedExtensions, string windowName = "SAVE FILE", Sprite windowIcon, bool saveLastPath = True) { }

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void Hide() { }

	// RVA: 0xFBF220 Offset: 0xFBD820 VA: 0x180FBF220
	public void GoUp() { }

	// RVA: 0xFBEFA0 Offset: 0xFBD5A0 VA: 0x180FBEFA0
	public void GoTo(string newPath) { }

	// RVA: 0xFBF980 Offset: 0xFBDF80 VA: 0x180FBF980
	public void SelectFile(string file) { }

	// RVA: 0xFBF2C0 Offset: 0xFBD8C0 VA: 0x180FBF2C0
	public void OnCommitClick() { }

	// RVA: 0xFBF270 Offset: 0xFBD870 VA: 0x180FBF270
	public void OnCancelClick() { }

	// RVA: 0xFBEE50 Offset: 0xFBD450 VA: 0x180FBEE50
	public void ClearSelection() { }

	// RVA: 0xFBF4D0 Offset: 0xFBDAD0 VA: 0x180FBF4D0
	public void OnTypedFilename(string newName) { }

	// RVA: 0xFBF3A0 Offset: 0xFBD9A0 VA: 0x180FBF3A0
	public void OnTypedEnd(string newName) { }

	// RVA: 0xFBFE80 Offset: 0xFBE480 VA: 0x180FBFE80
	public void UpdateFileInfo() { }

	// RVA: 0xFBF560 Offset: 0xFBDB60 VA: 0x180FBF560
	public void OpenDir(string path) { }

	// RVA: 0xFBFE50 Offset: 0xFBE450 VA: 0x180FBFE50
	private void UpdateElements() { }

	// RVA: 0xFBFAF0 Offset: 0xFBE0F0 VA: 0x180FBFAF0
	private void UpdateDrivesList() { }

	// RVA: 0xFBEEB0 Offset: 0xFBD4B0 VA: 0x180FBEEB0
	private string GetFileSizeText(long size) { }

	// RVA: 0xFC0040 Offset: 0xFBE640 VA: 0x180FC0040
	private void UpdateFilesList() { }

	// RVA: 0xFC11C0 Offset: 0xFBF7C0 VA: 0x180FC11C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFBFA70 Offset: 0xFBE070 VA: 0x180FBFA70
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

	// RVA: 0xFD6C80 Offset: 0xFD5280 VA: 0x180FD6C80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD6FD0 Offset: 0xFD55D0 VA: 0x180FD6FD0 Slot: 8
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

	// RVA: 0xFD7490 Offset: 0xFD5A90 VA: 0x180FD7490 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD77D0 Offset: 0xFD5DD0 VA: 0x180FD77D0 Slot: 8
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

	// RVA: 0xFC11E0 Offset: 0xFBF7E0 VA: 0x180FC11E0
	public void OnClick() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

internal static class FileUtilities // TypeDefIndex: 7615
{	// Methods

	// RVA: 0x1398660 Offset: 0x1396C60 VA: 0x181398660
	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	// RVA: 0x1398920 Offset: 0x1396F20 VA: 0x181398920
	internal static FileStream OpenFileForRead(string filePath) { }

	// RVA: 0x1398780 Offset: 0x1396D80 VA: 0x181398780
	private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition) { }

}

public class FileSystem_Warmup : MonoBehaviour // TypeDefIndex: 9371
{	// Fields
	public static bool ranInBackground; // 0x0
	private static bool run; // 0x1
	public static string[] ExcludeFilter; // 0x8

	// Methods

	// RVA: 0x7880B0 Offset: 0x7866B0 VA: 0x1807880B0
	public static void Run() { }

	// RVA: 0x788230 Offset: 0x786830 VA: 0x180788230
	public static IEnumerator Run(string[] assetList, Action<string> statusFunction, string format, int priority = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7C90 Offset: 0xE7090 VA: 0x1800E7C90
	// RVA: 0x787F60 Offset: 0x786560 VA: 0x180787F60
	private static IEnumerator RunAsyncImpl(string[] assetList, Action<string> statusFunction, string format, int priority) { }

	[IteratorStateMachineAttribute] // RVA: 0xE7D60 Offset: 0xE7160 VA: 0x1800E7D60
	// RVA: 0x788010 Offset: 0x786610 VA: 0x180788010
	private static IEnumerator RunImpl(string[] assetList, Action<string> statusFunction, string format) { }

	// RVA: 0x787AD0 Offset: 0x7860D0 VA: 0x180787AD0
	private static float CalculateFrameBudget() { }

	// RVA: 0x7883E0 Offset: 0x7869E0 VA: 0x1807883E0
	private static bool ShouldIgnore(string path) { }

	// RVA: 0x787B00 Offset: 0x786100 VA: 0x180787B00
	public static string[] GetAssetList(Nullable<bool> poolFilter) { }

	// RVA: 0x787EE0 Offset: 0x7864E0 VA: 0x180787EE0
	private static void PrefabWarmup(string path) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x788510 Offset: 0x786B10 VA: 0x180788510
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

	// RVA: 0x799670 Offset: 0x797C70 VA: 0x180799670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x799AB0 Offset: 0x7980B0 VA: 0x180799AB0 Slot: 8
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

	// RVA: 0x799B00 Offset: 0x798100 VA: 0x180799B00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x799E60 Offset: 0x798460 VA: 0x180799E60 Slot: 8
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

	// RVA: 0x79A2A0 Offset: 0x7988A0 VA: 0x18079A2A0
	internal bool <GetAssetList>b__2(GameManifest.PrefabProperties x) { }

}

private sealed class FileSystem_Warmup.<>c // TypeDefIndex: 9375
{	// Fields
	public static readonly FileSystem_Warmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, string> <>9__9_0; // 0x8
	public static Func<string, bool> <>9__9_1; // 0x10
	public static Func<GameManifest.PrefabProperties, string> <>9__9_3; // 0x18

	// Methods

	// RVA: 0x79A460 Offset: 0x798A60 VA: 0x18079A460
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAssetList>b__9_0(GameManifest.PrefabProperties x) { }

	// RVA: 0x799EB0 Offset: 0x7984B0 VA: 0x180799EB0
	internal bool <GetAssetList>b__9_1(string x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAssetList>b__9_3(GameManifest.PrefabProperties x) { }

}

public class FileStorage : IDisposable // TypeDefIndex: 10719
{	// Fields
	private Database db; // 0x10
	private CRC32 crc; // 0x18
	private MruDictionary<uint, FileStorage.CacheData> _cache; // 0x20
	public static FileStorage client; // 0x0

	// Methods

	// RVA: 0x787A30 Offset: 0x786030 VA: 0x180787A30
	protected void .ctor(string name, bool server) { }

	// RVA: 0x7867C0 Offset: 0x784DC0 VA: 0x1807867C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x786780 Offset: 0x784D80 VA: 0x180786780 Slot: 4
	public void Dispose() { }

	// RVA: 0x786860 Offset: 0x784E60 VA: 0x180786860
	private uint GetCRC(byte[] data, FileStorage.Type type) { }

	// RVA: 0x787760 Offset: 0x785D60 VA: 0x180787760
	public uint Store(byte[] data, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x786BE0 Offset: 0x7851E0 VA: 0x180786BE0
	public byte[] Get(uint crc, FileStorage.Type type, uint entityID, uint numID = 0) { }

	// RVA: 0x787470 Offset: 0x785A70 VA: 0x180787470
	public void Remove(uint crc, FileStorage.Type type, uint entityID) { }

	// RVA: 0x787330 Offset: 0x785930 VA: 0x180787330
	public void RemoveExact(uint crc, FileStorage.Type type, uint entityID, uint numid) { }

	// RVA: 0x787070 Offset: 0x785670 VA: 0x180787070
	public void RemoveEntityNum(uint entityid, uint numid) { }

	// RVA: 0x786F80 Offset: 0x785580 VA: 0x180786F80
	internal void RemoveAllByEntity(uint entityid) { }

	// RVA: 0x786E80 Offset: 0x785480 VA: 0x180786E80
	public void ReassignEntityId(uint oldId, uint newId) { }

	// RVA: 0x7869D0 Offset: 0x784FD0 VA: 0x1807869D0
	public List<FileStorageCacheData> GetCacheData() { }

	// RVA: 0x7875A0 Offset: 0x785BA0 VA: 0x1807875A0
	public void SetCache(List<FileStorageCacheData> data) { }

	// RVA: 0x786730 Offset: 0x784D30 VA: 0x180786730
	public void ClearCache() { }

	// RVA: 0x787920 Offset: 0x785F20 VA: 0x180787920
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

	// RVA: 0x79A1C0 Offset: 0x7987C0 VA: 0x18079A1C0
	internal bool <RemoveEntityNum>b__0(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

private sealed class FileStorage.<>c // TypeDefIndex: 10723
{	// Fields
	public static readonly FileStorage.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, FileStorage.CacheData>, uint> <>9__14_1; // 0x8

	// Methods

	// RVA: 0x79A3A0 Offset: 0x7989A0 VA: 0x18079A3A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A150 Offset: 0x798750 VA: 0x18079A150
	internal uint <RemoveEntityNum>b__14_1(KeyValuePair<uint, FileStorage.CacheData> x) { }

}

public static class FileEx // TypeDefIndex: 11346
{	// Methods

	// RVA: 0x786310 Offset: 0x784910 VA: 0x180786310
	public static void Backup(DirectoryInfo parent, string[] names) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x786680 Offset: 0x784C80 VA: 0x180786680
	public static bool MoveToSafe(FileInfo parent, string target, int retries = 10) { }

	// RVA: 0x786440 Offset: 0x784A40 VA: 0x180786440
	public static void Backup(string[] names) { }

}

public class FileConVar : ConsoleSystem // TypeDefIndex: 11922
{	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool time { get; set; }

	// Methods

	// RVA: 0x6E0460 Offset: 0x6DEA60 VA: 0x1806E0460
	public static bool get_debug() { }

	// RVA: 0x6E0520 Offset: 0x6DEB20 VA: 0x1806E0520
	public static void set_debug(bool value) { }

	// RVA: 0x6E04C0 Offset: 0x6DEAC0 VA: 0x1806E04C0
	public static bool get_time() { }

	// RVA: 0x6E0580 Offset: 0x6DEB80 VA: 0x1806E0580
	public static void set_time(bool value) { }

	// RVA: 0x6E0400 Offset: 0x6DEA00 VA: 0x1806E0400
	public void .ctor() { }

}

