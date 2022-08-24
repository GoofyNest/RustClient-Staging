public class FPS : ConsoleSystem // TypeDefIndex: 11927
{	private static int m_graph; // 0x2B119B8

	[ClientVar] // RVA: 0x9B360 Offset: 0x9A760 VA: 0x18009B360
	[ServerVar] // RVA: 0x9B360 Offset: 0x9A760 VA: 0x18009B360
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static int graph { get; set; }


	public static int get_limit() { }

	public static void set_limit(int value) { }

	public static int get_graph() { }

	public static void set_graph(int value) { }

	public void .ctor() { }

}

