public class Env : ConsoleSystem // TypeDefIndex: 11921
{	// Properties
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool cloudmovement { get; set; }
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float cloudrotation { get; set; }
	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	public static float skyrotation { get; set; }
	[ReplicatedVar] // RVA: 0x9AB90 Offset: 0x99F90 VA: 0x18009AB90
	public static float oceanlevel { get; set; }

	// Methods

	// RVA: 0x6DFAA0 Offset: 0x6DE0A0 VA: 0x1806DFAA0
	public static bool get_cloudmovement() { }

	// RVA: 0x6DFDE0 Offset: 0x6DE3E0 VA: 0x1806DFDE0
	public static void set_cloudmovement(bool value) { }

	// RVA: 0x6DFB80 Offset: 0x6DE180 VA: 0x1806DFB80
	public static float get_cloudrotation() { }

	// RVA: 0x6DFEC0 Offset: 0x6DE4C0 VA: 0x1806DFEC0
	public static void set_cloudrotation(float value) { }

	// RVA: 0x6DFD00 Offset: 0x6DE300 VA: 0x1806DFD00
	public static float get_skyrotation() { }

	// RVA: 0x6E0080 Offset: 0x6DE680 VA: 0x1806E0080
	public static void set_skyrotation(float value) { }

	// RVA: 0x6DFC60 Offset: 0x6DE260 VA: 0x1806DFC60
	public static float get_oceanlevel() { }

	// RVA: 0x6E0020 Offset: 0x6DE620 VA: 0x1806E0020
	public static void set_oceanlevel(float value) { }

	// RVA: 0x6DFA40 Offset: 0x6DE040 VA: 0x1806DFA40
	public void .ctor() { }

}

