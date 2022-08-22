internal struct SimulatePositionsJob : IJob // TypeDefIndex: 7320
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public NativeArray<ColliderData> ColliderData; // 0x0
	[ReadOnlyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public NativeArray<ColliderState> ColliderState; // 0x10
	[ReadOnlyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x237F00 Offset: 0x237300 VA: 0x180237F00 Slot: 4
	public void Execute() { }

	// RVA: 0x237EC0 Offset: 0x2372C0 VA: 0x180237EC0
	private void AdjustSimulationSpace() { }

	// RVA: 0x237F10 Offset: 0x237310 VA: 0x180237F10
	private void MovePositions() { }

	// RVA: 0x237ED0 Offset: 0x2372D0 VA: 0x180237ED0
	private void ApplyPositionConstraints(NativeArray<float3> newPositions) { }

	// RVA: 0x237F60 Offset: 0x237360 VA: 0x180237F60
	private void ResolveCollisions() { }

	// RVA: 0x237EF0 Offset: 0x2372F0 VA: 0x180237EF0
	private void ApplyRotationConstraints() { }

	// RVA: 0x237F20 Offset: 0x237320 VA: 0x180237F20
	private float3 RayMarch(in float3 origin, in float3 direction, float radius, float maxDistance) { }

	// RVA: 0x237F70 Offset: 0x237370 VA: 0x180237F70
	private float Scene(in float3 position) { }

	// RVA: 0x223EE30 Offset: 0x223D430 VA: 0x18223EE30
	private static float Union(float d1, float d2) { }

	// RVA: 0x223DA00 Offset: 0x223C000 VA: 0x18223DA00
	private static float Capsule(in float3 p, in float3 a, in float3 b, float r) { }

	// RVA: 0x223ECE0 Offset: 0x223D2E0 VA: 0x18223ECE0
	private static float3 Slerp(float3 a, float3 b, float t) { }

	// RVA: 0x223DCC0 Offset: 0x223C2C0 VA: 0x18223DCC0
	private static quaternion FromToRotation(float3 from, float3 to) { }

}

