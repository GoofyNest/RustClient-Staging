public class Env : ConsoleSystem // TypeDefIndex: 11921
{	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool cloudmovement { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float cloudrotation { get; set; }
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static float skyrotation { get; set; }
	[ReplicatedVar] // RVA: 0x9AD00 Offset: 0x9A100 VA: 0x18009AD00
	public static float oceanlevel { get; set; }

	// Methods

	// RVA: 0x6DFB40 Offset: 0x6DE140 VA: 0x1806DFB40
	public static bool get_cloudmovement() { }

	// RVA: 0x6DFE80 Offset: 0x6DE480 VA: 0x1806DFE80
	public static void set_cloudmovement(bool value) { }

	// RVA: 0x6DFC20 Offset: 0x6DE220 VA: 0x1806DFC20
	public static float get_cloudrotation() { }

	// RVA: 0x6DFF60 Offset: 0x6DE560 VA: 0x1806DFF60
	public static void set_cloudrotation(float value) { }

	// RVA: 0x6DFDA0 Offset: 0x6DE3A0 VA: 0x1806DFDA0
	public static float get_skyrotation() { }

	// RVA: 0x6E0120 Offset: 0x6DE720 VA: 0x1806E0120
	public static void set_skyrotation(float value) { }

	// RVA: 0x6DFD00 Offset: 0x6DE300 VA: 0x1806DFD00
	public static float get_oceanlevel() { }

	// RVA: 0x6E00C0 Offset: 0x6DE6C0 VA: 0x1806E00C0
	public static void set_oceanlevel(float value) { }

	// RVA: 0x6DFAE0 Offset: 0x6DE0E0 VA: 0x1806DFAE0
	public void .ctor() { }

}

