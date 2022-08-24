public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x967B0 Offset: 0x95BB0 VA: 0x1800967B0
	public GameObjectRef DialogPrefab; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	[BaseEntity.Menu.Description] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	[BaseEntity.Menu.Icon] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	public void Menu_OpenTrophy(BasePlayer player) { }

	public void .ctor() { }

}

