public class Env : ConsoleSystem // TypeDefIndex: 11921
{	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool cloudmovement { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float cloudrotation { get; set; }
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static float skyrotation { get; set; }
	[ReplicatedVar] // RVA: 0x9AD00 Offset: 0x9A100 VA: 0x18009AD00
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

