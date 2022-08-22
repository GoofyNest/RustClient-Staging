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

	// RVA: 0xAB35E0 Offset: 0xAB1BE0 VA: 0x180AB35E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAB3DA0 Offset: 0xAB23A0 VA: 0x180AB3DA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAB39F0 Offset: 0xAB1FF0 VA: 0x180AB39F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	private bool IsWickBurning() { }

	// RVA: 0xAB38E0 Offset: 0xAB1EE0 VA: 0x180AB38E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAB3AE0 Offset: 0xAB20E0 VA: 0x180AB3AE0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.Description] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.Icon] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	// RVA: 0xAB39B0 Offset: 0xAB1FB0 VA: 0x180AB39B0
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x50DEE0 Offset: 0x50C4E0 VA: 0x18050DEE0
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0xAB3D80 Offset: 0xAB2380 VA: 0x180AB3D80
	public void .ctor() { }

}

