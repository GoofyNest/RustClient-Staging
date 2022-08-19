public class Grass : ConsoleSystem // TypeDefIndex: 11930
{	// Fields
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool displacement; // 0x0
	private static float m_quality; // 0x4
	private static float m_distance; // 0x8
	private static int m_maxthreads; // 0xC
	private static float m_refresh_budget; // 0x10

	// Properties
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float quality { get; set; }
	public static float quality01 { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float distance { get; set; }
	[ClientVar] // RVA: 0x891C0 Offset: 0x885C0 VA: 0x1800891C0
	public static int maxthreads { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float refresh_budget { get; set; }

	// Methods

	// RVA: 0x363390 Offset: 0x361990 VA: 0x180363390
	public static float get_quality() { }

	// RVA: 0x363B90 Offset: 0x362190 VA: 0x180363B90
	public static void set_quality(float value) { }

	// RVA: 0x3632E0 Offset: 0x3618E0 VA: 0x1803632E0
	public static float get_quality01() { }

	// RVA: 0x3639B0 Offset: 0x361FB0 VA: 0x1803639B0
	public static void set_quality01(float value) { }

	// RVA: 0x363220 Offset: 0x361820 VA: 0x180363220
	public static float get_distance() { }

	// RVA: 0x363780 Offset: 0x361D80 VA: 0x180363780
	public static void set_distance(float value) { }

	// RVA: 0x363280 Offset: 0x361880 VA: 0x180363280
	public static int get_maxthreads() { }

	// RVA: 0x363910 Offset: 0x361F10 VA: 0x180363910
	public static void set_maxthreads(int value) { }

	// RVA: 0x3633F0 Offset: 0x3619F0 VA: 0x1803633F0
	public static float get_refresh_budget() { }

	// RVA: 0x363D20 Offset: 0x362320 VA: 0x180363D20
	public static void set_refresh_budget(float value) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x363450 Offset: 0x361A50 VA: 0x180363450
	public static void print_foliage(ConsoleSystem.Arg args) { }

	// RVA: 0x3631C0 Offset: 0x3617C0 VA: 0x1803631C0
	public void .ctor() { }

	// RVA: 0x363130 Offset: 0x361730 VA: 0x180363130
	private static void .cctor() { }

}

