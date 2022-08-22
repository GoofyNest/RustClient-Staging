public class BaseLock : BaseEntity // TypeDefIndex: 8327
{	// Fields
	private Option __menuOption_Menu_RemoveLock; // 0x168
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemType; // 0x1C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA45240 Offset: 0xA43840 VA: 0x180A45240 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA456D0 Offset: 0xA43CD0 VA: 0x180A456D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA45580 Offset: 0xA43B80 VA: 0x180A45580 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	[BaseEntity.Menu.Description] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	[BaseEntity.Menu.Icon] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	[BaseEntity.Menu.ShowIf] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	// RVA: 0xA45540 Offset: 0xA43B40 VA: 0x180A45540
	public void Menu_RemoveLock(BasePlayer player) { }

	// RVA: 0x680E50 Offset: 0x67F450 VA: 0x180680E50
	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	// RVA: 0xA45140 Offset: 0xA43740 VA: 0x180A45140 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7C4280 Offset: 0x7C2880 VA: 0x1807C4280 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xA45670 Offset: 0xA43C70 VA: 0x180A45670
	public void .ctor() { }

}

