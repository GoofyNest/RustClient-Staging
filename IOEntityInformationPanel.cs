public class IOEntityInformationPanel : ItemInformationPanel // TypeDefIndex: 11007
{	// Fields
	public ItemTextValue requiredPowerDisplay; // 0x18
	public ItemTextValue requiredFluidDisplay; // 0x20
	public ItemTextValue generatedPowerDisplay; // 0x28
	public ItemTextValue capacityDisplay; // 0x30
	public ItemTextValue chargeDisplay; // 0x38

	// Methods

	// RVA: 0x8085F0 Offset: 0x806BF0 VA: 0x1808085F0
	public IOEntity GetIOEntityToUse(ItemDefinition info) { }

	// RVA: 0x808570 Offset: 0x806B70 VA: 0x180808570 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x808700 Offset: 0x806D00 VA: 0x180808700 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

