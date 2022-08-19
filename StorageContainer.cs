public class StorageContainer : DecayEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8457
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x258
	private Option __menuOption_Menu_OnFire; // 0x2B0
	private Option __menuOption_Menu_Open; // 0x308
	[HeaderAttribute] // RVA: 0x8DED0 Offset: 0x8D2D0 VA: 0x18008DED0
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
	[HeaderAttribute] // RVA: 0x8DFB0 Offset: 0x8D3B0 VA: 0x18008DFB0
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

	// RVA: 0x79C940 Offset: 0x79AF40 VA: 0x18079C940 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x79D7C0 Offset: 0x79BDC0 VA: 0x18079D7C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x79D420 Offset: 0x79BA20 VA: 0x18079D420 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79D930 Offset: 0x79BF30 VA: 0x18079D930 Slot: 147
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x79D510 Offset: 0x79BB10 VA: 0x18079D510 Slot: 27
	public override void ResetState() { }

	// RVA: 0x79D270 Offset: 0x79B870 VA: 0x18079D270 Slot: 150
	public virtual void OnDrawGizmos() { }

	// RVA: 0x79D0D0 Offset: 0x79B6D0 VA: 0x18079D0D0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x79D190 Offset: 0x79B790 VA: 0x18079D190
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 151
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 152
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x79D520 Offset: 0x79BB20 VA: 0x18079D520 Slot: 153
	public virtual bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Description] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Icon] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	// RVA: 0x79D150 Offset: 0x79B750 VA: 0x18079D150
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x79D130 Offset: 0x79B730 VA: 0x18079D130 Slot: 154
	protected virtual bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	[BaseEntity.Menu.Description] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	[BaseEntity.Menu.Icon] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x79D100 Offset: 0x79B700 VA: 0x18079D100
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E560 Offset: 0x8D960 VA: 0x18008E560
	[BaseEntity.Menu.Icon] // RVA: 0x8E560 Offset: 0x8D960 VA: 0x18008E560
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E560 Offset: 0x8D960 VA: 0x18008E560
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_OnFire(BasePlayer player) { }

	// RVA: 0x79D120 Offset: 0x79B720 VA: 0x18079D120
	public bool Menu_OnFire_ShowIf(BasePlayer player) { }

	// RVA: 0x59B8E0 Offset: 0x599EE0 VA: 0x18059B8E0 Slot: 148
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x79D7B0 Offset: 0x79BDB0 VA: 0x18079D7B0 Slot: 149
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x79D6C0 Offset: 0x79BCC0 VA: 0x18079D6C0
	public void .ctor() { }

	// RVA: 0x79D610 Offset: 0x79BC10 VA: 0x18079D610
	private static void .cctor() { }

}
