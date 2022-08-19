public class SelectedItem : SingletonComponent<SelectedItem>, IInventoryChanged // TypeDefIndex: 11051
{	// Fields
	public Image icon; // 0x18
	public Image iconSplitter; // 0x20
	public RustText title; // 0x28
	public RustText description; // 0x30
	public GameObject splitPanel; // 0x38
	public GameObject itemProtection; // 0x40
	public GameObject menuOption; // 0x48
	public GameObject optionsParent; // 0x50
	public GameObject innerPanelContainer; // 0x58
	private Animator animator; // 0x60
	private ProtectionValue[] protectionValues; // 0x68
	private ItemInformationPanel[] informationPanels; // 0x70
	private List<Option> previousOptions; // 0x78
	private Item lastItem; // 0x80
	internal bool wasOpen; // 0x88
	public static ItemIcon selectedItem; // 0x0
	public static ItemIcon hoveredItem; // 0x8

	// Properties
	public static Item item { get; }

	// Methods

	// RVA: 0x4ACC70 Offset: 0x4AB270 VA: 0x1804ACC70
	public static void UpdateItem() { }

	// RVA: 0x4ACF50 Offset: 0x4AB550 VA: 0x1804ACF50
	public static Item get_item() { }

	// RVA: 0x4ACA40 Offset: 0x4AB040 VA: 0x1804ACA40
	private void Start() { }

	// RVA: 0x4AC170 Offset: 0x4AA770 VA: 0x1804AC170
	private void OnEnable() { }

	// RVA: 0x4AC0C0 Offset: 0x4AA6C0 VA: 0x1804AC0C0
	private void OnDisable() { }

	// RVA: 0x4ABDB0 Offset: 0x4AA3B0 VA: 0x1804ABDB0
	public bool NeedsOptionsUpdate(List<Option> oldOpts, List<Option> newOpts, Item item) { }

	// RVA: 0x4AC260 Offset: 0x4AA860 VA: 0x1804AC260 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x4AC290 Offset: 0x4AA890 VA: 0x1804AC290
	private void RefreshItem(Item item) { }

	// RVA: 0x4ABB20 Offset: 0x4AA120 VA: 0x1804ABB20
	public static List<Option> ItemMenuOptions(Item item) { }

	// RVA: 0x4ACD50 Offset: 0x4AB350 VA: 0x1804ACD50
	public void Update() { }

	// RVA: 0x4ACB40 Offset: 0x4AB140 VA: 0x1804ACB40
	public static void TrySelect(ItemIcon newSelect, bool silent = False) { }

	// RVA: 0x4AB9E0 Offset: 0x4A9FE0 VA: 0x1804AB9E0
	public static void ClearIfSelected(ItemIcon newSelect) { }

	// RVA: 0x4ABA60 Offset: 0x4AA060 VA: 0x1804ABA60
	public static void ClearSelection() { }

	// RVA: 0x4AC940 Offset: 0x4AAF40 VA: 0x1804AC940
	internal static void SetHovered(ItemIcon item) { }

	// RVA: 0x4ACEF0 Offset: 0x4AB4F0 VA: 0x1804ACEF0
	public void .ctor() { }

}

