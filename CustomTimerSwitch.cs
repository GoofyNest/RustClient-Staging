public class CustomTimerSwitch : TimerSwitch // TypeDefIndex: 8377
{	// Fields
	private Option __menuOption_Menu_SetTime; // 0x2F8
	public GameObjectRef timerPanelPrefab; // 0x350

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6C76D0 Offset: 0x6C5CD0 VA: 0x1806C76D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6C7EE0 Offset: 0x6C64E0 VA: 0x1806C7EE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6C7C30 Offset: 0x6C6230 VA: 0x1806C7C30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6C7630 Offset: 0x6C5C30 VA: 0x1806C7630
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x6C7D20 Offset: 0x6C6320 VA: 0x1806C7D20
	public void SendNewTime(float seconds) { }

	[BaseEntity.Menu] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.Description] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.Icon] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	// RVA: 0x6C7A20 Offset: 0x6C6020 VA: 0x1806C7A20
	public void Menu_SetTime(BasePlayer player) { }

	// RVA: 0x6C79E0 Offset: 0x6C5FE0 VA: 0x1806C79E0
	public bool Menu_SetTime_ShowIf(BasePlayer player) { }

	// RVA: 0x6C7ED0 Offset: 0x6C64D0 VA: 0x1806C7ED0
	public void .ctor() { }

}

