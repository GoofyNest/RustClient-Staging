public class ResourceContainer : EntityComponent<BaseEntity> // TypeDefIndex: 8436
{	// Fields
	private Option __menuOption_MenuLoot; // 0x20
	public bool lootable; // 0x78

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x955D30 Offset: 0x954330 VA: 0x180955D30 Slot: 7
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9561E0 Offset: 0x9547E0 VA: 0x1809561E0 Slot: 8
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9560B0 Offset: 0x9546B0 VA: 0x1809560B0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.Description] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.Icon] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.ShowIf] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	// RVA: 0x956020 Offset: 0x954620 VA: 0x180956020
	public void MenuLoot(BasePlayer player) { }

	// RVA: 0x956010 Offset: 0x954610 VA: 0x180956010
	public bool MenuLoot_Test(BasePlayer player) { }

	// RVA: 0x9561A0 Offset: 0x9547A0 VA: 0x1809561A0
	public void .ctor() { }

}

