public class DieselEngine : StorageContainer // TypeDefIndex: 8380
{	// Fields
	private Option __menuOption_Menu_EngineStartup; // 0x3D0
	private Option __menuOption_Menu_NoFuel; // 0x428
	public GameObjectRef rumbleEffect; // 0x480
	public Transform rumbleOrigin; // 0x488
	public const BaseEntity.Flags Flag_HasFuel = 512;
	public float runningTimePerFuelUnit; // 0x490
	private float cachedFuelTime; // 0x494
	private const float rumbleMaxDistSq = 100;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x985580 Offset: 0x983B80 VA: 0x180985580 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x986240 Offset: 0x984840 VA: 0x180986240 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x985DA0 Offset: 0x9843A0 VA: 0x180985DA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x985BC0 Offset: 0x9841C0 VA: 0x180985BC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool HasFuel() { }

	// RVA: 0x985FE0 Offset: 0x9845E0 VA: 0x180985FE0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x5B12D0 Offset: 0x5AF8D0 VA: 0x1805B12D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x985E90 Offset: 0x984490 VA: 0x180985E90
	public void Rumble() { }

	[BaseEntity.Menu] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Description] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Icon] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	// RVA: 0x985CB0 Offset: 0x9842B0 VA: 0x180985CB0
	public void Menu_EngineStartup(BasePlayer player) { }

	// RVA: 0x985C20 Offset: 0x984220 VA: 0x180985C20
	public bool Menu_EngineStartup_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	[BaseEntity.Menu.Description] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	[BaseEntity.Menu.Icon] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_NoFuel(BasePlayer player) { }

	// RVA: 0x985D00 Offset: 0x984300 VA: 0x180985D00
	public bool Menu_NoFuel_ShowIf(BasePlayer player) { }

	// RVA: 0x9861E0 Offset: 0x9847E0 VA: 0x1809861E0
	public void .ctor() { }

}

