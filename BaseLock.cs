public class BaseLock : BaseEntity // TypeDefIndex: 8327
{	// Fields
	private Option __menuOption_Menu_RemoveLock; // 0x168
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemType; // 0x1C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA44D50 Offset: 0xA43350 VA: 0x180A44D50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA451E0 Offset: 0xA437E0 VA: 0x180A451E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA45090 Offset: 0xA43690 VA: 0x180A45090 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	[BaseEntity.Menu.Description] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	[BaseEntity.Menu.Icon] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	[BaseEntity.Menu.ShowIf] // RVA: 0xB8900 Offset: 0xB7D00 VA: 0x1800B8900
	// RVA: 0xA45050 Offset: 0xA43650 VA: 0x180A45050
	public void Menu_RemoveLock(BasePlayer player) { }

	// RVA: 0x680EC0 Offset: 0x67F4C0 VA: 0x180680EC0
	public bool Menu_RemoveLock_ShowIf(BasePlayer player) { }

	// RVA: 0xA44C50 Offset: 0xA43250 VA: 0x180A44C50 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7A5E80 Offset: 0x7A4480 VA: 0x1807A5E80 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xA45180 Offset: 0xA43780 VA: 0x180A45180
	public void .ctor() { }

}

