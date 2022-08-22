public class Candle : BaseCombatEntity, ISplashable, IIgniteable // TypeDefIndex: 8366
{	// Fields
	private Option __menuOption_Menu_Extinguish; // 0x240
	private Option __menuOption_Menu_Ignite; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6FD710 Offset: 0x6FBD10 VA: 0x1806FD710 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6FDDE0 Offset: 0x6FC3E0 VA: 0x1806FDDE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6FDCF0 Offset: 0x6FC2F0 VA: 0x1806FDCF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	[BaseEntity.Menu.Description] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	[BaseEntity.Menu.Icon] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	// RVA: 0x6FDCA0 Offset: 0x6FC2A0 VA: 0x1806FDCA0
	public void Menu_Ignite(BasePlayer player) { }

	// RVA: 0x6FDC80 Offset: 0x6FC280 VA: 0x1806FDC80
	public bool Menu_Ignite_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	[BaseEntity.Menu.Description] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	[BaseEntity.Menu.Icon] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	// RVA: 0x6FDC30 Offset: 0x6FC230 VA: 0x1806FDC30
	public void Menu_Extinguish(BasePlayer player) { }

	// RVA: 0x5B03C0 Offset: 0x5AE9C0 VA: 0x1805B03C0
	public bool Menu_Extinguish_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

