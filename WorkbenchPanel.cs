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

	// RVA: 0x8FE130 Offset: 0x8FC730 VA: 0x1808FE130 Slot: 5
	public override void Update() { }

	// RVA: 0x8FDF90 Offset: 0x8FC590 VA: 0x1808FDF90
	private void OnEnable() { }

	// RVA: 0x8FDED0 Offset: 0x8FC4D0 VA: 0x1808FDED0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x8FDC80 Offset: 0x8FC280 VA: 0x1808FDC80
	public void ExperimentButtonClicked() { }

	// RVA: 0x8FDD70 Offset: 0x8FC370 VA: 0x1808FDD70
	public Workbench GetWorkbench() { }

	// RVA: 0x8FDAE0 Offset: 0x8FC0E0 VA: 0x1808FDAE0
	public bool CanAffordExperiment() { }

	// RVA: 0x8FE020 Offset: 0x8FC620 VA: 0x1808FE020
	public void Refresh() { }

	// RVA: 0x8FE010 Offset: 0x8FC610 VA: 0x1808FE010 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x8FDE00 Offset: 0x8FC400 VA: 0x1808FDE00
	public bool IsWorking() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

