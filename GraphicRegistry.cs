public class GraphicRegistry // TypeDefIndex: 4934
{	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x15ECCD0 Offset: 0x15EB2D0 VA: 0x1815ECCD0
	protected void .ctor() { }

	// RVA: 0x15ECDD0 Offset: 0x15EB3D0 VA: 0x1815ECDD0
	public static GraphicRegistry get_instance() { }

	// RVA: 0x15EC990 Offset: 0x15EAF90 VA: 0x1815EC990
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15ECB20 Offset: 0x15EB120 VA: 0x1815ECB20
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15EC8C0 Offset: 0x15EAEC0 VA: 0x1815EC8C0
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x15ECC60 Offset: 0x15EB260 VA: 0x1815ECC60
	private static void .cctor() { }

}

