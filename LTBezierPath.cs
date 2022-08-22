public class LTBezierPath // TypeDefIndex: 5583
{	// Fields
	public Vector3[] pts; // 0x10
	public float length; // 0x18
	public bool orientToPath; // 0x1C
	public bool orientToPath2d; // 0x1D
	private LTBezier[] beziers; // 0x20
	private float[] lengthRatio; // 0x28
	private int currentBezier; // 0x30
	private int previousBezier; // 0x34

	// Properties
	public float distance { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x198C750 Offset: 0x198AD50 VA: 0x18198C750
	public void .ctor(Vector3[] pts_) { }

	// RVA: 0x198D290 Offset: 0x198B890 VA: 0x18198D290
	public void setPoints(Vector3[] pts_) { }

	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_distance() { }

	// RVA: 0x198D180 Offset: 0x198B780 VA: 0x18198D180
	public Vector3 point(float ratio) { }

	// RVA: 0x198C890 Offset: 0x198AE90 VA: 0x18198C890
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x198CA60 Offset: 0x198B060 VA: 0x18198CA60
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x198CF70 Offset: 0x198B570 VA: 0x18198CF70
	public void place(Transform transform, float ratio) { }

	// RVA: 0x198D0A0 Offset: 0x198B6A0 VA: 0x18198D0A0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x198CDB0 Offset: 0x198B3B0 VA: 0x18198CDB0
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x198CC30 Offset: 0x198B230 VA: 0x18198CC30
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x198C780 Offset: 0x198AD80 VA: 0x18198C780
	public void gizmoDraw(float t = -1) { }

}

