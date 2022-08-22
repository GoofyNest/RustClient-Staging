public class GraphicRegistry // TypeDefIndex: 4934
{	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x15ECF90 Offset: 0x15EB590 VA: 0x1815ECF90
	protected void .ctor() { }

	// RVA: 0x15ED090 Offset: 0x15EB690 VA: 0x1815ED090
	public static GraphicRegistry get_instance() { }

	// RVA: 0x15ECC50 Offset: 0x15EB250 VA: 0x1815ECC50
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15ECDE0 Offset: 0x15EB3E0 VA: 0x1815ECDE0
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15ECB80 Offset: 0x15EB180 VA: 0x1815ECB80
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x15ECF20 Offset: 0x15EB520 VA: 0x1815ECF20
	private static void .cctor() { }

}

