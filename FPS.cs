public class FPS : ConsoleSystem // TypeDefIndex: 11923
{	// Fields
	private static int m_graph; // 0x2B101A0

	// Properties
	[ClientVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	[ServerVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int graph { get; set; }

	// Methods

	// RVA: 0x6E0250 Offset: 0x6DE850 VA: 0x1806E0250
	public static int get_limit() { }

	// RVA: 0x6E0390 Offset: 0x6DE990 VA: 0x1806E0390
	public static void set_limit(int value) { }

	// RVA: 0x6E0210 Offset: 0x6DE810 VA: 0x1806E0210
	public static int get_graph() { }

	// RVA: 0x6E0260 Offset: 0x6DE860 VA: 0x1806E0260
	public static void set_graph(int value) { }

	// RVA: 0x6E01B0 Offset: 0x6DE7B0 VA: 0x1806E01B0
	public void .ctor() { }

}

