public class EZSoftBone : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 7128
{	// Fields
	public const float DeltaTime_Min = 1E-06;
	public const int MaxInstanceCount = 12;
	private static float CurrentFrame; // 0x0
	private static int InstanceNumber; // 0x4
	[FormerlySerializedAsAttribute] // RVA: 0x80A50 Offset: 0x7FE50 VA: 0x180080A50
	public List<Transform> rootBones; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x80A90 Offset: 0x7FE90 VA: 0x180080A90
	public List<Transform> endBones; // 0x20
	[SerializeField] // RVA: 0x80AC0 Offset: 0x7FEC0 VA: 0x180080AC0
	[FormerlySerializedAsAttribute] // RVA: 0x80AC0 Offset: 0x7FEC0 VA: 0x180080AC0
	private EZSoftBoneMaterial _material; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x80C90 Offset: 0x80090 VA: 0x180080C90
	public int startDepth; // 0x30
	public int stiffnessDepth; // 0x34
	[FormerlySerializedAsAttribute] // RVA: 0x80CF0 Offset: 0x800F0 VA: 0x180080CF0
	public EZSoftBone.UnificationMode siblingConstraints; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0x80E70 Offset: 0x80270 VA: 0x180080E70
	public EZSoftBone.UnificationMode lengthUnification; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0x81020 Offset: 0x80420 VA: 0x180081020
	public bool siblingRotationConstraints; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x81140 Offset: 0x80540 VA: 0x180081140
	public bool closedSiblings; // 0x41
	[FormerlySerializedAsAttribute] // RVA: 0x812C0 Offset: 0x806C0 VA: 0x1800812C0
	public LayerMask collisionLayers; // 0x44
	[FormerlySerializedAsAttribute] // RVA: 0x813B0 Offset: 0x807B0 VA: 0x1800813B0
	public float radius; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0x81570 Offset: 0x80970 VA: 0x180081570
	[EZCurveRectAttribute] // RVA: 0x81570 Offset: 0x80970 VA: 0x180081570
	public AnimationCurve radiusCurve; // 0x50
	public float deadZoneRadius; // 0x58
	public float deadZoneExtent; // 0x5C
	[FormerlySerializedAsAttribute] // RVA: 0x816D0 Offset: 0x80AD0 VA: 0x1800816D0
	public EZSoftBone.DeltaTimeMode deltaTimeMode; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0x817C0 Offset: 0x80BC0 VA: 0x1800817C0
	public float constantDeltaTime; // 0x64
	[FormerlySerializedAsAttribute] // RVA: 0x81870 Offset: 0x80C70 VA: 0x180081870
	[RangeAttribute] // RVA: 0x81870 Offset: 0x80C70 VA: 0x180081870
	public int iterations; // 0x68
	[FormerlySerializedAsAttribute] // RVA: 0x81A30 Offset: 0x80E30 VA: 0x180081A30
	public float sleepThreshold; // 0x6C
	[FormerlySerializedAsAttribute] // RVA: 0x81A70 Offset: 0x80E70 VA: 0x180081A70
	public Vector3 gravity; // 0x70
	[SerializeField] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	[FormerlySerializedAsAttribute] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	private Transform _simulateSpace; // 0x80
	public float globalRadius; // 0x88
	public Vector3 globalForce; // 0x8C
	public bool collisionEnabled; // 0x98
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x2296610 Offset: 0x2294C10 VA: 0x182296610
	public EZSoftBoneMaterial get_sharedMaterial() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_sharedMaterial(EZSoftBoneMaterial value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Transform get_simulateSpace() { }

	// RVA: 0x2296750 Offset: 0x2294D50 VA: 0x182296750
	public void set_simulateSpace(Transform value) { }

	// RVA: 0x2292D70 Offset: 0x2291370 VA: 0x182292D70
	private void Awake() { }

	// RVA: 0x2294000 Offset: 0x2292600 VA: 0x182294000
	private void OnEnable() { }

	// RVA: 0x2293FF0 Offset: 0x22925F0 VA: 0x182293FF0
	private void OnDisable() { }

	// RVA: 0x2293A40 Offset: 0x2292040 VA: 0x182293A40
	private void LateUpdate() { }

	// RVA: 0x2293FF0 Offset: 0x22925F0 VA: 0x182293FF0
	public void RevertTransforms() { }

	// RVA: 0x22947C0 Offset: 0x2292DC0 VA: 0x1822947C0
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x2293240 Offset: 0x2291840 VA: 0x182293240
	public void InitStructures(bool force = False) { }

	// RVA: 0x2294970 Offset: 0x2292F70 VA: 0x182294970
	public void SetRestState() { }

	// RVA: 0x2292F50 Offset: 0x2291550 VA: 0x182292F50
	private void CreateBones() { }

	// RVA: 0x2294880 Offset: 0x2292E80 VA: 0x182294880
	private void SetParentBones() { }

	// RVA: 0x2294A20 Offset: 0x2293020 VA: 0x182294A20
	private void SetSiblings() { }

	// RVA: 0x2294E50 Offset: 0x2293450 VA: 0x182294E50
	private void SetTreeLength() { }

	// RVA: 0x22945B0 Offset: 0x2292BB0 VA: 0x1822945B0
	public void RefreshRadius() { }

	// RVA: 0x2295FF0 Offset: 0x22945F0 VA: 0x182295FF0
	private void UpdateStructures(float deltaTime) { }

	// RVA: 0x2295190 Offset: 0x2293790 VA: 0x182295190
	private void UpdateBones(EZSoftBone.Bone bone, float deltaTime) { }

	// RVA: 0x22964A0 Offset: 0x2294AA0 VA: 0x1822964A0
	private void UpdateTransforms() { }

	// RVA: 0x2295EA0 Offset: 0x22944A0 VA: 0x182295EA0
	private void UpdateSimulationSpace(Transform transform) { }

	// RVA: 0x22941A0 Offset: 0x22927A0 VA: 0x1822941A0
	public void PushBonesOutOfDeadZone() { }

	// RVA: 0x2294180 Offset: 0x2292780 VA: 0x182294180
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x2294190 Offset: 0x2292790 VA: 0x182294190 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2296580 Offset: 0x2294B80 VA: 0x182296580
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2295160 Offset: 0x2293760 VA: 0x182295160
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

	// RVA: 0x228DC20 Offset: 0x228C220 VA: 0x18228DC20
	public void .ctor(Transform origin, Transform systemSpace, Transform transform, List<Transform> endBones, int startDepth) { }

	// RVA: 0x228DB80 Offset: 0x228C180 VA: 0x18228DB80
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

	// RVA: 0x228ECB0 Offset: 0x228D2B0 VA: 0x18228ECB0
	public void .ctor(Transform systemSpace, Transform transform, int depth, float boneLength) { }

	// RVA: 0x228E610 Offset: 0x228CC10 VA: 0x18228E610
	public void SetTreeLength() { }

	// RVA: 0x228E640 Offset: 0x228CC40 VA: 0x18228E640
	public void SetTreeLength(float treeLength) { }

	// RVA: 0x228E250 Offset: 0x228C850 VA: 0x18228E250
	public void SetLeftSibling(EZSoftBone.Bone left) { }

	// RVA: 0x228E4D0 Offset: 0x228CAD0 VA: 0x18228E4D0
	public void SetRightSibling(EZSoftBone.Bone right) { }

	// RVA: 0x228E190 Offset: 0x228C790 VA: 0x18228E190
	public void Inflate(float baseRadius, AnimationCurve radiusCurve) { }

	// RVA: 0x228E070 Offset: 0x228C670 VA: 0x18228E070
	public void Inflate(float baseRadius, AnimationCurve radiusCurve, EZSoftBoneMaterial material) { }

	// RVA: 0x228E1E0 Offset: 0x228C7E0 VA: 0x18228E1E0
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x228E6D0 Offset: 0x228CCD0 VA: 0x18228E6D0
	public void UpdateTransform(bool siblingRotationConstraints, int startDepth) { }

	// RVA: 0x228E390 Offset: 0x228C990 VA: 0x18228E390
	public void SetRestState() { }

	// RVA: 0x228E670 Offset: 0x228CC70 VA: 0x18228E670
	public void UpdateSpace() { }

}

private sealed class EZSoftBone.<>c // TypeDefIndex: 7133
{	// Fields
	public static readonly EZSoftBone.<>c <>9; // 0x0
	public static Func<EZSoftBone.BoneChain, int> <>9__55_0; // 0x8

	// Methods

	// RVA: 0x2296820 Offset: 0x2294E20 VA: 0x182296820
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2296800 Offset: 0x2294E00 VA: 0x182296800
	internal int <SetSiblings>b__55_0(EZSoftBone.BoneChain c) { }

}

