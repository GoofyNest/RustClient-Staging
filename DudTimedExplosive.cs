public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable // TypeDefIndex: 8384
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x1B8
	public GameObjectRef fizzleEffect; // 0x210
	public GameObject wickSpark; // 0x218
	public AudioSource wickSound; // 0x220
	public float dudChance; // 0x228
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemToGive; // 0x230
	private float explodeTime; // 0x238

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAB3110 Offset: 0xAB1710 VA: 0x180AB3110 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAB38D0 Offset: 0xAB1ED0 VA: 0x180AB38D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAB3520 Offset: 0xAB1B20 VA: 0x180AB3520 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	private bool IsWickBurning() { }

	// RVA: 0xAB3410 Offset: 0xAB1A10 VA: 0x180AB3410 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAB3610 Offset: 0xAB1C10 VA: 0x180AB3610
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.Description] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.Icon] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	// RVA: 0xAB34E0 Offset: 0xAB1AE0 VA: 0x180AB34E0
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0xAB38B0 Offset: 0xAB1EB0 VA: 0x180AB38B0
	public void .ctor() { }

}

