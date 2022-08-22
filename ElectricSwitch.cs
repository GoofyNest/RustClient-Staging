public class ElectricSwitch : IOEntity // TypeDefIndex: 8386
{	// Fields
	private Option __menuOption_Menu_Toggle; // 0x288
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	public bool isToggleSwitch; // 0x390

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC0840 Offset: 0xABEE40 VA: 0x180AC0840 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC1290 Offset: 0xABF890 VA: 0x180AC1290 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC1140 Offset: 0xABF740 VA: 0x180AC1140 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B03C0 Offset: 0x5AE9C0 VA: 0x1805B03C0 Slot: 148
	public override bool WantsPower() { }

	[BaseEntity.Menu] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Description] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Icon] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.ShowIf] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	// RVA: 0xAC10F0 Offset: 0xABF6F0 VA: 0x180AC10F0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0xAC10C0 Offset: 0xABF6C0 VA: 0x180AC10C0
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Description] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Icon] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.ShowIf] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	// RVA: 0xAC1070 Offset: 0xABF670 VA: 0x180AC1070
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0xAC1040 Offset: 0xABF640 VA: 0x180AC1040
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Description] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.Icon] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAE00 Offset: 0xDA200 VA: 0x1800DAE00
	// RVA: 0xAC0FF0 Offset: 0xABF5F0 VA: 0x180AC0FF0
	public void Menu_Toggle(BasePlayer player) { }

	// RVA: 0xAC0FC0 Offset: 0xABF5C0 VA: 0x180AC0FC0
	public bool Menu_Toggle_ShowIf(BasePlayer player) { }

	// RVA: 0xAC1230 Offset: 0xABF830 VA: 0x180AC1230
	public void .ctor() { }

}

