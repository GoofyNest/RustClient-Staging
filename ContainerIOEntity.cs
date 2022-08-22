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

	// RVA: 0x6B8740 Offset: 0x6B6D40 VA: 0x1806B8740 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6B90D0 Offset: 0x6B76D0 VA: 0x1806B90D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6B8E00 Offset: 0x6B7400 VA: 0x1806B8E00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6B9210 Offset: 0x6B7810 VA: 0x1806B9210 Slot: 161
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x6B8D20 Offset: 0x6B7320 VA: 0x1806B8D20
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x6B8C80 Offset: 0x6B7280 VA: 0x1806B8C80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0x6B8CE0 Offset: 0x6B72E0 VA: 0x1806B8CE0
	public void Menu_Open(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Description] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.Icon] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x6B8CA0 Offset: 0x6B72A0 VA: 0x1806B8CA0
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x6B8CC0 Offset: 0x6B72C0 VA: 0x1806B8CC0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x6B8EF0 Offset: 0x6B74F0 VA: 0x1806B8EF0 Slot: 164
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 165
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 166
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x6B9220 Offset: 0x6B7820 VA: 0x1806B9220 Slot: 162
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x6B90C0 Offset: 0x6B76C0 VA: 0x1806B90C0 Slot: 163
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x6B8FF0 Offset: 0x6B75F0 VA: 0x1806B8FF0
	public void .ctor() { }

}

