public class Debugging : ConsoleSystem // TypeDefIndex: 11900
{	// Fields
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool checktriggers; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool checkparentingtriggers; // 0x1
	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	public static bool callbacks; // 0x2
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_targetbind; // 0x8
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_dollyforward; // 0x10
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_dollyback; // 0x18
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_cyclebone; // 0x20
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float debugcamera_dollyspeed; // 0x28
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_raise; // 0x30
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_lower; // 0x38
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_zoomin; // 0x40
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static Buttons.ConButton debugcamera_zoomout; // 0x48
	[ClientVar] // RVA: 0x8E530 Offset: 0x8D930 VA: 0x18008E530
	public static Vector3 debugcamera_offset; // 0x50
	[ClientVar] // RVA: 0x93CE0 Offset: 0x930E0 VA: 0x180093CE0
	public static bool debugcamera_bonerotation; // 0x5C
	[ClientVar] // RVA: 0x93DD0 Offset: 0x931D0 VA: 0x180093DD0
	public static bool debugcamera_lookat; // 0x5D
	[ClientVar] // RVA: 0x93E60 Offset: 0x93260 VA: 0x180093E60
	public static bool debugcamera_autosave; // 0x5E
	[ClientVar] // RVA: 0x93F20 Offset: 0x93320 VA: 0x180093F20
	public static bool debugcamera_autoload; // 0x5F
	[ClientVar] // RVA: 0x94030 Offset: 0x93430 VA: 0x180094030
	public static bool debugcamera_preserve; // 0x60
	[ClientVar] // RVA: 0x940A0 Offset: 0x934A0 VA: 0x1800940A0
	public static bool debugcamera_lock; // 0x61
	[ClientVar] // RVA: 0x94140 Offset: 0x93540 VA: 0x180094140
	public static bool drawcolliders; // 0x62
	[ClientVar] // RVA: 0x941C0 Offset: 0x935C0 VA: 0x1800941C0
	public static bool ambientvolumes; // 0x63
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool oninventorychanged; // 0x64
	[ClientVar] // RVA: 0x94300 Offset: 0x93700 VA: 0x180094300
	public static string fakeSpeechPlayer; // 0x68

	// Properties
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool log { get; set; }
	[ClientVar] // RVA: 0x95500 Offset: 0x94900 VA: 0x180095500
	public static bool skyreflection { get; set; }

	// Methods

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6D8960 Offset: 0x6D6F60 VA: 0x1806D8960
	public static void renderinfo(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D8970 Offset: 0x6D6F70 VA: 0x1806D8970
	public static void set_log(bool value) { }

	// RVA: 0x6D8060 Offset: 0x6D6660 VA: 0x1806D8060
	public static bool get_log() { }

	[ClientVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[ServerVar] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	// RVA: 0x6D8BC0 Offset: 0x6D71C0 VA: 0x1806D8BC0
	public static void stall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x945B0 Offset: 0x939B0 VA: 0x1800945B0
	// RVA: 0x6D8410 Offset: 0x6D6A10 VA: 0x1806D8410
	public static void lookingat(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94720 Offset: 0x93B20 VA: 0x180094720
	// RVA: 0x6D8180 Offset: 0x6D6780 VA: 0x1806D8180
	public static void lookingat_debug(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x947B0 Offset: 0x93BB0 VA: 0x1800947B0
	// RVA: 0x6D6EA0 Offset: 0x6D54A0 VA: 0x1806D6EA0
	public static void debugcamera(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94840 Offset: 0x93C40 VA: 0x180094840
	// RVA: 0x6D65E0 Offset: 0x6D4BE0 VA: 0x1806D65E0
	public static string debugcamera_fov(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94880 Offset: 0x93C80 VA: 0x180094880
	// RVA: 0x6D76D0 Offset: 0x6D5CD0 VA: 0x1806D76D0
	public static void debugcamera_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94990 Offset: 0x93D90 VA: 0x180094990
	// RVA: 0x6D6B00 Offset: 0x6D5100 VA: 0x1806D6B00
	public static string debugcamera_guide(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94A90 Offset: 0x93E90 VA: 0x180094A90
	// RVA: 0x6D68E0 Offset: 0x6D4EE0 VA: 0x1806D68E0
	public static string debugcamera_guide_color(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94AD0 Offset: 0x93ED0 VA: 0x180094AD0
	// RVA: 0x6D74F0 Offset: 0x6D5AF0 VA: 0x1806D74F0
	public static void debugcamera_shake(float amplitude, float frequency, float duration) { }

	[ClientVar] // RVA: 0x94B50 Offset: 0x93F50 VA: 0x180094B50
	// RVA: 0x6D7600 Offset: 0x6D5C00 VA: 0x1806D7600
	public static void debugcamera_stopshake() { }

	[ClientVar] // RVA: 0x94C70 Offset: 0x94070 VA: 0x180094C70
	// RVA: 0x6D6740 Offset: 0x6D4D40 VA: 0x1806D6740
	public static string debugcamera_guide_aspectratio(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D7270 Offset: 0x6D5870 VA: 0x1806D7270
	public static void debugcamera_save(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D6D50 Offset: 0x6D5350 VA: 0x1806D6D50
	public static void debugcamera_load(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D73A0 Offset: 0x6D59A0 VA: 0x1806D73A0
	public static void debugcamera_savetofile(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D6510 Offset: 0x6D4B10 VA: 0x1806D6510
	public static void debugcamera_clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D6C60 Offset: 0x6D5260 VA: 0x1806D6C60
	public static void debugcamera_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D7910 Offset: 0x6D5F10 VA: 0x1806D7910
	public static void debugcamera_targetprint(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95230 Offset: 0x94630 VA: 0x180095230
	// RVA: 0x6D7BF0 Offset: 0x6D61F0 VA: 0x1806D7BF0
	public static Debugging.EntityInfo[] ent_find_radius(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x952F0 Offset: 0x946F0 VA: 0x1800952F0
	// RVA: 0x6D8770 Offset: 0x6D6D70 VA: 0x1806D8770
	public static void noclip(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95370 Offset: 0x94770 VA: 0x180095370
	// RVA: 0x6D7AB0 Offset: 0x6D60B0 VA: 0x1806D7AB0
	public static void debugcamera_unfreeze(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D80D0 Offset: 0x6D66D0 VA: 0x1806D80D0
	public static bool get_skyreflection() { }

	// RVA: 0x6D8A50 Offset: 0x6D7050 VA: 0x1806D8A50
	public static void set_skyreflection(bool value) { }

	// RVA: 0x6D64B0 Offset: 0x6D4AB0 VA: 0x1806D64B0
	public void .ctor() { }

	// RVA: 0x6D6170 Offset: 0x6D4770 VA: 0x1806D6170
	private static void .cctor() { }

}

public struct Debugging.EntityInfo // TypeDefIndex: 11901
{	// Fields
	public string name; // 0x0
	public uint netId; // 0x8

}

private sealed class Debugging.<>c__DisplayClass40_0 // TypeDefIndex: 11902
{	// Fields
	public Vector3 position; // 0x10
	public float radius; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E83D0 Offset: 0x6E69D0 VA: 0x1806E83D0
	internal bool <ent_find_radius>b__0(BaseNetworkable x) { }

}

private sealed class Debugging.<>c // TypeDefIndex: 11903
{	// Fields
	public static readonly Debugging.<>c <>9; // 0x0
	public static Func<BaseNetworkable, uint> <>9__40_1; // 0x8
	public static Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable> <>9__40_2; // 0x10
	public static Func<BaseNetworkable, Debugging.EntityInfo> <>9__40_3; // 0x18

	// Methods

	// RVA: 0x6E86B0 Offset: 0x6E6CB0 VA: 0x1806E86B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8270 Offset: 0x6E6870 VA: 0x1806E8270
	internal uint <ent_find_radius>b__40_1(BaseNetworkable x) { }

	// RVA: 0x6E8290 Offset: 0x6E6890 VA: 0x1806E8290
	internal BaseNetworkable <ent_find_radius>b__40_2(IGrouping<uint, BaseNetworkable> x) { }

	// RVA: 0x6E82D0 Offset: 0x6E68D0 VA: 0x1806E82D0
	internal Debugging.EntityInfo <ent_find_radius>b__40_3(BaseNetworkable x) { }

}

