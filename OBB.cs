public struct OBB // TypeDefIndex: 6590
{	// Fields
	public Quaternion rotation; // 0x0
	public Vector3 position; // 0x10
	public Vector3 extents; // 0x1C
	public Vector3 forward; // 0x28
	public Vector3 right; // 0x34
	public Vector3 up; // 0x40
	public float reject; // 0x4C

	// Methods

	// RVA: 0x22D7C0 Offset: 0x22CBC0 VA: 0x18022D7C0
	public void .ctor(Transform transform, Bounds bounds) { }

	// RVA: 0x22D320 Offset: 0x22C720 VA: 0x18022D320
	public void .ctor(Vector3 position, Vector3 scale, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x22D3B0 Offset: 0x22C7B0 VA: 0x18022D3B0
	public void .ctor(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x22D5F0 Offset: 0x22C9F0 VA: 0x18022D5F0
	public void .ctor(Vector3 position, Vector3 size, Quaternion rotation) { }

	// RVA: 0x22D160 Offset: 0x22C560 VA: 0x18022D160
	public void Transform(Vector3 position, Vector3 scale, Quaternion rotation) { }

	// RVA: 0x22C960 Offset: 0x22BD60 VA: 0x18022C960
	public Vector3 GetPoint(float x, float y, float z) { }

	// RVA: 0x22D100 Offset: 0x22C500 VA: 0x18022D100
	public Bounds ToBounds() { }

	// RVA: 0x22C6D0 Offset: 0x22BAD0 VA: 0x18022C6D0
	public bool Contains(Vector3 target) { }

	// RVA: 0x22CCF0 Offset: 0x22C0F0 VA: 0x18022CCF0
	public bool Intersects(OBB target) { }

	// RVA: 0x22CB50 Offset: 0x22BF50 VA: 0x18022CB50
	public bool Intersects2D(OBB target) { }

	// RVA: 0x22CDF0 Offset: 0x22C1F0 VA: 0x18022CDF0
	public bool Intersects(Ray ray) { }

	// RVA: 0x22D120 Offset: 0x22C520 VA: 0x18022D120
	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22C690 Offset: 0x22BA90 VA: 0x18022C690
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22C700 Offset: 0x22BB00 VA: 0x18022C700
	public float Distance(OBB other) { }

	// RVA: 0x22C8A0 Offset: 0x22BCA0 VA: 0x18022C8A0
	public float Distance(Vector3 position) { }

	// RVA: 0x22CF40 Offset: 0x22C340 VA: 0x18022CF40
	public float SqrDistance(OBB other) { }

	// RVA: 0x22CE50 Offset: 0x22C250 VA: 0x18022CE50
	public float SqrDistance(Vector3 position) { }

}

