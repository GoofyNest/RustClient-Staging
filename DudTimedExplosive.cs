public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable // TypeDefIndex: 8384
{	private Option __menuOption_Menu_Pickup; // 0x1B8
	public GameObjectRef fizzleEffect; // 0x210
	public GameObject wickSpark; // 0x218
	public AudioSource wickSound; // 0x220
	public float dudChance; // 0x228
	[ItemSelector] // RVA: 0xA7740 Offset: 0xA6B40 VA: 0x1800A7740
	public ItemDefinition itemToGive; // 0x230
	private float explodeTime; // 0x238

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private bool IsWickBurning() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDA570 Offset: 0xD9970 VA: 0x1800DA570
	[BaseEntity.Menu.Description] // RVA: 0xDA570 Offset: 0xD9970 VA: 0x1800DA570
	[BaseEntity.Menu.Icon] // RVA: 0xDA570 Offset: 0xD9970 VA: 0x1800DA570
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA570 Offset: 0xD9970 VA: 0x1800DA570
	public void Menu_Pickup(BasePlayer player) { }

	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

