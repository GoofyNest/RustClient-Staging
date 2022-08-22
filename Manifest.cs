internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 485
{	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0xFE94F0 Offset: 0xFE7AF0 VA: 0x180FE94F0 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0xFEA030 Offset: 0xFE8630 VA: 0x180FEA030
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0xFE8FC0 Offset: 0xFE75C0 VA: 0x180FE8FC0
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0xFE8370 Offset: 0xFE6970 VA: 0x180FE8370
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0xFE8E40 Offset: 0xFE7440 VA: 0x180FE8E40
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE7FB0 Offset: 0xFE65B0 VA: 0x180FE7FB0
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0xFE9310 Offset: 0xFE7910 VA: 0x180FE9310
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0xFE7E20 Offset: 0xFE6420 VA: 0x180FE7E20
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0xFE92B0 Offset: 0xFE78B0 VA: 0x180FE92B0
	private string GetSatelliteAssemblyName() { }

	// RVA: 0xFE9CB0 Offset: 0xFE82B0 VA: 0x180FE9CB0
	private void HandleSatelliteMissing() { }

	// RVA: 0xFE9990 Offset: 0xFE7F90 VA: 0x180FE9990
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0xFE8F30 Offset: 0xFE7530 VA: 0x180FE8F30
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

	// RVA: 0x13862C0 Offset: 0x13848C0 VA: 0x1813862C0
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

	// RVA: 0x10E42B0 Offset: 0x10E28B0 VA: 0x1810E42B0
	public void .ctor(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) { }

	// RVA: 0x10E0020 Offset: 0x10DE620 VA: 0x1810E0020
	public void AddOpcode(string name, int value) { }

	// RVA: 0x10E0360 Offset: 0x10DE960 VA: 0x1810E0360
	public void AddTask(string name, int value) { }

	// RVA: 0x10DFAB0 Offset: 0x10DE0B0 VA: 0x1810DFAB0
	public void AddKeyword(string name, ulong value) { }

	// RVA: 0x10E2EB0 Offset: 0x10E14B0 VA: 0x1810E2EB0
	public void StartEvent(string eventName, EventAttribute eventAttribute) { }

	// RVA: 0x10DF560 Offset: 0x10DDB60 VA: 0x1810DF560
	public void AddEventParameter(Type type, string name) { }

	// RVA: 0x10E1D30 Offset: 0x10E0330 VA: 0x1810E1D30
	public void EndEvent() { }

	// RVA: 0x10E1CF0 Offset: 0x10E02F0 VA: 0x1810E1CF0
	public byte[] CreateManifest() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public IList<string> get_Errors() { }

	// RVA: 0x10E2DA0 Offset: 0x10E13A0 VA: 0x1810E2DA0
	public void ManifestError(string msg, bool runtimeCritical = False) { }

	// RVA: 0x10E06E0 Offset: 0x10DECE0 VA: 0x1810E06E0
	private string CreateManifestString() { }

	// RVA: 0x10E41F0 Offset: 0x10E27F0 VA: 0x1810E41F0
	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name) { }

	// RVA: 0x10E3FD0 Offset: 0x10E25D0 VA: 0x1810E3FD0
	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value) { }

	// RVA: 0x10E2260 Offset: 0x10E0860 VA: 0x1810E2260
	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat) { }

	// RVA: 0x10E2640 Offset: 0x10E0C40 VA: 0x1810E2640
	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources) { }

	// RVA: 0x10E21B0 Offset: 0x10E07B0 VA: 0x1810E21B0
	private static string GetLevelName(EventLevel level) { }

	// RVA: 0x10E27F0 Offset: 0x10E0DF0 VA: 0x1810E27F0
	private string GetTaskName(EventTask task, string eventName) { }

	// RVA: 0x10E2380 Offset: 0x10E0980 VA: 0x1810E2380
	private string GetOpcodeName(EventOpcode opcode, string eventName) { }

	// RVA: 0x10E1F20 Offset: 0x10E0520 VA: 0x1810E1F20
	private string GetKeywords(ulong keywords, string eventName) { }

	// RVA: 0x10E2900 Offset: 0x10E0F00 VA: 0x1810E2900
	private string GetTypeName(Type type) { }

	// RVA: 0x10E3F20 Offset: 0x10E2520 VA: 0x1810E3F20
	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count) { }

	// RVA: 0x10E34A0 Offset: 0x10E1AA0 VA: 0x1810E34A0
	private string TranslateToManifestConvention(string eventMessage, string evtName) { }

	// RVA: 0x10E3330 Offset: 0x10E1930 VA: 0x1810E3330
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

	// RVA: 0x10EA0A0 Offset: 0x10E86A0 VA: 0x1810EA0A0
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
	// RVA: 0x14B5C80 Offset: 0x14B4280 VA: 0x1814B5C80
	public static DateTime get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B5D10 Offset: 0x14B4310 VA: 0x1814B5D10
	internal static void set_LastDownloaded(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B5C40 Offset: 0x14B4240 VA: 0x1814B5C40
	public static string get_Contents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B5CC0 Offset: 0x14B42C0 VA: 0x1814B5CC0
	internal static void set_Contents(string value) { }

	// RVA: 0x14B5090 Offset: 0x14B3690 VA: 0x1814B5090
	internal static void Download() { }

	[IteratorStateMachineAttribute] // RVA: 0xA5500 Offset: 0xA4900 VA: 0x1800A5500
	// RVA: 0x14B5BF0 Offset: 0x14B41F0 VA: 0x1814B5BF0
	private static IEnumerator UpdateManifest() { }

	// RVA: 0x14B5300 Offset: 0x14B3900 VA: 0x1814B5300
	private static void LoadManifest(string text) { }

	// RVA: 0x14B5B20 Offset: 0x14B4120 VA: 0x1814B5B20
	private static void OnManifestLoaded(Manifest manifest) { }

}

private sealed class Manifest.<>c // TypeDefIndex: 6200
{	// Fields
	public static readonly Manifest.<>c <>9; // 0x0
	public static Action<string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x14BD2A0 Offset: 0x14BB8A0 VA: 0x1814BD2A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCAF0 Offset: 0x14BB0F0 VA: 0x1814BCAF0
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

	// RVA: 0x14BD480 Offset: 0x14BBA80 VA: 0x1814BD480 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BD7E0 Offset: 0x14BBDE0 VA: 0x1814BD7E0 Slot: 8
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

	// RVA: 0x14B5200 Offset: 0x14B3800 VA: 0x1814B5200
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

	// RVA: 0x14B91C0 Offset: 0x14B77C0 VA: 0x1814B91C0
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

