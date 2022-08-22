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

	// RVA: 0x6D4E40 Offset: 0x6D3440 VA: 0x1806D4E40
	public static bool get_toggle() { }

	// RVA: 0x6D50D0 Offset: 0x6D36D0 VA: 0x1806D50D0
	public static void set_toggle(bool value) { }

	// RVA: 0x6D4DA0 Offset: 0x6D33A0 VA: 0x1806D4DA0
	public static bool get_safeMode() { }

	// RVA: 0x6D5020 Offset: 0x6D3620 VA: 0x1806D5020
	public static void set_safeMode(bool value) { }

	// RVA: 0x6D4D40 Offset: 0x6D3340 VA: 0x1806D4D40
	public static bool get_env() { }

	// RVA: 0x6D4F90 Offset: 0x6D3590 VA: 0x1806D4F90
	public static void set_env(bool value) { }

	// RVA: 0x6D4B60 Offset: 0x6D3160 VA: 0x1806D4B60
	public static int get_debug() { }

	// RVA: 0x6D4EE0 Offset: 0x6D34E0 VA: 0x1806D4EE0
	public static void set_debug(int value) { }

	// RVA: 0x6D4B00 Offset: 0x6D3100 VA: 0x1806D4B00
	public void .ctor() { }

	// RVA: 0x6D4A50 Offset: 0x6D3050 VA: 0x1806D4A50
	private static void .cctor() { }

}

