public class VendingPanelAdmin : UIDialog // TypeDefIndex: 8737
{	// Fields
	public GameObject sellOrderAdminContainer; // 0x30
	public GameObject sellOrderAdminPrefab; // 0x38
	public InputField storeNameInputField; // 0x40
	private VendingMachine vendingMachine; // 0x48

	// Methods

	// RVA: 0xADCBC0 Offset: 0xADB1C0 VA: 0x180ADCBC0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0xADCA60 Offset: 0xADB060 VA: 0x180ADCA60 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xADCA50 Offset: 0xADB050 VA: 0x180ADCA50
	public void Awake() { }

	// RVA: 0xADCF40 Offset: 0xADB540 VA: 0x180ADCF40
	public void VendingMachineUpdated() { }

	// RVA: 0xADCC40 Offset: 0xADB240 VA: 0x180ADCC40
	public void UpdateSellOrders() { }

	// RVA: 0xADCBE0 Offset: 0xADB1E0 VA: 0x180ADCBE0
	public void SetVendingMachine(VendingMachine vend) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public VendingMachine GetVendingMachine() { }

	// RVA: 0xADCEA0 Offset: 0xADB4A0 VA: 0x180ADCEA0
	public void Update() { }

	// RVA: 0xADCB30 Offset: 0xADB130 VA: 0x180ADCB30
	public void DeleteClicked(int index) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StoreNameTextChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StoreNameTextComplete() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

