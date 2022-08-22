public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x966E0 Offset: 0x95AE0 VA: 0x1800966E0
	public GameObjectRef DialogPrefab; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x967D0 Offset: 0x95BD0 VA: 0x1800967D0
	[BaseEntity.Menu.Description] // RVA: 0x967D0 Offset: 0x95BD0 VA: 0x1800967D0
	[BaseEntity.Menu.Icon] // RVA: 0x967D0 Offset: 0x95BD0 VA: 0x1800967D0
	public void Menu_OpenTrophy(BasePlayer player) { }

	public void .ctor() { }

}

