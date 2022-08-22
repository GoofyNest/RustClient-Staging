public class DroppedItemContainer : BaseCombatEntity, LootPanel.IHasLootPanel, IContainerSounds // TypeDefIndex: 8383
{	// Fields
	private Option __menuOption_Menu_Open; // 0x240
	public string lootPanelName; // 0x298
	public int maxItemCount; // 0x2A0
	public ulong playerSteamID; // 0x2A8
	public string _playerName; // 0x2B0
	public bool onlyOwnerLoot; // 0x2B8
	public SoundDefinition openSound; // 0x2C0
	public SoundDefinition closeSound; // 0x2C8

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	public string playerName { get; set; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0xAB2910 Offset: 0xAB0F10 VA: 0x180AB2910 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAB2C50 Offset: 0xAB1250 VA: 0x180AB2C50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAB2DB0 Offset: 0xAB13B0 VA: 0x180AB2DB0 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0xAB2DF0 Offset: 0xAB13F0 VA: 0x180AB2DF0
	public string get_playerName() { }

	// RVA: 0xAB2E10 Offset: 0xAB1410 VA: 0x180AB2E10
	public void set_playerName(string value) { }

	// RVA: 0xAB2B90 Offset: 0xAB1190 VA: 0x180AB2B90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Description] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Icon] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	// RVA: 0xAB2C10 Offset: 0xAB1210 VA: 0x180AB2C10
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAB2DE0 Offset: 0xAB13E0 VA: 0x180AB2DE0 Slot: 146
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xAB2DA0 Offset: 0xAB13A0 VA: 0x180AB2DA0 Slot: 147
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xAB2D40 Offset: 0xAB1340 VA: 0x180AB2D40
	public void .ctor() { }

}

