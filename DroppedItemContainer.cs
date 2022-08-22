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

	// RVA: 0xAB2180 Offset: 0xAB0780 VA: 0x180AB2180 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAB24C0 Offset: 0xAB0AC0 VA: 0x180AB24C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAB2620 Offset: 0xAB0C20 VA: 0x180AB2620 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0xAB2660 Offset: 0xAB0C60 VA: 0x180AB2660
	public string get_playerName() { }

	// RVA: 0xAB2680 Offset: 0xAB0C80 VA: 0x180AB2680
	public void set_playerName(string value) { }

	// RVA: 0xAB2400 Offset: 0xAB0A00 VA: 0x180AB2400 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Description] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Icon] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	// RVA: 0xAB2480 Offset: 0xAB0A80 VA: 0x180AB2480
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAB2650 Offset: 0xAB0C50 VA: 0x180AB2650 Slot: 146
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xAB2610 Offset: 0xAB0C10 VA: 0x180AB2610 Slot: 147
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xAB25B0 Offset: 0xAB0BB0 VA: 0x180AB25B0
	public void .ctor() { }

}

