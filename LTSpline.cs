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

	// RVA: 0x21AB9A0 Offset: 0x21A9FA0 VA: 0x1821AB9A0
	public void .ctor(Vector3[] pts) { }

	// RVA: 0x21AB950 Offset: 0x21A9F50 VA: 0x1821AB950
	public void .ctor(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21AC220 Offset: 0x21AA820 VA: 0x1821AC220
	private void init(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21ACCA0 Offset: 0x21AB2A0 VA: 0x1821ACCA0
	public Vector3 map(float u) { }

	// RVA: 0x21AC6B0 Offset: 0x21AACB0 VA: 0x1821AC6B0
	public Vector3 interp(float t) { }

	// RVA: 0x21AD920 Offset: 0x21ABF20 VA: 0x1821AD920
	public float ratioAtPoint(Vector3 pt) { }

	// RVA: 0x21AD8D0 Offset: 0x21ABED0 VA: 0x1821AD8D0
	public Vector3 point(float ratio) { }

	// RVA: 0x21ACF00 Offset: 0x21AB500 VA: 0x1821ACF00
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x21AD100 Offset: 0x21AB700 VA: 0x1821AD100
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x21AD660 Offset: 0x21ABC60 VA: 0x1821AD660
	public void place(Transform transform, float ratio) { }

	// RVA: 0x21AD7C0 Offset: 0x21ABDC0 VA: 0x1821AD7C0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21AD350 Offset: 0x21AB950 VA: 0x1821AD350
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x21AD500 Offset: 0x21ABB00 VA: 0x1821AD500
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21AC140 Offset: 0x21AA740 VA: 0x1821AC140
	public void gizmoDraw(float t = -1) { }

	// RVA: 0x21ABC20 Offset: 0x21AA220 VA: 0x1821ABC20
	public void drawGizmo(Color color) { }

	// RVA: 0x21AB9E0 Offset: 0x21A9FE0 VA: 0x1821AB9E0
	public static void drawGizmo(Transform[] arr, Color color) { }

	// RVA: 0x21ABD60 Offset: 0x21AA360 VA: 0x1821ABD60
	public static void drawLine(Transform[] arr, float width, Color color) { }

	// RVA: 0x21ABD80 Offset: 0x21AA380 VA: 0x1821ABD80
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	// RVA: 0x21ABFC0 Offset: 0x21AA5C0 VA: 0x1821ABFC0
	public Vector3[] generateVectors() { }

	// RVA: 0x21AB900 Offset: 0x21A9F00 VA: 0x1821AB900
	private static void .cctor() { }

}

