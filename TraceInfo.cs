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

	// RVA: 0xFB430 Offset: 0xFA830 VA: 0x1800FB430
	public void UpdateHitTest(HitTest test) { }

	// RVA: 0xFB2A0 Offset: 0xFA6A0 VA: 0x1800FB2A0
	public uint BoneID() { }

	// RVA: 0xFB360 Offset: 0xFA760 VA: 0x1800FB360
	public uint MaterialID() { }

}

