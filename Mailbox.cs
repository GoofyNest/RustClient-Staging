public class Mailbox : StorageContainer // TypeDefIndex: 8408
{	// Fields
	private Option __menuOption_Full; // 0x3D0
	public string ownerPanel; // 0x428
	public GameObjectRef mailDropSound; // 0x430
	public ItemDefinition[] allowedItems; // 0x438
	public bool autoSubmitWhenClosed; // 0x440
	public bool shouldMarkAsFull; // 0x441

	// Properties
	public override bool HasMenuOptions { get; }
	public int mailInputSlot { get; }

	// Methods

	// RVA: 0x55BC20 Offset: 0x55A220 VA: 0x18055BC20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x55C2A0 Offset: 0x55A8A0 VA: 0x18055C2A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x55BFF0 Offset: 0x55A5F0 VA: 0x18055BFF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x55C3A0 Offset: 0x55A9A0 VA: 0x18055C3A0
	public int get_mailInputSlot() { }

	// RVA: 0x55C0E0 Offset: 0x55A6E0 VA: 0x18055C0E0 Slot: 155
	public virtual bool PlayerIsOwner(BasePlayer player) { }

	// RVA: 0x55BFA0 Offset: 0x55A5A0 VA: 0x18055BFA0
	public bool IsFull() { }

	// RVA: 0x55BFC0 Offset: 0x55A5C0 VA: 0x18055BFC0
	public void MarkFull(bool full) { }

	[BaseEntity.Menu] // RVA: 0xECF60 Offset: 0xEC360 VA: 0x1800ECF60
	[BaseEntity.Menu.Description] // RVA: 0xECF60 Offset: 0xEC360 VA: 0x1800ECF60
	[BaseEntity.Menu.Icon] // RVA: 0xECF60 Offset: 0xEC360 VA: 0x1800ECF60
	[BaseEntity.Menu.ShowIf] // RVA: 0xECF60 Offset: 0xEC360 VA: 0x1800ECF60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Full(BasePlayer player) { }

	// RVA: 0x55BBC0 Offset: 0x55A1C0 VA: 0x18055BBC0
	public bool Full_ShowIf(BasePlayer player) { }

	// RVA: 0x55C100 Offset: 0x55A700 VA: 0x18055C100 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x55C200 Offset: 0x55A800 VA: 0x18055C200
	public void TrySubmit() { }

	// RVA: 0x55BF60 Offset: 0x55A560 VA: 0x18055BF60 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x55C240 Offset: 0x55A840 VA: 0x18055C240
	public void .ctor() { }

}

