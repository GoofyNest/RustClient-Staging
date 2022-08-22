public static class Global // TypeDefIndex: 6621
{	// Fields
	public static Func<string, GameObject> LoadPrefab; // 0x0
	public static Func<string, GameObject> FindPrefab; // 0x8
	public static Func<string, GameObject> CreatePrefab; // 0x10
	public static Action OpenMainMenu; // 0x18
	private static MonoBehaviour _runner; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static int <LaunchCountThisVersion>k__BackingField; // 0x28

	// Properties
	public static MonoBehaviour Runner { get; }
	public static int LaunchCountThisVersion { get; set; }

	// Methods

	// RVA: 0x1BA39A0 Offset: 0x1BA1FA0 VA: 0x181BA39A0
	public static MonoBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BA3960 Offset: 0x1BA1F60 VA: 0x181BA3960
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BA3AA0 Offset: 0x1BA20A0 VA: 0x181BA3AA0
	private static void set_LaunchCountThisVersion(int value) { }

	// RVA: 0x1BA3860 Offset: 0x1BA1E60 VA: 0x181BA3860
	public static void Init() { }

}

public class Global : ConsoleSystem // TypeDefIndex: 11926
{	// Fields
	private static int _developer; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x6E2AE0 Offset: 0x6E10E0 VA: 0x1806E2AE0
	public static void set_developer(int value) { }

	// RVA: 0x6E1830 Offset: 0x6DFE30 VA: 0x1806E1830
	public static int get_developer() { }

	// RVA: 0x6E1680 Offset: 0x6DFC80 VA: 0x1806E1680
	public static int get_censornudity() { }

	// RVA: 0x6E25A0 Offset: 0x6E0BA0 VA: 0x1806E25A0
	public static void set_censornudity(int value) { }

	// RVA: 0x6E0B40 Offset: 0x6DF140 VA: 0x1806E0B40
	private static bool ForceUnderwear() { }

	// RVA: 0x6E1770 Offset: 0x6DFD70 VA: 0x1806E1770
	public static bool get_censorsigns() { }

	// RVA: 0x6E28A0 Offset: 0x6E0EA0 VA: 0x1806E28A0
	public static void set_censorsigns(bool value) { }

	// RVA: 0x6E1710 Offset: 0x6DFD10 VA: 0x1806E1710
	public static bool get_censorrecordings() { }

	// RVA: 0x6E2680 Offset: 0x6E0C80 VA: 0x1806E2680
	public static void set_censorrecordings(bool value) { }

	// RVA: 0x6E1A70 Offset: 0x6E0070 VA: 0x1806E1A70
	public static bool get_processMidiInput() { }

	// RVA: 0x6E2C70 Offset: 0x6E1270 VA: 0x1806E2C70
	public static void set_processMidiInput(bool value) { }

	// RVA: 0x6E1AD0 Offset: 0x6E00D0 VA: 0x1806E1AD0
	public static bool get_showBlood() { }

	// RVA: 0x6E2D60 Offset: 0x6E1360 VA: 0x1806E2D60
	public static void set_showBlood(bool value) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x6E2390 Offset: 0x6E0990 VA: 0x1806E2390
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E3860 Offset: 0x6E1E60 VA: 0x1806E3860
	public static void writecfg() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E2470 Offset: 0x6E0A70 VA: 0x1806E2470
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E13A0 Offset: 0x6DF9A0 VA: 0x1806E13A0
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E1B30 Offset: 0x6E0130 VA: 0x1806E1B30
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E3250 Offset: 0x6E1850 VA: 0x1806E3250
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E0F50 Offset: 0x6DF550 VA: 0x1806E0F50
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E1370 Offset: 0x6DF970 VA: 0x1806E1370
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E2340 Offset: 0x6E0940 VA: 0x1806E2340
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E2DC0 Offset: 0x6E13C0 VA: 0x1806E2DC0
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E1510 Offset: 0x6DFB10 VA: 0x1806E1510
	public static void free(ConsoleSystem.Arg args) { }

	// RVA: 0x6E19D0 Offset: 0x6DFFD0 VA: 0x1806E19D0
	public static string get_language() { }

	// RVA: 0x6E2B40 Offset: 0x6E1140 VA: 0x1806E2B40
	public static void set_language(string value) { }

	// RVA: 0x6E17D0 Offset: 0x6DFDD0 VA: 0x1806E17D0
	public static float get_consoleScale() { }

	// RVA: 0x6E2990 Offset: 0x6E0F90 VA: 0x1806E2990
	public static void set_consoleScale(float value) { }

	[ServerVar] // RVA: 0x9F4F0 Offset: 0x9E8F0 VA: 0x18009F4F0
	[ClientVar] // RVA: 0x9F4F0 Offset: 0x9E8F0 VA: 0x18009F4F0
	// RVA: 0x6E35A0 Offset: 0x6E1BA0 VA: 0x1806E35A0
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E31F0 Offset: 0x6E17F0 VA: 0x1806E31F0
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E3220 Offset: 0x6E1820 VA: 0x1806E3220
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E2E90 Offset: 0x6E1490 VA: 0x1806E2E90
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E0EF0 Offset: 0x6DF4F0 VA: 0x1806E0EF0
	public void .ctor() { }

	// RVA: 0x6E0D20 Offset: 0x6DF320 VA: 0x1806E0D20
	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 11927
{	// Fields
	public static readonly Global.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, long>, long> <>9__46_0; // 0x8
	public static Func<Collider, bool> <>9__48_0; // 0x10
	public static Func<Collider, bool> <>9__48_1; // 0x18

	// Methods

	// RVA: 0x6E8810 Offset: 0x6E6E10 VA: 0x1806E8810
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E83D0 Offset: 0x6E69D0 VA: 0x1806E83D0
	internal long <objects>b__46_0(KeyValuePair<Type, long> x) { }

	// RVA: 0x6E82C0 Offset: 0x6E68C0 VA: 0x1806E82C0
	internal bool <colliders>b__48_0(Collider x) { }

	// RVA: 0x6E82E0 Offset: 0x6E68E0 VA: 0x1806E82E0
	internal bool <colliders>b__48_1(Collider x) { }

}

