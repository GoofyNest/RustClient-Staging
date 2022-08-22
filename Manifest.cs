internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 485
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE9F90 Offset: 0xFE8590 VA: 0x180FE9F90 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFEAAD0 Offset: 0xFE90D0 VA: 0x180FEAAD0
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0xFE9A60 Offset: 0xFE8060 VA: 0x180FE9A60
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0xFE8E10 Offset: 0xFE7410 VA: 0x180FE8E10
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0xFE98E0 Offset: 0xFE7EE0 VA: 0x180FE98E0
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE8A50 Offset: 0xFE7050 VA: 0x180FE8A50
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0xFE9DB0 Offset: 0xFE83B0 VA: 0x180FE9DB0
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE88C0 Offset: 0xFE6EC0 VA: 0x180FE88C0
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0xFE9D50 Offset: 0xFE8350 VA: 0x180FE9D50
	private string GetSatelliteAssemblyName() { }

	// RVA: 0xFEA750 Offset: 0xFE8D50 VA: 0x180FEA750
	private void HandleSatelliteMissing() { }

	// RVA: 0xFEA430 Offset: 0xFE8A30 VA: 0x180FEA430
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0xFE99D0 Offset: 0xFE7FD0 VA: 0x180FE99D0
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }

}

public class ManifestResourceInfo // TypeDefIndex: 531
{	// Fields
	private Assembly _containingAssembly; // 0x10
	private string _containingFileName; // 0x18
	private ResourceLocation _resourceLocation; // 0x20

	// Properties
	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }

	// Methods

	// RVA: 0x13853C0 Offset: 0x13839C0 VA: 0x1813853C0
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public virtual string get_FileName() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 6
	public virtual ResourceLocation get_ResourceLocation() { }

}

internal class ManifestBuilder // TypeDefIndex: 1624
{	// Fields
	private Dictionary<int, string> opcodeTab; // 0x10
	private Dictionary<int, string> taskTab; // 0x18
	private Dictionary<ulong, string> keywordTab; // 0x20
	private Dictionary<string, Type> mapsTab; // 0x28
	private Dictionary<string, string> stringTab; // 0x30
	private StringBuilder sb; // 0x38
	private StringBuilder events; // 0x40
	private StringBuilder templates; // 0x48
	private ResourceManager resources; // 0x50
	private EventManifestOptions flags; // 0x58
	private IList<string> errors; // 0x60
	private Dictionary<string, List<int>> perEventByteArrayArgIndices; // 0x68
	private string eventName; // 0x70
	private int numParams; // 0x78
	private List<int> byteArrArgIndices; // 0x80

	// Properties
	public IList<string> Errors { get; }

	// Methods

	// RVA: 0x10E4D20 Offset: 0x10E3320 VA: 0x1810E4D20
	public void .ctor(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) { }

	// RVA: 0x10E0A90 Offset: 0x10DF090 VA: 0x1810E0A90
	public void AddOpcode(string name, int value) { }

	// RVA: 0x10E0DD0 Offset: 0x10DF3D0 VA: 0x1810E0DD0
	public void AddTask(string name, int value) { }

	// RVA: 0x10E0520 Offset: 0x10DEB20 VA: 0x1810E0520
	public void AddKeyword(string name, ulong value) { }

	// RVA: 0x10E3920 Offset: 0x10E1F20 VA: 0x1810E3920
	public void StartEvent(string eventName, EventAttribute eventAttribute) { }

	// RVA: 0x10DFFD0 Offset: 0x10DE5D0 VA: 0x1810DFFD0
	public void AddEventParameter(Type type, string name) { }

	// RVA: 0x10E27A0 Offset: 0x10E0DA0 VA: 0x1810E27A0
	public void EndEvent() { }

	// RVA: 0x10E2760 Offset: 0x10E0D60 VA: 0x1810E2760
	public byte[] CreateManifest() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public IList<string> get_Errors() { }

	// RVA: 0x10E3810 Offset: 0x10E1E10 VA: 0x1810E3810
	public void ManifestError(string msg, bool runtimeCritical = False) { }

	// RVA: 0x10E1150 Offset: 0x10DF750 VA: 0x1810E1150
	private string CreateManifestString() { }

	// RVA: 0x10E4C60 Offset: 0x10E3260 VA: 0x1810E4C60
	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name) { }

	// RVA: 0x10E4A40 Offset: 0x10E3040 VA: 0x1810E4A40
	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value) { }

	// RVA: 0x10E2CD0 Offset: 0x10E12D0 VA: 0x1810E2CD0
	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat) { }

	// RVA: 0x10E30B0 Offset: 0x10E16B0 VA: 0x1810E30B0
	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources) { }

	// RVA: 0x10E2C20 Offset: 0x10E1220 VA: 0x1810E2C20
	private static string GetLevelName(EventLevel level) { }

	// RVA: 0x10E3260 Offset: 0x10E1860 VA: 0x1810E3260
	private string GetTaskName(EventTask task, string eventName) { }

	// RVA: 0x10E2DF0 Offset: 0x10E13F0 VA: 0x1810E2DF0
	private string GetOpcodeName(EventOpcode opcode, string eventName) { }

	// RVA: 0x10E2990 Offset: 0x10E0F90 VA: 0x1810E2990
	private string GetKeywords(ulong keywords, string eventName) { }

	// RVA: 0x10E3370 Offset: 0x10E1970 VA: 0x1810E3370
	private string GetTypeName(Type type) { }

	// RVA: 0x10E4990 Offset: 0x10E2F90 VA: 0x1810E4990
	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count) { }

	// RVA: 0x10E3F10 Offset: 0x10E2510 VA: 0x1810E3F10
	private string TranslateToManifestConvention(string eventMessage, string evtName) { }

	// RVA: 0x10E3DA0 Offset: 0x10E23A0 VA: 0x1810E3DA0
	private int TranslateIndexToManifestConvention(int idx, string evtName) { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_0 // TypeDefIndex: 1625
{	// Fields
	public StringBuilder stringBuilder; // 0x10
	public string eventMessage; // 0x18
	public int writtenSoFar; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class ManifestBuilder.<>c__DisplayClass22_1 // TypeDefIndex: 1626
{	// Fields
	public int i; // 0x10
	public ManifestBuilder.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10EAB10 Offset: 0x10E9110 VA: 0x1810EAB10
	internal void <TranslateToManifestConvention>b__0(char ch, string escape) { }

}

internal struct ManifestEnvelope // TypeDefIndex: 1627
{	// Fields
	public ManifestEnvelope.ManifestFormats Format; // 0x0
	public byte MajorVersion; // 0x1
	public byte MinorVersion; // 0x2
	public byte Magic; // 0x3
	public ushort TotalChunks; // 0x4
	public ushort ChunkNumber; // 0x6

}

public enum ManifestEnvelope.ManifestFormats // TypeDefIndex: 1628
{	// Fields
	public byte value__; // 0x0
	public const ManifestEnvelope.ManifestFormats SimpleXmlFormat = 1;

}

public static class Manifest // TypeDefIndex: 6199
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static DateTime <LastDownloaded>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string <Contents>k__BackingField; // 0x8

	// Properties
	public static DateTime LastDownloaded { get; set; }
	public static string Contents { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4D50 Offset: 0x14B3350 VA: 0x1814B4D50
	public static DateTime get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4DE0 Offset: 0x14B33E0 VA: 0x1814B4DE0
	internal static void set_LastDownloaded(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4D10 Offset: 0x14B3310 VA: 0x1814B4D10
	public static string get_Contents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4D90 Offset: 0x14B3390 VA: 0x1814B4D90
	internal static void set_Contents(string value) { }

	// RVA: 0x14B4160 Offset: 0x14B2760 VA: 0x1814B4160
	internal static void Download() { }

	[IteratorStateMachineAttribute] // RVA: 0xA5500 Offset: 0xA4900 VA: 0x1800A5500
	// RVA: 0x14B4CC0 Offset: 0x14B32C0 VA: 0x1814B4CC0
	private static IEnumerator UpdateManifest() { }

	// RVA: 0x14B43D0 Offset: 0x14B29D0 VA: 0x1814B43D0
	private static void LoadManifest(string text) { }

	// RVA: 0x14B4BF0 Offset: 0x14B31F0 VA: 0x1814B4BF0
	private static void OnManifestLoaded(Manifest manifest) { }

}

private sealed class Manifest.<>c // TypeDefIndex: 6200
{	// Fields
	public static readonly Manifest.<>c <>9; // 0x0
	public static Action<string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x14BC370 Offset: 0x14BA970 VA: 0x1814BC370
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BBBC0 Offset: 0x14BA1C0 VA: 0x1814BBBC0
	internal void <UpdateManifest>b__9_0(string str) { }

}

private sealed class Manifest.<UpdateManifest>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6201
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private string <url>5__2; // 0x20

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

	// RVA: 0x14BC550 Offset: 0x14BAB50 VA: 0x1814BC550 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BC8B0 Offset: 0x14BAEB0 VA: 0x1814BC8B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class Manifest // TypeDefIndex: 6244
{	// Fields
	public Manifest.NewsInfo News; // 0x10
	public Manifest.ServersInfo Servers; // 0x18
	public string ExceptionReportingUrl; // 0x20
	public string BenchmarkUrl; // 0x28
	public string AnalyticUrl; // 0x30
	public string DatabaseUrl; // 0x38
	public string LeaderboardUrl; // 0x40
	public string ReportUrl; // 0x48
	public string AccountUrl; // 0x50
	public Hero[] Heroes; // 0x58
	public Manifest.Administrator[] Administrators; // 0x60
	public JObject Metadata; // 0x68

	// Methods

	// RVA: 0x14B42D0 Offset: 0x14B28D0 VA: 0x1814B42D0
	internal static Manifest FromJson(string text) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Manifest.Administrator // TypeDefIndex: 6245
{	// Fields
	public string UserId; // 0x10
	public string Level; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Manifest.NewsInfo // TypeDefIndex: 6246
{	// Fields
	public Manifest.NewsInfo.BlogInfo[] Blogs; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Manifest.NewsInfo.BlogInfo // TypeDefIndex: 6247
{	// Fields
	public DateTime Date; // 0x10
	public string ShortName; // 0x18
	public string Title; // 0x20
	public string HeaderImage; // 0x28
	public string SummaryHtml; // 0x30
	public string Url; // 0x38
	public string Tags; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Manifest.ServersInfo // TypeDefIndex: 6248
{	// Fields
	public Manifest.ServerDesc[] Official; // 0x10
	public string[] Banned; // 0x18

	// Methods

	// RVA: 0x14B8290 Offset: 0x14B6890 VA: 0x1814B8290
	public bool IsBannedServer(string ip) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Manifest.ServerDesc // TypeDefIndex: 6249
{	// Fields
	public string Address; // 0x10
	public int Port; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Manifest // TypeDefIndex: 11943
{	// Methods

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x366330 Offset: 0x364930 VA: 0x180366330
	public static object PrintManifest() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x3662F0 Offset: 0x3648F0 VA: 0x1803662F0
	public static object PrintManifestRaw() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

