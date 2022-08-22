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

	// RVA: 0xAB2440 Offset: 0xAB0A40 VA: 0x180AB2440 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAB2780 Offset: 0xAB0D80 VA: 0x180AB2780 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAB28E0 Offset: 0xAB0EE0 VA: 0x180AB28E0 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0xAB2920 Offset: 0xAB0F20 VA: 0x180AB2920
	public string get_playerName() { }

	// RVA: 0xAB2940 Offset: 0xAB0F40 VA: 0x180AB2940
	public void set_playerName(string value) { }

	// RVA: 0xAB26C0 Offset: 0xAB0CC0 VA: 0x180AB26C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Description] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Icon] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	// RVA: 0xAB2740 Offset: 0xAB0D40 VA: 0x180AB2740
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAB2910 Offset: 0xAB0F10 VA: 0x180AB2910 Slot: 146
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xAB28D0 Offset: 0xAB0ED0 VA: 0x180AB28D0 Slot: 147
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xAB2870 Offset: 0xAB0E70 VA: 0x180AB2870
	public void .ctor() { }

}

