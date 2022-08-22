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

	// RVA: 0x4AA560 Offset: 0x4A8B60 VA: 0x1804AA560
	public static void UpdateBlueprint(ItemBlueprint blueprint) { }

	// RVA: 0x4A9C00 Offset: 0x4A8200 VA: 0x1804A9C00
	public static void RefreshFavouriteDisplay() { }

	// RVA: 0x4AAC60 Offset: 0x4A9260 VA: 0x1804AAC60
	public static bool get_isOpen() { }

	// RVA: 0x4AA300 Offset: 0x4A8900 VA: 0x1804AA300
	private void Start() { }

	// RVA: 0x4A9510 Offset: 0x4A7B10 VA: 0x1804A9510
	private void OnEnable() { }

	// RVA: 0x4A9460 Offset: 0x4A7A60 VA: 0x1804A9460
	private void OnDisable() { }

	// RVA: 0x4A9150 Offset: 0x4A7750 VA: 0x1804A9150
	public void ChangeEffects() { }

	// RVA: 0x4A95B0 Offset: 0x4A7BB0 VA: 0x1804A95B0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x4A95C0 Offset: 0x4A7BC0 VA: 0x1804A95C0
	private void RefreshBlueprint() { }

	// RVA: 0x4A92F0 Offset: 0x4A78F0 VA: 0x1804A92F0
	public void Max() { }

	// RVA: 0x4A9DA0 Offset: 0x4A83A0 VA: 0x1804A9DA0
	public void StartCrafting() { }

	// RVA: 0x4A8FF0 Offset: 0x4A75F0 VA: 0x1804A8FF0
	public void AddToCraft(int i) { }

	// RVA: 0x4A9C70 Offset: 0x4A8270 VA: 0x1804A9C70
	public void SetCraftFromTextbox(string i) { }

	// RVA: 0x4A9CB0 Offset: 0x4A82B0 VA: 0x1804A9CB0
	public void SetCraft(int i) { }

	// RVA: 0x4AA900 Offset: 0x4A8F00 VA: 0x1804AA900
	public void UpdateIngredients() { }

	// RVA: 0x4AAB40 Offset: 0x4A9140 VA: 0x1804AAB40
	private void Update() { }

	// RVA: 0x4A9090 Offset: 0x4A7690 VA: 0x1804A9090
	public bool CanCraft() { }

	// RVA: 0x4A9000 Offset: 0x4A7600 VA: 0x1804A9000
	public bool CanCraftAmount(int amount) { }

	// RVA: 0x4AA410 Offset: 0x4A8A10 VA: 0x1804AA410
	public void Unlock() { }

	// RVA: 0x4AA350 Offset: 0x4A8950 VA: 0x1804AA350
	public void ToggleFavourite() { }

	// RVA: 0x4A9B00 Offset: 0x4A8100 VA: 0x1804A9B00
	private void RefreshFavouriteButton() { }

	// RVA: 0x4AAC00 Offset: 0x4A9200 VA: 0x1804AAC00
	public void .ctor() { }

}

private sealed class SelectedBlueprint.<>c__DisplayClass30_0 // TypeDefIndex: 10994
{	// Fields
	public int inventoryId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3B30 Offset: 0x4B2130 VA: 0x1804B3B30
	internal bool <StartCrafting>b__0(ItemSkinDirectory.Skin x) { }

	// RVA: 0x4B3B40 Offset: 0x4B2140 VA: 0x1804B3B40
	internal bool <StartCrafting>b__1(IPlayerItemDefinition x) { }

}

