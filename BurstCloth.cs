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

	// RVA: 0x223A7A0 Offset: 0x2238DA0 VA: 0x18223A7A0
	protected void Initialize() { }

	// RVA: 0x6F18D0 Offset: 0x6EFED0 VA: 0x1806F18D0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x223B340 Offset: 0x2239940 VA: 0x18223B340 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x223B1D0 Offset: 0x22397D0 VA: 0x18223B1D0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2239F30 Offset: 0x2238530 VA: 0x182239F30 Slot: 7
	protected internal virtual void FrameUpdate() { }

	// RVA: 0x223C1D0 Offset: 0x223A7D0 VA: 0x18223C1D0
	internal JobHandle SimulateSystem() { }

	// RVA: 0x223B3A0 Offset: 0x22399A0 VA: 0x18223B3A0
	private void SetupData() { }

	// RVA: 0x223B3C0 Offset: 0x22399C0 VA: 0x18223B3C0
	private void SetupManagedData() { }

	// RVA: 0x223B5F0 Offset: 0x2239BF0 VA: 0x18223B5F0
	private void SetupNativeData() { }

	// RVA: 0x223A570 Offset: 0x2238B70 VA: 0x18223A570 Slot: 8
	protected virtual ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x223A180 Offset: 0x2238780 VA: 0x18223A180
	private static ValueTuple<Vector3, float> GetBoneLocalPositionAndLength(Transform parent, Transform child) { }

	// RVA: 0x223A6B0 Offset: 0x2238CB0 VA: 0x18223A6B0
	private ValueTuple<Transform, int> GetSiblingAndIndex(int chainIndex, int depth) { }

	// RVA: 0x2239CF0 Offset: 0x22382F0 VA: 0x182239CF0
	private void BuildBoneToIndexMap(Dictionary<Transform, int> boneToIndex) { }

	// RVA: 0x223A310 Offset: 0x2238910 VA: 0x18223A310
	protected static CapsuleParams GetCapsuleParams(CapsuleCollider collider) { }

	// RVA: 0x223C630 Offset: 0x223AC30 VA: 0x18223C630
	protected void UpdateCachedMaterialData() { }

	// RVA: 0x223CB70 Offset: 0x223B170 VA: 0x18223CB70
	public void .ctor() { }

	// RVA: 0x223CB00 Offset: 0x223B100 VA: 0x18223CB00
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

	// RVA: 0x223F720 Offset: 0x223DD20 VA: 0x18223F720
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x223F6A0 Offset: 0x223DCA0 VA: 0x18223F6A0
	internal int <SetupManagedData>b__42_0(BurstCloth.Chain c) { }

	// RVA: 0x223F6E0 Offset: 0x223DCE0 VA: 0x18223F6E0
	internal int <SetupManagedData>b__42_1(BurstCloth.Chain c) { }

}

