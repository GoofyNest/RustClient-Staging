public class Candle : BaseCombatEntity, ISplashable, IIgniteable // TypeDefIndex: 8366
{	private Option __menuOption_Menu_Extinguish; // 0x240
	private Option __menuOption_Menu_Ignite; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	[BaseEntity.Menu.Description] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	[BaseEntity.Menu.Icon] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	public void Menu_Ignite(BasePlayer player) { }

	public bool Menu_Ignite_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	[BaseEntity.Menu.Description] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	[BaseEntity.Menu.Icon] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD01C0 Offset: 0xCF5C0 VA: 0x1800D01C0
	public void Menu_Extinguish(BasePlayer player) { }

	public bool Menu_Extinguish_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

