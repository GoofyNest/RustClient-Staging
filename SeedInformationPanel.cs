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

	// RVA: 0x4A8150 Offset: 0x4A6750 VA: 0x1804A8150 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x4A8240 Offset: 0x4A6840 VA: 0x1804A8240 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4A8560 Offset: 0x4A6B60 VA: 0x1804A8560
	public void .ctor() { }

}

