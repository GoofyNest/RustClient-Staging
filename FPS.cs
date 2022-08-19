public class FPS : ConsoleSystem // TypeDefIndex: 11923
{	// Fields
	private static int m_graph; // 0x2B11180

	// Properties
	[ClientVar] // RVA: 0x9AF10 Offset: 0x9A310 VA: 0x18009AF10
	[ServerVar] // RVA: 0x9AF10 Offset: 0x9A310 VA: 0x18009AF10
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
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

