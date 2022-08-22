public class WaterVolume : TriggerBase // TypeDefIndex: 10058
{	// Fields
	public Bounds WaterBounds; // 0x30
	private OBB cachedBounds; // 0x48
	private Transform cachedTransform; // 0x98
	public Transform[] cutOffPlanes; // 0xA0
	public bool waterEnabled; // 0xA8

	// Methods

	// RVA: 0x8F0100 Offset: 0x8EE700 VA: 0x1808F0100
	private void OnEnable() { }

	// RVA: 0x8F05A0 Offset: 0x8EEBA0 VA: 0x1808F05A0
	public bool Test(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8F0880 Offset: 0x8EEE80 VA: 0x1808F0880
	public bool Test(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8F01C0 Offset: 0x8EE7C0 VA: 0x1808F01C0
	public bool Test(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8EFEB0 Offset: 0x8EE4B0 VA: 0x1808EFEB0
	private bool CheckCutOffPlanes(Vector3 pos) { }

	// RVA: 0x8F0BB0 Offset: 0x8EF1B0 VA: 0x1808F0BB0
	private void UpdateCachedTransform() { }

	// RVA: 0x8F0020 Offset: 0x8EE620 VA: 0x1808F0020 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x8F0CF0 Offset: 0x8EF2F0 VA: 0x1808F0CF0
	public void .ctor() { }

}

