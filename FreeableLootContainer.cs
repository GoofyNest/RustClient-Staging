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

	// RVA: 0x754870 Offset: 0x752E70 VA: 0x180754870 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x754DE0 Offset: 0x7533E0 VA: 0x180754DE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x754CA0 Offset: 0x7532A0 VA: 0x180754CA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x754BC0 Offset: 0x7531C0 VA: 0x180754BC0
	public Rigidbody GetRB() { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0
	public bool IsTiedDown() { }

	// RVA: 0x754D90 Offset: 0x753390 VA: 0x180754D90 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[BaseEntity.Menu.Description] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[BaseEntity.Menu.Icon] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	// RVA: 0x754C60 Offset: 0x753260 VA: 0x180754C60
	public void Menu_FreeCrate(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_FreeCrate_Start() { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0
	public bool Menu_FreeCrate_ShowIf(BasePlayer player) { }

	// RVA: 0x754DD0 Offset: 0x7533D0 VA: 0x180754DD0
	public void .ctor() { }

}

