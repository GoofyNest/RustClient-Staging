public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	// Fields
	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAAC7C0 Offset: 0xAAADC0 VA: 0x180AAC7C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAACE00 Offset: 0xAAB400 VA: 0x180AACE00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAACCB0 Offset: 0xAAB2B0 VA: 0x180AACCB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xAAC730 Offset: 0xAAAD30 VA: 0x180AAC730
	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Description] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Icon] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	// RVA: 0xAACC70 Offset: 0xAAB270 VA: 0x180AACC70
	public void Menu_Remove(BasePlayer player) { }

	// RVA: 0xAACAD0 Offset: 0xAAB0D0 VA: 0x180AACAD0
	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	// RVA: 0xAACDA0 Offset: 0xAAB3A0 VA: 0x180AACDA0
	public void .ctor() { }

}

