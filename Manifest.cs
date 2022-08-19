internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 485
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE9230 Offset: 0xFE7830 VA: 0x180FE9230 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE9D70 Offset: 0xFE8370 VA: 0x180FE9D70
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0xFE8D00 Offset: 0xFE7300 VA: 0x180FE8D00
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0xFE80B0 Offset: 0xFE66B0 VA: 0x180FE80B0
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0xFE8B80 Offset: 0xFE7180 VA: 0x180FE8B80
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE7CF0 Offset: 0xFE62F0 VA: 0x180FE7CF0
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0xFE9050 Offset: 0xFE7650 VA: 0x180FE9050
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE7B60 Offset: 0xFE6160 VA: 0x180FE7B60
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0xFE8FF0 Offset: 0xFE75F0 VA: 0x180FE8FF0
	private string GetSatelliteAssemblyName() { }

	// RVA: 0xFE99F0 Offset: 0xFE7FF0 VA: 0x180FE99F0
	private void HandleSatelliteMissing() { }

	// RVA: 0xFE96D0 Offset: 0xFE7CD0 VA: 0x180FE96D0
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0xFE8C70 Offset: 0xFE7270 VA: 0x180FE8C70
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

	// RVA: 0x1386000 Offset: 0x1384600 VA: 0x181386000
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public virtual string get_FileName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 6
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

	// RVA: 0x10E3FF0 Offset: 0x10E25F0 VA: 0x1810E3FF0
	public void .ctor(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) { }

	// RVA: 0x10DFD60 Offset: 0x10DE360 VA: 0x1810DFD60
	public void AddOpcode(string name, int value) { }

	// RVA: 0x10E00A0 Offset: 0x10DE6A0 VA: 0x1810E00A0
	public void AddTask(string name, int value) { }

	// RVA: 0x10DF7F0 Offset: 0x10DDDF0 VA: 0x1810DF7F0
	public void AddKeyword(string name, ulong value) { }

	// RVA: 0x10E2BF0 Offset: 0x10E11F0 VA: 0x1810E2BF0
	public void StartEvent(string eventName, EventAttribute eventAttribute) { }

	// RVA: 0x10DF2A0 Offset: 0x10DD8A0 VA: 0x1810DF2A0
	public void AddEventParameter(Type type, string name) { }

	// RVA: 0x10E1A70 Offset: 0x10E0070 VA: 0x1810E1A70
	public void EndEvent() { }

	// RVA: 0x10E1A30 Offset: 0x10E0030 VA: 0x1810E1A30
	public byte[] CreateManifest() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public IList<string> get_Errors() { }

	// RVA: 0x10E2AE0 Offset: 0x10E10E0 VA: 0x1810E2AE0
	public void ManifestError(string msg, bool runtimeCritical = False) { }

	// RVA: 0x10E0420 Offset: 0x10DEA20 VA: 0x1810E0420
	private string CreateManifestString() { }

	// RVA: 0x10E3F30 Offset: 0x10E2530 VA: 0x1810E3F30
	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name) { }

	// RVA: 0x10E3D10 Offset: 0x10E2310 VA: 0x1810E3D10
	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value) { }

	// RVA: 0x10E1FA0 Offset: 0x10E05A0 VA: 0x1810E1FA0
	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat) { }

	// RVA: 0x10E2380 Offset: 0x10E0980 VA: 0x1810E2380
	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources) { }

	// RVA: 0x10E1EF0 Offset: 0x10E04F0 VA: 0x1810E1EF0
	private static string GetLevelName(EventLevel level) { }

	// RVA: 0x10E2530 Offset: 0x10E0B30 VA: 0x1810E2530
	private string GetTaskName(EventTask task, string eventName) { }

	// RVA: 0x10E20C0 Offset: 0x10E06C0 VA: 0x1810E20C0
	private string GetOpcodeName(EventOpcode opcode, string eventName) { }

	// RVA: 0x10E1C60 Offset: 0x10E0260 VA: 0x1810E1C60
	private string GetKeywords(ulong keywords, string eventName) { }

	// RVA: 0x10E2640 Offset: 0x10E0C40 VA: 0x1810E2640
	private string GetTypeName(Type type) { }

	// RVA: 0x10E3C60 Offset: 0x10E2260 VA: 0x1810E3C60
	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count) { }

	// RVA: 0x10E31E0 Offset: 0x10E17E0 VA: 0x1810E31E0
	private string TranslateToManifestConvention(string eventMessage, string evtName) { }

	// RVA: 0x10E3070 Offset: 0x10E1670 VA: 0x1810E3070
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

	// RVA: 0x10E9DE0 Offset: 0x10E83E0 VA: 0x1810E9DE0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static DateTime <LastDownloaded>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static string <Contents>k__BackingField; // 0x8

	// Properties
	public static DateTime LastDownloaded { get; set; }
	public static string Contents { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B59C0 Offset: 0x14B3FC0 VA: 0x1814B59C0
	public static DateTime get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B5A50 Offset: 0x14B4050 VA: 0x1814B5A50
	internal static void set_LastDownloaded(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B5980 Offset: 0x14B3F80 VA: 0x1814B5980
	public static string get_Contents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B5A00 Offset: 0x14B4000 VA: 0x1814B5A00
	internal static void set_Contents(string value) { }

	// RVA: 0x14B4DD0 Offset: 0x14B33D0 VA: 0x1814B4DD0
	internal static void Download() { }

	[IteratorStateMachineAttribute] // RVA: 0xA5470 Offset: 0xA4870 VA: 0x1800A5470
	// RVA: 0x14B5930 Offset: 0x14B3F30 VA: 0x1814B5930
	private static IEnumerator UpdateManifest() { }

	// RVA: 0x14B5040 Offset: 0x14B3640 VA: 0x1814B5040
	private static void LoadManifest(string text) { }

	// RVA: 0x14B5860 Offset: 0x14B3E60 VA: 0x1814B5860
	private static void OnManifestLoaded(Manifest manifest) { }

}

private sealed class Manifest.<>c // TypeDefIndex: 6200
{	// Fields
	public static readonly Manifest.<>c <>9; // 0x0
	public static Action<string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x14BCFE0 Offset: 0x14BB5E0 VA: 0x1814BCFE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BC830 Offset: 0x14BAE30 VA: 0x1814BC830
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14BD1C0 Offset: 0x14BB7C0 VA: 0x1814BD1C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14BD520 Offset: 0x14BBB20 VA: 0x1814BD520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x14B4F40 Offset: 0x14B3540 VA: 0x1814B4F40
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

	// RVA: 0x14B8F00 Offset: 0x14B7500 VA: 0x1814B8F00
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

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x366330 Offset: 0x364930 VA: 0x180366330
	public static object PrintManifest() { }

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x3662F0 Offset: 0x3648F0 VA: 0x1803662F0
	public static object PrintManifestRaw() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

