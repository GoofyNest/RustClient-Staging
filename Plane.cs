public struct Plane // TypeDefIndex: 3374
{	// Fields
	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; set; }
	public float distance { get; set; }

	// Methods

	// RVA: 0x211FC0 Offset: 0x2113C0 VA: 0x180211FC0
	public Vector3 get_normal() { }

	// RVA: 0x204B60 Offset: 0x203F60 VA: 0x180204B60
	public void set_normal(Vector3 value) { }

	// RVA: 0x211780 Offset: 0x210B80 VA: 0x180211780
	public float get_distance() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_distance(float value) { }

	// RVA: 0x2176B0 Offset: 0x216AB0 VA: 0x1802176B0
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x2175C0 Offset: 0x2169C0 VA: 0x1802175C0
	public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x217200 Offset: 0x216600 VA: 0x180217200
	public Vector3 ClosestPointOnPlane(Vector3 point) { }

	// RVA: 0x217330 Offset: 0x216730 VA: 0x180217330
	public bool GetSide(Vector3 point) { }

	// RVA: 0x2173E0 Offset: 0x2167E0 VA: 0x1802173E0
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x2176A0 Offset: 0x216AA0 VA: 0x1802176A0 Slot: 3
	public override string ToString() { }

}

