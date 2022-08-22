public static class Global // TypeDefIndex: 6621
{	public static Func<string, GameObject> LoadPrefab; // 0x0
	public static Func<string, GameObject> FindPrefab; // 0x8
	public static Func<string, GameObject> CreatePrefab; // 0x10
	public static Action OpenMainMenu; // 0x18
	private static MonoBehaviour _runner; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static int <LaunchCountThisVersion>k__BackingField; // 0x28

	public static MonoBehaviour Runner { get; }
	public static int LaunchCountThisVersion { get; set; }


	public static MonoBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void set_LaunchCountThisVersion(int value) { }

	public static void Init() { }

}

public class Global : ConsoleSystem // TypeDefIndex: 11926
{	private static int _developer; // 0x0
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool skipassetwarmup; // 0x4
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static int maxthreads; // 0x8
	private const int DefaultWarmupConcurrency = 1;
	private const int DefaultPreloadConcurrency = 1;
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static int warmupConcurrency; // 0xC
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static int preloadConcurrency; // 0x10
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool forceUnloadBundles; // 0x14
	private const bool DefaultAsyncWarmupEnabled = False;
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool asyncWarmup; // 0x15
	private static int _censornudity; // 0x18
	private static bool _censorsigns; // 0x1C
	[ClientVar] // RVA: 0x9DC60 Offset: 0x9D060 VA: 0x18009DC60
	public static int signUndoBuffer; // 0x20
	private static bool _censorRecordings; // 0x24
	private static bool _processMidiInput; // 0x25
	private static bool _showBlood; // 0x26
	[ClientVar] // RVA: 0x9DD20 Offset: 0x9D120 VA: 0x18009DD20
	public static bool limitFlashing; // 0x27
	[ClientVar] // RVA: 0x9DD90 Offset: 0x9D190 VA: 0x18009DD90
	public static bool showItemCountsOnPickup; // 0x28
	[ClientVar] // RVA: 0x9DF20 Offset: 0x9D320 VA: 0x18009DF20
	public static bool useSingleItemPickupNotice; // 0x29
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool showItemPickupNotices; // 0x2A
	[ClientVar] // RVA: 0x9E0D0 Offset: 0x9D4D0 VA: 0x18009E0D0
	public static float vehicleDismountHoldTime; // 0x2C
	[ServerVar] // RVA: 0x9E1A0 Offset: 0x9D5A0 VA: 0x18009E1A0
	[ClientVar] // RVA: 0x9E1A0 Offset: 0x9D5A0 VA: 0x18009E1A0
	public static int perf; // 0x30
	[ClientVar] // RVA: 0x9E340 Offset: 0x9D740 VA: 0x18009E340
	public static bool god; // 0x34
	[ClientVar] // RVA: 0x9E650 Offset: 0x9DA50 VA: 0x18009E650
	public static bool specnet; // 0x35
	[ClientVar] // RVA: 0x8ECF0 Offset: 0x8E0F0 VA: 0x18008ECF0
	public static bool streamermode; // 0x36
	[ClientVar] // RVA: 0x8ECF0 Offset: 0x8E0F0 VA: 0x18008ECF0
	public static bool richPresence; // 0x37
	private static float _consoleScale; // 0x38

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static int developer { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int censornudity { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool censorsigns { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool censorrecordings { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool processMidiInput { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool showBlood { get; set; }
	[ClientVar] // RVA: 0x8ECF0 Offset: 0x8E0F0 VA: 0x18008ECF0
	public static string language { get; set; }
	[ClientVar] // RVA: 0x9FC70 Offset: 0x9F070 VA: 0x18009FC70
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

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void writecfg() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void free(ConsoleSystem.Arg args) { }

	public static string get_language() { }

	public static void set_language(string value) { }

	public static float get_consoleScale() { }

	public static void set_consoleScale(float value) { }

	[ServerVar] // RVA: 0x9F4F0 Offset: 0x9E8F0 VA: 0x18009F4F0
	[ClientVar] // RVA: 0x9F4F0 Offset: 0x9E8F0 VA: 0x18009F4F0
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 11927
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

