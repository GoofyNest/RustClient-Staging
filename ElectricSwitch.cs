public class ElectricSwitch : IOEntity // TypeDefIndex: 8386
{	// Fields
	private Option __menuOption_Menu_Toggle; // 0x288
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	public bool isToggleSwitch; // 0x390

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC00B0 Offset: 0xABE6B0 VA: 0x180AC00B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC0B00 Offset: 0xABF100 VA: 0x180AC0B00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC09B0 Offset: 0xABEFB0 VA: 0x180AC09B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430 Slot: 148
	public override bool WantsPower() { }

	[BaseEntity.Menu] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Description] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Icon] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.ShowIf] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	// RVA: 0xAC0960 Offset: 0xABEF60 VA: 0x180AC0960
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0xAC0930 Offset: 0xABEF30 VA: 0x180AC0930
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Description] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Icon] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.ShowIf] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	// RVA: 0xAC08E0 Offset: 0xABEEE0 VA: 0x180AC08E0
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0xAC08B0 Offset: 0xABEEB0 VA: 0x180AC08B0
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Description] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Icon] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	// RVA: 0xAC0860 Offset: 0xABEE60 VA: 0x180AC0860
	public void Menu_Toggle(BasePlayer player) { }

	// RVA: 0xAC0830 Offset: 0xABEE30 VA: 0x180AC0830
	public bool Menu_Toggle_ShowIf(BasePlayer player) { }

	// RVA: 0xAC0AA0 Offset: 0xABF0A0 VA: 0x180AC0AA0
	public void .ctor() { }

}

