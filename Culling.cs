public class Culling : ConsoleSystem // TypeDefIndex: 11897
{	// Fields
	[ClientVar] // RVA: 0x91280 Offset: 0x90680 VA: 0x180091280
	public static float entityUpdateRate; // 0x0
	[ClientVar] // RVA: 0x91320 Offset: 0x90720 VA: 0x180091320
	public static float entityMinCullDist; // 0x4
	public const float entityMinAnimatorCullDist = 100;
	[ClientVar] // RVA: 0x91390 Offset: 0x90790 VA: 0x180091390
	public static float entityMinShadowCullDist; // 0x8
	[ClientVar] // RVA: 0x91400 Offset: 0x90800 VA: 0x180091400
	public static float entityMaxDist; // 0xC
	private static bool _env; // 0x10
	[ClientVar] // RVA: 0x914D0 Offset: 0x908D0 VA: 0x1800914D0
	public static float envMinDist; // 0x14
	[ClientVar] // RVA: 0x91640 Offset: 0x90A40 VA: 0x180091640
	public static bool noDataVisible; // 0x18

	// Properties
	[ClientVar] // RVA: 0x916E0 Offset: 0x90AE0 VA: 0x1800916E0
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91860 Offset: 0x90C60 VA: 0x180091860
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x91910 Offset: 0x90D10 VA: 0x180091910
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x91A90 Offset: 0x90E90 VA: 0x180091A90
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

