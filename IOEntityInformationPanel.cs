public class IOEntityInformationPanel : ItemInformationPanel // TypeDefIndex: 11007
{	// Fields
	public ItemTextValue requiredPowerDisplay; // 0x18
	public ItemTextValue requiredFluidDisplay; // 0x20
	public ItemTextValue generatedPowerDisplay; // 0x28
	public ItemTextValue capacityDisplay; // 0x30
	public ItemTextValue chargeDisplay; // 0x38

	// Methods

	// RVA: 0x808700 Offset: 0x806D00 VA: 0x180808700
	public IOEntity GetIOEntityToUse(ItemDefinition info) { }

	// RVA: 0x808680 Offset: 0x806C80 VA: 0x180808680 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x808810 Offset: 0x806E10 VA: 0x180808810 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

