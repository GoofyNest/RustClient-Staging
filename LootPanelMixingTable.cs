public class LootPanelMixingTable : LootPanel, IInventoryChanged // TypeDefIndex: 11034
{	// Fields
	public GameObject controlsOn; // 0x38
	public GameObject controlsOff; // 0x40
	public Button StartMixingButton; // 0x48
	public InfoBar ProgressBar; // 0x50
	public GameObject recipeItemPrefab; // 0x58
	public RectTransform recipeContentRect; // 0x60
	private List<Item> inventoryItems; // 0x68

	// Methods

	// RVA: 0x508B00 Offset: 0x507100 VA: 0x180508B00
	private void OnEnable() { }

	// RVA: 0x508A40 Offset: 0x507040 VA: 0x180508A40 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x508E00 Offset: 0x507400 VA: 0x180508E00
	public void SetupRecipeBook() { }

	// RVA: 0x5088B0 Offset: 0x506EB0 VA: 0x1805088B0
	private void DestroyRecipeItems() { }

	// RVA: 0x5092C0 Offset: 0x5078C0 VA: 0x1805092C0 Slot: 5
	public override void Update() { }

	// RVA: 0x508B90 Offset: 0x507190 VA: 0x180508B90 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x508BA0 Offset: 0x5071A0 VA: 0x180508BA0
	private void RefreshRecipeValidity() { }

	// RVA: 0x508980 Offset: 0x506F80 VA: 0x180508980
	public MixingTable GetMixingTable() { }

	// RVA: 0x508A10 Offset: 0x507010 VA: 0x180508A10
	public bool IsOn() { }

	// RVA: 0x509150 Offset: 0x507750 VA: 0x180509150
	public void Switch(bool onOff) { }

	// RVA: 0x5094D0 Offset: 0x507AD0 VA: 0x1805094D0
	public void .ctor() { }

}

