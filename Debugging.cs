public class Debugging : ConsoleSystem // TypeDefIndex: 11904
{	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static bool checktriggers; // 0x0
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static bool checkparentingtriggers; // 0x1
	[ClientVar] // RVA: 0x939A0 Offset: 0x92DA0 VA: 0x1800939A0
	[ServerVar] // RVA: 0x939A0 Offset: 0x92DA0 VA: 0x1800939A0
	public static bool callbacks; // 0x2
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_targetbind; // 0x8
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_dollyforward; // 0x10
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_dollyback; // 0x18
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_cyclebone; // 0x20
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static float debugcamera_dollyspeed; // 0x28
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_raise; // 0x30
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_lower; // 0x38
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_zoomin; // 0x40
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static Buttons.ConButton debugcamera_zoomout; // 0x48
	[ClientVar] // RVA: 0x8E7F0 Offset: 0x8DBF0 VA: 0x18008E7F0
	public static Vector3 debugcamera_offset; // 0x50
	[ClientVar] // RVA: 0x93FF0 Offset: 0x933F0 VA: 0x180093FF0
	public static bool debugcamera_bonerotation; // 0x5C
	[ClientVar] // RVA: 0x94060 Offset: 0x93460 VA: 0x180094060
	public static bool debugcamera_lookat; // 0x5D
	[ClientVar] // RVA: 0x94170 Offset: 0x93570 VA: 0x180094170
	public static bool debugcamera_autosave; // 0x5E
	[ClientVar] // RVA: 0x941E0 Offset: 0x935E0 VA: 0x1800941E0
	public static bool debugcamera_autoload; // 0x5F
	[ClientVar] // RVA: 0x94280 Offset: 0x93680 VA: 0x180094280
	public static bool debugcamera_preserve; // 0x60
	[ClientVar] // RVA: 0x943B0 Offset: 0x937B0 VA: 0x1800943B0
	public static bool debugcamera_lock; // 0x61
	[ClientVar] // RVA: 0x94420 Offset: 0x93820 VA: 0x180094420
	public static bool drawcolliders; // 0x62
	[ClientVar] // RVA: 0x94580 Offset: 0x93980 VA: 0x180094580
	public static bool ambientvolumes; // 0x63
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static bool oninventorychanged; // 0x64
	[ClientVar] // RVA: 0x94620 Offset: 0x93A20 VA: 0x180094620
	public static string fakeSpeechPlayer; // 0x68

	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static bool log { get; set; }
	[ClientVar] // RVA: 0x95730 Offset: 0x94B30 VA: 0x180095730
	public static bool skyreflection { get; set; }


	[ServerVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	[ClientVar] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void renderinfo(ConsoleSystem.Arg arg) { }

	public static void set_log(bool value) { }

	public static bool get_log() { }

	[ClientVar] // RVA: 0x939A0 Offset: 0x92DA0 VA: 0x1800939A0
	[ServerVar] // RVA: 0x939A0 Offset: 0x92DA0 VA: 0x1800939A0
	public static void stall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x948F0 Offset: 0x93CF0 VA: 0x1800948F0
	public static void lookingat(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94930 Offset: 0x93D30 VA: 0x180094930
	public static void lookingat_debug(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x949C0 Offset: 0x93DC0 VA: 0x1800949C0
	public static void debugcamera(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94AD0 Offset: 0x93ED0 VA: 0x180094AD0
	public static string debugcamera_fov(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94BD0 Offset: 0x93FD0 VA: 0x180094BD0
	public static void debugcamera_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94C10 Offset: 0x94010 VA: 0x180094C10
	public static string debugcamera_guide(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94C90 Offset: 0x94090 VA: 0x180094C90
	public static string debugcamera_guide_color(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94DB0 Offset: 0x941B0 VA: 0x180094DB0
	public static void debugcamera_shake(float amplitude, float frequency, float duration) { }

	[ClientVar] // RVA: 0x94EA0 Offset: 0x942A0 VA: 0x180094EA0
	public static void debugcamera_stopshake() { }

	[ClientVar] // RVA: 0x94F70 Offset: 0x94370 VA: 0x180094F70
	public static string debugcamera_guide_aspectratio(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void debugcamera_save(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void debugcamera_load(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void debugcamera_savetofile(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void debugcamera_clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void debugcamera_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void debugcamera_targetprint(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95460 Offset: 0x94860 VA: 0x180095460
	public static Debugging.EntityInfo[] ent_find_radius(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x955A0 Offset: 0x949A0 VA: 0x1800955A0
	public static void noclip(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95680 Offset: 0x94A80 VA: 0x180095680
	public static void debugcamera_unfreeze(ConsoleSystem.Arg arg) { }

	public static bool get_skyreflection() { }

	public static void set_skyreflection(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Debugging.EntityInfo // TypeDefIndex: 11905
{	public string name; // 0x0
	public uint netId; // 0x8

}

private sealed class Debugging.<>c__DisplayClass40_0 // TypeDefIndex: 11906
{	public Vector3 position; // 0x10
	public float radius; // 0x1C


	public void .ctor() { }

	internal bool <ent_find_radius>b__0(BaseNetworkable x) { }

}

private sealed class Debugging.<>c // TypeDefIndex: 11907
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

