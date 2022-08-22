public struct Capsule // TypeDefIndex: 6586
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC
	public float extent; // 0x10

	// Methods

	// RVA: 0x22BFF0 Offset: 0x22B3F0 VA: 0x18022BFF0
	public void .ctor(Vector3 position, float radius, float extent) { }

	// RVA: 0x22BEA0 Offset: 0x22B2A0 VA: 0x18022BEA0
	public bool Contains(Vector3 target) { }

	// RVA: 0x22BE60 Offset: 0x22B260 VA: 0x18022BE60
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22BF60 Offset: 0x22B360 VA: 0x18022BF60
	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	// RVA: 0x22BFA0 Offset: 0x22B3A0 VA: 0x18022BFA0
	public bool Trace(Ray ray, out RaycastHit hit, float rayRadius = 0, float maxDistance = ∞) { }

}

