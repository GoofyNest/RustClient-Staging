public class SoundSource : MonoBehaviour, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9043
{	// Fields
	[HeaderAttribute] // RVA: 0xD0520 Offset: 0xCF920 VA: 0x1800D0520
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

	// RVA: 0xA7CFB0 Offset: 0xA7B5B0 VA: 0x180A7CFB0
	private void OnDrawGizmosSelected() { }

	// RVA: 0xA7D2D0 Offset: 0xA7B8D0 VA: 0x180A7D2D0
	private void OnValidate() { }

	// RVA: 0xA7D180 Offset: 0xA7B780 VA: 0x180A7D180
	private void OnEnable() { }

	// RVA: 0xA7CE20 Offset: 0xA7B420 VA: 0x180A7CE20
	private void OnDisable() { }

	// RVA: 0xA7CD30 Offset: 0xA7B330 VA: 0x180A7CD30 Slot: 7
	public void DoUpdate() { }

	// RVA: 0xA7C760 Offset: 0xA7AD60 VA: 0x180A7C760
	public void DoOcclusionCheck() { }

	// RVA: 0xA7D450 Offset: 0xA7BA50 VA: 0x180A7D450 Slot: 6
	public void RefreshLOD() { }

	// RVA: 0xA7C710 Offset: 0xA7AD10 VA: 0x180A7C710 Slot: 5
	public void ChangeLOD() { }

	// RVA: 0xA7D3A0 Offset: 0xA7B9A0 VA: 0x180A7D3A0 Slot: 9
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public bool IsSyncedToParent() { }

	// RVA: 0xA7D4D0 Offset: 0xA7BAD0 VA: 0x180A7D4D0
	public void .ctor() { }

}

public class SoundSource.OcclusionPoint // TypeDefIndex: 9044
{	// Fields
	public Vector3 offset; // 0x10
	public bool isOccluded; // 0x1C

	// Methods

	// RVA: 0xA74790 Offset: 0xA72D90 VA: 0x180A74790
	public void .ctor() { }

}

