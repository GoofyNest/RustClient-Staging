public class SoundSource : MonoBehaviour, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9043
{	// Fields
	[HeaderAttribute] // RVA: 0xD0490 Offset: 0xCF890 VA: 0x1800D0490
	public bool handleOcclusionChecks; // 0x18
	public LayerMask occlusionLayerMask; // 0x1C
	public List<SoundSource.OcclusionPoint> occlusionPoints; // 0x20
	public bool isOccluded; // 0x28
	public float occlusionAmount; // 0x2C
	public float lodDistance; // 0x30
	public bool inRange; // 0x34
	private bool wasInRange; // 0x35
	private LODCell cell; // 0x38
	private float lastOcclusionCheck; // 0x40
	private float occlusionCheckInterval; // 0x44
	private int lastOcclusionPointIdx; // 0x48
	private Ray ray; // 0x4C
	private List<RaycastHit> hits; // 0x68

	// Methods

	// RVA: 0xA7CCF0 Offset: 0xA7B2F0 VA: 0x180A7CCF0
	private void OnDrawGizmosSelected() { }

	// RVA: 0xA7D010 Offset: 0xA7B610 VA: 0x180A7D010
	private void OnValidate() { }

	// RVA: 0xA7CEC0 Offset: 0xA7B4C0 VA: 0x180A7CEC0
	private void OnEnable() { }

	// RVA: 0xA7CB60 Offset: 0xA7B160 VA: 0x180A7CB60
	private void OnDisable() { }

	// RVA: 0xA7CA70 Offset: 0xA7B070 VA: 0x180A7CA70 Slot: 7
	public void DoUpdate() { }

	// RVA: 0xA7C4A0 Offset: 0xA7AAA0 VA: 0x180A7C4A0
	public void DoOcclusionCheck() { }

	// RVA: 0xA7D190 Offset: 0xA7B790 VA: 0x180A7D190 Slot: 6
	public void RefreshLOD() { }

	// RVA: 0xA7C450 Offset: 0xA7AA50 VA: 0x180A7C450 Slot: 5
	public void ChangeLOD() { }

	// RVA: 0xA7D0E0 Offset: 0xA7B6E0 VA: 0x180A7D0E0 Slot: 9
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public bool IsSyncedToParent() { }

	// RVA: 0xA7D210 Offset: 0xA7B810 VA: 0x180A7D210
	public void .ctor() { }

}

public class SoundSource.OcclusionPoint // TypeDefIndex: 9044
{	// Fields
	public Vector3 offset; // 0x10
	public bool isOccluded; // 0x1C

	// Methods

	// RVA: 0xA744D0 Offset: 0xA72AD0 VA: 0x180A744D0
	public void .ctor() { }

}

