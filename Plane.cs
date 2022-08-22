public struct Plane // TypeDefIndex: 3374
{	// Fields
	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; set; }
	public float distance { get; set; }

	// Methods

	// RVA: 0x212B90 Offset: 0x211F90 VA: 0x180212B90
	public Vector3 get_normal() { }

	// RVA: 0x204F30 Offset: 0x204330 VA: 0x180204F30
	public void set_normal(Vector3 value) { }

	// RVA: 0x212350 Offset: 0x211750 VA: 0x180212350
	public float get_distance() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_distance(float value) { }

	// RVA: 0x216FE0 Offset: 0x2163E0 VA: 0x180216FE0
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x216EF0 Offset: 0x2162F0 VA: 0x180216EF0
	public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x216B30 Offset: 0x215F30 VA: 0x180216B30
	public Vector3 ClosestPointOnPlane(Vector3 point) { }

	// RVA: 0x216C60 Offset: 0x216060 VA: 0x180216C60
	public bool GetSide(Vector3 point) { }

	// RVA: 0x216D10 Offset: 0x216110 VA: 0x180216D10
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x216FD0 Offset: 0x2163D0 VA: 0x180216FD0 Slot: 3
	public override string ToString() { }

}

