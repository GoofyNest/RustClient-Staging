public class FPS : ConsoleSystem // TypeDefIndex: 11923
{	private static int m_graph; // 0x1E584

	[ClientVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	[ServerVar] // RVA: 0x9B020 Offset: 0x9A420 VA: 0x18009B020
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int graph { get; set; }


	public static int get_limit() { }

	public static void set_limit(int value) { }

	public static int get_graph() { }

	public static void set_graph(int value) { }

	public void .ctor() { }

}

