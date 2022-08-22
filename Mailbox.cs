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

	// RVA: 0x55BBB0 Offset: 0x55A1B0 VA: 0x18055BBB0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x55C230 Offset: 0x55A830 VA: 0x18055C230 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x55BF80 Offset: 0x55A580 VA: 0x18055BF80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x55C330 Offset: 0x55A930 VA: 0x18055C330
	public int get_mailInputSlot() { }

	// RVA: 0x55C070 Offset: 0x55A670 VA: 0x18055C070 Slot: 155
	public virtual bool PlayerIsOwner(BasePlayer player) { }

	// RVA: 0x55BF30 Offset: 0x55A530 VA: 0x18055BF30
	public bool IsFull() { }

	// RVA: 0x55BF50 Offset: 0x55A550 VA: 0x18055BF50
	public void MarkFull(bool full) { }

	[BaseEntity.Menu] // RVA: 0xED010 Offset: 0xEC410 VA: 0x1800ED010
	[BaseEntity.Menu.Description] // RVA: 0xED010 Offset: 0xEC410 VA: 0x1800ED010
	[BaseEntity.Menu.Icon] // RVA: 0xED010 Offset: 0xEC410 VA: 0x1800ED010
	[BaseEntity.Menu.ShowIf] // RVA: 0xED010 Offset: 0xEC410 VA: 0x1800ED010
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Full(BasePlayer player) { }

	// RVA: 0x55BB50 Offset: 0x55A150 VA: 0x18055BB50
	public bool Full_ShowIf(BasePlayer player) { }

	// RVA: 0x55C090 Offset: 0x55A690 VA: 0x18055C090 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x55C190 Offset: 0x55A790 VA: 0x18055C190
	public void TrySubmit() { }

	// RVA: 0x55BEF0 Offset: 0x55A4F0 VA: 0x18055BEF0 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x55C1D0 Offset: 0x55A7D0 VA: 0x18055C1D0
	public void .ctor() { }

}

