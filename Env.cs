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

	// RVA: 0x6DFBB0 Offset: 0x6DE1B0 VA: 0x1806DFBB0
	public static bool get_cloudmovement() { }

	// RVA: 0x6DFEF0 Offset: 0x6DE4F0 VA: 0x1806DFEF0
	public static void set_cloudmovement(bool value) { }

	// RVA: 0x6DFC90 Offset: 0x6DE290 VA: 0x1806DFC90
	public static float get_cloudrotation() { }

	// RVA: 0x6DFFD0 Offset: 0x6DE5D0 VA: 0x1806DFFD0
	public static void set_cloudrotation(float value) { }

	// RVA: 0x6DFE10 Offset: 0x6DE410 VA: 0x1806DFE10
	public static float get_skyrotation() { }

	// RVA: 0x6E0190 Offset: 0x6DE790 VA: 0x1806E0190
	public static void set_skyrotation(float value) { }

	// RVA: 0x6DFD70 Offset: 0x6DE370 VA: 0x1806DFD70
	public static float get_oceanlevel() { }

	// RVA: 0x6E0130 Offset: 0x6DE730 VA: 0x1806E0130
	public static void set_oceanlevel(float value) { }

	// RVA: 0x6DFB50 Offset: 0x6DE150 VA: 0x1806DFB50
	public void .ctor() { }

}

