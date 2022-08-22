public class MountableParentCombatEntity : BaseCombatEntity // TypeDefIndex: 8423
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
	private BaseMountable mountable; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }
	private BaseMountable Mountable { get; }

	// Methods

	// RVA: 0x7B9B20 Offset: 0x7B8120 VA: 0x1807B9B20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B9F20 Offset: 0x7B8520 VA: 0x1807B9F20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B9FE0 Offset: 0x7B85E0 VA: 0x1807B9FE0
	private BaseMountable get_Mountable() { }

	[BaseEntity.Menu] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Description] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Icon] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	// RVA: 0x7B9EF0 Offset: 0x7B84F0 VA: 0x1807B9EF0
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0x7B9E30 Offset: 0x7B8430 VA: 0x1807B9E30
	public bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

