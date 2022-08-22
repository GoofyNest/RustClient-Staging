public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	// Fields
	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAAC500 Offset: 0xAAAB00 VA: 0x180AAC500 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAACB40 Offset: 0xAAB140 VA: 0x180AACB40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAC9F0 Offset: 0xAAAFF0 VA: 0x180AAC9F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xAAC470 Offset: 0xAAAA70 VA: 0x180AAC470
	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Description] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Icon] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	// RVA: 0xAAC9B0 Offset: 0xAAAFB0 VA: 0x180AAC9B0
	public void Menu_Remove(BasePlayer player) { }

	// RVA: 0xAAC810 Offset: 0xAAAE10 VA: 0x180AAC810
	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	// RVA: 0xAACAE0 Offset: 0xAAB0E0 VA: 0x180AACAE0
	public void .ctor() { }

}

