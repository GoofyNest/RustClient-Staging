public class BurstClothHitBoxCollision : BurstCloth, IClientComponent, IPrefabPreProcess // TypeDefIndex: 8674
{	[HeaderAttribute] // RVA: 0xB9490 Offset: 0xB8890 VA: 0x1800B9490
	public float GravityStrength; // 0x130
	public float DefaultLength; // 0x134
	public float MountedLengthMultiplier; // 0x138
	public float DuckedLengthMultiplier; // 0x13C
	public float CorpseLengthMultiplier; // 0x140
	[HeaderAttribute] // RVA: 0x94FB0 Offset: 0x943B0 VA: 0x180094FB0
	public string[] IgnoreKeywords; // 0x148
	private BasePlayer _player; // 0x150
	private Ragdoll _ragdoll; // 0x158
	private HitboxSystem _hitboxSystem; // 0x160


	protected override void Awake() { }

	public void PlayerPreviewVisibility(bool isVisible) { }

	protected override void FrameUpdate() { }

	private void UpdateSimulationSpace() { }

	protected override ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	private ValueTuple<Quaternion, Vector3> GetOrientation() { }

	protected override void GatherColliders(List<CapsuleParams> colliders) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <GatherColliders>g__ShouldIgnore|15_0(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void <GatherColliders>g__Swap|15_1<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<object>
	|
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<ValueTuple<float, Vector3>>
	*/

}

