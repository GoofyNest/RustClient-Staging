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

	// RVA: 0xA8B500 Offset: 0xA89B00 VA: 0x180A8B500 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA8C140 Offset: 0xA8A740 VA: 0x180A8C140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA8B9A0 Offset: 0xA89FA0 VA: 0x180A8B9A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	public bool IsHidden() { }

	// RVA: 0xA8BA90 Offset: 0xA8A090 VA: 0x180A8BA90
	public bool PlayerInRange(BasePlayer ply) { }

	// RVA: 0xA8BCD0 Offset: 0xA8A2D0 VA: 0x180A8BCD0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0xA8B350 Offset: 0xA89950 VA: 0x180A8B350 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA8B800 Offset: 0xA89E00 VA: 0x180A8B800 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	[BaseEntity.Menu.Description] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	[BaseEntity.Menu.Icon] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DCC0 Offset: 0x8D0C0 VA: 0x18008DCC0
	// RVA: 0xA8B960 Offset: 0xA89F60 VA: 0x180A8B960
	public void Menu_HideStash(BasePlayer player) { }

	// RVA: 0x79D240 Offset: 0x79B840 VA: 0x18079D240
	public bool Menu_HideStash_ShowIf(BasePlayer player) { }

	// RVA: 0xA8BD10 Offset: 0xA8A310 VA: 0x180A8BD10
	public void TryUnhide() { }

	// RVA: 0xA8BE50 Offset: 0xA8A450 VA: 0x180A8BE50
	public void Update() { }

	// RVA: 0xA8C0E0 Offset: 0xA8A6E0 VA: 0x180A8C0E0
	public void .ctor() { }

}

public static class StashContainer.StashContainerFlags // TypeDefIndex: 8456
{	// Fields
	public const BaseEntity.Flags Hidden = 2048;

}

