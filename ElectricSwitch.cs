public class ElectricSwitch : IOEntity // TypeDefIndex: 8386
{	// Fields
	private Option __menuOption_Menu_Toggle; // 0x288
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	public bool isToggleSwitch; // 0x390

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC0370 Offset: 0xABE970 VA: 0x180AC0370 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC0DC0 Offset: 0xABF3C0 VA: 0x180AC0DC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC0C70 Offset: 0xABF270 VA: 0x180AC0C70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430 Slot: 148
	public override bool WantsPower() { }

	[BaseEntity.Menu] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Description] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Icon] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.ShowIf] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	// RVA: 0xAC0C20 Offset: 0xABF220 VA: 0x180AC0C20
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0xAC0BF0 Offset: 0xABF1F0 VA: 0x180AC0BF0
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Description] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Icon] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.ShowIf] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	// RVA: 0xAC0BA0 Offset: 0xABF1A0 VA: 0x180AC0BA0
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0xAC0B70 Offset: 0xABF170 VA: 0x180AC0B70
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Description] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Icon] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	// RVA: 0xAC0B20 Offset: 0xABF120 VA: 0x180AC0B20
	public void Menu_Toggle(BasePlayer player) { }

	// RVA: 0xAC0AF0 Offset: 0xABF0F0 VA: 0x180AC0AF0
	public bool Menu_Toggle_ShowIf(BasePlayer player) { }

	// RVA: 0xAC0D60 Offset: 0xABF360 VA: 0x180AC0D60
	public void .ctor() { }

}

