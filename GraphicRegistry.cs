public class GraphicRegistry // TypeDefIndex: 4934
{	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x15DA2B0 Offset: 0x15D88B0 VA: 0x1815DA2B0
	protected void .ctor() { }

	// RVA: 0x15DA3B0 Offset: 0x15D89B0 VA: 0x1815DA3B0
	public static GraphicRegistry get_instance() { }

	// RVA: 0x15D9F70 Offset: 0x15D8570 VA: 0x1815D9F70
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15DA100 Offset: 0x15D8700 VA: 0x1815DA100
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15D9EA0 Offset: 0x15D84A0 VA: 0x1815D9EA0
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x15DA240 Offset: 0x15D8840 VA: 0x1815DA240
	private static void .cctor() { }

}

