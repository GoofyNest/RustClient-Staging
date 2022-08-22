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

	// RVA: 0x9547B0 Offset: 0x952DB0 VA: 0x1809547B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x9552F0 Offset: 0x9538F0 VA: 0x1809552F0 Slot: 5
	public override void Update() { }

	// RVA: 0x954D50 Offset: 0x953350 VA: 0x180954D50
	public void ResearchClicked() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public Item get_researchItem() { }

	// RVA: 0x9547D0 Offset: 0x952DD0 VA: 0x1809547D0
	public bool IsResearching() { }

	// RVA: 0x954DE0 Offset: 0x9533E0 VA: 0x180954DE0
	public float ResearchTimeLeft() { }

	// RVA: 0x9548A0 Offset: 0x952EA0 VA: 0x1809548A0
	private void Refresh() { }

	// RVA: 0x954F30 Offset: 0x953530 VA: 0x180954F30
	private void UpdateResearchProgress() { }

	// RVA: 0x9550C0 Offset: 0x9536C0 VA: 0x1809550C0
	public void UpdateWorkbenchNotifications() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

