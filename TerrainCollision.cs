public class TerrainCollision : TerrainExtension // TypeDefIndex: 10385
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x30
	private TerrainCollider terrainCollider; // 0x38

	// Methods

	// RVA: 0x113D4C0 Offset: 0x113BAC0 VA: 0x18113D4C0 Slot: 4
	public override void Setup() { }

	// RVA: 0x113CCA0 Offset: 0x113B2A0 VA: 0x18113CCA0
	public void Clear() { }

	// RVA: 0x113D1A0 Offset: 0x113B7A0 VA: 0x18113D1A0
	public void Reset(Collider collider) { }

	// RVA: 0x113CF30 Offset: 0x113B530 VA: 0x18113CF30
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x113CE10 Offset: 0x113B410 VA: 0x18113CE10
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x113CFC0 Offset: 0x113B5C0 VA: 0x18113CFC0
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x113D270 Offset: 0x113B870 VA: 0x18113D270
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x113D090 Offset: 0x113B690 VA: 0x18113D090
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

