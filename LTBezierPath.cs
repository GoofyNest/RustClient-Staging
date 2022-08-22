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

	// RVA: 0x1979B50 Offset: 0x1978150 VA: 0x181979B50
	public void .ctor(Vector3[] pts_) { }

	// RVA: 0x197A690 Offset: 0x1978C90 VA: 0x18197A690
	public void setPoints(Vector3[] pts_) { }

	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_distance() { }

	// RVA: 0x197A580 Offset: 0x1978B80 VA: 0x18197A580
	public Vector3 point(float ratio) { }

	// RVA: 0x1979C90 Offset: 0x1978290 VA: 0x181979C90
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x1979E60 Offset: 0x1978460 VA: 0x181979E60
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x197A370 Offset: 0x1978970 VA: 0x18197A370
	public void place(Transform transform, float ratio) { }

	// RVA: 0x197A4A0 Offset: 0x1978AA0 VA: 0x18197A4A0
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x197A1B0 Offset: 0x19787B0 VA: 0x18197A1B0
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x197A030 Offset: 0x1978630 VA: 0x18197A030
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x1979B80 Offset: 0x1978180 VA: 0x181979B80
	public void gizmoDraw(float t = -1) { }

}

