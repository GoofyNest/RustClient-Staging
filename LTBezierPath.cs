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

	// RVA: 0x198C490 Offset: 0x198AA90 VA: 0x18198C490
	public void .ctor(Vector3[] pts_) { }

	// RVA: 0x198CFD0 Offset: 0x198B5D0 VA: 0x18198CFD0
	public void setPoints(Vector3[] pts_) { }

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_distance() { }

	// RVA: 0x198CEC0 Offset: 0x198B4C0 VA: 0x18198CEC0
	public Vector3 point(float ratio) { }

	// RVA: 0x198C5D0 Offset: 0x198ABD0 VA: 0x18198C5D0
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x198C7A0 Offset: 0x198ADA0 VA: 0x18198C7A0
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x198CCB0 Offset: 0x198B2B0 VA: 0x18198CCB0
	public void place(Transform transform, float ratio) { }

	// RVA: 0x198CDE0 Offset: 0x198B3E0 VA: 0x18198CDE0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x198CAF0 Offset: 0x198B0F0 VA: 0x18198CAF0
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x198C970 Offset: 0x198AF70 VA: 0x18198C970
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x198C4C0 Offset: 0x198AAC0 VA: 0x18198C4C0
	public void gizmoDraw(float t = -1) { }

}

