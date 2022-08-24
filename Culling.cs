public class Culling : ConsoleSystem // TypeDefIndex: 11901
{	[ClientVar] // RVA: 0x90F00 Offset: 0x90300 VA: 0x180090F00
	public static float entityUpdateRate; // 0x0
	[ClientVar] // RVA: 0x91050 Offset: 0x90450 VA: 0x180091050
	public static float entityMinCullDist; // 0x4
	public const float entityMinAnimatorCullDist = 100;
	[ClientVar] // RVA: 0x91280 Offset: 0x90680 VA: 0x180091280
	public static float entityMinShadowCullDist; // 0x8
	[ClientVar] // RVA: 0x912F0 Offset: 0x906F0 VA: 0x1800912F0
	public static float entityMaxDist; // 0xC
	private static bool _env; // 0x10
	[ClientVar] // RVA: 0x91360 Offset: 0x90760 VA: 0x180091360
	public static float envMinDist; // 0x14
	[ClientVar] // RVA: 0x91450 Offset: 0x90850 VA: 0x180091450
	public static bool noDataVisible; // 0x18

	[ClientVar] // RVA: 0x914F0 Offset: 0x908F0 VA: 0x1800914F0
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91560 Offset: 0x90960 VA: 0x180091560
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x915D0 Offset: 0x909D0 VA: 0x1800915D0
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x916F0 Offset: 0x90AF0 VA: 0x1800916F0
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

