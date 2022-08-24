public static class Global // TypeDefIndex: 6621
{	public static Func<string, GameObject> LoadPrefab; // 0x0
	public static Func<string, GameObject> FindPrefab; // 0x8
	public static Func<string, GameObject> CreatePrefab; // 0x10
	public static Action OpenMainMenu; // 0x18
	private static MonoBehaviour _runner; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static int <LaunchCountThisVersion>k__BackingField; // 0x28

	public static MonoBehaviour Runner { get; }
	public static int LaunchCountThisVersion { get; set; }


	public static MonoBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void set_LaunchCountThisVersion(int value) { }

	public static void Init() { }

}

public class Global : ConsoleSystem // TypeDefIndex: 11930
{	private static int _developer; // 0x0
	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static bool skipassetwarmup; // 0x4
	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static int maxthreads; // 0x8
	private const int DefaultWarmupConcurrency = 1;
	private const int DefaultPreloadConcurrency = 1;
	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static int warmupConcurrency; // 0xC
	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static int preloadConcurrency; // 0x10
	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static bool forceUnloadBundles; // 0x14
	private const bool DefaultAsyncWarmupEnabled = False;
	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static bool asyncWarmup; // 0x15
	private static int _censornudity; // 0x18
	private static bool _censorsigns; // 0x1C
	[ClientVar] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	public static int signUndoBuffer; // 0x20
	private static bool _censorRecordings; // 0x24
	private static bool _processMidiInput; // 0x25
	private static bool _showBlood; // 0x26
	[ClientVar] // RVA: 0x9D6B0 Offset: 0x9CAB0 VA: 0x18009D6B0
	public static bool limitFlashing; // 0x27
	[ClientVar] // RVA: 0x9D740 Offset: 0x9CB40 VA: 0x18009D740
	public static bool showItemCountsOnPickup; // 0x28
	[ClientVar] // RVA: 0x9DC80 Offset: 0x9D080 VA: 0x18009DC80
	public static bool useSingleItemPickupNotice; // 0x29
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static bool showItemPickupNotices; // 0x2A
	[ClientVar] // RVA: 0x9DD30 Offset: 0x9D130 VA: 0x18009DD30
	public static float vehicleDismountHoldTime; // 0x2C
	[ServerVar] // RVA: 0x9DDF0 Offset: 0x9D1F0 VA: 0x18009DDF0
	[ClientVar] // RVA: 0x9DDF0 Offset: 0x9D1F0 VA: 0x18009DDF0
	public static int perf; // 0x30
	[ClientVar] // RVA: 0x9DEA0 Offset: 0x9D2A0 VA: 0x18009DEA0
	public static bool god; // 0x34
	[ClientVar] // RVA: 0x9E030 Offset: 0x9D430 VA: 0x18009E030
	public static bool specnet; // 0x35
	[ClientVar] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	public static bool streamermode; // 0x36
	[ClientVar] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	public static bool richPresence; // 0x37
	private static float _consoleScale; // 0x38

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static int developer { get; set; }
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static int censornudity { get; set; }
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool censorsigns { get; set; }
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool censorrecordings { get; set; }
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool processMidiInput { get; set; }
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool showBlood { get; set; }
	[ClientVar] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	public static string language { get; set; }
	[ClientVar] // RVA: 0x9F910 Offset: 0x9ED10 VA: 0x18009F910
	public static float consoleScale { get; set; }


	public static void set_developer(int value) { }

	public static int get_developer() { }

	public static int get_censornudity() { }

	public static void set_censornudity(int value) { }

	private static bool ForceUnderwear() { }

	public static bool get_censorsigns() { }

	public static void set_censorsigns(bool value) { }

	public static bool get_censorrecordings() { }

	public static void set_censorrecordings(bool value) { }

	public static bool get_processMidiInput() { }

	public static void set_processMidiInput(bool value) { }

	public static bool get_showBlood() { }

	public static void set_showBlood(bool value) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void writecfg() { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void free(ConsoleSystem.Arg args) { }

	public static string get_language() { }

	public static void set_language(string value) { }

	public static float get_consoleScale() { }

	public static void set_consoleScale(float value) { }

	[ServerVar] // RVA: 0x9F2D0 Offset: 0x9E6D0 VA: 0x18009F2D0
	[ClientVar] // RVA: 0x9F2D0 Offset: 0x9E6D0 VA: 0x18009F2D0
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 11931
{	public static readonly Global.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, long>, long> <>9__46_0; // 0x8
	public static Func<Collider, bool> <>9__48_0; // 0x10
	public static Func<Collider, bool> <>9__48_1; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal long <objects>b__46_0(KeyValuePair<Type, long> x) { }

	internal bool <colliders>b__48_0(Collider x) { }

	internal bool <colliders>b__48_1(Collider x) { }

}

