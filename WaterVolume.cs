public class WaterVolume : TriggerBase // TypeDefIndex: 10058
{	// Fields
	public Bounds WaterBounds; // 0x30
	private OBB cachedBounds; // 0x48
	private Transform cachedTransform; // 0x98
	public Transform[] cutOffPlanes; // 0xA0
	public bool waterEnabled; // 0xA8

	// Methods

	// RVA: 0x8EFAE0 Offset: 0x8EE0E0 VA: 0x1808EFAE0
	private void OnEnable() { }

	// RVA: 0x8EFF80 Offset: 0x8EE580 VA: 0x1808EFF80
	public bool Test(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8F0260 Offset: 0x8EE860 VA: 0x1808F0260
	public bool Test(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8EFBA0 Offset: 0x8EE1A0 VA: 0x1808EFBA0
	public bool Test(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8EF890 Offset: 0x8EDE90 VA: 0x1808EF890
	private bool CheckCutOffPlanes(Vector3 pos) { }

	// RVA: 0x8F0590 Offset: 0x8EEB90 VA: 0x1808F0590
	private void UpdateCachedTransform() { }

	// RVA: 0x8EFA00 Offset: 0x8EE000 VA: 0x1808EFA00 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x8F06D0 Offset: 0x8EECD0 VA: 0x1808F06D0
	public void .ctor() { }

}

