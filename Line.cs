public struct Line // TypeDefIndex: 6588
{	// Fields
	public Vector3 point0; // 0x0
	public Vector3 point1; // 0xC

	// Methods

	// RVA: 0x1BD6E0 Offset: 0x1BCAE0 VA: 0x1801BD6E0
	public void .ctor(Vector3 point0, Vector3 point1) { }

	// RVA: 0x22C5A0 Offset: 0x22B9A0 VA: 0x18022C5A0
	public void .ctor(Vector3 origin, Vector3 direction, float length) { }

	// RVA: 0x22C550 Offset: 0x22B950 VA: 0x18022C550
	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22C330 Offset: 0x22B730 VA: 0x18022C330
	public Vector3 ClosestPoint(Vector3 pos) { }

	// RVA: 0x22C2F0 Offset: 0x22B6F0 VA: 0x18022C2F0
	public Vector3 ClosestPoint2D(Vector3 pos) { }

	// RVA: 0x22C370 Offset: 0x22B770 VA: 0x18022C370
	public float Distance(Vector3 pos) { }

	// RVA: 0x22C460 Offset: 0x22B860 VA: 0x18022C460
	public float SqrDistance(Vector3 pos) { }

}

