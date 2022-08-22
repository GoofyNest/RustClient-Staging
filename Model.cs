public class Model : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9210
{	// Fields
	public SphereCollider collision; // 0x18
	public Transform rootBone; // 0x20
	public Transform headBone; // 0x28
	public Transform eyeBone; // 0x30
	public Animator animator; // 0x38
	public Skeleton skeleton; // 0x40
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform[] boneTransforms; // 0x48
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string[] boneNames; // 0x50
	internal BoneDictionary boneDict; // 0x58
	internal int skin; // 0x60
	private LODGroup _lodGroup; // 0x68

	// Properties
	public LODGroup lodGroup { get; }

	// Methods

	// RVA: 0x773C10 Offset: 0x772210 VA: 0x180773C10
	protected void OnEnable() { }

	// RVA: 0x773380 Offset: 0x771980 VA: 0x180773380
	public void BuildBoneDictionary() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int GetSkin() { }

	// RVA: 0x773470 Offset: 0x771A70 VA: 0x180773470
	private Transform FindBoneInternal(string name) { }

	// RVA: 0x773500 Offset: 0x771B00 VA: 0x180773500
	public Transform FindBone(string name) { }

	// RVA: 0x7734B0 Offset: 0x771AB0 VA: 0x1807734B0
	public Transform FindBone(uint hash) { }

	// RVA: 0x773430 Offset: 0x771A30 VA: 0x180773430
	public uint FindBoneID(Transform transform) { }

	// RVA: 0x773710 Offset: 0x771D10 VA: 0x180773710
	public Transform[] GetBones() { }

	// RVA: 0x773570 Offset: 0x771B70 VA: 0x180773570
	public Transform FindClosestBone(Vector3 worldPos) { }

	// RVA: 0x774400 Offset: 0x772A00 VA: 0x180774400
	public LODGroup get_lodGroup() { }

	// RVA: 0x773AE0 Offset: 0x7720E0 VA: 0x180773AE0
	private void OnDisable() { }

	// RVA: 0x773FE0 Offset: 0x7725E0 VA: 0x180773FE0
	public void SyncBones(Model other) { }

	// RVA: 0x774350 Offset: 0x772950 VA: 0x180774350
	public void Trigger(string triggerName) { }

	// RVA: 0x773740 Offset: 0x771D40 VA: 0x180773740
	public static Transform GetTransform(Transform bone, Vector3 position, BaseEntity entity) { }

	// RVA: 0x7731F0 Offset: 0x7717F0 VA: 0x1807731F0
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0x773C20 Offset: 0x772220 VA: 0x180773C20 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

