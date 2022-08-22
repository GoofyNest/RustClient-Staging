public class CollectableEasterEgg : BaseEntity // TypeDefIndex: 8374
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x168
	public Transform artwork; // 0x1C0
	public float bounceRange; // 0x1C8
	public float bounceSpeed; // 0x1CC
	public GameObjectRef pickupEffect; // 0x1D0
	public ItemDefinition itemToGive; // 0x1D8
	private float randOffset; // 0x1E0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x57BD40 Offset: 0x57A340 VA: 0x18057BD40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x57C3B0 Offset: 0x57A9B0 VA: 0x18057C3B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x57C0F0 Offset: 0x57A6F0 VA: 0x18057C0F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x57BC50 Offset: 0x57A250 VA: 0x18057BC50
	public void BasketPickup() { }

	// RVA: 0x57BD00 Offset: 0x57A300 VA: 0x18057BD00
	public void DelayedPickup() { }

	// RVA: 0x57BCC0 Offset: 0x57A2C0 VA: 0x18057BCC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x57C1E0 Offset: 0x57A7E0 VA: 0x18057C1E0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	[BaseEntity.Menu.Description] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	[BaseEntity.Menu.Icon] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	// RVA: 0x57C0B0 Offset: 0x57A6B0 VA: 0x18057C0B0
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x57C070 Offset: 0x57A670 VA: 0x18057C070
	public void Menu_Pickup_Start() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0x57C340 Offset: 0x57A940 VA: 0x18057C340
	public void .ctor() { }

}

