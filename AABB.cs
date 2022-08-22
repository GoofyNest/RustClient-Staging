public struct AABB // TypeDefIndex: 6585
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 extents; // 0xC

	// Methods

	// RVA: 0x22BDB0 Offset: 0x22B1B0 VA: 0x18022BDB0
	public void .ctor(Vector3 position, Vector3 size) { }

	// RVA: 0x22BBE0 Offset: 0x22AFE0 VA: 0x18022BBE0
	public bool Contains(Vector3 target) { }

	// RVA: 0x22BBA0 Offset: 0x22AFA0 VA: 0x18022BBA0
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22BD60 Offset: 0x22B160 VA: 0x18022BD60
	public bool Trace(Ray ray, out RaycastHit hit, float radius = 0, float maxDistance = ∞) { }

}

