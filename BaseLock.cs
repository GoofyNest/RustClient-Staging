public class BaseLock : BaseEntity // TypeDefIndex: 8327
{	private Option __menuOption_Menu_RemoveLock; // 0x168
	[ItemSelector] // RVA: 0xA77B0 Offset: 0xA6BB0 VA: 0x1800A77B0
	public ItemDefinition itemType; // 0x1C0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB89C0 Offset: 0xB7DC0 VA: 0x1800B89C0
	[BaseEntity.Menu.Description] // RVA: 0xB89C0 Offset: 0xB7DC0 VA: 0x1800B89C0
	[BaseEntity.Menu.Icon] // RVA: 0xB89C0 Offset: 0xB7DC0 VA: 0x1800B89C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB89C0 Offset: 0xB7DC0 VA: 0x1800B89C0
	public void Menu_RemoveLock(BasePlayer player) { }

	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	public override List<Option> GetMenuItems(BasePlayer player) { }

	public override float BoundsPadding() { }

	public void .ctor() { }

}

