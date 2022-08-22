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

	// RVA: 0x985A80 Offset: 0x984080 VA: 0x180985A80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x986740 Offset: 0x984D40 VA: 0x180986740 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9862A0 Offset: 0x9848A0 VA: 0x1809862A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9860C0 Offset: 0x9846C0 VA: 0x1809860C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x50CBD0 Offset: 0x50B1D0 VA: 0x18050CBD0
	public bool HasFuel() { }

	// RVA: 0x9864E0 Offset: 0x984AE0 VA: 0x1809864E0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x5B1260 Offset: 0x5AF860 VA: 0x1805B1260 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x986390 Offset: 0x984990 VA: 0x180986390
	public void Rumble() { }

	[BaseEntity.Menu] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Description] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Icon] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	// RVA: 0x9861B0 Offset: 0x9847B0 VA: 0x1809861B0
	public void Menu_EngineStartup(BasePlayer player) { }

	// RVA: 0x986120 Offset: 0x984720 VA: 0x180986120
	public bool Menu_EngineStartup_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	[BaseEntity.Menu.Description] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	[BaseEntity.Menu.Icon] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_NoFuel(BasePlayer player) { }

	// RVA: 0x986200 Offset: 0x984800 VA: 0x180986200
	public bool Menu_NoFuel_ShowIf(BasePlayer player) { }

	// RVA: 0x9866E0 Offset: 0x984CE0 VA: 0x1809866E0
	public void .ctor() { }

}

