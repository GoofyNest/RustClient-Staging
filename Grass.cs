public class Grass : ConsoleSystem // TypeDefIndex: 11934
{	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool displacement; // 0x0
	private static float m_quality; // 0x4
	private static float m_distance; // 0x8
	private static int m_maxthreads; // 0xC
	private static float m_refresh_budget; // 0x10

	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static float quality { get; set; }
	public static float quality01 { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static float distance { get; set; }
	[ClientVar] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	public static int maxthreads { get; set; }
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static float refresh_budget { get; set; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_quality01() { }

	public static void set_quality01(float value) { }

	public static float get_distance() { }

	public static void set_distance(float value) { }

	public static int get_maxthreads() { }

	public static void set_maxthreads(int value) { }

	public static float get_refresh_budget() { }

	public static void set_refresh_budget(float value) { }

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static void print_foliage(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

