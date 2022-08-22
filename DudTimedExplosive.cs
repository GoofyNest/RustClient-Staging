public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable // TypeDefIndex: 8384
{	private Option __menuOption_Menu_Pickup; // 0x1B8
	public GameObjectRef fizzleEffect; // 0x210
	public GameObject wickSpark; // 0x218
	public AudioSource wickSound; // 0x220
	public float dudChance; // 0x228
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemToGive; // 0x230
	private float explodeTime; // 0x238

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private bool IsWickBurning() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.Description] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.Icon] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	public void Menu_Pickup(BasePlayer player) { }

	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

