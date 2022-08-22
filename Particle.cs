public class Particle : ConsoleSystem // TypeDefIndex: 11951
{	// Fields
	private static float m_quality; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool simulationspace; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool ik; // 0x5

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }

	// Methods

	// RVA: 0x367860 Offset: 0x365E60 VA: 0x180367860
	public static float get_quality() { }

	// RVA: 0x3678C0 Offset: 0x365EC0 VA: 0x1803678C0
	public static void set_quality(float value) { }

	// RVA: 0x3677B0 Offset: 0x365DB0 VA: 0x1803677B0
	public static float get_lod() { }

	// RVA: 0x3676D0 Offset: 0x365CD0 VA: 0x1803676D0
	public static float get_cull() { }

	// RVA: 0x367670 Offset: 0x365C70 VA: 0x180367670
	public void .ctor() { }

	// RVA: 0x367610 Offset: 0x365C10 VA: 0x180367610
	private static void .cctor() { }

}

