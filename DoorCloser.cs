public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	// Fields
	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAACC90 Offset: 0xAAB290 VA: 0x180AACC90 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAAD2D0 Offset: 0xAAB8D0 VA: 0x180AAD2D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAD180 Offset: 0xAAB780 VA: 0x180AAD180 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xAACC00 Offset: 0xAAB200 VA: 0x180AACC00
	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Description] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Icon] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	// RVA: 0xAAD140 Offset: 0xAAB740 VA: 0x180AAD140
	public void Menu_Remove(BasePlayer player) { }

	// RVA: 0xAACFA0 Offset: 0xAAB5A0 VA: 0x180AACFA0
	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	// RVA: 0xAAD270 Offset: 0xAAB870 VA: 0x180AAD270
	public void .ctor() { }

}

