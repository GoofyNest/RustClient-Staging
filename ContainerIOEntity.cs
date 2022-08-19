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

	// RVA: 0x6B8630 Offset: 0x6B6C30 VA: 0x1806B8630 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6B8FC0 Offset: 0x6B75C0 VA: 0x1806B8FC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6B8CF0 Offset: 0x6B72F0 VA: 0x1806B8CF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6B9100 Offset: 0x6B7700 VA: 0x1806B9100 Slot: 161
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x6B8C10 Offset: 0x6B7210 VA: 0x1806B8C10
	public bool OccupiedCheck(BasePlayer player) { }

	// RVA: 0x6B8B70 Offset: 0x6B7170 VA: 0x1806B8B70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Description] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Icon] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	// RVA: 0x6B8BD0 Offset: 0x6B71D0 VA: 0x1806B8BD0
	public void Menu_Open(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	[BaseEntity.Menu.Description] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	[BaseEntity.Menu.Icon] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E230 Offset: 0x8D630 VA: 0x18008E230
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x6B8B90 Offset: 0x6B7190 VA: 0x1806B8B90
	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x6B8BB0 Offset: 0x6B71B0 VA: 0x1806B8BB0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x6B8DE0 Offset: 0x6B73E0 VA: 0x1806B8DE0 Slot: 164
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 165
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 166
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x6B9110 Offset: 0x6B7710 VA: 0x1806B9110 Slot: 162
	public SoundDefinition get_OpenSound() { }

	// RVA: 0x6B8FB0 Offset: 0x6B75B0 VA: 0x1806B8FB0 Slot: 163
	public SoundDefinition get_CloseSound() { }

	// RVA: 0x6B8EE0 Offset: 0x6B74E0 VA: 0x1806B8EE0
	public void .ctor() { }

}

