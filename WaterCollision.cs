public class WaterCollision : MonoBehaviour // TypeDefIndex: 10600
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x18
	private HashSet<Collider> waterColliders; // 0x20

	// Methods

	// RVA: 0x8041D0 Offset: 0x8027D0 VA: 0x1808041D0
	private void Awake() { }

	// RVA: 0x804260 Offset: 0x802860 VA: 0x180804260
	public void Clear() { }

	// RVA: 0x804930 Offset: 0x802F30 VA: 0x180804930
	public void Reset(Collider collider) { }

	// RVA: 0x8044D0 Offset: 0x802AD0 VA: 0x1808044D0
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x804560 Offset: 0x802B60 VA: 0x180804560
	public bool GetIgnore(Bounds bounds) { }

	// RVA: 0x8045E0 Offset: 0x802BE0 VA: 0x1808045E0
	public bool GetIgnore(Vector3 start, Vector3 end, float radius) { }

	// RVA: 0x804690 Offset: 0x802C90 VA: 0x180804690
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x804430 Offset: 0x802A30 VA: 0x180804430
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x804A50 Offset: 0x803050 VA: 0x180804A50
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x8047A0 Offset: 0x802DA0 VA: 0x1808047A0
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

