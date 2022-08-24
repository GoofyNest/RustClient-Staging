public class Debugging : ConsoleSystem // TypeDefIndex: 11904
{	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static bool checktriggers; // 0x0
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static bool checkparentingtriggers; // 0x1
	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static bool callbacks; // 0x2
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_targetbind; // 0x8
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_dollyforward; // 0x10
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_dollyback; // 0x18
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_cyclebone; // 0x20
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static float debugcamera_dollyspeed; // 0x28
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_raise; // 0x30
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_lower; // 0x38
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_zoomin; // 0x40
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static Buttons.ConButton debugcamera_zoomout; // 0x48
	[ClientVar] // RVA: 0x8DF50 Offset: 0x8D350 VA: 0x18008DF50
	public static Vector3 debugcamera_offset; // 0x50
	[ClientVar] // RVA: 0x939D0 Offset: 0x92DD0 VA: 0x1800939D0
	public static bool debugcamera_bonerotation; // 0x5C
	[ClientVar] // RVA: 0x93AE0 Offset: 0x92EE0 VA: 0x180093AE0
	public static bool debugcamera_lookat; // 0x5D
	[ClientVar] // RVA: 0x93B50 Offset: 0x92F50 VA: 0x180093B50
	public static bool debugcamera_autosave; // 0x5E
	[ClientVar] // RVA: 0x93CC0 Offset: 0x930C0 VA: 0x180093CC0
	public static bool debugcamera_autoload; // 0x5F
	[ClientVar] // RVA: 0x93DD0 Offset: 0x931D0 VA: 0x180093DD0
	public static bool debugcamera_preserve; // 0x60
	[ClientVar] // RVA: 0x93E60 Offset: 0x93260 VA: 0x180093E60
	public static bool debugcamera_lock; // 0x61
	[ClientVar] // RVA: 0x93F50 Offset: 0x93350 VA: 0x180093F50
	public static bool drawcolliders; // 0x62
	[ClientVar] // RVA: 0x94030 Offset: 0x93430 VA: 0x180094030
	public static bool ambientvolumes; // 0x63
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static bool oninventorychanged; // 0x64
	[ClientVar] // RVA: 0x94160 Offset: 0x93560 VA: 0x180094160
	public static string fakeSpeechPlayer; // 0x68

	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static bool log { get; set; }
	[ClientVar] // RVA: 0x95320 Offset: 0x94720 VA: 0x180095320
	public static bool skyreflection { get; set; }


	[ServerVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	[ClientVar] // RVA: 0x89520 Offset: 0x88920 VA: 0x180089520
	public static void renderinfo(ConsoleSystem.Arg arg) { }

	public static void set_log(bool value) { }

	public static bool get_log() { }

	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void stall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x943A0 Offset: 0x937A0 VA: 0x1800943A0
	public static void lookingat(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94410 Offset: 0x93810 VA: 0x180094410
	public static void lookingat_debug(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	public static void debugcamera(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94640 Offset: 0x93A40 VA: 0x180094640
	public static string debugcamera_fov(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	public static void debugcamera_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94780 Offset: 0x93B80 VA: 0x180094780
	public static string debugcamera_guide(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x948F0 Offset: 0x93CF0 VA: 0x1800948F0
	public static string debugcamera_guide_color(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94980 Offset: 0x93D80 VA: 0x180094980
	public static void debugcamera_shake(float amplitude, float frequency, float duration) { }

	[ClientVar] // RVA: 0x949C0 Offset: 0x93DC0 VA: 0x1800949C0
	public static void debugcamera_stopshake() { }

	[ClientVar] // RVA: 0x94A80 Offset: 0x93E80 VA: 0x180094A80
	public static string debugcamera_guide_aspectratio(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void debugcamera_save(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void debugcamera_load(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void debugcamera_savetofile(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void debugcamera_clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void debugcamera_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void debugcamera_targetprint(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94EF0 Offset: 0x942F0 VA: 0x180094EF0
	public static Debugging.EntityInfo[] ent_find_radius(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94FE0 Offset: 0x943E0 VA: 0x180094FE0
	public static void noclip(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x950C0 Offset: 0x944C0 VA: 0x1800950C0
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

