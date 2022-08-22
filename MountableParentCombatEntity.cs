public class MountableParentCombatEntity : BaseCombatEntity // TypeDefIndex: 8423
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
	private BaseMountable mountable; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }
	private BaseMountable Mountable { get; }

	// Methods

	// RVA: 0x7D7F10 Offset: 0x7D6510 VA: 0x1807D7F10 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D8310 Offset: 0x7D6910 VA: 0x1807D8310 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D83D0 Offset: 0x7D69D0 VA: 0x1807D83D0
	private BaseMountable get_Mountable() { }

	[BaseEntity.Menu] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Description] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Icon] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	// RVA: 0x7D82E0 Offset: 0x7D68E0 VA: 0x1807D82E0
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0x7D8220 Offset: 0x7D6820 VA: 0x1807D8220
	public bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

