public struct TraceInfo // TypeDefIndex: 9261
{	// Fields
	public bool valid; // 0x0
	public float distance; // 0x4
	public BaseEntity entity; // 0x8
	public Vector3 point; // 0x10
	public Vector3 normal; // 0x1C
	public Transform bone; // 0x28
	public PhysicMaterial material; // 0x30
	public uint partID; // 0x38
	public Collider collider; // 0x40

	// Methods

	// RVA: 0xFB3B0 Offset: 0xFA7B0 VA: 0x1800FB3B0
	public void UpdateHitTest(HitTest test) { }

	// RVA: 0xFB220 Offset: 0xFA620 VA: 0x1800FB220
	public uint BoneID() { }

	// RVA: 0xFB2E0 Offset: 0xFA6E0 VA: 0x1800FB2E0
	public uint MaterialID() { }

}

