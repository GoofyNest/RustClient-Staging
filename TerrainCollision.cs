public class TerrainCollision : TerrainExtension // TypeDefIndex: 10385
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x30
	private TerrainCollider terrainCollider; // 0x38

	// Methods

	// RVA: 0x113DF30 Offset: 0x113C530 VA: 0x18113DF30 Slot: 4
	public override void Setup() { }

	// RVA: 0x113D710 Offset: 0x113BD10 VA: 0x18113D710
	public void Clear() { }

	// RVA: 0x113DC10 Offset: 0x113C210 VA: 0x18113DC10
	public void Reset(Collider collider) { }

	// RVA: 0x113D9A0 Offset: 0x113BFA0 VA: 0x18113D9A0
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x113D880 Offset: 0x113BE80 VA: 0x18113D880
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x113DA30 Offset: 0x113C030 VA: 0x18113DA30
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x113DCE0 Offset: 0x113C2E0 VA: 0x18113DCE0
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x113DB00 Offset: 0x113C100 VA: 0x18113DB00
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

