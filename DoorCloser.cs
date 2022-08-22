public class DoorCloser : BaseEntity // TypeDefIndex: 8382
{	private Option __menuOption_Menu_Remove; // 0x168
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemType; // 0x1C0
	public float delay; // 0x1C8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override float BoundsPadding() { }

	public Door GetDoor() { }

	[BaseEntity.Menu] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Description] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.Icon] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA060 Offset: 0xD9460 VA: 0x1800DA060
	public void Menu_Remove(BasePlayer player) { }

	public bool Menu_Remove_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

