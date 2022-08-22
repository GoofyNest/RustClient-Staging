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

	// RVA: 0xA7D480 Offset: 0xA7BA80 VA: 0x180A7D480
	private void OnDrawGizmosSelected() { }

	// RVA: 0xA7D7A0 Offset: 0xA7BDA0 VA: 0x180A7D7A0
	private void OnValidate() { }

	// RVA: 0xA7D650 Offset: 0xA7BC50 VA: 0x180A7D650
	private void OnEnable() { }

	// RVA: 0xA7D2F0 Offset: 0xA7B8F0 VA: 0x180A7D2F0
	private void OnDisable() { }

	// RVA: 0xA7D200 Offset: 0xA7B800 VA: 0x180A7D200 Slot: 7
	public void DoUpdate() { }

	// RVA: 0xA7CC30 Offset: 0xA7B230 VA: 0x180A7CC30
	public void DoOcclusionCheck() { }

	// RVA: 0xA7D920 Offset: 0xA7BF20 VA: 0x180A7D920 Slot: 6
	public void RefreshLOD() { }

	// RVA: 0xA7CBE0 Offset: 0xA7B1E0 VA: 0x180A7CBE0 Slot: 5
	public void ChangeLOD() { }

	// RVA: 0xA7D870 Offset: 0xA7BE70 VA: 0x180A7D870 Slot: 9
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public bool IsSyncedToParent() { }

	// RVA: 0xA7D9A0 Offset: 0xA7BFA0 VA: 0x180A7D9A0
	public void .ctor() { }

}

public class SoundSource.OcclusionPoint // TypeDefIndex: 9044
{	// Fields
	public Vector3 offset; // 0x10
	public bool isOccluded; // 0x1C

	// Methods

	// RVA: 0xA74C60 Offset: 0xA73260 VA: 0x180A74C60
	public void .ctor() { }

}

