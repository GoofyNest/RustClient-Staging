public class ExplosiveInformationPanel : ItemInformationPanel // TypeDefIndex: 11003
{	// Fields
	public ItemTextValue explosiveDmgDisplay; // 0x18
	public ItemTextValue lethalDmgDisplay; // 0x20
	public ItemTextValue throwDistanceDisplay; // 0x28
	public ItemTextValue projectileDistanceDisplay; // 0x30
	public ItemTextValue fuseLengthDisplay; // 0x38
	public ItemTextValue blastRadiusDisplay; // 0x40
	public Text unreliableText; // 0x48

	// Methods

	// RVA: 0x8D32C0 Offset: 0x8D18C0 VA: 0x1808D32C0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8D3540 Offset: 0x8D1B40 VA: 0x1808D3540 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

