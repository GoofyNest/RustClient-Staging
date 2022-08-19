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

	// RVA: 0x21AB080 Offset: 0x21A9680 VA: 0x1821AB080
	public void .ctor(Vector3[] pts) { }

	// RVA: 0x21AB030 Offset: 0x21A9630 VA: 0x1821AB030
	public void .ctor(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21AB900 Offset: 0x21A9F00 VA: 0x1821AB900
	private void init(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21AC380 Offset: 0x21AA980 VA: 0x1821AC380
	public Vector3 map(float u) { }

	// RVA: 0x21ABD90 Offset: 0x21AA390 VA: 0x1821ABD90
	public Vector3 interp(float t) { }

	// RVA: 0x21AD000 Offset: 0x21AB600 VA: 0x1821AD000
	public float ratioAtPoint(Vector3 pt) { }

	// RVA: 0x21ACFB0 Offset: 0x21AB5B0 VA: 0x1821ACFB0
	public Vector3 point(float ratio) { }

	// RVA: 0x21AC5E0 Offset: 0x21AABE0 VA: 0x1821AC5E0
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x21AC7E0 Offset: 0x21AADE0 VA: 0x1821AC7E0
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x21ACD40 Offset: 0x21AB340 VA: 0x1821ACD40
	public void place(Transform transform, float ratio) { }

	// RVA: 0x21ACEA0 Offset: 0x21AB4A0 VA: 0x1821ACEA0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21ACA30 Offset: 0x21AB030 VA: 0x1821ACA30
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x21ACBE0 Offset: 0x21AB1E0 VA: 0x1821ACBE0
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21AB820 Offset: 0x21A9E20 VA: 0x1821AB820
	public void gizmoDraw(float t = -1) { }

	// RVA: 0x21AB300 Offset: 0x21A9900 VA: 0x1821AB300
	public void drawGizmo(Color color) { }

	// RVA: 0x21AB0C0 Offset: 0x21A96C0 VA: 0x1821AB0C0
	public static void drawGizmo(Transform[] arr, Color color) { }

	// RVA: 0x21AB440 Offset: 0x21A9A40 VA: 0x1821AB440
	public static void drawLine(Transform[] arr, float width, Color color) { }

	// RVA: 0x21AB460 Offset: 0x21A9A60 VA: 0x1821AB460
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	// RVA: 0x21AB6A0 Offset: 0x21A9CA0 VA: 0x1821AB6A0
	public Vector3[] generateVectors() { }

	// RVA: 0x21AAFE0 Offset: 0x21A95E0 VA: 0x1821AAFE0
	private static void .cctor() { }

}

