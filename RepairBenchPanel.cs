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

	// RVA: 0x952470 Offset: 0x950A70 VA: 0x180952470
	public void OnEnable() { }

	// RVA: 0x952370 Offset: 0x950970 VA: 0x180952370 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x952C40 Offset: 0x951240 VA: 0x180952C40 Slot: 5
	public override void Update() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public Item get_item() { }

	// RVA: 0x9529E0 Offset: 0x950FE0 VA: 0x1809529E0
	public void UpdateAvailableSkins() { }

	// RVA: 0x9528A0 Offset: 0x950EA0 VA: 0x1809528A0
	public void SkinClicked() { }

	// RVA: 0x951A60 Offset: 0x950060 VA: 0x180951A60
	private void DisableAttachmentBlock() { }

	// RVA: 0x952810 Offset: 0x950E10 VA: 0x180952810
	public void RepairClicked() { }

	// RVA: 0x9522E0 Offset: 0x9508E0 VA: 0x1809522E0
	public bool IsItemRepairable(ItemDefinition info) { }

	// RVA: 0x951A90 Offset: 0x950090 VA: 0x180951A90
	private string GetCostText() { }

	// RVA: 0x952520 Offset: 0x950B20 VA: 0x180952520
	private void Refresh() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void UpdateSkinPanel() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

