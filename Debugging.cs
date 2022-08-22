public class Debugging : ConsoleSystem // TypeDefIndex: 11900
{	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool checktriggers; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool checkparentingtriggers; // 0x1
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static bool callbacks; // 0x2
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_targetbind; // 0x8
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_dollyforward; // 0x10
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_dollyback; // 0x18
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_cyclebone; // 0x20
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float debugcamera_dollyspeed; // 0x28
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_raise; // 0x30
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_lower; // 0x38
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_zoomin; // 0x40
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static Buttons.ConButton debugcamera_zoomout; // 0x48
	[ClientVar] // RVA: 0x8E5B0 Offset: 0x8D9B0 VA: 0x18008E5B0
	public static Vector3 debugcamera_offset; // 0x50
	[ClientVar] // RVA: 0x93DC0 Offset: 0x931C0 VA: 0x180093DC0
	public static bool debugcamera_bonerotation; // 0x5C
	[ClientVar] // RVA: 0x93EA0 Offset: 0x932A0 VA: 0x180093EA0
	public static bool debugcamera_lookat; // 0x5D
	[ClientVar] // RVA: 0x93F30 Offset: 0x93330 VA: 0x180093F30
	public static bool debugcamera_autosave; // 0x5E
	[ClientVar] // RVA: 0x93FA0 Offset: 0x933A0 VA: 0x180093FA0
	public static bool debugcamera_autoload; // 0x5F
	[ClientVar] // RVA: 0x940B0 Offset: 0x934B0 VA: 0x1800940B0
	public static bool debugcamera_preserve; // 0x60
	[ClientVar] // RVA: 0x94150 Offset: 0x93550 VA: 0x180094150
	public static bool debugcamera_lock; // 0x61
	[ClientVar] // RVA: 0x941C0 Offset: 0x935C0 VA: 0x1800941C0
	public static bool drawcolliders; // 0x62
	[ClientVar] // RVA: 0x942F0 Offset: 0x936F0 VA: 0x1800942F0
	public static bool ambientvolumes; // 0x63
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool oninventorychanged; // 0x64
	[ClientVar] // RVA: 0x944A0 Offset: 0x938A0 VA: 0x1800944A0
	public static string fakeSpeechPlayer; // 0x68

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool log { get; set; }
	[ClientVar] // RVA: 0x955C0 Offset: 0x949C0 VA: 0x1800955C0
	public static bool skyreflection { get; set; }


	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void renderinfo(ConsoleSystem.Arg arg) { }

	public static void set_log(bool value) { }

	public static bool get_log() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static void stall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94630 Offset: 0x93A30 VA: 0x180094630
	public static void lookingat(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x947A0 Offset: 0x93BA0 VA: 0x1800947A0
	public static void lookingat_debug(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94830 Offset: 0x93C30 VA: 0x180094830
	public static void debugcamera(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x948C0 Offset: 0x93CC0 VA: 0x1800948C0
	public static string debugcamera_fov(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x949A0 Offset: 0x93DA0 VA: 0x1800949A0
	public static void debugcamera_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94A10 Offset: 0x93E10 VA: 0x180094A10
	public static string debugcamera_guide(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94B10 Offset: 0x93F10 VA: 0x180094B10
	public static string debugcamera_guide_color(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94B50 Offset: 0x93F50 VA: 0x180094B50
	public static void debugcamera_shake(float amplitude, float frequency, float duration) { }

	[ClientVar] // RVA: 0x94C30 Offset: 0x94030 VA: 0x180094C30
	public static void debugcamera_stopshake() { }

	[ClientVar] // RVA: 0x94D70 Offset: 0x94170 VA: 0x180094D70
	public static string debugcamera_guide_aspectratio(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void debugcamera_save(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void debugcamera_load(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void debugcamera_savetofile(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void debugcamera_clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void debugcamera_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void debugcamera_targetprint(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x952B0 Offset: 0x946B0 VA: 0x1800952B0
	public static Debugging.EntityInfo[] ent_find_radius(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95370 Offset: 0x94770 VA: 0x180095370
	public static void noclip(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95460 Offset: 0x94860 VA: 0x180095460
	public static void debugcamera_unfreeze(ConsoleSystem.Arg arg) { }

	public static bool get_skyreflection() { }

	public static void set_skyreflection(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Debugging.EntityInfo // TypeDefIndex: 11901
{	public string name; // 0x0
	public uint netId; // 0x8

}

private sealed class Debugging.<>c__DisplayClass40_0 // TypeDefIndex: 11902
{	public Vector3 position; // 0x10
	public float radius; // 0x1C


	public void .ctor() { }

	internal bool <ent_find_radius>b__0(BaseNetworkable x) { }

}

private sealed class Debugging.<>c // TypeDefIndex: 11903
{	public static readonly Debugging.<>c <>9; // 0x0
	public static Func<BaseNetworkable, uint> <>9__40_1; // 0x8
	public static Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable> <>9__40_2; // 0x10
	public static Func<BaseNetworkable, Debugging.EntityInfo> <>9__40_3; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <ent_find_radius>b__40_1(BaseNetworkable x) { }

	internal BaseNetworkable <ent_find_radius>b__40_2(IGrouping<uint, BaseNetworkable> x) { }

	internal Debugging.EntityInfo <ent_find_radius>b__40_3(BaseNetworkable x) { }

}

