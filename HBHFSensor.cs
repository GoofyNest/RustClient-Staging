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

	// RVA: 0x732140 Offset: 0x730740 VA: 0x180732140 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x732FA0 Offset: 0x7315A0 VA: 0x180732FA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x732EB0 Offset: 0x7314B0 VA: 0x180732EB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x50CBD0 Offset: 0x50B1D0 VA: 0x18050CBD0
	public bool ShouldIncludeAuthorized() { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	public bool ShouldIncludeOthers() { }

	[BaseEntity.Menu] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	[BaseEntity.Menu.Description] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	[BaseEntity.Menu.Icon] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	// RVA: 0x732DA0 Offset: 0x7313A0 VA: 0x180732DA0
	public void Menu_IncludeAuth(BasePlayer player) { }

	// RVA: 0x732D30 Offset: 0x731330 VA: 0x180732D30
	public bool Menu_IncludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	[BaseEntity.Menu.Description] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	[BaseEntity.Menu.Icon] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	// RVA: 0x732C20 Offset: 0x731220 VA: 0x180732C20
	public void Menu_ExcludeAuth(BasePlayer player) { }

	// RVA: 0x732BB0 Offset: 0x7311B0 VA: 0x180732BB0
	public bool Menu_ExcludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	[BaseEntity.Menu.Description] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	[BaseEntity.Menu.Icon] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	// RVA: 0x732E60 Offset: 0x731460 VA: 0x180732E60
	public void Menu_IncludeOthers(BasePlayer player) { }

	// RVA: 0x732DF0 Offset: 0x7313F0 VA: 0x180732DF0
	public bool Menu_IncludeOthers_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	[BaseEntity.Menu.Description] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	[BaseEntity.Menu.Icon] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	// RVA: 0x732CE0 Offset: 0x7312E0 VA: 0x180732CE0
	public void Menu_ExcludeOthers(BasePlayer player) { }

	// RVA: 0x732C70 Offset: 0x731270 VA: 0x180732C70
	public bool Menu_ExcludeOthers_ShowIf(BasePlayer player) { }

	// RVA: 0x689960 Offset: 0x687F60 VA: 0x180689960
	public void .ctor() { }

}

