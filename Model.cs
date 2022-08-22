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

	// RVA: 0x773D20 Offset: 0x772320 VA: 0x180773D20
	protected void OnEnable() { }

	// RVA: 0x773490 Offset: 0x771A90 VA: 0x180773490
	public void BuildBoneDictionary() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int GetSkin() { }

	// RVA: 0x773580 Offset: 0x771B80 VA: 0x180773580
	private Transform FindBoneInternal(string name) { }

	// RVA: 0x773610 Offset: 0x771C10 VA: 0x180773610
	public Transform FindBone(string name) { }

	// RVA: 0x7735C0 Offset: 0x771BC0 VA: 0x1807735C0
	public Transform FindBone(uint hash) { }

	// RVA: 0x773540 Offset: 0x771B40 VA: 0x180773540
	public uint FindBoneID(Transform transform) { }

	// RVA: 0x773820 Offset: 0x771E20 VA: 0x180773820
	public Transform[] GetBones() { }

	// RVA: 0x773680 Offset: 0x771C80 VA: 0x180773680
	public Transform FindClosestBone(Vector3 worldPos) { }

	// RVA: 0x774510 Offset: 0x772B10 VA: 0x180774510
	public LODGroup get_lodGroup() { }

	// RVA: 0x773BF0 Offset: 0x7721F0 VA: 0x180773BF0
	private void OnDisable() { }

	// RVA: 0x7740F0 Offset: 0x7726F0 VA: 0x1807740F0
	public void SyncBones(Model other) { }

	// RVA: 0x774460 Offset: 0x772A60 VA: 0x180774460
	public void Trigger(string triggerName) { }

	// RVA: 0x773850 Offset: 0x771E50 VA: 0x180773850
	public static Transform GetTransform(Transform bone, Vector3 position, BaseEntity entity) { }

	// RVA: 0x773300 Offset: 0x771900 VA: 0x180773300
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0x773D30 Offset: 0x772330 VA: 0x180773D30 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

