public class MountableParentCombatEntity : BaseCombatEntity // TypeDefIndex: 8423
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
	private BaseMountable mountable; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }
	private BaseMountable Mountable { get; }

	// Methods

	// RVA: 0x7B9A10 Offset: 0x7B8010 VA: 0x1807B9A10 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B9E10 Offset: 0x7B8410 VA: 0x1807B9E10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B9ED0 Offset: 0x7B84D0 VA: 0x1807B9ED0
	private BaseMountable get_Mountable() { }

	[BaseEntity.Menu] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Description] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Icon] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	// RVA: 0x7B9DE0 Offset: 0x7B83E0 VA: 0x1807B9DE0
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0x7B9D20 Offset: 0x7B8320 VA: 0x1807B9D20
	public bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

