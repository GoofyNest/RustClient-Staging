public class WorkbenchPanel : LootPanel, IInventoryChanged // TypeDefIndex: 11069
{	// Fields
	public Button experimentButton; // 0x38
	public Text timerText; // 0x40
	public Text costText; // 0x48
	public GameObject expermentCostParent; // 0x50
	public GameObject controlsParent; // 0x58
	public GameObject allUnlockedNotification; // 0x60
	public GameObject informationParent; // 0x68
	public GameObject cycleIcon; // 0x70
	public TechTreeDialog techTreeDialog; // 0x78
	private bool wasWorking; // 0x80

	// Methods

	// RVA: 0x8FDB10 Offset: 0x8FC110 VA: 0x1808FDB10 Slot: 5
	public override void Update() { }

	// RVA: 0x8FD970 Offset: 0x8FBF70 VA: 0x1808FD970
	private void OnEnable() { }

	// RVA: 0x8FD8B0 Offset: 0x8FBEB0 VA: 0x1808FD8B0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x8FD660 Offset: 0x8FBC60 VA: 0x1808FD660
	public void ExperimentButtonClicked() { }

	// RVA: 0x8FD750 Offset: 0x8FBD50 VA: 0x1808FD750
	public Workbench GetWorkbench() { }

	// RVA: 0x8FD4C0 Offset: 0x8FBAC0 VA: 0x1808FD4C0
	public bool CanAffordExperiment() { }

	// RVA: 0x8FDA00 Offset: 0x8FC000 VA: 0x1808FDA00
	public void Refresh() { }

	// RVA: 0x8FD9F0 Offset: 0x8FBFF0 VA: 0x1808FD9F0 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x8FD7E0 Offset: 0x8FBDE0 VA: 0x1808FD7E0
	public bool IsWorking() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

