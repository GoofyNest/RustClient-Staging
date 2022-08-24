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
	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static bool skipassetwarmup; // 0x4
	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static int maxthreads; // 0x8
	private const int DefaultWarmupConcurrency = 1;
	private const int DefaultPreloadConcurrency = 1;
	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static int warmupConcurrency; // 0xC
	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static int preloadConcurrency; // 0x10
	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static bool forceUnloadBundles; // 0x14
	private const bool DefaultAsyncWarmupEnabled = False;
	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static bool asyncWarmup; // 0x15
	private static int _censornudity; // 0x18
	private static bool _censorsigns; // 0x1C
	[ClientVar] // RVA: 0x9DE40 Offset: 0x9D240 VA: 0x18009DE40
	public static int signUndoBuffer; // 0x20
	private static bool _censorRecordings; // 0x24
	private static bool _processMidiInput; // 0x25
	private static bool _showBlood; // 0x26
	[ClientVar] // RVA: 0x9DFD0 Offset: 0x9D3D0 VA: 0x18009DFD0
	public static bool limitFlashing; // 0x27
	[ClientVar] // RVA: 0x9E0C0 Offset: 0x9D4C0 VA: 0x18009E0C0
	public static bool showItemCountsOnPickup; // 0x28
	[ClientVar] // RVA: 0x9E1C0 Offset: 0x9D5C0 VA: 0x18009E1C0
	public static bool useSingleItemPickupNotice; // 0x29
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static bool showItemPickupNotices; // 0x2A
	[ClientVar] // RVA: 0x9E310 Offset: 0x9D710 VA: 0x18009E310
	public static float vehicleDismountHoldTime; // 0x2C
	[ServerVar] // RVA: 0x9E4B0 Offset: 0x9D8B0 VA: 0x18009E4B0
	[ClientVar] // RVA: 0x9E4B0 Offset: 0x9D8B0 VA: 0x18009E4B0
	public static int perf; // 0x30
	[ClientVar] // RVA: 0x9E7E0 Offset: 0x9DBE0 VA: 0x18009E7E0
	public static bool god; // 0x34
	[ClientVar] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	public static bool specnet; // 0x35
	[ClientVar] // RVA: 0x8EF80 Offset: 0x8E380 VA: 0x18008EF80
	public static bool streamermode; // 0x36
	[ClientVar] // RVA: 0x8EF80 Offset: 0x8E380 VA: 0x18008EF80
	public static bool richPresence; // 0x37
	private static float _consoleScale; // 0x38

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static int developer { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static int censornudity { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool censorsigns { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool censorrecordings { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool processMidiInput { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool showBlood { get; set; }
	[ClientVar] // RVA: 0x8EF80 Offset: 0x8E380 VA: 0x18008EF80
	public static string language { get; set; }
	[ClientVar] // RVA: 0xA1130 Offset: 0xA0530 VA: 0x1800A1130
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

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x939A0 Offset: 0x92DA0 VA: 0x1800939A0
	[ServerVar] // RVA: 0x939A0 Offset: 0x92DA0 VA: 0x1800939A0
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void writecfg() { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void free(ConsoleSystem.Arg args) { }

	public static string get_language() { }

	public static void set_language(string value) { }

	public static float get_consoleScale() { }

	public static void set_consoleScale(float value) { }

	[ServerVar] // RVA: 0x9F800 Offset: 0x9EC00 VA: 0x18009F800
	[ClientVar] // RVA: 0x9F800 Offset: 0x9EC00 VA: 0x18009F800
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
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

