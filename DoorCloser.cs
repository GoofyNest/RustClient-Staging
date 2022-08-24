public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7740 Offset: 0xA6B40 VA: 0x1800A7740
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override float BoundsPadding() { }

	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xDA140 Offset: 0xD9540 VA: 0x1800DA140
	[BaseEntity.Menu.Description] // RVA: 0xDA140 Offset: 0xD9540 VA: 0x1800DA140
	[BaseEntity.Menu.Icon] // RVA: 0xDA140 Offset: 0xD9540 VA: 0x1800DA140
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA140 Offset: 0xD9540 VA: 0x1800DA140
	public void Menu_Remove(BasePlayer player) { }

	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

