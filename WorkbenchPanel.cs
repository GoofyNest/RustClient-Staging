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

	// RVA: 0x8FDC20 Offset: 0x8FC220 VA: 0x1808FDC20 Slot: 5
	public override void Update() { }

	// RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	private void OnEnable() { }

	// RVA: 0x8FD9C0 Offset: 0x8FBFC0 VA: 0x1808FD9C0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x8FD770 Offset: 0x8FBD70 VA: 0x1808FD770
	public void ExperimentButtonClicked() { }

	// RVA: 0x8FD860 Offset: 0x8FBE60 VA: 0x1808FD860
	public Workbench GetWorkbench() { }

	// RVA: 0x8FD5D0 Offset: 0x8FBBD0 VA: 0x1808FD5D0
	public bool CanAffordExperiment() { }

	// RVA: 0x8FDB10 Offset: 0x8FC110 VA: 0x1808FDB10
	public void Refresh() { }

	// RVA: 0x8FDB00 Offset: 0x8FC100 VA: 0x1808FDB00 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x8FD8F0 Offset: 0x8FBEF0 VA: 0x1808FD8F0
	public bool IsWorking() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

