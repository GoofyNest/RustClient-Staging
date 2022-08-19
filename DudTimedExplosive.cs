public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable // TypeDefIndex: 8384
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x1B8
	public GameObjectRef fizzleEffect; // 0x210
	public GameObject wickSpark; // 0x218
	public AudioSource wickSound; // 0x220
	public float dudChance; // 0x228
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition itemToGive; // 0x230
	private float explodeTime; // 0x238

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAB2E50 Offset: 0xAB1450 VA: 0x180AB2E50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAB3610 Offset: 0xAB1C10 VA: 0x180AB3610 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAB3260 Offset: 0xAB1860 VA: 0x180AB3260 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	private bool IsWickBurning() { }

	// RVA: 0xAB3150 Offset: 0xAB1750 VA: 0x180AB3150 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAB3350 Offset: 0xAB1950 VA: 0x180AB3350
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDA3A0 Offset: 0xD97A0 VA: 0x1800DA3A0
	[BaseEntity.Menu.Description] // RVA: 0xDA3A0 Offset: 0xD97A0 VA: 0x1800DA3A0
	[BaseEntity.Menu.Icon] // RVA: 0xDA3A0 Offset: 0xD97A0 VA: 0x1800DA3A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA3A0 Offset: 0xD97A0 VA: 0x1800DA3A0
	// RVA: 0xAB3220 Offset: 0xAB1820 VA: 0x180AB3220
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0xAB35F0 Offset: 0xAB1BF0 VA: 0x180AB35F0
	public void .ctor() { }

}

