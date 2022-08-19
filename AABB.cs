public struct AABB // TypeDefIndex: 6585
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 extents; // 0xC

	// Methods

	// RVA: 0x22BE30 Offset: 0x22B230 VA: 0x18022BE30
	public void .ctor(Vector3 position, Vector3 size) { }

	// RVA: 0x22BC60 Offset: 0x22B060 VA: 0x18022BC60
	public bool Contains(Vector3 target) { }

	// RVA: 0x22BC20 Offset: 0x22B020 VA: 0x18022BC20
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22BDE0 Offset: 0x22B1E0 VA: 0x18022BDE0
	public bool Trace(Ray ray, out RaycastHit hit, float radius = 0, float maxDistance = ∞) { }

}

