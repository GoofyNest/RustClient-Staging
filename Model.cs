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

	// RVA: 0x773C70 Offset: 0x772270 VA: 0x180773C70
	protected void OnEnable() { }

	// RVA: 0x7733E0 Offset: 0x7719E0 VA: 0x1807733E0
	public void BuildBoneDictionary() { }

	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int GetSkin() { }

	// RVA: 0x7734D0 Offset: 0x771AD0 VA: 0x1807734D0
	private Transform FindBoneInternal(string name) { }

	// RVA: 0x773560 Offset: 0x771B60 VA: 0x180773560
	public Transform FindBone(string name) { }

	// RVA: 0x773510 Offset: 0x771B10 VA: 0x180773510
	public Transform FindBone(uint hash) { }

	// RVA: 0x773490 Offset: 0x771A90 VA: 0x180773490
	public uint FindBoneID(Transform transform) { }

	// RVA: 0x773770 Offset: 0x771D70 VA: 0x180773770
	public Transform[] GetBones() { }

	// RVA: 0x7735D0 Offset: 0x771BD0 VA: 0x1807735D0
	public Transform FindClosestBone(Vector3 worldPos) { }

	// RVA: 0x774460 Offset: 0x772A60 VA: 0x180774460
	public LODGroup get_lodGroup() { }

	// RVA: 0x773B40 Offset: 0x772140 VA: 0x180773B40
	private void OnDisable() { }

	// RVA: 0x774040 Offset: 0x772640 VA: 0x180774040
	public void SyncBones(Model other) { }

	// RVA: 0x7743B0 Offset: 0x7729B0 VA: 0x1807743B0
	public void Trigger(string triggerName) { }

	// RVA: 0x7737A0 Offset: 0x771DA0 VA: 0x1807737A0
	public static Transform GetTransform(Transform bone, Vector3 position, BaseEntity entity) { }

	// RVA: 0x773250 Offset: 0x771850 VA: 0x180773250
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0x773C80 Offset: 0x772280 VA: 0x180773C80 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

