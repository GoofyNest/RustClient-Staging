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

	// RVA: 0x9542B0 Offset: 0x9528B0 VA: 0x1809542B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x954DF0 Offset: 0x9533F0 VA: 0x180954DF0 Slot: 5
	public override void Update() { }

	// RVA: 0x954850 Offset: 0x952E50 VA: 0x180954850
	public void ResearchClicked() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public Item get_researchItem() { }

	// RVA: 0x9542D0 Offset: 0x9528D0 VA: 0x1809542D0
	public bool IsResearching() { }

	// RVA: 0x9548E0 Offset: 0x952EE0 VA: 0x1809548E0
	public float ResearchTimeLeft() { }

	// RVA: 0x9543A0 Offset: 0x9529A0 VA: 0x1809543A0
	private void Refresh() { }

	// RVA: 0x954A30 Offset: 0x953030 VA: 0x180954A30
	private void UpdateResearchProgress() { }

	// RVA: 0x954BC0 Offset: 0x9531C0 VA: 0x180954BC0
	public void UpdateWorkbenchNotifications() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

