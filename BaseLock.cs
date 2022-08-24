public class BaseLock : BaseEntity // TypeDefIndex: 8327
{	private Option __menuOption_Menu_RemoveLock; // 0x168
	[ItemSelector] // RVA: 0xA7740 Offset: 0xA6B40 VA: 0x1800A7740
	public ItemDefinition itemType; // 0x1C0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB89E0 Offset: 0xB7DE0 VA: 0x1800B89E0
	[BaseEntity.Menu.Description] // RVA: 0xB89E0 Offset: 0xB7DE0 VA: 0x1800B89E0
	[BaseEntity.Menu.Icon] // RVA: 0xB89E0 Offset: 0xB7DE0 VA: 0x1800B89E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB89E0 Offset: 0xB7DE0 VA: 0x1800B89E0
	public void Menu_RemoveLock(BasePlayer player) { }

	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	public override List<Option> GetMenuItems(BasePlayer player) { }

	public override float BoundsPadding() { }

	public void .ctor() { }

}

