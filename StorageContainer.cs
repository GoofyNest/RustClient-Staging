public class StorageContainer : DecayEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8457
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x258
	private Option __menuOption_Menu_OnFire; // 0x2B0
	private Option __menuOption_Menu_Open; // 0x308
	[HeaderAttribute] // RVA: 0x8DF50 Offset: 0x8D350 VA: 0x18008DF50
	public static readonly Translate.Phrase LockedMessage; // 0x0
	public static readonly Translate.Phrase InUseMessage; // 0x8
	public int inventorySlots; // 0x360
	public bool dropsLoot; // 0x364
	public bool dropFloats; // 0x365
	public bool isLootable; // 0x366
	public bool isLockable; // 0x367
	public bool isMonitorable; // 0x368
	public string panelName; // 0x370
	public Translate.Phrase panelTitle; // 0x378
	public ItemContainer.ContentsType allowedContents; // 0x380
	public ItemDefinition allowedItem; // 0x388
	public ItemDefinition allowedItem2; // 0x390
	public int maxStackSize; // 0x398
	public bool needsBuildingPrivilegeToUse; // 0x39C
	public bool mustBeMountedToUse; // 0x39D
	public SoundDefinition openSound; // 0x3A0
	public SoundDefinition closeSound; // 0x3A8
	[HeaderAttribute] // RVA: 0x8E030 Offset: 0x8D430 VA: 0x18008E030
	public Vector3 dropPosition; // 0x3B0
	public Vector3 dropVelocity; // 0x3BC
	public ItemCategory onlyAcceptCategory; // 0x3C8
	public bool onlyOneUser; // 0x3CC

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0x7BAE50 Offset: 0x7B9450 VA: 0x1807BAE50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7BBCD0 Offset: 0x7BA2D0 VA: 0x1807BBCD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7BB930 Offset: 0x7B9F30 VA: 0x1807BB930 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7BBE40 Offset: 0x7BA440 VA: 0x1807BBE40 Slot: 147
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x7BBA20 Offset: 0x7BA020 VA: 0x1807BBA20 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7BB780 Offset: 0x7B9D80 VA: 0x1807BB780 Slot: 150
	public virtual void OnDrawGizmos() { }

	// RVA: 0x7BB5E0 Offset: 0x7B9BE0 VA: 0x1807BB5E0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x7BB6A0 Offset: 0x7B9CA0 VA: 0x1807BB6A0
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 151
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 152
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x7BBA30 Offset: 0x7BA030 VA: 0x1807BBA30 Slot: 153
	public virtual bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0x7BB660 Offset: 0x7B9C60 VA: 0x1807BB660
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x7BB640 Offset: 0x7B9C40 VA: 0x1807BB640 Slot: 154
	protected virtual bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Description] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Icon] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x7BB610 Offset: 0x7B9C10 VA: 0x1807BB610
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	[BaseEntity.Menu.Icon] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_OnFire(BasePlayer player) { }

	// RVA: 0x7BB630 Offset: 0x7B9C30 VA: 0x1807BB630
	public bool Menu_OnFire_ShowIf(BasePlayer player) { }

	// RVA: 0x59B870 Offset: 0x599E70 VA: 0x18059B870 Slot: 148
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x7BBCC0 Offset: 0x7BA2C0 VA: 0x1807BBCC0 Slot: 149
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x7BBBD0 Offset: 0x7BA1D0 VA: 0x1807BBBD0
	public void .ctor() { }

	// RVA: 0x7BBB20 Offset: 0x7BA120 VA: 0x1807BBB20
	private static void .cctor() { }

}

