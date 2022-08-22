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

	// RVA: 0x57BCD0 Offset: 0x57A2D0 VA: 0x18057BCD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x57C340 Offset: 0x57A940 VA: 0x18057C340 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x57C080 Offset: 0x57A680 VA: 0x18057C080 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x57BBE0 Offset: 0x57A1E0 VA: 0x18057BBE0
	public void BasketPickup() { }

	// RVA: 0x57BC90 Offset: 0x57A290 VA: 0x18057BC90
	public void DelayedPickup() { }

	// RVA: 0x57BC50 Offset: 0x57A250 VA: 0x18057BC50 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x57C170 Offset: 0x57A770 VA: 0x18057C170
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	[BaseEntity.Menu.Description] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	[BaseEntity.Menu.Icon] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5D10 Offset: 0xD5110 VA: 0x1800D5D10
	// RVA: 0x57C040 Offset: 0x57A640 VA: 0x18057C040
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x57C000 Offset: 0x57A600 VA: 0x18057C000
	public void Menu_Pickup_Start() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0x57C2D0 Offset: 0x57A8D0 VA: 0x18057C2D0
	public void .ctor() { }

}

