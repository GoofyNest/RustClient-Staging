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

	// RVA: 0x79CA50 Offset: 0x79B050 VA: 0x18079CA50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x79D8D0 Offset: 0x79BED0 VA: 0x18079D8D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x79D530 Offset: 0x79BB30 VA: 0x18079D530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79DA40 Offset: 0x79C040 VA: 0x18079DA40 Slot: 147
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x79D620 Offset: 0x79BC20 VA: 0x18079D620 Slot: 27
	public override void ResetState() { }

	// RVA: 0x79D380 Offset: 0x79B980 VA: 0x18079D380 Slot: 150
	public virtual void OnDrawGizmos() { }

	// RVA: 0x79D1E0 Offset: 0x79B7E0 VA: 0x18079D1E0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x79D2A0 Offset: 0x79B8A0 VA: 0x18079D2A0
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 151
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 152
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x79D630 Offset: 0x79BC30 VA: 0x18079D630 Slot: 153
	public virtual bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0x79D260 Offset: 0x79B860 VA: 0x18079D260
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x79D240 Offset: 0x79B840 VA: 0x18079D240 Slot: 154
	protected virtual bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Description] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Icon] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x79D210 Offset: 0x79B810 VA: 0x18079D210
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	[BaseEntity.Menu.Icon] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_OnFire(BasePlayer player) { }

	// RVA: 0x79D230 Offset: 0x79B830 VA: 0x18079D230
	public bool Menu_OnFire_ShowIf(BasePlayer player) { }

	// RVA: 0x59B8E0 Offset: 0x599EE0 VA: 0x18059B8E0 Slot: 148
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x79D8C0 Offset: 0x79BEC0 VA: 0x18079D8C0 Slot: 149
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x79D7D0 Offset: 0x79BDD0 VA: 0x18079D7D0
	public void .ctor() { }

	// RVA: 0x79D720 Offset: 0x79BD20 VA: 0x18079D720
	private static void .cctor() { }

}

