public class CustomTimerSwitch : TimerSwitch // TypeDefIndex: 8377
{	// Fields
	private Option __menuOption_Menu_SetTime; // 0x2F8
	public GameObjectRef timerPanelPrefab; // 0x350

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6C7740 Offset: 0x6C5D40 VA: 0x1806C7740 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6C7F50 Offset: 0x6C6550 VA: 0x1806C7F50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6C7CA0 Offset: 0x6C62A0 VA: 0x1806C7CA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6C76A0 Offset: 0x6C5CA0 VA: 0x1806C76A0
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x6C7D90 Offset: 0x6C6390 VA: 0x1806C7D90
	public void SendNewTime(float seconds) { }

	[BaseEntity.Menu] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.Description] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.Icon] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6900 Offset: 0xD5D00 VA: 0x1800D6900
	// RVA: 0x6C7A90 Offset: 0x6C6090 VA: 0x1806C7A90
	public void Menu_SetTime(BasePlayer player) { }

	// RVA: 0x6C7A50 Offset: 0x6C6050 VA: 0x1806C7A50
	public bool Menu_SetTime_ShowIf(BasePlayer player) { }

	// RVA: 0x6C7F40 Offset: 0x6C6540 VA: 0x1806C7F40
	public void .ctor() { }

}

