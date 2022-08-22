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

	// RVA: 0x2296710 Offset: 0x2294D10 VA: 0x182296710
	public EZSoftBoneMaterial get_sharedMaterial() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_sharedMaterial(EZSoftBoneMaterial value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Transform get_simulateSpace() { }

	// RVA: 0x2296850 Offset: 0x2294E50 VA: 0x182296850
	public void set_simulateSpace(Transform value) { }

	// RVA: 0x2292E70 Offset: 0x2291470 VA: 0x182292E70
	private void Awake() { }

	// RVA: 0x2294100 Offset: 0x2292700 VA: 0x182294100
	private void OnEnable() { }

	// RVA: 0x22940F0 Offset: 0x22926F0 VA: 0x1822940F0
	private void OnDisable() { }

	// RVA: 0x2293B40 Offset: 0x2292140 VA: 0x182293B40
	private void LateUpdate() { }

	// RVA: 0x22940F0 Offset: 0x22926F0 VA: 0x1822940F0
	public void RevertTransforms() { }

	// RVA: 0x22948C0 Offset: 0x2292EC0 VA: 0x1822948C0
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x2293340 Offset: 0x2291940 VA: 0x182293340
	public void InitStructures(bool force = False) { }

	// RVA: 0x2294A70 Offset: 0x2293070 VA: 0x182294A70
	public void SetRestState() { }

	// RVA: 0x2293050 Offset: 0x2291650 VA: 0x182293050
	private void CreateBones() { }

	// RVA: 0x2294980 Offset: 0x2292F80 VA: 0x182294980
	private void SetParentBones() { }

	// RVA: 0x2294B20 Offset: 0x2293120 VA: 0x182294B20
	private void SetSiblings() { }

	// RVA: 0x2294F50 Offset: 0x2293550 VA: 0x182294F50
	private void SetTreeLength() { }

	// RVA: 0x22946B0 Offset: 0x2292CB0 VA: 0x1822946B0
	public void RefreshRadius() { }

	// RVA: 0x22960F0 Offset: 0x22946F0 VA: 0x1822960F0
	private void UpdateStructures(float deltaTime) { }

	// RVA: 0x2295290 Offset: 0x2293890 VA: 0x182295290
	private void UpdateBones(EZSoftBone.Bone bone, float deltaTime) { }

	// RVA: 0x22965A0 Offset: 0x2294BA0 VA: 0x1822965A0
	private void UpdateTransforms() { }

	// RVA: 0x2295FA0 Offset: 0x22945A0 VA: 0x182295FA0
	private void UpdateSimulationSpace(Transform transform) { }

	// RVA: 0x22942A0 Offset: 0x22928A0 VA: 0x1822942A0
	public void PushBonesOutOfDeadZone() { }

	// RVA: 0x2294280 Offset: 0x2292880 VA: 0x182294280
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x2294290 Offset: 0x2292890 VA: 0x182294290 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2296680 Offset: 0x2294C80 VA: 0x182296680
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2295260 Offset: 0x2293860 VA: 0x182295260
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

	// RVA: 0x228DD20 Offset: 0x228C320 VA: 0x18228DD20
	public void .ctor(Transform origin, Transform systemSpace, Transform transform, List<Transform> endBones, int startDepth) { }

	// RVA: 0x228DC80 Offset: 0x228C280 VA: 0x18228DC80
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

	// RVA: 0x228EDB0 Offset: 0x228D3B0 VA: 0x18228EDB0
	public void .ctor(Transform systemSpace, Transform transform, int depth, float boneLength) { }

	// RVA: 0x228E710 Offset: 0x228CD10 VA: 0x18228E710
	public void SetTreeLength() { }

	// RVA: 0x228E740 Offset: 0x228CD40 VA: 0x18228E740
	public void SetTreeLength(float treeLength) { }

	// RVA: 0x228E350 Offset: 0x228C950 VA: 0x18228E350
	public void SetLeftSibling(EZSoftBone.Bone left) { }

	// RVA: 0x228E5D0 Offset: 0x228CBD0 VA: 0x18228E5D0
	public void SetRightSibling(EZSoftBone.Bone right) { }

	// RVA: 0x228E290 Offset: 0x228C890 VA: 0x18228E290
	public void Inflate(float baseRadius, AnimationCurve radiusCurve) { }

	// RVA: 0x228E170 Offset: 0x228C770 VA: 0x18228E170
	public void Inflate(float baseRadius, AnimationCurve radiusCurve, EZSoftBoneMaterial material) { }

	// RVA: 0x228E2E0 Offset: 0x228C8E0 VA: 0x18228E2E0
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x228E7D0 Offset: 0x228CDD0 VA: 0x18228E7D0
	public void UpdateTransform(bool siblingRotationConstraints, int startDepth) { }

	// RVA: 0x228E490 Offset: 0x228CA90 VA: 0x18228E490
	public void SetRestState() { }

	// RVA: 0x228E770 Offset: 0x228CD70 VA: 0x18228E770
	public void UpdateSpace() { }

}

private sealed class EZSoftBone.<>c // TypeDefIndex: 7133
{	// Fields
	public static readonly EZSoftBone.<>c <>9; // 0x0
	public static Func<EZSoftBone.BoneChain, int> <>9__55_0; // 0x8

	// Methods

	// RVA: 0x2296920 Offset: 0x2294F20 VA: 0x182296920
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2296900 Offset: 0x2294F00 VA: 0x182296900
	internal int <SetSiblings>b__55_0(EZSoftBone.BoneChain c) { }

}

