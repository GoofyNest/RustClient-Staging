public class HackableLockedCrate : LootContainer // TypeDefIndex: 8396
{	// Fields
	private Option __menuOption_Menu_Hack; // 0x418
	public const BaseEntity.Flags Flag_Hacking = 128;
	public const BaseEntity.Flags Flag_FullyHacked = 256;
	public Text timerText; // 0x470
	[ServerVar] // RVA: 0xE65D0 Offset: 0xE59D0 VA: 0x1800E65D0
	public static float requiredHackSeconds; // 0x0
	[ServerVar] // RVA: 0xE66A0 Offset: 0xE5AA0 VA: 0x1800E66A0
	public static float decaySeconds; // 0x4
	public SoundPlayer hackProgressBeep; // 0x478
	private float hackSeconds; // 0x480
	public GameObjectRef shockEffect; // 0x488
	public GameObjectRef mapMarkerEntityPrefab; // 0x490
	public GameObjectRef landEffect; // 0x498
	public bool shouldDecay; // 0x4A0
	private int beepSeconds; // 0x4A4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x733380 Offset: 0x731980 VA: 0x180733380 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x734140 Offset: 0x732740 VA: 0x180734140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x733A90 Offset: 0x732090 VA: 0x180733A90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsBeingHacked() { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	public bool IsFullyHacked() { }

	// RVA: 0x6D3240 Offset: 0x6D1840 VA: 0x1806D3240 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x734010 Offset: 0x732610 VA: 0x180734010
	public void UpdateHackProgress(int totalSecondsComplete, int totalSecondsRequired) { }

	// RVA: 0x5B1260 Offset: 0x5AF860 VA: 0x1805B1260 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x733690 Offset: 0x731C90 VA: 0x180733690
	public void HackScreenUpdate() { }

	// RVA: 0x733F60 Offset: 0x732560 VA: 0x180733F60 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE6910 Offset: 0xE5D10 VA: 0x1800E6910
	[BaseEntity.Menu.Description] // RVA: 0xE6910 Offset: 0xE5D10 VA: 0x1800E6910
	[BaseEntity.Menu.Icon] // RVA: 0xE6910 Offset: 0xE5D10 VA: 0x1800E6910
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6910 Offset: 0xE5D10 VA: 0x1800E6910
	// RVA: 0x733A50 Offset: 0x732050 VA: 0x180733A50
	public void Menu_Hack(BasePlayer player) { }

	// RVA: 0x733990 Offset: 0x731F90 VA: 0x180733990
	public bool Menu_Hack_ShowIf(BasePlayer player) { }

	// RVA: 0x7332F0 Offset: 0x7318F0 VA: 0x1807332F0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x733240 Offset: 0x731840 VA: 0x180733240 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x734130 Offset: 0x732730 VA: 0x180734130
	public void .ctor() { }

	// RVA: 0x7340E0 Offset: 0x7326E0 VA: 0x1807340E0
	private static void .cctor() { }

}

