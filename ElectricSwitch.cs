public class ElectricSwitch : IOEntity // TypeDefIndex: 8386
{	private Option __menuOption_Menu_Toggle; // 0x288
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	public bool isToggleSwitch; // 0x390

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool WantsPower() { }

	[BaseEntity.Menu] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Description] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Icon] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.ShowIf] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Description] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Icon] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.ShowIf] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Description] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Icon] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	public void Menu_Toggle(BasePlayer player) { }

	public bool Menu_Toggle_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

