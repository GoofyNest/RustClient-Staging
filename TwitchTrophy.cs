public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	// Fields
	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x966F0 Offset: 0x95AF0 VA: 0x1800966F0
	public GameObjectRef DialogPrefab; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x4D4EF0 Offset: 0x4D34F0 VA: 0x1804D4EF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x96790 Offset: 0x95B90 VA: 0x180096790
	[BaseEntity.Menu.Description] // RVA: 0x96790 Offset: 0x95B90 VA: 0x180096790
	[BaseEntity.Menu.Icon] // RVA: 0x96790 Offset: 0x95B90 VA: 0x180096790
	// RVA: 0x4D5170 Offset: 0x4D3770 VA: 0x1804D5170
	public void Menu_OpenTrophy(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}
