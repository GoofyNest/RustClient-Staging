public class Particle : ConsoleSystem // TypeDefIndex: 11955
{	private static float m_quality; // 0x0
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static bool simulationspace; // 0x4
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static bool ik; // 0x5

	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
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

