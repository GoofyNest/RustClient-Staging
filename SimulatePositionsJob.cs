internal struct SimulatePositionsJob : IJob // TypeDefIndex: 7320
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public NativeArray<ColliderData> ColliderData; // 0x0
	[ReadOnlyAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public NativeArray<ColliderState> ColliderState; // 0x10
	[ReadOnlyAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public NativeArray<BoneData> BoneData; // 0x20
	public NativeArray<BoneState> BoneState; // 0x30
	public int TickRate; // 0x40
	public float DeltaTime; // 0x44
	public int IterationCount; // 0x48
	public float3 SimulationSpaceDelta; // 0x4C
	public float3 Gravity; // 0x58
	public int StiffnessDepth; // 0x64
	public float LengthModifier; // 0x68
	public bool SiblingConstraints; // 0x6C
	public bool EnableCollisions; // 0x6D
	public float3 Origin; // 0x70
	public quaternion Rotation; // 0x7C
	public float3 Up; // 0x8C
	public float Radius; // 0x98

	// Methods

	// RVA: 0x237F80 Offset: 0x237380 VA: 0x180237F80 Slot: 4
	public void Execute() { }

	// RVA: 0x237F40 Offset: 0x237340 VA: 0x180237F40
	private void AdjustSimulationSpace() { }

	// RVA: 0x237F90 Offset: 0x237390 VA: 0x180237F90
	private void MovePositions() { }

	// RVA: 0x237F50 Offset: 0x237350 VA: 0x180237F50
	private void ApplyPositionConstraints(NativeArray<float3> newPositions) { }

	// RVA: 0x237FE0 Offset: 0x2373E0 VA: 0x180237FE0
	private void ResolveCollisions() { }

	// RVA: 0x237F70 Offset: 0x237370 VA: 0x180237F70
	private void ApplyRotationConstraints() { }

	// RVA: 0x237FA0 Offset: 0x2373A0 VA: 0x180237FA0
	private float3 RayMarch(in float3 origin, in float3 direction, float radius, float maxDistance) { }

	// RVA: 0x237FF0 Offset: 0x2373F0 VA: 0x180237FF0
	private float Scene(in float3 position) { }

	// RVA: 0x223ED30 Offset: 0x223D330 VA: 0x18223ED30
	private static float Union(float d1, float d2) { }

	// RVA: 0x223D900 Offset: 0x223BF00 VA: 0x18223D900
	private static float Capsule(in float3 p, in float3 a, in float3 b, float r) { }

	// RVA: 0x223EBE0 Offset: 0x223D1E0 VA: 0x18223EBE0
	private static float3 Slerp(float3 a, float3 b, float t) { }

	// RVA: 0x223DBC0 Offset: 0x223C1C0 VA: 0x18223DBC0
	private static quaternion FromToRotation(float3 from, float3 to) { }

}

