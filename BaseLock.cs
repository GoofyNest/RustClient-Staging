public class BaseLock : BaseEntity // TypeDefIndex: 8327
{	// Fields
	private Option __menuOption_Menu_RemoveLock; // 0x168
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition itemType; // 0x1C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA44A90 Offset: 0xA43090 VA: 0x180A44A90 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA44F20 Offset: 0xA43520 VA: 0x180A44F20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA44DD0 Offset: 0xA433D0 VA: 0x180A44DD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB8860 Offset: 0xB7C60 VA: 0x1800B8860
	[BaseEntity.Menu.Description] // RVA: 0xB8860 Offset: 0xB7C60 VA: 0x1800B8860
	[BaseEntity.Menu.Icon] // RVA: 0xB8860 Offset: 0xB7C60 VA: 0x1800B8860
	[BaseEntity.Menu.ShowIf] // RVA: 0xB8860 Offset: 0xB7C60 VA: 0x1800B8860
	// RVA: 0xA44D90 Offset: 0xA43390 VA: 0x180A44D90
	public void Menu_RemoveLock(BasePlayer player) { }

	// RVA: 0x680EC0 Offset: 0x67F4C0 VA: 0x180680EC0
	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	// RVA: 0xA44990 Offset: 0xA42F90 VA: 0x180A44990 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7A5D70 Offset: 0x7A4370 VA: 0x1807A5D70 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xA44EC0 Offset: 0xA434C0 VA: 0x180A44EC0
	public void .ctor() { }

}

