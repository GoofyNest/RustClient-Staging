public class SeedInformationPanel : ItemInformationPanel // TypeDefIndex: 11050
{	// Fields
	public ItemTextValue maxHarvestsDisplay; // 0x18
	public UIGenesDisplay GeneticsDisplay; // 0x20
	public Text TextUnknownGenetics; // 0x28
	public GameObject GeneticsGameObject; // 0x30
	public ItemStatValue WaterResilience; // 0x38
	public ItemStatValue GroundResilience; // 0x40
	public ItemStatValue LightResilience; // 0x48
	public ItemStatValue TemperatureResilience; // 0x50
	private GrowableGenes genes; // 0x58

	// Methods

	// RVA: 0x4A81C0 Offset: 0x4A67C0 VA: 0x1804A81C0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x4A82B0 Offset: 0x4A68B0 VA: 0x1804A82B0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4A85D0 Offset: 0x4A6BD0 VA: 0x1804A85D0
	public void .ctor() { }

}

