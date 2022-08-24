public class BurstCloth : MonoBehaviour // TypeDefIndex: 7308
{	internal const int TickRateMultiplier = 60;
	internal const int MaximumTickRate = 240;
	private static readonly List<CapsuleParams> CapsuleParamsShared; // 0x0
	[HeaderAttribute] // RVA: 0x94D10 Offset: 0x94110 VA: 0x180094D10
	public Transform[] RootBones; // 0x18
	public bool SiblingConstraints; // 0x20
	public int StiffnessDepth; // 0x24
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float LengthModifier; // 0x28
	[HeaderAttribute] // RVA: 0x94EC0 Offset: 0x942C0 VA: 0x180094EC0
	public BurstClothMaterial Material; // 0x30
	public Vector3 Gravity; // 0x38
	public Transform SimulationSpace; // 0x48
	[HeaderAttribute] // RVA: 0x94FB0 Offset: 0x943B0 VA: 0x180094FB0
	public bool EnableCollisions; // 0x50
	public float CollisionRadius; // 0x54
	[BurstClothCurveRectAttribute] // RVA: 0x95080 Offset: 0x94480 VA: 0x180095080
	public AnimationCurve CollisionRadiusCurve; // 0x58
	[HeaderAttribute] // RVA: 0x95130 Offset: 0x94530 VA: 0x180095130
	public bool EnableSimulation; // 0x60
	[RangeAttribute] // RVA: 0x95220 Offset: 0x94620 VA: 0x180095220
	public int TickRate; // 0x64
	[RangeAttribute] // RVA: 0x953F0 Offset: 0x947F0 VA: 0x1800953F0
	public int MaxTicksPerFrame; // 0x68
	[SerializeField] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	[HideInInspector] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	private List<BurstCloth.Chain> _chains; // 0x70
	[SerializeField] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
	[HideInInspector] // RVA: 0x71870 Offset: 0x70C70 VA: 0x180071870
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


	protected void Initialize() { }

	protected virtual void Awake() { }

	protected virtual void OnEnable() { }

	protected virtual void OnDisable() { }

	protected internal virtual void FrameUpdate() { }

	internal JobHandle SimulateSystem() { }

	private void SetupData() { }

	private void SetupManagedData() { }

	private void SetupNativeData() { }

	protected virtual ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	protected virtual void GatherColliders(List<CapsuleParams> colliders) { }

	private static ValueTuple<Vector3, float> GetBoneLocalPositionAndLength(Transform parent, Transform child) { }

	private ValueTuple<Transform, int> GetSiblingAndIndex(int chainIndex, int depth) { }

	private void BuildBoneToIndexMap(Dictionary<Transform, int> boneToIndex) { }

	protected static CapsuleParams GetCapsuleParams(CapsuleCollider collider) { }

	protected void UpdateCachedMaterialData() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct BurstCloth.Chain // TypeDefIndex: 7309
{	public List<Transform> Transforms; // 0x0

}

private sealed class BurstCloth.<>c // TypeDefIndex: 7310
{	public static readonly BurstCloth.<>c <>9; // 0x0
	public static Func<BurstCloth.Chain, int> <>9__42_0; // 0x8
	public static Func<BurstCloth.Chain, int> <>9__42_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <SetupManagedData>b__42_0(BurstCloth.Chain c) { }

	internal int <SetupManagedData>b__42_1(BurstCloth.Chain c) { }

}

