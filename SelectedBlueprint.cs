public class SelectedBlueprint : SingletonComponent<SelectedBlueprint>, IInventoryChanged // TypeDefIndex: 10993
{	// Fields
	public ItemBlueprint blueprint; // 0x18
	public InputField craftAmountText; // 0x20
	public GameObject ingredientGrid; // 0x28
	public IconSkinPicker skinPicker; // 0x30
	public Image iconImage; // 0x38
	public RustText titleText; // 0x40
	public RustText descriptionText; // 0x48
	public CanvasGroup CraftArea; // 0x50
	public Button CraftButton; // 0x58
	public RustText CraftingTime; // 0x60
	public RustText CraftingAmount; // 0x68
	public Sprite FavouriteOnSprite; // 0x70
	public Sprite FavouriteOffSprite; // 0x78
	public Image FavouriteButtonStatusMarker; // 0x80
	public GameObject[] workbenchReqs; // 0x88
	private ItemInformationPanel[] informationPanels; // 0x90
	private bool needsRefresh; // 0x98
	private int craftAmount; // 0x9C
	private BlueprintCraftGridRow[] ingredientRows; // 0xA0

	// Properties
	public static bool isOpen { get; }

	// Methods

	// RVA: 0x4AA5D0 Offset: 0x4A8BD0 VA: 0x1804AA5D0
	public static void UpdateBlueprint(ItemBlueprint blueprint) { }

	// RVA: 0x4A9C70 Offset: 0x4A8270 VA: 0x1804A9C70
	public static void RefreshFavouriteDisplay() { }

	// RVA: 0x4AACD0 Offset: 0x4A92D0 VA: 0x1804AACD0
	public static bool get_isOpen() { }

	// RVA: 0x4AA370 Offset: 0x4A8970 VA: 0x1804AA370
	private void Start() { }

	// RVA: 0x4A9580 Offset: 0x4A7B80 VA: 0x1804A9580
	private void OnEnable() { }

	// RVA: 0x4A94D0 Offset: 0x4A7AD0 VA: 0x1804A94D0
	private void OnDisable() { }

	// RVA: 0x4A91C0 Offset: 0x4A77C0 VA: 0x1804A91C0
	public void ChangeEffects() { }

	// RVA: 0x4A9620 Offset: 0x4A7C20 VA: 0x1804A9620 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x4A9630 Offset: 0x4A7C30 VA: 0x1804A9630
	private void RefreshBlueprint() { }

	// RVA: 0x4A9360 Offset: 0x4A7960 VA: 0x1804A9360
	public void Max() { }

	// RVA: 0x4A9E10 Offset: 0x4A8410 VA: 0x1804A9E10
	public void StartCrafting() { }

	// RVA: 0x4A9060 Offset: 0x4A7660 VA: 0x1804A9060
	public void AddToCraft(int i) { }

	// RVA: 0x4A9CE0 Offset: 0x4A82E0 VA: 0x1804A9CE0
	public void SetCraftFromTextbox(string i) { }

	// RVA: 0x4A9D20 Offset: 0x4A8320 VA: 0x1804A9D20
	public void SetCraft(int i) { }

	// RVA: 0x4AA970 Offset: 0x4A8F70 VA: 0x1804AA970
	public void UpdateIngredients() { }

	// RVA: 0x4AABB0 Offset: 0x4A91B0 VA: 0x1804AABB0
	private void Update() { }

	// RVA: 0x4A9100 Offset: 0x4A7700 VA: 0x1804A9100
	public bool CanCraft() { }

	// RVA: 0x4A9070 Offset: 0x4A7670 VA: 0x1804A9070
	public bool CanCraftAmount(int amount) { }

	// RVA: 0x4AA480 Offset: 0x4A8A80 VA: 0x1804AA480
	public void Unlock() { }

	// RVA: 0x4AA3C0 Offset: 0x4A89C0 VA: 0x1804AA3C0
	public void ToggleFavourite() { }

	// RVA: 0x4A9B70 Offset: 0x4A8170 VA: 0x1804A9B70
	private void RefreshFavouriteButton() { }

	// RVA: 0x4AAC70 Offset: 0x4A9270 VA: 0x1804AAC70
	public void .ctor() { }

}

private sealed class SelectedBlueprint.<>c__DisplayClass30_0 // TypeDefIndex: 10994
{	// Fields
	public int inventoryId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3BA0 Offset: 0x4B21A0 VA: 0x1804B3BA0
	internal bool <StartCrafting>b__0(ItemSkinDirectory.Skin x) { }

	// RVA: 0x4B3BB0 Offset: 0x4B21B0 VA: 0x1804B3BB0
	internal bool <StartCrafting>b__1(IPlayerItemDefinition x) { }

}

