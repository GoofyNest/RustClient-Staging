public class Culling : ConsoleSystem // TypeDefIndex: 11901
{	[ClientVar] // RVA: 0x914D0 Offset: 0x908D0 VA: 0x1800914D0
	public static float entityUpdateRate; // 0x0
	[ClientVar] // RVA: 0x91540 Offset: 0x90940 VA: 0x180091540
	public static float entityMinCullDist; // 0x4
	public const float entityMinAnimatorCullDist = 100;
	[ClientVar] // RVA: 0x91610 Offset: 0x90A10 VA: 0x180091610
	public static float entityMinShadowCullDist; // 0x8
	[ClientVar] // RVA: 0x91730 Offset: 0x90B30 VA: 0x180091730
	public static float entityMaxDist; // 0xC
	private static bool _env; // 0x10
	[ClientVar] // RVA: 0x91800 Offset: 0x90C00 VA: 0x180091800
	public static float envMinDist; // 0x14
	[ClientVar] // RVA: 0x919D0 Offset: 0x90DD0 VA: 0x1800919D0
	public static bool noDataVisible; // 0x18

	[ClientVar] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91B80 Offset: 0x90F80 VA: 0x180091B80
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x91C60 Offset: 0x91060 VA: 0x180091C60
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x930D0 Offset: 0x924D0 VA: 0x1800930D0
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

