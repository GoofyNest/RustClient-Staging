public class HackableLockedCrate : LootContainer // TypeDefIndex: 8396
{	// Fields
	private Option __menuOption_Menu_Hack; // 0x418
	public const BaseEntity.Flags Flag_Hacking = 128;
	public const BaseEntity.Flags Flag_FullyHacked = 256;
	public Text timerText; // 0x470
	[ServerVar] // RVA: 0xE6510 Offset: 0xE5910 VA: 0x1800E6510
	public static float requiredHackSeconds; // 0x0
	[ServerVar] // RVA: 0xE6600 Offset: 0xE5A00 VA: 0x1800E6600
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

	// RVA: 0x733320 Offset: 0x731920 VA: 0x180733320 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7340E0 Offset: 0x7326E0 VA: 0x1807340E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x733A30 Offset: 0x732030 VA: 0x180733A30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsBeingHacked() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool IsFullyHacked() { }

	// RVA: 0x6D31A0 Offset: 0x6D17A0 VA: 0x1806D31A0 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x733FB0 Offset: 0x7325B0 VA: 0x180733FB0
	public void UpdateHackProgress(int totalSecondsComplete, int totalSecondsRequired) { }

	// RVA: 0x5B12D0 Offset: 0x5AF8D0 VA: 0x1805B12D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x733630 Offset: 0x731C30 VA: 0x180733630
	public void HackScreenUpdate() { }

	// RVA: 0x733F00 Offset: 0x732500 VA: 0x180733F00 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE6870 Offset: 0xE5C70 VA: 0x1800E6870
	[BaseEntity.Menu.Description] // RVA: 0xE6870 Offset: 0xE5C70 VA: 0x1800E6870
	[BaseEntity.Menu.Icon] // RVA: 0xE6870 Offset: 0xE5C70 VA: 0x1800E6870
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6870 Offset: 0xE5C70 VA: 0x1800E6870
	// RVA: 0x7339F0 Offset: 0x731FF0 VA: 0x1807339F0
	public void Menu_Hack(BasePlayer player) { }

	// RVA: 0x733930 Offset: 0x731F30 VA: 0x180733930
	public bool Menu_Hack_ShowIf(BasePlayer player) { }

	// RVA: 0x733290 Offset: 0x731890 VA: 0x180733290 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x7331E0 Offset: 0x7317E0 VA: 0x1807331E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7340D0 Offset: 0x7326D0 VA: 0x1807340D0
	public void .ctor() { }

	// RVA: 0x734080 Offset: 0x732680 VA: 0x180734080
	private static void .cctor() { }

}

