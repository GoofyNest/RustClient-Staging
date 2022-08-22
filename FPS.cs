public class FPS : ConsoleSystem // TypeDefIndex: 11923
{	// Fields
	private static int m_graph; // 0x2B111E0

	// Properties
	[ClientVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	[ServerVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int graph { get; set; }

	// Methods

	// RVA: 0x6E0360 Offset: 0x6DE960 VA: 0x1806E0360
	public static int get_limit() { }

	// RVA: 0x6E04A0 Offset: 0x6DEAA0 VA: 0x1806E04A0
	public static void set_limit(int value) { }

	// RVA: 0x6E0320 Offset: 0x6DE920 VA: 0x1806E0320
	public static int get_graph() { }

	// RVA: 0x6E0370 Offset: 0x6DE970 VA: 0x1806E0370
	public static void set_graph(int value) { }

	// RVA: 0x6E02C0 Offset: 0x6DE8C0 VA: 0x1806E02C0
	public void .ctor() { }

}

