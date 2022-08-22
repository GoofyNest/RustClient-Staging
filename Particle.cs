public class Particle : ConsoleSystem // TypeDefIndex: 11951
{	private static float m_quality; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool simulationspace; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool ik; // 0x5

	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_lod() { }

	public static float get_cull() { }

	public void .ctor() { }

	private static void .cctor() { }

}

