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

	// RVA: 0x22D740 Offset: 0x22CB40 VA: 0x18022D740
	public void .ctor(Transform transform, Bounds bounds) { }

	// RVA: 0x22D2A0 Offset: 0x22C6A0 VA: 0x18022D2A0
	public void .ctor(Vector3 position, Vector3 scale, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x22D330 Offset: 0x22C730 VA: 0x18022D330
	public void .ctor(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x22D570 Offset: 0x22C970 VA: 0x18022D570
	public void .ctor(Vector3 position, Vector3 size, Quaternion rotation) { }

	// RVA: 0x22D0E0 Offset: 0x22C4E0 VA: 0x18022D0E0
	public void Transform(Vector3 position, Vector3 scale, Quaternion rotation) { }

	// RVA: 0x22C8E0 Offset: 0x22BCE0 VA: 0x18022C8E0
	public Vector3 GetPoint(float x, float y, float z) { }

	// RVA: 0x22D080 Offset: 0x22C480 VA: 0x18022D080
	public Bounds ToBounds() { }

	// RVA: 0x22C650 Offset: 0x22BA50 VA: 0x18022C650
	public bool Contains(Vector3 target) { }

	// RVA: 0x22CC70 Offset: 0x22C070 VA: 0x18022CC70
	public bool Intersects(OBB target) { }

	// RVA: 0x22CAD0 Offset: 0x22BED0 VA: 0x18022CAD0
	public bool Intersects2D(OBB target) { }

	// RVA: 0x22CD70 Offset: 0x22C170 VA: 0x18022CD70
	public bool Intersects(Ray ray) { }

	// RVA: 0x22D0A0 Offset: 0x22C4A0 VA: 0x18022D0A0
	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22C610 Offset: 0x22BA10 VA: 0x18022C610
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22C680 Offset: 0x22BA80 VA: 0x18022C680
	public float Distance(OBB other) { }

	// RVA: 0x22C820 Offset: 0x22BC20 VA: 0x18022C820
	public float Distance(Vector3 position) { }

	// RVA: 0x22CEC0 Offset: 0x22C2C0 VA: 0x18022CEC0
	public float SqrDistance(OBB other) { }

	// RVA: 0x22CDD0 Offset: 0x22C1D0 VA: 0x18022CDD0
	public float SqrDistance(Vector3 position) { }

}

