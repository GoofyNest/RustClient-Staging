public class FPS : ConsoleSystem // TypeDefIndex: 11923
{	// Fields
	private static int m_graph; // 0x1E584

	// Properties
	[ClientVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	[ServerVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int graph { get; set; }

	// Methods

	// RVA: 0x6E02F0 Offset: 0x6DE8F0 VA: 0x1806E02F0
	public static int get_limit() { }

	// RVA: 0x6E0430 Offset: 0x6DEA30 VA: 0x1806E0430
	public static void set_limit(int value) { }

	// RVA: 0x6E02B0 Offset: 0x6DE8B0 VA: 0x1806E02B0
	public static int get_graph() { }

	// RVA: 0x6E0300 Offset: 0x6DE900 VA: 0x1806E0300
	public static void set_graph(int value) { }

	// RVA: 0x6E0250 Offset: 0x6DE850 VA: 0x1806E0250
	public void .ctor() { }

}

