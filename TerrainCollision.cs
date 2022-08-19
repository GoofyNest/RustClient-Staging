public class TerrainCollision : TerrainExtension // TypeDefIndex: 10385
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x30
	private TerrainCollider terrainCollider; // 0x38

	// Methods

	// RVA: 0x113D200 Offset: 0x113B800 VA: 0x18113D200 Slot: 4
	public override void Setup() { }

	// RVA: 0x113C9E0 Offset: 0x113AFE0 VA: 0x18113C9E0
	public void Clear() { }

	// RVA: 0x113CEE0 Offset: 0x113B4E0 VA: 0x18113CEE0
	public void Reset(Collider collider) { }

	// RVA: 0x113CC70 Offset: 0x113B270 VA: 0x18113CC70
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x113CB50 Offset: 0x113B150 VA: 0x18113CB50
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x113CD00 Offset: 0x113B300 VA: 0x18113CD00
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x113CFB0 Offset: 0x113B5B0 VA: 0x18113CFB0
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x113CDD0 Offset: 0x113B3D0 VA: 0x18113CDD0
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

