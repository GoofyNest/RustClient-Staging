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

	// RVA: 0xA8B9D0 Offset: 0xA89FD0 VA: 0x180A8B9D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA8C610 Offset: 0xA8AC10 VA: 0x180A8C610 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA8BE70 Offset: 0xA8A470 VA: 0x180A8BE70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7381F0 Offset: 0x7367F0 VA: 0x1807381F0
	public bool IsHidden() { }

	// RVA: 0xA8BF60 Offset: 0xA8A560 VA: 0x180A8BF60
	public bool PlayerInRange(BasePlayer ply) { }

	// RVA: 0xA8C1A0 Offset: 0xA8A7A0 VA: 0x180A8C1A0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0xA8B820 Offset: 0xA89E20 VA: 0x180A8B820 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA8BCD0 Offset: 0xA8A2D0 VA: 0x180A8BCD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	[BaseEntity.Menu.Description] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	[BaseEntity.Menu.Icon] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	// RVA: 0xA8BE30 Offset: 0xA8A430 VA: 0x180A8BE30
	public void Menu_HideStash(BasePlayer player) { }

	// RVA: 0x7BB640 Offset: 0x7B9C40 VA: 0x1807BB640
	public bool Menu_HideStash_ShowIf(BasePlayer player) { }

	// RVA: 0xA8C1E0 Offset: 0xA8A7E0 VA: 0x180A8C1E0
	public void TryUnhide() { }

	// RVA: 0xA8C320 Offset: 0xA8A920 VA: 0x180A8C320
	public void Update() { }

	// RVA: 0xA8C5B0 Offset: 0xA8ABB0 VA: 0x180A8C5B0
	public void .ctor() { }

}

public static class StashContainer.StashContainerFlags // TypeDefIndex: 8456
{	// Fields
	public const BaseEntity.Flags Hidden = 2048;

}

