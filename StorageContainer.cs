public class StorageContainer : DecayEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8457
{	private Option __menuOption_Menu_Occupied; // 0x258
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

	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Translate.Phrase get_LootPanelTitle() { }

	public override void ResetState() { }

	public virtual void OnDrawGizmos() { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public bool OccupiedCheck(BasePlayer player) { }

	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	public virtual bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	public void Menu_Open(BasePlayer player) { }

	protected virtual bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Description] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Icon] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	public void Menu_Occupied(BasePlayer player) { }

	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	[BaseEntity.Menu.Icon] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E610 Offset: 0x8DA10 VA: 0x18008E610
	public void Menu_OnFire(BasePlayer player) { }

	public bool Menu_OnFire_ShowIf(BasePlayer player) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

	private static void .cctor() { }

}

