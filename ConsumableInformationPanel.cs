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

	// RVA: 0x6B6860 Offset: 0x6B4E60 VA: 0x1806B6860 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x6B6A10 Offset: 0x6B5010 VA: 0x1806B6A10
	private void GetValues() { }

	// RVA: 0x6B6A80 Offset: 0x6B5080 VA: 0x1806B6A80 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x6B73E0 Offset: 0x6B59E0 VA: 0x1806B73E0
	private void SetupGenes(Item item) { }

	// RVA: 0x6B7460 Offset: 0x6B5A60 VA: 0x1806B7460
	public void .ctor() { }

}

