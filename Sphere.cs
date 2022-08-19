public struct Sphere // TypeDefIndex: 6593
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC

	// Methods

	// RVA: 0xFB280 Offset: 0xFA680 VA: 0x1800FB280
	public void .ctor(Vector3 position, float radius) { }

	// RVA: 0x22D910 Offset: 0x22CD10 VA: 0x18022D910
	public bool Contains(Vector3 target) { }

	// RVA: 0x22D8D0 Offset: 0x22CCD0 VA: 0x18022D8D0
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22D9D0 Offset: 0x22CDD0 VA: 0x18022D9D0
	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	// RVA: 0x22DBA0 Offset: 0x22CFA0 VA: 0x18022DBA0
	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

}

