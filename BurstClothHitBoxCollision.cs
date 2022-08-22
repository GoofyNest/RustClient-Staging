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

	// RVA: 0x6F0710 Offset: 0x6EED10 VA: 0x1806F0710 Slot: 4
	protected override void Awake() { }

	// RVA: 0x6F18C0 Offset: 0x6EFEC0 VA: 0x1806F18C0
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x6F07F0 Offset: 0x6EEDF0 VA: 0x1806F07F0 Slot: 7
	protected override void FrameUpdate() { }

	// RVA: 0x6F19B0 Offset: 0x6EFFB0 VA: 0x1806F19B0
	private void UpdateSimulationSpace() { }

	// RVA: 0x6F17C0 Offset: 0x6EFDC0 VA: 0x1806F17C0 Slot: 8
	protected override ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x6F1420 Offset: 0x6EFA20 VA: 0x1806F1420
	private ValueTuple<Quaternion, Vector3> GetOrientation() { }

	// RVA: 0x6F0AD0 Offset: 0x6EF0D0 VA: 0x1806F0AD0 Slot: 9
	protected override void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x6F18D0 Offset: 0x6EFED0 VA: 0x1806F18D0 Slot: 10
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6F1AD0 Offset: 0x6F00D0 VA: 0x1806F1AD0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F18E0 Offset: 0x6EFEE0 VA: 0x1806F18E0
	private bool <GatherColliders>g__ShouldIgnore|15_0(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static void <GatherColliders>g__Swap|15_1<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570E80 Offset: 0x56F480 VA: 0x180570E80
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<object>
	|
	|-RVA: 0x15707E0 Offset: 0x156EDE0 VA: 0x1815707E0
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<ValueTuple<float, Vector3>>
	*/

}

