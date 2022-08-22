public class CustomDoorManipulator : DoorManipulator // TypeDefIndex: 8376
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x2A8
	private Option __menuOption_Menu_SetClose; // 0x300
	private Option __menuOption_Menu_SetOpen; // 0x358

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6C6A00 Offset: 0x6C5000 VA: 0x1806C6A00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6C73A0 Offset: 0x6C59A0 VA: 0x1806C73A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6C7200 Offset: 0x6C5800 VA: 0x1806C7200 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	public override bool PairWithLockedDoors() { }

	// RVA: 0x6C6960 Offset: 0x6C4F60 VA: 0x1806C6960
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x6C6F70 Offset: 0x6C5570 VA: 0x1806C6F70
	public bool IsPaired() { }

	[BaseEntity.Menu] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.Description] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.Icon] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	// RVA: 0x6C7070 Offset: 0x6C5670 VA: 0x1806C7070
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x6C6FD0 Offset: 0x6C55D0 VA: 0x1806C6FD0
	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	// RVA: 0x6C7350 Offset: 0x6C5950 VA: 0x1806C7350
	public void RequestPair() { }

	// RVA: 0x6C72F0 Offset: 0x6C58F0 VA: 0x1806C72F0
	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.Description] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.Icon] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	// RVA: 0x6C7130 Offset: 0x6C5730 VA: 0x1806C7130
	public void Menu_SetOpen(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.Description] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.Icon] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	// RVA: 0x6C7130 Offset: 0x6C5730 VA: 0x1806C7130
	public void Menu_SetClose(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	// RVA: 0x6C7390 Offset: 0x6C5990 VA: 0x1806C7390
	public void .ctor() { }

}

