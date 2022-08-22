public class LTSpline // TypeDefIndex: 5584
{	// Fields
	public static int DISTANCE_COUNT; // 0x0
	public static int SUBLINE_COUNT; // 0x4
	public float distance; // 0x10
	public bool constantSpeed; // 0x14
	public Vector3[] pts; // 0x18
	public Vector3[] ptsAdj; // 0x20
	public int ptsAdjLength; // 0x28
	public bool orientToPath; // 0x2C
	public bool orientToPath2d; // 0x2D
	private int numSections; // 0x30
	private int currPt; // 0x34

	// Methods

	// RVA: 0x21AB180 Offset: 0x21A9780 VA: 0x1821AB180
	public void .ctor(Vector3[] pts) { }

	// RVA: 0x21AB130 Offset: 0x21A9730 VA: 0x1821AB130
	public void .ctor(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21ABA00 Offset: 0x21AA000 VA: 0x1821ABA00
	private void init(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21AC480 Offset: 0x21AAA80 VA: 0x1821AC480
	public Vector3 map(float u) { }

	// RVA: 0x21ABE90 Offset: 0x21AA490 VA: 0x1821ABE90
	public Vector3 interp(float t) { }

	// RVA: 0x21AD100 Offset: 0x21AB700 VA: 0x1821AD100
	public float ratioAtPoint(Vector3 pt) { }

	// RVA: 0x21AD0B0 Offset: 0x21AB6B0 VA: 0x1821AD0B0
	public Vector3 point(float ratio) { }

	// RVA: 0x21AC6E0 Offset: 0x21AACE0 VA: 0x1821AC6E0
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x21AC8E0 Offset: 0x21AAEE0 VA: 0x1821AC8E0
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x21ACE40 Offset: 0x21AB440 VA: 0x1821ACE40
	public void place(Transform transform, float ratio) { }

	// RVA: 0x21ACFA0 Offset: 0x21AB5A0 VA: 0x1821ACFA0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21ACB30 Offset: 0x21AB130 VA: 0x1821ACB30
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x21ACCE0 Offset: 0x21AB2E0 VA: 0x1821ACCE0
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21AB920 Offset: 0x21A9F20 VA: 0x1821AB920
	public void gizmoDraw(float t = -1) { }

	// RVA: 0x21AB400 Offset: 0x21A9A00 VA: 0x1821AB400
	public void drawGizmo(Color color) { }

	// RVA: 0x21AB1C0 Offset: 0x21A97C0 VA: 0x1821AB1C0
	public static void drawGizmo(Transform[] arr, Color color) { }

	// RVA: 0x21AB540 Offset: 0x21A9B40 VA: 0x1821AB540
	public static void drawLine(Transform[] arr, float width, Color color) { }

	// RVA: 0x21AB560 Offset: 0x21A9B60 VA: 0x1821AB560
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	// RVA: 0x21AB7A0 Offset: 0x21A9DA0 VA: 0x1821AB7A0
	public Vector3[] generateVectors() { }

	// RVA: 0x21AB0E0 Offset: 0x21A96E0 VA: 0x1821AB0E0
	private static void .cctor() { }

}

