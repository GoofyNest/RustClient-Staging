public class VendingPanelAdmin : UIDialog // TypeDefIndex: 8737
{	// Fields
	public GameObject sellOrderAdminContainer; // 0x30
	public GameObject sellOrderAdminPrefab; // 0x38
	public InputField storeNameInputField; // 0x40
	private VendingMachine vendingMachine; // 0x48

	// Methods

	// RVA: 0xADD350 Offset: 0xADB950 VA: 0x180ADD350 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0xADD1F0 Offset: 0xADB7F0 VA: 0x180ADD1F0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xADD1E0 Offset: 0xADB7E0 VA: 0x180ADD1E0
	public void Awake() { }

	// RVA: 0xADD6D0 Offset: 0xADBCD0 VA: 0x180ADD6D0
	public void VendingMachineUpdated() { }

	// RVA: 0xADD3D0 Offset: 0xADB9D0 VA: 0x180ADD3D0
	public void UpdateSellOrders() { }

	// RVA: 0xADD370 Offset: 0xADB970 VA: 0x180ADD370
	public void SetVendingMachine(VendingMachine vend) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public VendingMachine GetVendingMachine() { }

	// RVA: 0xADD630 Offset: 0xADBC30 VA: 0x180ADD630
	public void Update() { }

	// RVA: 0xADD2C0 Offset: 0xADB8C0 VA: 0x180ADD2C0
	public void DeleteClicked(int index) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StoreNameTextChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void StoreNameTextComplete() { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

