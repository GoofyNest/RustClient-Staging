public class ElectricalBranch : IOEntity // TypeDefIndex: 8385
{	// Fields
	private Option __menuOption_Menu_SetBranch; // 0x288
	public int branchAmount; // 0x2E0
	public GameObjectRef branchPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC1770 Offset: 0xABFD70 VA: 0x180AC1770 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC1E90 Offset: 0xAC0490 VA: 0x180AC1E90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC1D40 Offset: 0xAC0340 VA: 0x180AC1D40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F5C0 Offset: 0x69DBC0 VA: 0x18069F5C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.Description] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.Icon] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	// RVA: 0xAC1B30 Offset: 0xAC0130 VA: 0x180AC1B30
	public void Menu_SetBranch(BasePlayer player) { }

	// RVA: 0xAC1A80 Offset: 0xAC0080 VA: 0x180AC1A80
	public bool Menu_SetBranch_ShowIf(BasePlayer player) { }

	// RVA: 0xAC1720 Offset: 0xABFD20 VA: 0x180AC1720
	public void ClientChangePower(int newAmount) { }

	// RVA: 0xAC1E30 Offset: 0xAC0430 VA: 0x180AC1E30
	public void .ctor() { }

}

