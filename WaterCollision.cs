public class WaterCollision : MonoBehaviour // TypeDefIndex: 10600
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x18
	private HashSet<Collider> waterColliders; // 0x20

	// Methods

	// RVA: 0x8042E0 Offset: 0x8028E0 VA: 0x1808042E0
	private void Awake() { }

	// RVA: 0x804370 Offset: 0x802970 VA: 0x180804370
	public void Clear() { }

	// RVA: 0x804A40 Offset: 0x803040 VA: 0x180804A40
	public void Reset(Collider collider) { }

	// RVA: 0x8045E0 Offset: 0x802BE0 VA: 0x1808045E0
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x804670 Offset: 0x802C70 VA: 0x180804670
	public bool GetIgnore(Bounds bounds) { }

	// RVA: 0x8046F0 Offset: 0x802CF0 VA: 0x1808046F0
	public bool GetIgnore(Vector3 start, Vector3 end, float radius) { }

	// RVA: 0x8047A0 Offset: 0x802DA0 VA: 0x1808047A0
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x804540 Offset: 0x802B40 VA: 0x180804540
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x804B60 Offset: 0x803160 VA: 0x180804B60
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x8048B0 Offset: 0x802EB0 VA: 0x1808048B0
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

