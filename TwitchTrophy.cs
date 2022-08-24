public class TwitchTrophy : BaseCombatEntity // TypeDefIndex: 8476
{	private Option __menuOption_Menu_OpenTrophy; // 0x240
	[HeaderAttribute] // RVA: 0x96910 Offset: 0x95D10 VA: 0x180096910
	public GameObjectRef DialogPrefab; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x969B0 Offset: 0x95DB0 VA: 0x1800969B0
	[BaseEntity.Menu.Description] // RVA: 0x969B0 Offset: 0x95DB0 VA: 0x1800969B0
	[BaseEntity.Menu.Icon] // RVA: 0x969B0 Offset: 0x95DB0 VA: 0x1800969B0
	public void Menu_OpenTrophy(BasePlayer player) { }

	public void .ctor() { }

}

