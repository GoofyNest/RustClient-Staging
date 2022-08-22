public class EZSoftBone : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 7128
{	// Fields
	public const float DeltaTime_Min = 1E-06;
	public const int MaxInstanceCount = 12;
	private static float CurrentFrame; // 0x0
	private static int InstanceNumber; // 0x4
	[FormerlySerializedAsAttribute] // RVA: 0x80B10 Offset: 0x7FF10 VA: 0x180080B10
	public List<Transform> rootBones; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x80B50 Offset: 0x7FF50 VA: 0x180080B50
	public List<Transform> endBones; // 0x20
	[SerializeField] // RVA: 0x80B80 Offset: 0x7FF80 VA: 0x180080B80
	[FormerlySerializedAsAttribute] // RVA: 0x80B80 Offset: 0x7FF80 VA: 0x180080B80
	private EZSoftBoneMaterial _material; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x80D50 Offset: 0x80150 VA: 0x180080D50
	public int startDepth; // 0x30
	public int stiffnessDepth; // 0x34
	[FormerlySerializedAsAttribute] // RVA: 0x80D80 Offset: 0x80180 VA: 0x180080D80
	public EZSoftBone.UnificationMode siblingConstraints; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0x80F30 Offset: 0x80330 VA: 0x180080F30
	public EZSoftBone.UnificationMode lengthUnification; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0x810E0 Offset: 0x804E0 VA: 0x1800810E0
	public bool siblingRotationConstraints; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x81200 Offset: 0x80600 VA: 0x180081200
	public bool closedSiblings; // 0x41
	[FormerlySerializedAsAttribute] // RVA: 0x813B0 Offset: 0x807B0 VA: 0x1800813B0
	public LayerMask collisionLayers; // 0x44
	[FormerlySerializedAsAttribute] // RVA: 0x814A0 Offset: 0x808A0 VA: 0x1800814A0
	public float radius; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0x81630 Offset: 0x80A30 VA: 0x180081630
	[EZCurveRectAttribute] // RVA: 0x81630 Offset: 0x80A30 VA: 0x180081630
	public AnimationCurve radiusCurve; // 0x50
	public float deadZoneRadius; // 0x58
	public float deadZoneExtent; // 0x5C
	[FormerlySerializedAsAttribute] // RVA: 0x81750 Offset: 0x80B50 VA: 0x180081750
	public EZSoftBone.DeltaTimeMode deltaTimeMode; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0x81850 Offset: 0x80C50 VA: 0x180081850
	public float constantDeltaTime; // 0x64
	[FormerlySerializedAsAttribute] // RVA: 0x818F0 Offset: 0x80CF0 VA: 0x1800818F0
	[RangeAttribute] // RVA: 0x818F0 Offset: 0x80CF0 VA: 0x1800818F0
	public int iterations; // 0x68
	[FormerlySerializedAsAttribute] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public float sleepThreshold; // 0x6C
	[FormerlySerializedAsAttribute] // RVA: 0x81B20 Offset: 0x80F20 VA: 0x180081B20
	public Vector3 gravity; // 0x70
	[SerializeField] // RVA: 0x81B50 Offset: 0x80F50 VA: 0x180081B50
	[FormerlySerializedAsAttribute] // RVA: 0x81B50 Offset: 0x80F50 VA: 0x180081B50
	private Transform _simulateSpace; // 0x80
	public float globalRadius; // 0x88
	public Vector3 globalForce; // 0x8C
	public bool collisionEnabled; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EZSoftBone.BoneChain[] structures; // 0xA0
	private Vector3 origin; // 0xA8
	private Vector3 prevOrigin; // 0xB4
	private Vector3 originDelta; // 0xC0
	private bool simulationSpaceChanged; // 0xCC
	private Capsule deadZoneCapsule; // 0xD0
	private bool isVisible; // 0xE4
	private Vector3 forceDirection; // 0xE8

	// Properties
	public EZSoftBoneMaterial sharedMaterial { get; set; }
	public Transform simulateSpace { get; set; }

	// Methods

	// RVA: 0x2296450 Offset: 0x2294A50 VA: 0x182296450
	public EZSoftBoneMaterial get_sharedMaterial() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_sharedMaterial(EZSoftBoneMaterial value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Transform get_simulateSpace() { }

	// RVA: 0x2296590 Offset: 0x2294B90 VA: 0x182296590
	public void set_simulateSpace(Transform value) { }

	// RVA: 0x2292BB0 Offset: 0x22911B0 VA: 0x182292BB0
	private void Awake() { }

	// RVA: 0x2293E40 Offset: 0x2292440 VA: 0x182293E40
	private void OnEnable() { }

	// RVA: 0x2293E30 Offset: 0x2292430 VA: 0x182293E30
	private void OnDisable() { }

	// RVA: 0x2293880 Offset: 0x2291E80 VA: 0x182293880
	private void LateUpdate() { }

	// RVA: 0x2293E30 Offset: 0x2292430 VA: 0x182293E30
	public void RevertTransforms() { }

	// RVA: 0x2294600 Offset: 0x2292C00 VA: 0x182294600
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x2293080 Offset: 0x2291680 VA: 0x182293080
	public void InitStructures(bool force = False) { }

	// RVA: 0x22947B0 Offset: 0x2292DB0 VA: 0x1822947B0
	public void SetRestState() { }

	// RVA: 0x2292D90 Offset: 0x2291390 VA: 0x182292D90
	private void CreateBones() { }

	// RVA: 0x22946C0 Offset: 0x2292CC0 VA: 0x1822946C0
	private void SetParentBones() { }

	// RVA: 0x2294860 Offset: 0x2292E60 VA: 0x182294860
	private void SetSiblings() { }

	// RVA: 0x2294C90 Offset: 0x2293290 VA: 0x182294C90
	private void SetTreeLength() { }

	// RVA: 0x22943F0 Offset: 0x22929F0 VA: 0x1822943F0
	public void RefreshRadius() { }

	// RVA: 0x2295E30 Offset: 0x2294430 VA: 0x182295E30
	private void UpdateStructures(float deltaTime) { }

	// RVA: 0x2294FD0 Offset: 0x22935D0 VA: 0x182294FD0
	private void UpdateBones(EZSoftBone.Bone bone, float deltaTime) { }

	// RVA: 0x22962E0 Offset: 0x22948E0 VA: 0x1822962E0
	private void UpdateTransforms() { }

	// RVA: 0x2295CE0 Offset: 0x22942E0 VA: 0x182295CE0
	private void UpdateSimulationSpace(Transform transform) { }

	// RVA: 0x2293FE0 Offset: 0x22925E0 VA: 0x182293FE0
	public void PushBonesOutOfDeadZone() { }

	// RVA: 0x2293FC0 Offset: 0x22925C0 VA: 0x182293FC0
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x2293FD0 Offset: 0x22925D0 VA: 0x182293FD0 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x22963C0 Offset: 0x22949C0 VA: 0x1822963C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2294FA0 Offset: 0x22935A0 VA: 0x182294FA0
	internal static bool <SetSiblings>g__HasBoneAtDepth|55_1(EZSoftBone.BoneChain chain, int depth) { }

}

public enum EZSoftBone.UnificationMode // TypeDefIndex: 7129
{	// Fields
	public int value__; // 0x0
	public const EZSoftBone.UnificationMode None = 0;
	public const EZSoftBone.UnificationMode Rooted = 1;
	public const EZSoftBone.UnificationMode Unified = 2;

}

public enum EZSoftBone.DeltaTimeMode // TypeDefIndex: 7130
{	// Fields
	public int value__; // 0x0
	public const EZSoftBone.DeltaTimeMode DeltaTime = 0;
	public const EZSoftBone.DeltaTimeMode SmoothDeltaTime = 1;
	public const EZSoftBone.DeltaTimeMode UnscaledDeltaTime = 2;
	public const EZSoftBone.DeltaTimeMode Constant = 3;

}

private class EZSoftBone.BoneChain // TypeDefIndex: 7131
{	// Fields
	public EZSoftBone.Bone[] childBones; // 0x10

	// Methods

	// RVA: 0x228DA60 Offset: 0x228C060 VA: 0x18228DA60
	public void .ctor(Transform origin, Transform systemSpace, Transform transform, List<Transform> endBones, int startDepth) { }

	// RVA: 0x228D9C0 Offset: 0x228BFC0 VA: 0x18228D9C0
	public void InitializeParents() { }

}

private class EZSoftBone.Bone // TypeDefIndex: 7132
{	// Fields
	public EZSoftBone.Bone parentBone; // 0x10
	public Vector3 localPosition; // 0x18
	public Quaternion localRotation; // 0x24
	public EZSoftBone.Bone childBone; // 0x38
	public EZSoftBone.Bone leftBone; // 0x40
	public Vector3 leftPosition; // 0x48
	public EZSoftBone.Bone rightBone; // 0x58
	public Vector3 rightPosition; // 0x60
	public Transform transform; // 0x70
	public Vector3 worldPosition; // 0x78
	public Transform systemSpace; // 0x88
	public Vector3 systemPosition; // 0x90
	public int depth; // 0x9C
	public float boneLength; // 0xA0
	public float treeLength; // 0xA4
	public float normalizedLength; // 0xA8
	public float length; // 0xAC
	public float lengthToLeft; // 0xB0
	public float lengthToRight; // 0xB4
	public float radius; // 0xB8
	public float damping; // 0xBC
	public float stiffness; // 0xC0
	public float resistance; // 0xC4
	public float slackness; // 0xC8
	public Vector3 speed; // 0xCC

	// Methods

	// RVA: 0x228EAF0 Offset: 0x228D0F0 VA: 0x18228EAF0
	public void .ctor(Transform systemSpace, Transform transform, int depth, float boneLength) { }

	// RVA: 0x228E450 Offset: 0x228CA50 VA: 0x18228E450
	public void SetTreeLength() { }

	// RVA: 0x228E480 Offset: 0x228CA80 VA: 0x18228E480
	public void SetTreeLength(float treeLength) { }

	// RVA: 0x228E090 Offset: 0x228C690 VA: 0x18228E090
	public void SetLeftSibling(EZSoftBone.Bone left) { }

	// RVA: 0x228E310 Offset: 0x228C910 VA: 0x18228E310
	public void SetRightSibling(EZSoftBone.Bone right) { }

	// RVA: 0x228DFD0 Offset: 0x228C5D0 VA: 0x18228DFD0
	public void Inflate(float baseRadius, AnimationCurve radiusCurve) { }

	// RVA: 0x228DEB0 Offset: 0x228C4B0 VA: 0x18228DEB0
	public void Inflate(float baseRadius, AnimationCurve radiusCurve, EZSoftBoneMaterial material) { }

	// RVA: 0x228E020 Offset: 0x228C620 VA: 0x18228E020
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x228E510 Offset: 0x228CB10 VA: 0x18228E510
	public void UpdateTransform(bool siblingRotationConstraints, int startDepth) { }

	// RVA: 0x228E1D0 Offset: 0x228C7D0 VA: 0x18228E1D0
	public void SetRestState() { }

	// RVA: 0x228E4B0 Offset: 0x228CAB0 VA: 0x18228E4B0
	public void UpdateSpace() { }

}

private sealed class EZSoftBone.<>c // TypeDefIndex: 7133
{	// Fields
	public static readonly EZSoftBone.<>c <>9; // 0x0
	public static Func<EZSoftBone.BoneChain, int> <>9__55_0; // 0x8

	// Methods

	// RVA: 0x2296660 Offset: 0x2294C60 VA: 0x182296660
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2296640 Offset: 0x2294C40 VA: 0x182296640
	internal int <SetSiblings>b__55_0(EZSoftBone.BoneChain c) { }

}

