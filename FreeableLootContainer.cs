public class FreeableLootContainer : LootContainer // TypeDefIndex: 8393
{	// Fields
	private Option __menuOption_Menu_FreeCrate; // 0x418
	private const BaseEntity.Flags tiedDown = 65536;
	public Buoyancy buoyancy; // 0x470
	public GameObjectRef freedEffect; // 0x478
	private Rigidbody rb; // 0x480
	public uint skinOverride; // 0x488

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x754920 Offset: 0x752F20 VA: 0x180754920 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x754E90 Offset: 0x753490 VA: 0x180754E90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x754D50 Offset: 0x753350 VA: 0x180754D50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x754C70 Offset: 0x753270 VA: 0x180754C70
	public Rigidbody GetRB() { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool IsTiedDown() { }

	// RVA: 0x754E40 Offset: 0x753440 VA: 0x180754E40 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[BaseEntity.Menu.Description] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[BaseEntity.Menu.Icon] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	// RVA: 0x754D10 Offset: 0x753310 VA: 0x180754D10
	public void Menu_FreeCrate(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_FreeCrate_Start() { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool Menu_FreeCrate_ShowIf(BasePlayer player) { }

	// RVA: 0x754E80 Offset: 0x753480 VA: 0x180754E80
	public void .ctor() { }

}

