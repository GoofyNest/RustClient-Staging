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

	// RVA: 0x6B6750 Offset: 0x6B4D50 VA: 0x1806B6750 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x6B6900 Offset: 0x6B4F00 VA: 0x1806B6900
	private void GetValues() { }

	// RVA: 0x6B6970 Offset: 0x6B4F70 VA: 0x1806B6970 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x6B72D0 Offset: 0x6B58D0 VA: 0x1806B72D0
	private void SetupGenes(Item item) { }

	// RVA: 0x6B7350 Offset: 0x6B5950 VA: 0x1806B7350
	public void .ctor() { }

}

