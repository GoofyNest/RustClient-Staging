public class CustomTimerSwitch : TimerSwitch // TypeDefIndex: 8377
{	// Fields
	private Option __menuOption_Menu_SetTime; // 0x2F8
	public GameObjectRef timerPanelPrefab; // 0x350

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6C7630 Offset: 0x6C5C30 VA: 0x1806C7630 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6C7E40 Offset: 0x6C6440 VA: 0x1806C7E40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6C7B90 Offset: 0x6C6190 VA: 0x1806C7B90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6C7590 Offset: 0x6C5B90 VA: 0x1806C7590
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x6C7C80 Offset: 0x6C6280 VA: 0x1806C7C80
	public void SendNewTime(float seconds) { }

	[BaseEntity.Menu] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.Description] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.Icon] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	// RVA: 0x6C7980 Offset: 0x6C5F80 VA: 0x1806C7980
	public void Menu_SetTime(BasePlayer player) { }

	// RVA: 0x6C7940 Offset: 0x6C5F40 VA: 0x1806C7940
	public bool Menu_SetTime_ShowIf(BasePlayer player) { }

	// RVA: 0x6C7E30 Offset: 0x6C6430 VA: 0x1806C7E30
	public void .ctor() { }

}

