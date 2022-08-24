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

	[BaseEntity.Menu] // RVA: 0xD6390 Offset: 0xD5790 VA: 0x1800D6390
	[BaseEntity.Menu.Description] // RVA: 0xD6390 Offset: 0xD5790 VA: 0x1800D6390
	[BaseEntity.Menu.Icon] // RVA: 0xD6390 Offset: 0xD5790 VA: 0x1800D6390
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6390 Offset: 0xD5790 VA: 0x1800D6390
	public void Menu_Pair(BasePlayer player) { }

	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	public void RequestPair() { }

	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] // RVA: 0xD65F0 Offset: 0xD59F0 VA: 0x1800D65F0
	[BaseEntity.Menu.Description] // RVA: 0xD65F0 Offset: 0xD59F0 VA: 0x1800D65F0
	[BaseEntity.Menu.Icon] // RVA: 0xD65F0 Offset: 0xD59F0 VA: 0x1800D65F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD65F0 Offset: 0xD59F0 VA: 0x1800D65F0
	public void Menu_SetOpen(BasePlayer player) { }

	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD6890 Offset: 0xD5C90 VA: 0x1800D6890
	[BaseEntity.Menu.Description] // RVA: 0xD6890 Offset: 0xD5C90 VA: 0x1800D6890
	[BaseEntity.Menu.Icon] // RVA: 0xD6890 Offset: 0xD5C90 VA: 0x1800D6890
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6890 Offset: 0xD5C90 VA: 0x1800D6890
	public void Menu_SetClose(BasePlayer player) { }

	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

