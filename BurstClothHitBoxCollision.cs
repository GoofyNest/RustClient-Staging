public class BurstClothHitBoxCollision : BurstCloth, IClientComponent, IPrefabPreProcess // TypeDefIndex: 8674
{	// Fields
	[HeaderAttribute] // RVA: 0xB9300 Offset: 0xB8700 VA: 0x1800B9300
	public float GravityStrength; // 0x130
	public float DefaultLength; // 0x134
	public float MountedLengthMultiplier; // 0x138
	public float DuckedLengthMultiplier; // 0x13C
	public float CorpseLengthMultiplier; // 0x140
	[HeaderAttribute] // RVA: 0x94E70 Offset: 0x94270 VA: 0x180094E70
	public string[] IgnoreKeywords; // 0x148
	private BasePlayer _player; // 0x150
	private Ragdoll _ragdoll; // 0x158
	private HitboxSystem _hitboxSystem; // 0x160

	// Methods

	// RVA: 0x6F0670 Offset: 0x6EEC70 VA: 0x1806F0670 Slot: 4
	protected override void Awake() { }

	// RVA: 0x6F1820 Offset: 0x6EFE20 VA: 0x1806F1820
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x6F0750 Offset: 0x6EED50 VA: 0x1806F0750 Slot: 7
	protected override void FrameUpdate() { }

	// RVA: 0x6F1910 Offset: 0x6EFF10 VA: 0x1806F1910
	private void UpdateSimulationSpace() { }

	// RVA: 0x6F1720 Offset: 0x6EFD20 VA: 0x1806F1720 Slot: 8
	protected override ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x6F1380 Offset: 0x6EF980 VA: 0x1806F1380
	private ValueTuple<Quaternion, Vector3> GetOrientation() { }

	// RVA: 0x6F0A30 Offset: 0x6EF030 VA: 0x1806F0A30 Slot: 9
	protected override void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x6F1830 Offset: 0x6EFE30 VA: 0x1806F1830 Slot: 10
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6F1A30 Offset: 0x6F0030 VA: 0x1806F1A30
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F1840 Offset: 0x6EFE40 VA: 0x1806F1840
	private bool <GatherColliders>g__ShouldIgnore|15_0(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static void <GatherColliders>g__Swap|15_1<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570EF0 Offset: 0x56F4F0 VA: 0x180570EF0
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<object>
	|
	|-RVA: 0x1571450 Offset: 0x156FA50 VA: 0x181571450
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<ValueTuple<float, Vector3>>
	*/

}

