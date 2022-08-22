public struct Line // TypeDefIndex: 6588
{	// Fields
	public Vector3 point0; // 0x0
	public Vector3 point1; // 0xC

	// Methods

	// RVA: 0x1BD3E0 Offset: 0x1BC7E0 VA: 0x1801BD3E0
	public void .ctor(Vector3 point0, Vector3 point1) { }

	// RVA: 0x22C520 Offset: 0x22B920 VA: 0x18022C520
	public void .ctor(Vector3 origin, Vector3 direction, float length) { }

	// RVA: 0x22C4D0 Offset: 0x22B8D0 VA: 0x18022C4D0
	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22C2B0 Offset: 0x22B6B0 VA: 0x18022C2B0
	public Vector3 ClosestPoint(Vector3 pos) { }

	// RVA: 0x22C270 Offset: 0x22B670 VA: 0x18022C270
	public Vector3 ClosestPoint2D(Vector3 pos) { }

	// RVA: 0x22C2F0 Offset: 0x22B6F0 VA: 0x18022C2F0
	public float Distance(Vector3 pos) { }

	// RVA: 0x22C3E0 Offset: 0x22B7E0 VA: 0x18022C3E0
	public float SqrDistance(Vector3 pos) { }

}

