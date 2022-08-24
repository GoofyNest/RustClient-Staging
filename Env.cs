public class Env : ConsoleSystem // TypeDefIndex: 11925
{	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static bool cloudmovement { get; set; }
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static float cloudrotation { get; set; }
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static float skyrotation { get; set; }
	[ReplicatedVar] // RVA: 0x9AE90 Offset: 0x9A290 VA: 0x18009AE90
	public static float oceanlevel { get; set; }


	public static bool get_cloudmovement() { }

	public static void set_cloudmovement(bool value) { }

	public static float get_cloudrotation() { }

	public static void set_cloudrotation(float value) { }

	public static float get_skyrotation() { }

	public static void set_skyrotation(float value) { }

	public static float get_oceanlevel() { }

	public static void set_oceanlevel(float value) { }

	public void .ctor() { }

}

