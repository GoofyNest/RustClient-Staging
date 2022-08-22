public class IOEntityInformationPanel : ItemInformationPanel // TypeDefIndex: 11007
{	// Fields
	public ItemTextValue requiredPowerDisplay; // 0x18
	public ItemTextValue requiredFluidDisplay; // 0x20
	public ItemTextValue generatedPowerDisplay; // 0x28
	public ItemTextValue capacityDisplay; // 0x30
	public ItemTextValue chargeDisplay; // 0x38

	// Methods

	// RVA: 0x808C90 Offset: 0x807290 VA: 0x180808C90
	public IOEntity GetIOEntityToUse(ItemDefinition info) { }

	// RVA: 0x808C10 Offset: 0x807210 VA: 0x180808C10 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x808DA0 Offset: 0x8073A0 VA: 0x180808DA0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

