public class ContainerIOEntity : IOEntity, IItemContainerEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8375
{	private Option __menuOption_Menu_Occupied; // 0x288
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

	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Translate.Phrase get_LootPanelTitle() { }

	public bool OccupiedCheck(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8E090 Offset: 0x8D490 VA: 0x18008E090
	[BaseEntity.Menu.Description] // RVA: 0x8E090 Offset: 0x8D490 VA: 0x18008E090
	[BaseEntity.Menu.Icon] // RVA: 0x8E090 Offset: 0x8D490 VA: 0x18008E090
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E090 Offset: 0x8D490 VA: 0x18008E090
	public void Menu_Open(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8E350 Offset: 0x8D750 VA: 0x18008E350
	[BaseEntity.Menu.Description] // RVA: 0x8E350 Offset: 0x8D750 VA: 0x18008E350
	[BaseEntity.Menu.Icon] // RVA: 0x8E350 Offset: 0x8D750 VA: 0x18008E350
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E350 Offset: 0x8D750 VA: 0x18008E350
	public void Menu_Occupied(BasePlayer player) { }

	public bool Menu_Occupied_ShowIf(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public virtual bool ShouldShowLootMenus() { }

	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

}

