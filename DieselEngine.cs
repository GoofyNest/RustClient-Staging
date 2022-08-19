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

	// RVA: 0x985470 Offset: 0x983A70 VA: 0x180985470 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x986130 Offset: 0x984730 VA: 0x180986130 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x985C90 Offset: 0x984290 VA: 0x180985C90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x985AB0 Offset: 0x9840B0 VA: 0x180985AB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool HasFuel() { }

	// RVA: 0x985ED0 Offset: 0x9844D0 VA: 0x180985ED0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x5B12D0 Offset: 0x5AF8D0 VA: 0x1805B12D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x985D80 Offset: 0x984380 VA: 0x180985D80
	public void Rumble() { }

	[BaseEntity.Menu] // RVA: 0xD8A60 Offset: 0xD7E60 VA: 0x1800D8A60
	[BaseEntity.Menu.Description] // RVA: 0xD8A60 Offset: 0xD7E60 VA: 0x1800D8A60
	[BaseEntity.Menu.Icon] // RVA: 0xD8A60 Offset: 0xD7E60 VA: 0x1800D8A60
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8A60 Offset: 0xD7E60 VA: 0x1800D8A60
	// RVA: 0x985BA0 Offset: 0x9841A0 VA: 0x180985BA0
	public void Menu_EngineStartup(BasePlayer player) { }

	// RVA: 0x985B10 Offset: 0x984110 VA: 0x180985B10
	public bool Menu_EngineStartup_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD8C60 Offset: 0xD8060 VA: 0x1800D8C60
	[BaseEntity.Menu.Description] // RVA: 0xD8C60 Offset: 0xD8060 VA: 0x1800D8C60
	[BaseEntity.Menu.Icon] // RVA: 0xD8C60 Offset: 0xD8060 VA: 0x1800D8C60
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8C60 Offset: 0xD8060 VA: 0x1800D8C60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_NoFuel(BasePlayer player) { }

	// RVA: 0x985BF0 Offset: 0x9841F0 VA: 0x180985BF0
	public bool Menu_NoFuel_ShowIf(BasePlayer player) { }

	// RVA: 0x9860D0 Offset: 0x9846D0 VA: 0x1809860D0
	public void .ctor() { }

}

