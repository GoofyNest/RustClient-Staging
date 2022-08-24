public class Env : ConsoleSystem // TypeDefIndex: 11925
{	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static bool cloudmovement { get; set; }
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static float cloudrotation { get; set; }
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static float skyrotation { get; set; }
	[ReplicatedVar] // RVA: 0x9A6B0 Offset: 0x99AB0 VA: 0x18009A6B0
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

