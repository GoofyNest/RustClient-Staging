public class ContainerIOEntity : IOEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8375
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x288
	private Option __menuOption_Menu_Open; // 0x2E0
	public ItemDefinition onlyAllowedItem; // 0x338
	public ItemContainer.ContentsType allowedContents; // 0x340
	public int maxStackSize; // 0x344
	public int numSlots; // 0x348
	public string lootPanelName; // 0x350
	public Translate.Phrase panelTitle; // 0x358
	public bool needsBuildingPrivilegeToUse; // 0x360
	public bool isLootable; // 0x361
	public bool dropsLoot; // 0x362
	public bool dropFloats; // 0x363
	public bool onlyOneUser; // 0x364
	public SoundDefinition openSound; // 0x368
	public SoundDefinition closeSound; // 0x370

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0x6B86D0 Offset: 0x6B6CD0 VA: 0x1806B86D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6B9060 Offset: 0x6B7660 VA: 0x1806B9060 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6B8D90 Offset: 0x6B7390 VA: 0x1806B8D90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6B91A0 Offset: 0x6B77A0 VA: 0x1806B91A0 Slot: 161
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x6B8CB0 Offset: 0x6B72B0 VA: 0x1806B8CB0
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x6B8C10 Offset: 0x6B7210 VA: 0x1806B8C10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0x6B8C70 Offset: 0x6B7270 VA: 0x1806B8C70
	public void Menu_Open(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Description] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Icon] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x6B8C30 Offset: 0x6B7230 VA: 0x1806B8C30
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x6B8C50 Offset: 0x6B7250 VA: 0x1806B8C50
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x6B8E80 Offset: 0x6B7480 VA: 0x1806B8E80 Slot: 164
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 165
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 166
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x6B91B0 Offset: 0x6B77B0 VA: 0x1806B91B0 Slot: 162
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x6B9050 Offset: 0x6B7650 VA: 0x1806B9050 Slot: 163
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x6B8F80 Offset: 0x6B7580 VA: 0x1806B8F80
	public void .ctor() { }

}

