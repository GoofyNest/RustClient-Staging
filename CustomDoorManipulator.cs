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

	[BaseEntity.Menu] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.Description] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.Icon] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	public void Menu_Pair(BasePlayer player) { }

	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	public void RequestPair() { }

	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.Description] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.Icon] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	public void Menu_SetOpen(BasePlayer player) { }

	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.Description] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.Icon] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	public void Menu_SetClose(BasePlayer player) { }

	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

