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

	// RVA: 0x1BA31B0 Offset: 0x1BA17B0 VA: 0x181BA31B0
	public static MonoBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BA3170 Offset: 0x1BA1770 VA: 0x181BA3170
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BA32B0 Offset: 0x1BA18B0 VA: 0x181BA32B0
	private static void set_LaunchCountThisVersion(int value) { }

	// RVA: 0x1BA3070 Offset: 0x1BA1670 VA: 0x181BA3070
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

	// RVA: 0x6E2B50 Offset: 0x6E1150 VA: 0x1806E2B50
	public static void set_developer(int value) { }

	// RVA: 0x6E18A0 Offset: 0x6DFEA0 VA: 0x1806E18A0
	public static int get_developer() { }

	// RVA: 0x6E16F0 Offset: 0x6DFCF0 VA: 0x1806E16F0
	public static int get_censornudity() { }

	// RVA: 0x6E2610 Offset: 0x6E0C10 VA: 0x1806E2610
	public static void set_censornudity(int value) { }

	// RVA: 0x6E0BB0 Offset: 0x6DF1B0 VA: 0x1806E0BB0
	private static bool ForceUnderwear() { }

	// RVA: 0x6E17E0 Offset: 0x6DFDE0 VA: 0x1806E17E0
	public static bool get_censorsigns() { }

	// RVA: 0x6E2910 Offset: 0x6E0F10 VA: 0x1806E2910
	public static void set_censorsigns(bool value) { }

	// RVA: 0x6E1780 Offset: 0x6DFD80 VA: 0x1806E1780
	public static bool get_censorrecordings() { }

	// RVA: 0x6E26F0 Offset: 0x6E0CF0 VA: 0x1806E26F0
	public static void set_censorrecordings(bool value) { }

	// RVA: 0x6E1AE0 Offset: 0x6E00E0 VA: 0x1806E1AE0
	public static bool get_processMidiInput() { }

	// RVA: 0x6E2CE0 Offset: 0x6E12E0 VA: 0x1806E2CE0
	public static void set_processMidiInput(bool value) { }

	// RVA: 0x6E1B40 Offset: 0x6E0140 VA: 0x1806E1B40
	public static bool get_showBlood() { }

	// RVA: 0x6E2DD0 Offset: 0x6E13D0 VA: 0x1806E2DD0
	public static void set_showBlood(bool value) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x6E2400 Offset: 0x6E0A00 VA: 0x1806E2400
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E38D0 Offset: 0x6E1ED0 VA: 0x1806E38D0
	public static void writecfg() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E24E0 Offset: 0x6E0AE0 VA: 0x1806E24E0
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E1410 Offset: 0x6DFA10 VA: 0x1806E1410
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E1BA0 Offset: 0x6E01A0 VA: 0x1806E1BA0
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E32C0 Offset: 0x6E18C0 VA: 0x1806E32C0
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E0FC0 Offset: 0x6DF5C0 VA: 0x1806E0FC0
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E13E0 Offset: 0x6DF9E0 VA: 0x1806E13E0
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E23B0 Offset: 0x6E09B0 VA: 0x1806E23B0
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E2E30 Offset: 0x6E1430 VA: 0x1806E2E30
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
	// RVA: 0x6E1580 Offset: 0x6DFB80 VA: 0x1806E1580
	public static void free(ConsoleSystem.Arg args) { }

	// RVA: 0x6E1A40 Offset: 0x6E0040 VA: 0x1806E1A40
	public static string get_language() { }

	// RVA: 0x6E2BB0 Offset: 0x6E11B0 VA: 0x1806E2BB0
	public static void set_language(string value) { }

	// RVA: 0x6E1840 Offset: 0x6DFE40 VA: 0x1806E1840
	public static float get_consoleScale() { }

	// RVA: 0x6E2A00 Offset: 0x6E1000 VA: 0x1806E2A00
	public static void set_consoleScale(float value) { }

	[ServerVar] // RVA: 0x9F4F0 Offset: 0x9E8F0 VA: 0x18009F4F0
	[ClientVar] // RVA: 0x9F4F0 Offset: 0x9E8F0 VA: 0x18009F4F0
	// RVA: 0x6E3610 Offset: 0x6E1C10 VA: 0x1806E3610
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E3260 Offset: 0x6E1860 VA: 0x1806E3260
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E3290 Offset: 0x6E1890 VA: 0x1806E3290
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E2F00 Offset: 0x6E1500 VA: 0x1806E2F00
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E0F60 Offset: 0x6DF560 VA: 0x1806E0F60
	public void .ctor() { }

	// RVA: 0x6E0D90 Offset: 0x6DF390 VA: 0x1806E0D90
	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 11927
{	// Fields
	public static readonly Global.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, long>, long> <>9__46_0; // 0x8
	public static Func<Collider, bool> <>9__48_0; // 0x10
	public static Func<Collider, bool> <>9__48_1; // 0x18

	// Methods

	// RVA: 0x6E8880 Offset: 0x6E6E80 VA: 0x1806E8880
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8440 Offset: 0x6E6A40 VA: 0x1806E8440
	internal long <objects>b__46_0(KeyValuePair<Type, long> x) { }

	// RVA: 0x6E8330 Offset: 0x6E6930 VA: 0x1806E8330
	internal bool <colliders>b__48_0(Collider x) { }

	// RVA: 0x6E8350 Offset: 0x6E6950 VA: 0x1806E8350
	internal bool <colliders>b__48_1(Collider x) { }

}

