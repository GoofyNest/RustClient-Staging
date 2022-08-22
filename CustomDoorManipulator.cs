public class CustomDoorManipulator : DoorManipulator // TypeDefIndex: 8376
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x2A8
	private Option __menuOption_Menu_SetClose; // 0x300
	private Option __menuOption_Menu_SetOpen; // 0x358

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6C6B10 Offset: 0x6C5110 VA: 0x1806C6B10 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6C74B0 Offset: 0x6C5AB0 VA: 0x1806C74B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6C7310 Offset: 0x6C5910 VA: 0x1806C7310 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	public override bool PairWithLockedDoors() { }

	// RVA: 0x6C6A70 Offset: 0x6C5070 VA: 0x1806C6A70
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x6C7080 Offset: 0x6C5680 VA: 0x1806C7080
	public bool IsPaired() { }

	[BaseEntity.Menu] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.Description] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.Icon] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6260 Offset: 0xD5660 VA: 0x1800D6260
	// RVA: 0x6C7180 Offset: 0x6C5780 VA: 0x1806C7180
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x6C70E0 Offset: 0x6C56E0 VA: 0x1806C70E0
	public bool Menu_Pair_ShowIf(BasePlayer player) { }

	// RVA: 0x6C7460 Offset: 0x6C5A60 VA: 0x1806C7460
	public void RequestPair() { }

	// RVA: 0x6C7400 Offset: 0x6C5A00 VA: 0x1806C7400
	public void RequestActionChange(DoorManipulator.DoorEffect newAction) { }

	[BaseEntity.Menu] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.Description] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.Icon] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6510 Offset: 0xD5910 VA: 0x1800D6510
	// RVA: 0x6C7240 Offset: 0x6C5840 VA: 0x1806C7240
	public void Menu_SetOpen(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool Menu_SetOpen_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.Description] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.Icon] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD67B0 Offset: 0xD5BB0 VA: 0x1800D67B0
	// RVA: 0x6C7240 Offset: 0x6C5840 VA: 0x1806C7240
	public void Menu_SetClose(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool Menu_SetClose_ShowIf(BasePlayer player) { }

	// RVA: 0x6C74A0 Offset: 0x6C5AA0 VA: 0x1806C74A0
	public void .ctor() { }

}

