public class RepairBenchPanel : LootPanel // TypeDefIndex: 11048
{	// Fields
	public Text infoText; // 0x38
	public Button repairButton; // 0x40
	public Color gotColor; // 0x48
	public Color notGotColor; // 0x58
	public Translate.Phrase phraseEmpty; // 0x68
	public Translate.Phrase phraseNotRepairable; // 0x70
	public Translate.Phrase phraseRepairNotNeeded; // 0x78
	public Translate.Phrase phraseNoBlueprint; // 0x80
	public GameObject skinsPanel; // 0x88
	public GameObject changeSkinDialog; // 0x90
	public IconSkinPicker picker; // 0x98
	public GameObject attachmentSkinBlocker; // 0xA0
	private Item _displayItem; // 0xA8

	// Properties
	public Item item { get; }

	// Methods

	// RVA: 0x952980 Offset: 0x950F80 VA: 0x180952980
	public void OnEnable() { }

	// RVA: 0x952880 Offset: 0x950E80 VA: 0x180952880 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x953150 Offset: 0x951750 VA: 0x180953150 Slot: 5
	public override void Update() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public Item get_item() { }

	// RVA: 0x952EF0 Offset: 0x9514F0 VA: 0x180952EF0
	public void UpdateAvailableSkins() { }

	// RVA: 0x952DB0 Offset: 0x9513B0 VA: 0x180952DB0
	public void SkinClicked() { }

	// RVA: 0x951F70 Offset: 0x950570 VA: 0x180951F70
	private void DisableAttachmentBlock() { }

	// RVA: 0x952D20 Offset: 0x951320 VA: 0x180952D20
	public void RepairClicked() { }

	// RVA: 0x9527F0 Offset: 0x950DF0 VA: 0x1809527F0
	public bool IsItemRepairable(ItemDefinition info) { }

	// RVA: 0x951FA0 Offset: 0x9505A0 VA: 0x180951FA0
	private string GetCostText() { }

	// RVA: 0x952A30 Offset: 0x951030 VA: 0x180952A30
	private void Refresh() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void UpdateSkinPanel() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

