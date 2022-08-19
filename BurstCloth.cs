public class BurstCloth : MonoBehaviour // TypeDefIndex: 7308
{	// Fields
	internal const int TickRateMultiplier = 60;
	internal const int MaximumTickRate = 240;
	private static readonly List<CapsuleParams> CapsuleParamsShared; // 0x0
	[HeaderAttribute] // RVA: 0x94B90 Offset: 0x93F90 VA: 0x180094B90
	public Transform[] RootBones; // 0x18
	public bool SiblingConstraints; // 0x20
	public int StiffnessDepth; // 0x24
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float LengthModifier; // 0x28
	[HeaderAttribute] // RVA: 0x94D40 Offset: 0x94140 VA: 0x180094D40
	public BurstClothMaterial Material; // 0x30
	public Vector3 Gravity; // 0x38
	public Transform SimulationSpace; // 0x48
	[HeaderAttribute] // RVA: 0x94DF0 Offset: 0x941F0 VA: 0x180094DF0
	public bool EnableCollisions; // 0x50
	public float CollisionRadius; // 0x54
	[BurstClothCurveRectAttribute] // RVA: 0x94E50 Offset: 0x94250 VA: 0x180094E50
	public AnimationCurve CollisionRadiusCurve; // 0x58
	[HeaderAttribute] // RVA: 0x94EC0 Offset: 0x942C0 VA: 0x180094EC0
	public bool EnableSimulation; // 0x60
	[RangeAttribute] // RVA: 0x95030 Offset: 0x94430 VA: 0x180095030
	public int TickRate; // 0x64
	[RangeAttribute] // RVA: 0x95130 Offset: 0x94530 VA: 0x180095130
	public int MaxTicksPerFrame; // 0x68
	[SerializeField] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[HideInInspector] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	private List<BurstCloth.Chain> _chains; // 0x70
	[SerializeField] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[HideInInspector] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
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

	// RVA: 0x2239E80 Offset: 0x2238480 VA: 0x182239E80
	protected void Initialize() { }

	// RVA: 0x6F1830 Offset: 0x6EFE30 VA: 0x1806F1830 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x223AA20 Offset: 0x2239020 VA: 0x18223AA20 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x223A8B0 Offset: 0x2238EB0 VA: 0x18223A8B0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2239610 Offset: 0x2237C10 VA: 0x182239610 Slot: 7
	protected internal virtual void FrameUpdate() { }

	// RVA: 0x223B8B0 Offset: 0x2239EB0 VA: 0x18223B8B0
	internal JobHandle SimulateSystem() { }

	// RVA: 0x223AA80 Offset: 0x2239080 VA: 0x18223AA80
	private void SetupData() { }

	// RVA: 0x223AAA0 Offset: 0x22390A0 VA: 0x18223AAA0
	private void SetupManagedData() { }

	// RVA: 0x223ACD0 Offset: 0x22392D0 VA: 0x18223ACD0
	private void SetupNativeData() { }

	// RVA: 0x2239C50 Offset: 0x2238250 VA: 0x182239C50 Slot: 8
	protected virtual ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x2239860 Offset: 0x2237E60 VA: 0x182239860
	private static ValueTuple<Vector3, float> GetBoneLocalPositionAndLength(Transform parent, Transform child) { }

	// RVA: 0x2239D90 Offset: 0x2238390 VA: 0x182239D90
	private ValueTuple<Transform, int> GetSiblingAndIndex(int chainIndex, int depth) { }

	// RVA: 0x22393D0 Offset: 0x22379D0 VA: 0x1822393D0
	private void BuildBoneToIndexMap(Dictionary<Transform, int> boneToIndex) { }

	// RVA: 0x22399F0 Offset: 0x2237FF0 VA: 0x1822399F0
	protected static CapsuleParams GetCapsuleParams(CapsuleCollider collider) { }

	// RVA: 0x223BD10 Offset: 0x223A310 VA: 0x18223BD10
	protected void UpdateCachedMaterialData() { }

	// RVA: 0x223C250 Offset: 0x223A850 VA: 0x18223C250
	public void .ctor() { }

	// RVA: 0x223C1E0 Offset: 0x223A7E0 VA: 0x18223C1E0
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

	// RVA: 0x223EE00 Offset: 0x223D400 VA: 0x18223EE00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x223ED80 Offset: 0x223D380 VA: 0x18223ED80
	internal int <SetupManagedData>b__42_0(BurstCloth.Chain c) { }

	// RVA: 0x223EDC0 Offset: 0x223D3C0 VA: 0x18223EDC0
	internal int <SetupManagedData>b__42_1(BurstCloth.Chain c) { }

}

