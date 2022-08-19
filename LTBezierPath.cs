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

	// RVA: 0x198C4D0 Offset: 0x198AAD0 VA: 0x18198C4D0
	public void .ctor(Vector3[] pts_) { }

	// RVA: 0x198D010 Offset: 0x198B610 VA: 0x18198D010
	public void setPoints(Vector3[] pts_) { }

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_distance() { }

	// RVA: 0x198CF00 Offset: 0x198B500 VA: 0x18198CF00
	public Vector3 point(float ratio) { }

	// RVA: 0x198C610 Offset: 0x198AC10 VA: 0x18198C610
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x198C7E0 Offset: 0x198ADE0 VA: 0x18198C7E0
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x198CCF0 Offset: 0x198B2F0 VA: 0x18198CCF0
	public void place(Transform transform, float ratio) { }

	// RVA: 0x198CE20 Offset: 0x198B420 VA: 0x18198CE20
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x198CB30 Offset: 0x198B130 VA: 0x18198CB30
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x198C9B0 Offset: 0x198AFB0 VA: 0x18198C9B0
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x198C500 Offset: 0x198AB00 VA: 0x18198C500
	public void gizmoDraw(float t = -1) { }

}

