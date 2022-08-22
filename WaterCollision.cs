public class WaterCollision : MonoBehaviour // TypeDefIndex: 10600
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x18
	private HashSet<Collider> waterColliders; // 0x20

	// Methods

	// RVA: 0x804870 Offset: 0x802E70 VA: 0x180804870
	private void Awake() { }

	// RVA: 0x804900 Offset: 0x802F00 VA: 0x180804900
	public void Clear() { }

	// RVA: 0x804FD0 Offset: 0x8035D0 VA: 0x180804FD0
	public void Reset(Collider collider) { }

	// RVA: 0x804B70 Offset: 0x803170 VA: 0x180804B70
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x804C00 Offset: 0x803200 VA: 0x180804C00
	public bool GetIgnore(Bounds bounds) { }

	// RVA: 0x804C80 Offset: 0x803280 VA: 0x180804C80
	public bool GetIgnore(Vector3 start, Vector3 end, float radius) { }

	// RVA: 0x804D30 Offset: 0x803330 VA: 0x180804D30
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x804AD0 Offset: 0x8030D0 VA: 0x180804AD0
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x8050F0 Offset: 0x8036F0 VA: 0x1808050F0
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x804E40 Offset: 0x803440 VA: 0x180804E40
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

