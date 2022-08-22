public class ElectricalBranch : IOEntity // TypeDefIndex: 8385
{	// Fields
	private Option __menuOption_Menu_SetBranch; // 0x288
	public int branchAmount; // 0x2E0
	public GameObjectRef branchPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC1C40 Offset: 0xAC0240 VA: 0x180AC1C40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC2360 Offset: 0xAC0960 VA: 0x180AC2360 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC2210 Offset: 0xAC0810 VA: 0x180AC2210 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F550 Offset: 0x69DB50 VA: 0x18069F550 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.Description] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.Icon] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA760 Offset: 0xD9B60 VA: 0x1800DA760
	// RVA: 0xAC2000 Offset: 0xAC0600 VA: 0x180AC2000
	public void Menu_SetBranch(BasePlayer player) { }

	// RVA: 0xAC1F50 Offset: 0xAC0550 VA: 0x180AC1F50
	public bool Menu_SetBranch_ShowIf(BasePlayer player) { }

	// RVA: 0xAC1BF0 Offset: 0xAC01F0 VA: 0x180AC1BF0
	public void ClientChangePower(int newAmount) { }

	// RVA: 0xAC2300 Offset: 0xAC0900 VA: 0x180AC2300
	public void .ctor() { }

}

