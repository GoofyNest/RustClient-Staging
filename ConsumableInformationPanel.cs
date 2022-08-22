public class ConsumableInformationPanel : ItemInformationPanel // TypeDefIndex: 10999
{	// Fields
	public ItemTextValue[] values; // 0x18
	public UIGenesDisplay Genes; // 0x20
	public Text TextUnknownGenetics; // 0x28
	public Text LabelGenetics; // 0x30
	public GameObject GeneticsGameObject; // 0x38
	public ItemTextValue durationValue; // 0x40
	public ItemTextValue baitValue; // 0x48
	private GrowableGenes genes; // 0x50

	// Methods

	// RVA: 0x6B67F0 Offset: 0x6B4DF0 VA: 0x1806B67F0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x6B69A0 Offset: 0x6B4FA0 VA: 0x1806B69A0
	private void GetValues() { }

	// RVA: 0x6B6A10 Offset: 0x6B5010 VA: 0x1806B6A10 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x6B7370 Offset: 0x6B5970 VA: 0x1806B7370
	private void SetupGenes(Item item) { }

	// RVA: 0x6B73F0 Offset: 0x6B59F0 VA: 0x1806B73F0
	public void .ctor() { }

}

