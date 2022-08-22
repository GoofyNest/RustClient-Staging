public class OreHopper : PercentFullStorageContainer // TypeDefIndex: 8284
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform oreOutputMesh; // 0x3D8
	private float visualPercentFull; // 0x3E0
	private Vector3 _oreScale; // 0x3E4
	private MeshRenderer[] orePlaneRenderers; // 0x3F0
	private Nullable<int> lastSetLootTypeIndex; // 0x3F8

	// Methods

	// RVA: 0x9E7460 Offset: 0x9E5A60 VA: 0x1809E7460 Slot: 155
	protected override void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x9E7920 Offset: 0x9E5F20 VA: 0x1809E7920
	private void SetVisualOreLevel(float percentFull) { }

	// RVA: 0x9E7460 Offset: 0x9E5A60 VA: 0x1809E7460
	public void VisualLerpToOreLevel() { }

	// RVA: 0x9E74F0 Offset: 0x9E5AF0 VA: 0x1809E74F0
	private void OreVisualLerpUpdate() { }

	// RVA: 0x9E73D0 Offset: 0x9E59D0 VA: 0x1809E73D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9E7640 Offset: 0x9E5C40 VA: 0x1809E7640
	public void SetOreMat(int lootTypeIndex, ParticleSystem[] unloadingFX, ParticleSystem[] particleFX) { }

	// RVA: 0x9E7A00 Offset: 0x9E6000 VA: 0x1809E7A00
	public void .ctor() { }

}

