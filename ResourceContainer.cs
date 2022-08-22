public class ResourceContainer : EntityComponent<BaseEntity> // TypeDefIndex: 8436
{	// Fields
	private Option __menuOption_MenuLoot; // 0x20
	public bool lootable; // 0x78

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x955830 Offset: 0x953E30 VA: 0x180955830 Slot: 7
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x955CE0 Offset: 0x9542E0 VA: 0x180955CE0 Slot: 8
	public override bool get_HasMenuOptions() { }

	// RVA: 0x955BB0 Offset: 0x9541B0 VA: 0x180955BB0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.Description] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.Icon] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.ShowIf] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	// RVA: 0x955B20 Offset: 0x954120 VA: 0x180955B20
	public void MenuLoot(BasePlayer player) { }

	// RVA: 0x955B10 Offset: 0x954110 VA: 0x180955B10
	public bool MenuLoot_Test(BasePlayer player) { }

	// RVA: 0x955CA0 Offset: 0x9542A0 VA: 0x180955CA0
	public void .ctor() { }

}

