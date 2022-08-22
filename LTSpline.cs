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

	// RVA: 0x21AAEC0 Offset: 0x21A94C0 VA: 0x1821AAEC0
	public void .ctor(Vector3[] pts) { }

	// RVA: 0x21AAE70 Offset: 0x21A9470 VA: 0x1821AAE70
	public void .ctor(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21AB740 Offset: 0x21A9D40 VA: 0x1821AB740
	private void init(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21AC1C0 Offset: 0x21AA7C0 VA: 0x1821AC1C0
	public Vector3 map(float u) { }

	// RVA: 0x21ABBD0 Offset: 0x21AA1D0 VA: 0x1821ABBD0
	public Vector3 interp(float t) { }

	// RVA: 0x21ACE40 Offset: 0x21AB440 VA: 0x1821ACE40
	public float ratioAtPoint(Vector3 pt) { }

	// RVA: 0x21ACDF0 Offset: 0x21AB3F0 VA: 0x1821ACDF0
	public Vector3 point(float ratio) { }

	// RVA: 0x21AC420 Offset: 0x21AAA20 VA: 0x1821AC420
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x21AC620 Offset: 0x21AAC20 VA: 0x1821AC620
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x21ACB80 Offset: 0x21AB180 VA: 0x1821ACB80
	public void place(Transform transform, float ratio) { }

	// RVA: 0x21ACCE0 Offset: 0x21AB2E0 VA: 0x1821ACCE0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21AC870 Offset: 0x21AAE70 VA: 0x1821AC870
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x21ACA20 Offset: 0x21AB020 VA: 0x1821ACA20
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21AB660 Offset: 0x21A9C60 VA: 0x1821AB660
	public void gizmoDraw(float t = -1) { }

	// RVA: 0x21AB140 Offset: 0x21A9740 VA: 0x1821AB140
	public void drawGizmo(Color color) { }

	// RVA: 0x21AAF00 Offset: 0x21A9500 VA: 0x1821AAF00
	public static void drawGizmo(Transform[] arr, Color color) { }

	// RVA: 0x21AB280 Offset: 0x21A9880 VA: 0x1821AB280
	public static void drawLine(Transform[] arr, float width, Color color) { }

	// RVA: 0x21AB2A0 Offset: 0x21A98A0 VA: 0x1821AB2A0
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	// RVA: 0x21AB4E0 Offset: 0x21A9AE0 VA: 0x1821AB4E0
	public Vector3[] generateVectors() { }

	// RVA: 0x21AAE20 Offset: 0x21A9420 VA: 0x1821AAE20
	private static void .cctor() { }

}

