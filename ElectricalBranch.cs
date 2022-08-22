public class ElectricalBranch : IOEntity // TypeDefIndex: 8385
{	// Fields
	private Option __menuOption_Menu_SetBranch; // 0x288
	public int branchAmount; // 0x2E0
	public GameObjectRef branchPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC14B0 Offset: 0xABFAB0 VA: 0x180AC14B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC1BD0 Offset: 0xAC01D0 VA: 0x180AC1BD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC1A80 Offset: 0xAC0080 VA: 0x180AC1A80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F4B0 Offset: 0x69DAB0 VA: 0x18069F4B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.Description] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.Icon] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	// RVA: 0xAC1870 Offset: 0xABFE70 VA: 0x180AC1870
	public void Menu_SetBranch(BasePlayer player) { }

	// RVA: 0xAC17C0 Offset: 0xABFDC0 VA: 0x180AC17C0
	public bool Menu_SetBranch_ShowIf(BasePlayer player) { }

	// RVA: 0xAC1460 Offset: 0xABFA60 VA: 0x180AC1460
	public void ClientChangePower(int newAmount) { }

	// RVA: 0xAC1B70 Offset: 0xAC0170 VA: 0x180AC1B70
	public void .ctor() { }

}

