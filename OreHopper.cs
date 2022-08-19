public class OreHopper : PercentFullStorageContainer // TypeDefIndex: 8284
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform oreOutputMesh; // 0x3D8
	private float visualPercentFull; // 0x3E0
	private Vector3 _oreScale; // 0x3E4
	private MeshRenderer[] orePlaneRenderers; // 0x3F0
	private Nullable<int> lastSetLootTypeIndex; // 0x3F8

	// Methods

	// RVA: 0x9E6CB0 Offset: 0x9E52B0 VA: 0x1809E6CB0 Slot: 155
	protected override void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x9E7170 Offset: 0x9E5770 VA: 0x1809E7170
	private void SetVisualOreLevel(float percentFull) { }

	// RVA: 0x9E6CB0 Offset: 0x9E52B0 VA: 0x1809E6CB0
	public void VisualLerpToOreLevel() { }

	// RVA: 0x9E6D40 Offset: 0x9E5340 VA: 0x1809E6D40
	private void OreVisualLerpUpdate() { }

	// RVA: 0x9E6C20 Offset: 0x9E5220 VA: 0x1809E6C20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9E6E90 Offset: 0x9E5490 VA: 0x1809E6E90
	public void SetOreMat(int lootTypeIndex, ParticleSystem[] unloadingFX, ParticleSystem[] particleFX) { }

	// RVA: 0x9E7250 Offset: 0x9E5850 VA: 0x1809E7250
	public void .ctor() { }

}

