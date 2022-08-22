public class ResourceContainer : EntityComponent<BaseEntity> // TypeDefIndex: 8436
{	// Fields
	private Option __menuOption_MenuLoot; // 0x20
	public bool lootable; // 0x78

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x955720 Offset: 0x953D20 VA: 0x180955720 Slot: 7
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x955BD0 Offset: 0x9541D0 VA: 0x180955BD0 Slot: 8
	public override bool get_HasMenuOptions() { }

	// RVA: 0x955AA0 Offset: 0x9540A0 VA: 0x180955AA0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.Description] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.Icon] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	[BaseEntity.Menu.ShowIf] // RVA: 0x80050 Offset: 0x7F450 VA: 0x180080050
	// RVA: 0x955A10 Offset: 0x954010 VA: 0x180955A10
	public void MenuLoot(BasePlayer player) { }

	// RVA: 0x955A00 Offset: 0x954000 VA: 0x180955A00
	public bool MenuLoot_Test(BasePlayer player) { }

	// RVA: 0x955B90 Offset: 0x954190 VA: 0x180955B90
	public void .ctor() { }

}

