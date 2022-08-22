public class WaterVolume : TriggerBase // TypeDefIndex: 10058
{	// Fields
	public Bounds WaterBounds; // 0x30
	private OBB cachedBounds; // 0x48
	private Transform cachedTransform; // 0x98
	public Transform[] cutOffPlanes; // 0xA0
	public bool waterEnabled; // 0xA8

	// Methods

	// RVA: 0x8EFBF0 Offset: 0x8EE1F0 VA: 0x1808EFBF0
	private void OnEnable() { }

	// RVA: 0x8F0090 Offset: 0x8EE690 VA: 0x1808F0090
	public bool Test(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8F0370 Offset: 0x8EE970 VA: 0x1808F0370
	public bool Test(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8EFCB0 Offset: 0x8EE2B0 VA: 0x1808EFCB0
	public bool Test(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8EF9A0 Offset: 0x8EDFA0 VA: 0x1808EF9A0
	private bool CheckCutOffPlanes(Vector3 pos) { }

	// RVA: 0x8F06A0 Offset: 0x8EECA0 VA: 0x1808F06A0
	private void UpdateCachedTransform() { }

	// RVA: 0x8EFB10 Offset: 0x8EE110 VA: 0x1808EFB10 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x8F07E0 Offset: 0x8EEDE0 VA: 0x1808F07E0
	public void .ctor() { }

}

