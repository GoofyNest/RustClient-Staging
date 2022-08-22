public class Culling : ConsoleSystem // TypeDefIndex: 11897
{	[ClientVar] // RVA: 0x91330 Offset: 0x90730 VA: 0x180091330
	public static float entityUpdateRate; // 0x0
	[ClientVar] // RVA: 0x913D0 Offset: 0x907D0 VA: 0x1800913D0
	public static float entityMinCullDist; // 0x4
	public const float entityMinAnimatorCullDist = 100;
	[ClientVar] // RVA: 0x91440 Offset: 0x90840 VA: 0x180091440
	public static float entityMinShadowCullDist; // 0x8
	[ClientVar] // RVA: 0x914B0 Offset: 0x908B0 VA: 0x1800914B0
	public static float entityMaxDist; // 0xC
	private static bool _env; // 0x10
	[ClientVar] // RVA: 0x915B0 Offset: 0x909B0 VA: 0x1800915B0
	public static float envMinDist; // 0x14
	[ClientVar] // RVA: 0x91720 Offset: 0x90B20 VA: 0x180091720
	public static bool noDataVisible; // 0x18

	[ClientVar] // RVA: 0x91840 Offset: 0x90C40 VA: 0x180091840
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91980 Offset: 0x90D80 VA: 0x180091980
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x91A30 Offset: 0x90E30 VA: 0x180091A30
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x91BB0 Offset: 0x90FB0 VA: 0x180091BB0
	public static int debug { get; set; }


	public static bool get_toggle() { }

	public static void set_toggle(bool value) { }

	public static bool get_safeMode() { }

	public static void set_safeMode(bool value) { }

	public static bool get_env() { }

	public static void set_env(bool value) { }

	public static int get_debug() { }

	public static void set_debug(int value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

