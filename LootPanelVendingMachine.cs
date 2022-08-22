public class LootPanelVendingMachine : LootPanel, IVendingMachineInterface // TypeDefIndex: 8732
{	// Fields
	public GameObjectRef sellOrderPrefab; // 0x38
	public GameObject sellOrderContainer; // 0x40
	public GameObject busyOverlayPrefab; // 0x48
	private GameObject busyOverlayInstance; // 0x50
	public static LootPanelVendingMachine Instance; // 0x0

	// Methods

	// RVA: 0x5505A0 Offset: 0x54EBA0 VA: 0x1805505A0
	public void OnEnable() { }

	// RVA: 0x5504A0 Offset: 0x54EAA0 VA: 0x1805504A0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x550490 Offset: 0x54EA90 VA: 0x180550490
	public void Initialize() { }

	// RVA: 0x550400 Offset: 0x54EA00 VA: 0x180550400
	public VendingMachine GetVendingMachine() { }

	// RVA: 0x5507D0 Offset: 0x54EDD0 VA: 0x1805507D0
	public void UpdateSellOrders() { }

	// RVA: 0x5503D0 Offset: 0x54E9D0 VA: 0x1805503D0
	public void ClearSellOrders() { }

	// RVA: 0x550610 Offset: 0x54EC10 VA: 0x180550610
	public void SetBusyOverlay(bool on) { }

	// RVA: 0x550A20 Offset: 0x54F020 VA: 0x180550A20 Slot: 5
	public override void Update() { }

	// RVA: 0x550310 Offset: 0x54E910 VA: 0x180550310 Slot: 7
	public void BuyButtonClicked(int index, int multiplier = 1) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

