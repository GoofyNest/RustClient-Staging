public class HBHFSensor : BaseDetector // TypeDefIndex: 8397
{	// Fields
	private Option __menuOption_Menu_ExcludeAuth; // 0x290
	private Option __menuOption_Menu_ExcludeOthers; // 0x2E8
	private Option __menuOption_Menu_IncludeAuth; // 0x340
	private Option __menuOption_Menu_IncludeOthers; // 0x398
	public GameObjectRef detectUp; // 0x3F0
	public GameObjectRef detectDown; // 0x3F8
	public const BaseEntity.Flags Flag_IncludeOthers = 256;
	public const BaseEntity.Flags Flag_IncludeAuthed = 512;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7320E0 Offset: 0x7306E0 VA: 0x1807320E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x732F40 Offset: 0x731540 VA: 0x180732F40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x732E50 Offset: 0x731450 VA: 0x180732E50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool ShouldIncludeAuthorized() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool ShouldIncludeOthers() { }

	[BaseEntity.Menu] // RVA: 0xE6B70 Offset: 0xE5F70 VA: 0x1800E6B70
	[BaseEntity.Menu.Description] // RVA: 0xE6B70 Offset: 0xE5F70 VA: 0x1800E6B70
	[BaseEntity.Menu.Icon] // RVA: 0xE6B70 Offset: 0xE5F70 VA: 0x1800E6B70
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6B70 Offset: 0xE5F70 VA: 0x1800E6B70
	// RVA: 0x732D40 Offset: 0x731340 VA: 0x180732D40
	public void Menu_IncludeAuth(BasePlayer player) { }

	// RVA: 0x732CD0 Offset: 0x7312D0 VA: 0x180732CD0
	public bool Menu_IncludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE6FC0 Offset: 0xE63C0 VA: 0x1800E6FC0
	[BaseEntity.Menu.Description] // RVA: 0xE6FC0 Offset: 0xE63C0 VA: 0x1800E6FC0
	[BaseEntity.Menu.Icon] // RVA: 0xE6FC0 Offset: 0xE63C0 VA: 0x1800E6FC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6FC0 Offset: 0xE63C0 VA: 0x1800E6FC0
	// RVA: 0x732BC0 Offset: 0x7311C0 VA: 0x180732BC0
	public void Menu_ExcludeAuth(BasePlayer player) { }

	// RVA: 0x732B50 Offset: 0x731150 VA: 0x180732B50
	public bool Menu_ExcludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7140 Offset: 0xE6540 VA: 0x1800E7140
	[BaseEntity.Menu.Description] // RVA: 0xE7140 Offset: 0xE6540 VA: 0x1800E7140
	[BaseEntity.Menu.Icon] // RVA: 0xE7140 Offset: 0xE6540 VA: 0x1800E7140
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7140 Offset: 0xE6540 VA: 0x1800E7140
	// RVA: 0x732E00 Offset: 0x731400 VA: 0x180732E00
	public void Menu_IncludeOthers(BasePlayer player) { }

	// RVA: 0x732D90 Offset: 0x731390 VA: 0x180732D90
	public bool Menu_IncludeOthers_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE73C0 Offset: 0xE67C0 VA: 0x1800E73C0
	[BaseEntity.Menu.Description] // RVA: 0xE73C0 Offset: 0xE67C0 VA: 0x1800E73C0
	[BaseEntity.Menu.Icon] // RVA: 0xE73C0 Offset: 0xE67C0 VA: 0x1800E73C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE73C0 Offset: 0xE67C0 VA: 0x1800E73C0
	// RVA: 0x732C80 Offset: 0x731280 VA: 0x180732C80
	public void Menu_ExcludeOthers(BasePlayer player) { }

	// RVA: 0x732C10 Offset: 0x731210 VA: 0x180732C10
	public bool Menu_ExcludeOthers_ShowIf(BasePlayer player) { }

	// RVA: 0x6899D0 Offset: 0x687FD0 VA: 0x1806899D0
	public void .ctor() { }

}

