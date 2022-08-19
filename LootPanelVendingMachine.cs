public class LootPanelVendingMachine : LootPanel, IVendingMachineInterface // TypeDefIndex: 8732
{	// Fields
	public GameObjectRef sellOrderPrefab; // 0x38
	public GameObject sellOrderContainer; // 0x40
	public GameObject busyOverlayPrefab; // 0x48
	private GameObject busyOverlayInstance; // 0x50
	public static LootPanelVendingMachine Instance; // 0x0

	// Methods

	// RVA: 0x550610 Offset: 0x54EC10 VA: 0x180550610
	public void OnEnable() { }

	// RVA: 0x550510 Offset: 0x54EB10 VA: 0x180550510 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x550500 Offset: 0x54EB00 VA: 0x180550500
	public void Initialize() { }

	// RVA: 0x550470 Offset: 0x54EA70 VA: 0x180550470
	public VendingMachine GetVendingMachine() { }

	// RVA: 0x550840 Offset: 0x54EE40 VA: 0x180550840
	public void UpdateSellOrders() { }

	// RVA: 0x550440 Offset: 0x54EA40 VA: 0x180550440
	public void ClearSellOrders() { }

	// RVA: 0x550680 Offset: 0x54EC80 VA: 0x180550680
	public void SetBusyOverlay(bool on) { }

	// RVA: 0x550A90 Offset: 0x54F090 VA: 0x180550A90 Slot: 5
	public override void Update() { }

	// RVA: 0x550380 Offset: 0x54E980 VA: 0x180550380 Slot: 7
	public void BuyButtonClicked(int index, int multiplier = 1) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

