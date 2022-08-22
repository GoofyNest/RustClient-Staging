public class OreHopper : PercentFullStorageContainer // TypeDefIndex: 8284
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform oreOutputMesh; // 0x3D8
	private float visualPercentFull; // 0x3E0
	private Vector3 _oreScale; // 0x3E4
	private MeshRenderer[] orePlaneRenderers; // 0x3F0
	private Nullable<int> lastSetLootTypeIndex; // 0x3F8

	// Methods

	// RVA: 0x9E6F70 Offset: 0x9E5570 VA: 0x1809E6F70 Slot: 155
	protected override void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x9E7430 Offset: 0x9E5A30 VA: 0x1809E7430
	private void SetVisualOreLevel(float percentFull) { }

	// RVA: 0x9E6F70 Offset: 0x9E5570 VA: 0x1809E6F70
	public void VisualLerpToOreLevel() { }

	// RVA: 0x9E7000 Offset: 0x9E5600 VA: 0x1809E7000
	private void OreVisualLerpUpdate() { }

	// RVA: 0x9E6EE0 Offset: 0x9E54E0 VA: 0x1809E6EE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9E7150 Offset: 0x9E5750 VA: 0x1809E7150
	public void SetOreMat(int lootTypeIndex, ParticleSystem[] unloadingFX, ParticleSystem[] particleFX) { }

	// RVA: 0x9E7510 Offset: 0x9E5B10 VA: 0x1809E7510
	public void .ctor() { }

}

