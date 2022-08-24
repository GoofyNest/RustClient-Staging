public class FPS : ConsoleSystem // TypeDefIndex: 11927
{	private static int m_graph; // 0x1E900

	[ClientVar] // RVA: 0x9AC40 Offset: 0x9A040 VA: 0x18009AC40
	[ServerVar] // RVA: 0x9AC40 Offset: 0x9A040 VA: 0x18009AC40
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static int graph { get; set; }


	public static int get_limit() { }

	public static void set_limit(int value) { }

	public static int get_graph() { }

	public static void set_graph(int value) { }

	public void .ctor() { }

}

