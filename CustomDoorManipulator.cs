public class CustomDoorManipulator : DoorManipulator // TypeDefIndex: 8376
{	private Option __menuOption_Menu_Pair; // 0x2A8
	private Option __menuOption_Menu_SetClose; // 0x300
	private Option __menuOption_Menu_SetOpen; // 0x358

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool PairWithLockedDoors() { }

	public bool CanPlayerAdmin(BasePlayer player) { }

	public bool IsPaired() { }

	[BaseEntity.Menu] // RVA: 0xD6300 Offset: 0xD5700 VA: 0x1800D6300
	[BaseEntity.Menu.Description] // RVA: 0xD6300 Offset: 0xD5700 VA: 0x1800D6300
	[BaseEntity.Menu.Icon] // RVA: 0xD6300 Offset: 0xD5700 VA: 0x1800D6300
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6300 Offset: 0xD5700 VA: 0x1800D6300
	public void Menu_Pair(BasePlayer player) { }

	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	public void RequestPair() { }

	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] // RVA: 0xD6560 Offset: 0xD5960 VA: 0x1800D6560
	[BaseEntity.Menu.Description] // RVA: 0xD6560 Offset: 0xD5960 VA: 0x1800D6560
	[BaseEntity.Menu.Icon] // RVA: 0xD6560 Offset: 0xD5960 VA: 0x1800D6560
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6560 Offset: 0xD5960 VA: 0x1800D6560
	public void Menu_SetOpen(BasePlayer player) { }

	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD6800 Offset: 0xD5C00 VA: 0x1800D6800
	[BaseEntity.Menu.Description] // RVA: 0xD6800 Offset: 0xD5C00 VA: 0x1800D6800
	[BaseEntity.Menu.Icon] // RVA: 0xD6800 Offset: 0xD5C00 VA: 0x1800D6800
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6800 Offset: 0xD5C00 VA: 0x1800D6800
	public void Menu_SetClose(BasePlayer player) { }

	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

