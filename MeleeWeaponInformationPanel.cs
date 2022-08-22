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

	// RVA: 0x95DB90 Offset: 0x95C190 VA: 0x18095DB90 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x95DC80 Offset: 0x95C280 VA: 0x18095DC80 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

