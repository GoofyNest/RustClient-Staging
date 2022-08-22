public struct Sphere // TypeDefIndex: 6593
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC

	// Methods

	// RVA: 0xFB200 Offset: 0xFA600 VA: 0x1800FB200
	public void .ctor(Vector3 position, float radius) { }

	// RVA: 0x22D890 Offset: 0x22CC90 VA: 0x18022D890
	public bool Contains(Vector3 target) { }

	// RVA: 0x22D850 Offset: 0x22CC50 VA: 0x18022D850
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22D950 Offset: 0x22CD50 VA: 0x18022D950
	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	// RVA: 0x22DB20 Offset: 0x22CF20 VA: 0x18022DB20
	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

}

