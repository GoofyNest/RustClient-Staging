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

	// RVA: 0x952360 Offset: 0x950960 VA: 0x180952360
	public void OnEnable() { }

	// RVA: 0x952260 Offset: 0x950860 VA: 0x180952260 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x952B30 Offset: 0x951130 VA: 0x180952B30 Slot: 5
	public override void Update() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public Item get_item() { }

	// RVA: 0x9528D0 Offset: 0x950ED0 VA: 0x1809528D0
	public void UpdateAvailableSkins() { }

	// RVA: 0x952790 Offset: 0x950D90 VA: 0x180952790
	public void SkinClicked() { }

	// RVA: 0x951950 Offset: 0x94FF50 VA: 0x180951950
	private void DisableAttachmentBlock() { }

	// RVA: 0x952700 Offset: 0x950D00 VA: 0x180952700
	public void RepairClicked() { }

	// RVA: 0x9521D0 Offset: 0x9507D0 VA: 0x1809521D0
	public bool IsItemRepairable(ItemDefinition info) { }

	// RVA: 0x951980 Offset: 0x94FF80 VA: 0x180951980
	private string GetCostText() { }

	// RVA: 0x952410 Offset: 0x950A10 VA: 0x180952410
	private void Refresh() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void UpdateSkinPanel() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

