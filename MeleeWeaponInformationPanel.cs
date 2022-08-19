public class MeleeWeaponInformationPanel : ItemInformationPanel // TypeDefIndex: 11040
{	// Fields
	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue attackRateDisplay; // 0x20
	public ItemStatValue attackSizeDisplay; // 0x28
	public ItemStatValue attackRangeDisplay; // 0x30
	public ItemStatValue oreGatherDisplay; // 0x38
	public ItemStatValue treeGatherDisplay; // 0x40
	public ItemStatValue fleshGatherDisplay; // 0x48

	// Methods

	// RVA: 0x95D580 Offset: 0x95BB80 VA: 0x18095D580 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x95D670 Offset: 0x95BC70 VA: 0x18095D670 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

