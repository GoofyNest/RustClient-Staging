public class Culling : ConsoleSystem // TypeDefIndex: 11897
{	// Fields
	[ClientVar] // RVA: 0x91330 Offset: 0x90730 VA: 0x180091330
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

	// Properties
	[ClientVar] // RVA: 0x91840 Offset: 0x90C40 VA: 0x180091840
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91980 Offset: 0x90D80 VA: 0x180091980
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x91A30 Offset: 0x90E30 VA: 0x180091A30
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x91BB0 Offset: 0x90FB0 VA: 0x180091BB0
	public static int debug { get; set; }

	// Methods

	// RVA: 0x6D4DA0 Offset: 0x6D33A0 VA: 0x1806D4DA0
	public static bool get_toggle() { }

	// RVA: 0x6D5030 Offset: 0x6D3630 VA: 0x1806D5030
	public static void set_toggle(bool value) { }

	// RVA: 0x6D4D00 Offset: 0x6D3300 VA: 0x1806D4D00
	public static bool get_safeMode() { }

	// RVA: 0x6D4F80 Offset: 0x6D3580 VA: 0x1806D4F80
	public static void set_safeMode(bool value) { }

	// RVA: 0x6D4CA0 Offset: 0x6D32A0 VA: 0x1806D4CA0
	public static bool get_env() { }

	// RVA: 0x6D4EF0 Offset: 0x6D34F0 VA: 0x1806D4EF0
	public static void set_env(bool value) { }

	// RVA: 0x6D4AC0 Offset: 0x6D30C0 VA: 0x1806D4AC0
	public static int get_debug() { }

	// RVA: 0x6D4E40 Offset: 0x6D3440 VA: 0x1806D4E40
	public static void set_debug(int value) { }

	// RVA: 0x6D4A60 Offset: 0x6D3060 VA: 0x1806D4A60
	public void .ctor() { }

	// RVA: 0x6D49B0 Offset: 0x6D2FB0 VA: 0x1806D49B0
	private static void .cctor() { }

}

