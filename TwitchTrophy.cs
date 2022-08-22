public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	// Fields
	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x966E0 Offset: 0x95AE0 VA: 0x1800966E0
	public GameObjectRef DialogPrefab; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x4D4E80 Offset: 0x4D3480 VA: 0x1804D4E80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x967D0 Offset: 0x95BD0 VA: 0x1800967D0
	[BaseEntity.Menu.Description] // RVA: 0x967D0 Offset: 0x95BD0 VA: 0x1800967D0
	[BaseEntity.Menu.Icon] // RVA: 0x967D0 Offset: 0x95BD0 VA: 0x1800967D0
	// RVA: 0x4D5100 Offset: 0x4D3700 VA: 0x1804D5100
	public void Menu_OpenTrophy(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

