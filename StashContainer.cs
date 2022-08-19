public class StashContainer : StorageContainer // TypeDefIndex: 8455
{	// Fields
	private Option __menuOption_Menu_HideStash; // 0x3D0
	public Transform visuals; // 0x428
	public float burriedOffset; // 0x430
	public float raisedOffset; // 0x434
	public GameObjectRef buryEffect; // 0x438
	public float uncoverRange; // 0x440

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA8B240 Offset: 0xA89840 VA: 0x180A8B240 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA8BE80 Offset: 0xA8A480 VA: 0x180A8BE80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA8B6E0 Offset: 0xA89CE0 VA: 0x180A8B6E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x738190 Offset: 0x736790 VA: 0x180738190
	public bool IsHidden() { }

	// RVA: 0xA8B7D0 Offset: 0xA89DD0 VA: 0x180A8B7D0
	public bool PlayerInRange(BasePlayer ply) { }

	// RVA: 0xA8BA10 Offset: 0xA8A010 VA: 0x180A8BA10 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0xA8B090 Offset: 0xA89690 VA: 0x180A8B090 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA8B540 Offset: 0xA89B40 VA: 0x180A8B540 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8DC10 Offset: 0x8D010 VA: 0x18008DC10
	[BaseEntity.Menu.Description] // RVA: 0x8DC10 Offset: 0x8D010 VA: 0x18008DC10
	[BaseEntity.Menu.Icon] // RVA: 0x8DC10 Offset: 0x8D010 VA: 0x18008DC10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DC10 Offset: 0x8D010 VA: 0x18008DC10
	// RVA: 0xA8B6A0 Offset: 0xA89CA0 VA: 0x180A8B6A0
	public void Menu_HideStash(BasePlayer player) { }

	// RVA: 0x79D130 Offset: 0x79B730 VA: 0x18079D130
	public bool Menu_HideStash_ShowIf(BasePlayer player) { }

	// RVA: 0xA8BA50 Offset: 0xA8A050 VA: 0x180A8BA50
	public void TryUnhide() { }

	// RVA: 0xA8BB90 Offset: 0xA8A190 VA: 0x180A8BB90
	public void Update() { }

	// RVA: 0xA8BE20 Offset: 0xA8A420 VA: 0x180A8BE20
	public void .ctor() { }

}

public static class StashContainer.StashContainerFlags // TypeDefIndex: 8456
{	// Fields
	public const BaseEntity.Flags Hidden = 2048;

}

