public class VendingPanelAdmin : UIDialog // TypeDefIndex: 8737
{	// Fields
	public GameObject sellOrderAdminContainer; // 0x30
	public GameObject sellOrderAdminPrefab; // 0x38
	public InputField storeNameInputField; // 0x40
	private VendingMachine vendingMachine; // 0x48

	// Methods

	// RVA: 0xADCE80 Offset: 0xADB480 VA: 0x180ADCE80 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0xADCD20 Offset: 0xADB320 VA: 0x180ADCD20 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xADCD10 Offset: 0xADB310 VA: 0x180ADCD10
	public void Awake() { }

	// RVA: 0xADD200 Offset: 0xADB800 VA: 0x180ADD200
	public void VendingMachineUpdated() { }

	// RVA: 0xADCF00 Offset: 0xADB500 VA: 0x180ADCF00
	public void UpdateSellOrders() { }

	// RVA: 0xADCEA0 Offset: 0xADB4A0 VA: 0x180ADCEA0
	public void SetVendingMachine(VendingMachine vend) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public VendingMachine GetVendingMachine() { }

	// RVA: 0xADD160 Offset: 0xADB760 VA: 0x180ADD160
	public void Update() { }

	// RVA: 0xADCDF0 Offset: 0xADB3F0 VA: 0x180ADCDF0
	public void DeleteClicked(int index) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StoreNameTextChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StoreNameTextComplete() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

