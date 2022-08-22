public class BurstCloth : MonoBehaviour // TypeDefIndex: 7308
{	// Fields
	internal const int TickRateMultiplier = 60;
	internal const int MaximumTickRate = 240;
	private static readonly List<CapsuleParams> CapsuleParamsShared; // 0x0
	[HeaderAttribute] // RVA: 0x94BD0 Offset: 0x93FD0 VA: 0x180094BD0
	public Transform[] RootBones; // 0x18
	public bool SiblingConstraints; // 0x20
	public int StiffnessDepth; // 0x24
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float LengthModifier; // 0x28
	[HeaderAttribute] // RVA: 0x94E10 Offset: 0x94210 VA: 0x180094E10
	public BurstClothMaterial Material; // 0x30
	public Vector3 Gravity; // 0x38
	public Transform SimulationSpace; // 0x48
	[HeaderAttribute] // RVA: 0x94E70 Offset: 0x94270 VA: 0x180094E70
	public bool EnableCollisions; // 0x50
	public float CollisionRadius; // 0x54
	[BurstClothCurveRectAttribute] // RVA: 0x94F00 Offset: 0x94300 VA: 0x180094F00
	public AnimationCurve CollisionRadiusCurve; // 0x58
	[HeaderAttribute] // RVA: 0x94F70 Offset: 0x94370 VA: 0x180094F70
	public bool EnableSimulation; // 0x60
	[RangeAttribute] // RVA: 0x950B0 Offset: 0x944B0 VA: 0x1800950B0
	public int TickRate; // 0x64
	[RangeAttribute] // RVA: 0x95240 Offset: 0x94640 VA: 0x180095240
	public int MaxTicksPerFrame; // 0x68
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private List<BurstCloth.Chain> _chains; // 0x70
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private List<BoneData> _boneDataOriginal; // 0x78
	private Vector3 _origin; // 0x80
	private Quaternion _rotation; // 0x8C
	private Vector3 _up; // 0x9C
	private Vector3 _simulationSpaceDelta; // 0xA8
	private Transform _prevSimulationSpace; // 0xB8
	private Vector3 _prevSimulationOrigin; // 0xC0
	private float _accumulator; // 0xCC
	private int _boneCount; // 0xD0
	private int _maxBoneDepth; // 0xD4
	private Dictionary<Transform, int> _boneToIndex; // 0xD8
	private TransformAccessArray _boneTransforms; // 0xE0
	private NativeArray<BoneData> _boneData; // 0xE8
	private NativeArray<BoneState> _boneState; // 0xF8
	private TransformAccessArray _colliderTransforms; // 0x108
	private NativeArray<ColliderData> _colliderData; // 0x110
	private NativeArray<ColliderState> _colliderState; // 0x120

	// Methods

	// RVA: 0x2239CC0 Offset: 0x22382C0 VA: 0x182239CC0
	protected void Initialize() { }

	// RVA: 0x6F1830 Offset: 0x6EFE30 VA: 0x1806F1830 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x223A860 Offset: 0x2238E60 VA: 0x18223A860 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x223A6F0 Offset: 0x2238CF0 VA: 0x18223A6F0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2239450 Offset: 0x2237A50 VA: 0x182239450 Slot: 7
	protected internal virtual void FrameUpdate() { }

	// RVA: 0x223B6F0 Offset: 0x2239CF0 VA: 0x18223B6F0
	internal JobHandle SimulateSystem() { }

	// RVA: 0x223A8C0 Offset: 0x2238EC0 VA: 0x18223A8C0
	private void SetupData() { }

	// RVA: 0x223A8E0 Offset: 0x2238EE0 VA: 0x18223A8E0
	private void SetupManagedData() { }

	// RVA: 0x223AB10 Offset: 0x2239110 VA: 0x18223AB10
	private void SetupNativeData() { }

	// RVA: 0x2239A90 Offset: 0x2238090 VA: 0x182239A90 Slot: 8
	protected virtual ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x22396A0 Offset: 0x2237CA0 VA: 0x1822396A0
	private static ValueTuple<Vector3, float> GetBoneLocalPositionAndLength(Transform parent, Transform child) { }

	// RVA: 0x2239BD0 Offset: 0x22381D0 VA: 0x182239BD0
	private ValueTuple<Transform, int> GetSiblingAndIndex(int chainIndex, int depth) { }

	// RVA: 0x2239210 Offset: 0x2237810 VA: 0x182239210
	private void BuildBoneToIndexMap(Dictionary<Transform, int> boneToIndex) { }

	// RVA: 0x2239830 Offset: 0x2237E30 VA: 0x182239830
	protected static CapsuleParams GetCapsuleParams(CapsuleCollider collider) { }

	// RVA: 0x223BB50 Offset: 0x223A150 VA: 0x18223BB50
	protected void UpdateCachedMaterialData() { }

	// RVA: 0x223C090 Offset: 0x223A690 VA: 0x18223C090
	public void .ctor() { }

	// RVA: 0x223C020 Offset: 0x223A620 VA: 0x18223C020
	private static void .cctor() { }

}

private struct BurstCloth.Chain // TypeDefIndex: 7309
{	// Fields
	public List<Transform> Transforms; // 0x0

}

private sealed class BurstCloth.<>c // TypeDefIndex: 7310
{	// Fields
	public static readonly BurstCloth.<>c <>9; // 0x0
	public static Func<BurstCloth.Chain, int> <>9__42_0; // 0x8
	public static Func<BurstCloth.Chain, int> <>9__42_1; // 0x10

	// Methods

	// RVA: 0x223EC40 Offset: 0x223D240 VA: 0x18223EC40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x223EBC0 Offset: 0x223D1C0 VA: 0x18223EBC0
	internal int <SetupManagedData>b__42_0(BurstCloth.Chain c) { }

	// RVA: 0x223EC00 Offset: 0x223D200 VA: 0x18223EC00
	internal int <SetupManagedData>b__42_1(BurstCloth.Chain c) { }

}

