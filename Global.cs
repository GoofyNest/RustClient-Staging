public static class Global // TypeDefIndex: 6621
{	// Fields
	public static Func<string, GameObject> LoadPrefab; // 0x0
	public static Func<string, GameObject> FindPrefab; // 0x8
	public static Func<string, GameObject> CreatePrefab; // 0x10
	public static Action OpenMainMenu; // 0x18
	private static MonoBehaviour _runner; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static int <LaunchCountThisVersion>k__BackingField; // 0x28

	// Properties
	public static MonoBehaviour Runner { get; }
	public static int LaunchCountThisVersion { get; set; }

	// Methods

	// RVA: 0x1BA30B0 Offset: 0x1BA16B0 VA: 0x181BA30B0
	public static MonoBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BA3070 Offset: 0x1BA1670 VA: 0x181BA3070
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BA31B0 Offset: 0x1BA17B0 VA: 0x181BA31B0
	private static void set_LaunchCountThisVersion(int value) { }

	// RVA: 0x1BA2F70 Offset: 0x1BA1570 VA: 0x181BA2F70
	public static void Init() { }

}

public class Global : ConsoleSystem // TypeDefIndex: 11926
{	// Fields
	private static int _developer; // 0x0
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool skipassetwarmup; // 0x4
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static int maxthreads; // 0x8
	private const int DefaultWarmupConcurrency = 1;
	private const int DefaultPreloadConcurrency = 1;
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static int warmupConcurrency; // 0xC
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static int preloadConcurrency; // 0x10
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool forceUnloadBundles; // 0x14
	private const bool DefaultAsyncWarmupEnabled = False;
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool asyncWarmup; // 0x15
	private static int _censornudity; // 0x18
	private static bool _censorsigns; // 0x1C
	[ClientVar] // RVA: 0x9DBD0 Offset: 0x9CFD0 VA: 0x18009DBD0
	public static int signUndoBuffer; // 0x20
	private static bool _censorRecordings; // 0x24
	private static bool _processMidiInput; // 0x25
	private static bool _showBlood; // 0x26
	[ClientVar] // RVA: 0x9DC90 Offset: 0x9D090 VA: 0x18009DC90
	public static bool limitFlashing; // 0x27
	[ClientVar] // RVA: 0x9DD00 Offset: 0x9D100 VA: 0x18009DD00
	public static bool showItemCountsOnPickup; // 0x28
	[ClientVar] // RVA: 0x9DE90 Offset: 0x9D290 VA: 0x18009DE90
	public static bool useSingleItemPickupNotice; // 0x29
	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	public static bool showItemPickupNotices; // 0x2A
	[ClientVar] // RVA: 0x9E000 Offset: 0x9D400 VA: 0x18009E000
	public static float vehicleDismountHoldTime; // 0x2C
	[ServerVar] // RVA: 0x9E0C0 Offset: 0x9D4C0 VA: 0x18009E0C0
	[ClientVar] // RVA: 0x9E0C0 Offset: 0x9D4C0 VA: 0x18009E0C0
	public static int perf; // 0x30
	[ClientVar] // RVA: 0x9E1F0 Offset: 0x9D5F0 VA: 0x18009E1F0
	public static bool god; // 0x34
	[ClientVar] // RVA: 0x9E530 Offset: 0x9D930 VA: 0x18009E530
	public static bool specnet; // 0x35
	[ClientVar] // RVA: 0x8EC70 Offset: 0x8E070 VA: 0x18008EC70
	public static bool streamermode; // 0x36
	[ClientVar] // RVA: 0x8EC70 Offset: 0x8E070 VA: 0x18008EC70
	public static bool richPresence; // 0x37
	private static float _consoleScale; // 0x38

	// Properties
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static int developer { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int censornudity { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool censorsigns { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool censorrecordings { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool processMidiInput { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool showBlood { get; set; }
	[ClientVar] // RVA: 0x8EC70 Offset: 0x8E070 VA: 0x18008EC70
	public static string language { get; set; }
	[ClientVar] // RVA: 0x9FB10 Offset: 0x9EF10 VA: 0x18009FB10
	public static float consoleScale { get; set; }

	// Methods

	// RVA: 0x6E2A40 Offset: 0x6E1040 VA: 0x1806E2A40
	public static void set_developer(int value) { }

	// RVA: 0x6E1790 Offset: 0x6DFD90 VA: 0x1806E1790
	public static int get_developer() { }

	// RVA: 0x6E15E0 Offset: 0x6DFBE0 VA: 0x1806E15E0
	public static int get_censornudity() { }

	// RVA: 0x6E2500 Offset: 0x6E0B00 VA: 0x1806E2500
	public static void set_censornudity(int value) { }

	// RVA: 0x6E0AA0 Offset: 0x6DF0A0 VA: 0x1806E0AA0
	private static bool ForceUnderwear() { }

	// RVA: 0x6E16D0 Offset: 0x6DFCD0 VA: 0x1806E16D0
	public static bool get_censorsigns() { }

	// RVA: 0x6E2800 Offset: 0x6E0E00 VA: 0x1806E2800
	public static void set_censorsigns(bool value) { }

	// RVA: 0x6E1670 Offset: 0x6DFC70 VA: 0x1806E1670
	public static bool get_censorrecordings() { }

	// RVA: 0x6E25E0 Offset: 0x6E0BE0 VA: 0x1806E25E0
	public static void set_censorrecordings(bool value) { }

	// RVA: 0x6E19D0 Offset: 0x6DFFD0 VA: 0x1806E19D0
	public static bool get_processMidiInput() { }

	// RVA: 0x6E2BD0 Offset: 0x6E11D0 VA: 0x1806E2BD0
	public static void set_processMidiInput(bool value) { }

	// RVA: 0x6E1A30 Offset: 0x6E0030 VA: 0x1806E1A30
	public static bool get_showBlood() { }

	// RVA: 0x6E2CC0 Offset: 0x6E12C0 VA: 0x1806E2CC0
	public static void set_showBlood(bool value) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x6E22F0 Offset: 0x6E08F0 VA: 0x1806E22F0
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E37C0 Offset: 0x6E1DC0 VA: 0x1806E37C0
	public static void writecfg() { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E23D0 Offset: 0x6E09D0 VA: 0x1806E23D0
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E1300 Offset: 0x6DF900 VA: 0x1806E1300
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E1A90 Offset: 0x6E0090 VA: 0x1806E1A90
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E31B0 Offset: 0x6E17B0 VA: 0x1806E31B0
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E0EB0 Offset: 0x6DF4B0 VA: 0x1806E0EB0
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E12D0 Offset: 0x6DF8D0 VA: 0x1806E12D0
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E22A0 Offset: 0x6E08A0 VA: 0x1806E22A0
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E2D20 Offset: 0x6E1320 VA: 0x1806E2D20
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E1470 Offset: 0x6DFA70 VA: 0x1806E1470
	public static void free(ConsoleSystem.Arg args) { }

	// RVA: 0x6E1930 Offset: 0x6DFF30 VA: 0x1806E1930
	public static string get_language() { }

	// RVA: 0x6E2AA0 Offset: 0x6E10A0 VA: 0x1806E2AA0
	public static void set_language(string value) { }

	// RVA: 0x6E1730 Offset: 0x6DFD30 VA: 0x1806E1730
	public static float get_consoleScale() { }

	// RVA: 0x6E28F0 Offset: 0x6E0EF0 VA: 0x1806E28F0
	public static void set_consoleScale(float value) { }

	[ServerVar] // RVA: 0x9F3B0 Offset: 0x9E7B0 VA: 0x18009F3B0
	[ClientVar] // RVA: 0x9F3B0 Offset: 0x9E7B0 VA: 0x18009F3B0
	// RVA: 0x6E3500 Offset: 0x6E1B00 VA: 0x1806E3500
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E3150 Offset: 0x6E1750 VA: 0x1806E3150
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E3180 Offset: 0x6E1780 VA: 0x1806E3180
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E2DF0 Offset: 0x6E13F0 VA: 0x1806E2DF0
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E0E50 Offset: 0x6DF450 VA: 0x1806E0E50
	public void .ctor() { }

	// RVA: 0x6E0C80 Offset: 0x6DF280 VA: 0x1806E0C80
	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 11927
{	// Fields
	public static readonly Global.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, long>, long> <>9__46_0; // 0x8
	public static Func<Collider, bool> <>9__48_0; // 0x10
	public static Func<Collider, bool> <>9__48_1; // 0x18

	// Methods

	// RVA: 0x6E8770 Offset: 0x6E6D70 VA: 0x1806E8770
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8330 Offset: 0x6E6930 VA: 0x1806E8330
	internal long <objects>b__46_0(KeyValuePair<Type, long> x) { }

	// RVA: 0x6E8220 Offset: 0x6E6820 VA: 0x1806E8220
	internal bool <colliders>b__48_0(Collider x) { }

	// RVA: 0x6E8240 Offset: 0x6E6840 VA: 0x1806E8240
	internal bool <colliders>b__48_1(Collider x) { }

}

