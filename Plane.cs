public struct Plane // TypeDefIndex: 3374
{	// Fields
	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; set; }
	public float distance { get; set; }

	// Methods

	// RVA: 0x212C10 Offset: 0x212010 VA: 0x180212C10
	public Vector3 get_normal() { }

	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_normal(Vector3 value) { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public float get_distance() { }

	// RVA: 0x1171D0 Offset: 0x1165D0 VA: 0x1801171D0
	public void set_distance(float value) { }

	// RVA: 0x217060 Offset: 0x216460 VA: 0x180217060
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x216F70 Offset: 0x216370 VA: 0x180216F70
	public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x216BB0 Offset: 0x215FB0 VA: 0x180216BB0
	public Vector3 ClosestPointOnPlane(Vector3 point) { }

	// RVA: 0x216CE0 Offset: 0x2160E0 VA: 0x180216CE0
	public bool GetSide(Vector3 point) { }

	// RVA: 0x216D90 Offset: 0x216190 VA: 0x180216D90
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x217050 Offset: 0x216450 VA: 0x180217050 Slot: 3
	public override string ToString() { }

}

