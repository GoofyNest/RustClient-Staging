public class ResearchTablePanel : LootPanel // TypeDefIndex: 11049
{	// Fields
	public Button researchButton; // 0x38
	public Text timerText; // 0x40
	public GameObject itemDescNoItem; // 0x48
	public GameObject itemDescTooBroken; // 0x50
	public GameObject itemDescNotResearchable; // 0x58
	public GameObject itemDescTooMany; // 0x60
	public GameObject itemTakeBlueprint; // 0x68
	public GameObject itemDescAlreadyResearched; // 0x70
	public Text successChanceText; // 0x78
	public ItemIcon scrapIcon; // 0x80
	public bool wasResearching; // 0x88
	public GameObject[] workbenchReqs; // 0x90
	private Item _researchItem; // 0x98

	// Properties
	public Item researchItem { get; }

	// Methods

	// RVA: 0x9541A0 Offset: 0x9527A0 VA: 0x1809541A0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x954CE0 Offset: 0x9532E0 VA: 0x180954CE0 Slot: 5
	public override void Update() { }

	// RVA: 0x954740 Offset: 0x952D40 VA: 0x180954740
	public void ResearchClicked() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public Item get_researchItem() { }

	// RVA: 0x9541C0 Offset: 0x9527C0 VA: 0x1809541C0
	public bool IsResearching() { }

	// RVA: 0x9547D0 Offset: 0x952DD0 VA: 0x1809547D0
	public float ResearchTimeLeft() { }

	// RVA: 0x954290 Offset: 0x952890 VA: 0x180954290
	private void Refresh() { }

	// RVA: 0x954920 Offset: 0x952F20 VA: 0x180954920
	private void UpdateResearchProgress() { }

	// RVA: 0x954AB0 Offset: 0x9530B0 VA: 0x180954AB0
	public void UpdateWorkbenchNotifications() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

