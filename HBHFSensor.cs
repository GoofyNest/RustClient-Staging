public class HBHFSensor : BaseDetector // TypeDefIndex: 8397
{	private Option __menuOption_Menu_ExcludeAuth; // 0x290
	private Option __menuOption_Menu_ExcludeOthers; // 0x2E8
	private Option __menuOption_Menu_IncludeAuth; // 0x340
	private Option __menuOption_Menu_IncludeOthers; // 0x398
	public GameObjectRef detectUp; // 0x3F0
	public GameObjectRef detectDown; // 0x3F8
	public const BaseEntity.Flags Flag_IncludeOthers = 256;
	public const BaseEntity.Flags Flag_IncludeAuthed = 512;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool ShouldIncludeAuthorized() { }

	public bool ShouldIncludeOthers() { }

	[BaseEntity.Menu] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	[BaseEntity.Menu.Description] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	[BaseEntity.Menu.Icon] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6C10 Offset: 0xE6010 VA: 0x1800E6C10
	public void Menu_IncludeAuth(BasePlayer player) { }

	public bool Menu_IncludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	[BaseEntity.Menu.Description] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	[BaseEntity.Menu.Icon] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7060 Offset: 0xE6460 VA: 0x1800E7060
	public void Menu_ExcludeAuth(BasePlayer player) { }

	public bool Menu_ExcludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	[BaseEntity.Menu.Description] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	[BaseEntity.Menu.Icon] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE71E0 Offset: 0xE65E0 VA: 0x1800E71E0
	public void Menu_IncludeOthers(BasePlayer player) { }

	public bool Menu_IncludeOthers_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	[BaseEntity.Menu.Description] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	[BaseEntity.Menu.Icon] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7460 Offset: 0xE6860 VA: 0x1800E7460
	public void Menu_ExcludeOthers(BasePlayer player) { }

	public bool Menu_ExcludeOthers_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

