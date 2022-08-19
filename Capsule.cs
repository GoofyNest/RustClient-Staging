public struct Capsule // TypeDefIndex: 6586
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC
	public float extent; // 0x10

	// Methods

	// RVA: 0x22C070 Offset: 0x22B470 VA: 0x18022C070
	public void .ctor(Vector3 position, float radius, float extent) { }

	// RVA: 0x22BF20 Offset: 0x22B320 VA: 0x18022BF20
	public bool Contains(Vector3 target) { }

	// RVA: 0x22BEE0 Offset: 0x22B2E0 VA: 0x18022BEE0
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22BFE0 Offset: 0x22B3E0 VA: 0x18022BFE0
	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	// RVA: 0x22C020 Offset: 0x22B420 VA: 0x18022C020
	public bool Trace(Ray ray, out RaycastHit hit, float rayRadius = 0, float maxDistance = ∞) { }

}

