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

	// RVA: 0x754810 Offset: 0x752E10 VA: 0x180754810 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x754D80 Offset: 0x753380 VA: 0x180754D80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x754C40 Offset: 0x753240 VA: 0x180754C40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x754B60 Offset: 0x753160 VA: 0x180754B60
	public Rigidbody GetRB() { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool IsTiedDown() { }

	// RVA: 0x754D30 Offset: 0x753330 VA: 0x180754D30 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE0330 Offset: 0xDF730 VA: 0x1800E0330
	[BaseEntity.Menu.Description] // RVA: 0xE0330 Offset: 0xDF730 VA: 0x1800E0330
	[BaseEntity.Menu.Icon] // RVA: 0xE0330 Offset: 0xDF730 VA: 0x1800E0330
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0330 Offset: 0xDF730 VA: 0x1800E0330
	// RVA: 0x754C00 Offset: 0x753200 VA: 0x180754C00
	public void Menu_FreeCrate(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_FreeCrate_Start() { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool Menu_FreeCrate_ShowIf(BasePlayer player) { }

	// RVA: 0x754D70 Offset: 0x753370 VA: 0x180754D70
	public void .ctor() { }

}

