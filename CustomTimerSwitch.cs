public class CustomTimerSwitch : TimerSwitch // TypeDefIndex: 8377
{	private Option __menuOption_Menu_SetTime; // 0x2F8
	public GameObjectRef timerPanelPrefab; // 0x350

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool CanPlayerAdmin(BasePlayer player) { }

	public void SendNewTime(float seconds) { }

	[BaseEntity.Menu] // RVA: 0xD6A30 Offset: 0xD5E30 VA: 0x1800D6A30
	[BaseEntity.Menu.Description] // RVA: 0xD6A30 Offset: 0xD5E30 VA: 0x1800D6A30
	[BaseEntity.Menu.Icon] // RVA: 0xD6A30 Offset: 0xD5E30 VA: 0x1800D6A30
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6A30 Offset: 0xD5E30 VA: 0x1800D6A30
	public void Menu_SetTime(BasePlayer player) { }

	public bool Menu_SetTime_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

