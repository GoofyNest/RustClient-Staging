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

	// RVA: 0x508B70 Offset: 0x507170 VA: 0x180508B70
	private void OnEnable() { }

	// RVA: 0x508AB0 Offset: 0x5070B0 VA: 0x180508AB0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x508E70 Offset: 0x507470 VA: 0x180508E70
	public void SetupRecipeBook() { }

	// RVA: 0x508920 Offset: 0x506F20 VA: 0x180508920
	private void DestroyRecipeItems() { }

	// RVA: 0x509330 Offset: 0x507930 VA: 0x180509330 Slot: 5
	public override void Update() { }

	// RVA: 0x508C00 Offset: 0x507200 VA: 0x180508C00 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x508C10 Offset: 0x507210 VA: 0x180508C10
	private void RefreshRecipeValidity() { }

	// RVA: 0x5089F0 Offset: 0x506FF0 VA: 0x1805089F0
	public MixingTable GetMixingTable() { }

	// RVA: 0x508A80 Offset: 0x507080 VA: 0x180508A80
	public bool IsOn() { }

	// RVA: 0x5091C0 Offset: 0x5077C0 VA: 0x1805091C0
	public void Switch(bool onOff) { }

	// RVA: 0x509540 Offset: 0x507B40 VA: 0x180509540
	public void .ctor() { }

}

