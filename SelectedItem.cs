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

	// RVA: 0x4ACC00 Offset: 0x4AB200 VA: 0x1804ACC00
	public static void UpdateItem() { }

	// RVA: 0x4ACEE0 Offset: 0x4AB4E0 VA: 0x1804ACEE0
	public static Item get_item() { }

	// RVA: 0x4AC9D0 Offset: 0x4AAFD0 VA: 0x1804AC9D0
	private void Start() { }

	// RVA: 0x4AC100 Offset: 0x4AA700 VA: 0x1804AC100
	private void OnEnable() { }

	// RVA: 0x4AC050 Offset: 0x4AA650 VA: 0x1804AC050
	private void OnDisable() { }

	// RVA: 0x4ABD40 Offset: 0x4AA340 VA: 0x1804ABD40
	public bool NeedsOptionsUpdate(List<Option> oldOpts, List<Option> newOpts, Item item) { }

	// RVA: 0x4AC1F0 Offset: 0x4AA7F0 VA: 0x1804AC1F0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x4AC220 Offset: 0x4AA820 VA: 0x1804AC220
	private void RefreshItem(Item item) { }

	// RVA: 0x4ABAB0 Offset: 0x4AA0B0 VA: 0x1804ABAB0
	public static List<Option> ItemMenuOptions(Item item) { }

	// RVA: 0x4ACCE0 Offset: 0x4AB2E0 VA: 0x1804ACCE0
	public void Update() { }

	// RVA: 0x4ACAD0 Offset: 0x4AB0D0 VA: 0x1804ACAD0
	public static void TrySelect(ItemIcon newSelect, bool silent = False) { }

	// RVA: 0x4AB970 Offset: 0x4A9F70 VA: 0x1804AB970
	public static void ClearIfSelected(ItemIcon newSelect) { }

	// RVA: 0x4AB9F0 Offset: 0x4A9FF0 VA: 0x1804AB9F0
	public static void ClearSelection() { }

	// RVA: 0x4AC8D0 Offset: 0x4AAED0 VA: 0x1804AC8D0
	internal static void SetHovered(ItemIcon item) { }

	// RVA: 0x4ACE80 Offset: 0x4AB480 VA: 0x1804ACE80
	public void .ctor() { }

}

