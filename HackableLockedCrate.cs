public class HackableLockedCrate : LootContainer // TypeDefIndex: 8396
{	private Option __menuOption_Menu_Hack; // 0x418
	public const BaseEntity.Flags Flag_Hacking = 128;
	public const BaseEntity.Flags Flag_FullyHacked = 256;
	public Text timerText; // 0x470
	[ServerVar] // RVA: 0xE6740 Offset: 0xE5B40 VA: 0x1800E6740
	public static float requiredHackSeconds; // 0x0
	[ServerVar] // RVA: 0xE67C0 Offset: 0xE5BC0 VA: 0x1800E67C0
	public static float decaySeconds; // 0x4
	public SoundPlayer hackProgressBeep; // 0x478
	private float hackSeconds; // 0x480
	public GameObjectRef shockEffect; // 0x488
	public GameObjectRef mapMarkerEntityPrefab; // 0x490
	public GameObjectRef landEffect; // 0x498
	public bool shouldDecay; // 0x4A0
	private int beepSeconds; // 0x4A4

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsBeingHacked() { }

	public bool IsFullyHacked() { }

	public override void DestroyShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void UpdateHackProgress(int totalSecondsComplete, int totalSecondsRequired) { }

	public override void PostNetworkUpdate() { }

	public void HackScreenUpdate() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE6A30 Offset: 0xE5E30 VA: 0x1800E6A30
	[BaseEntity.Menu.Description] // RVA: 0xE6A30 Offset: 0xE5E30 VA: 0x1800E6A30
	[BaseEntity.Menu.Icon] // RVA: 0xE6A30 Offset: 0xE5E30 VA: 0x1800E6A30
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6A30 Offset: 0xE5E30 VA: 0x1800E6A30
	public void Menu_Hack(BasePlayer player) { }

	public bool Menu_Hack_ShowIf(BasePlayer player) { }

	public override float GetExtrapolationTime() { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

