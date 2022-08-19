public class AdventCalendar : BaseCombatEntity // TypeDefIndex: 8304
{	// Fields
	private Option __menuOption_Menu_OpenCalendar; // 0x240
	public int startMonth; // 0x298
	public int startDay; // 0x29C
	public AdventCalendar.DayReward[] days; // 0x2A0
	public GameObject[] crosses; // 0x2A8
	public static List<AdventCalendar> all; // 0x0
	public static Dictionary<ulong, List<int>> playerRewardHistory; // 0x8
	public static readonly Translate.Phrase CheckLater; // 0x10
	public static readonly Translate.Phrase EventOver; // 0x18
	public GameObjectRef giftEffect; // 0x2B0
	public GameObjectRef boxCloseEffect; // 0x2B8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAA2070 Offset: 0xAA0670 VA: 0x180AA2070 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAA25B0 Offset: 0xAA0BB0 VA: 0x180AA25B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAA2390 Offset: 0xAA0990 VA: 0x180AA2390 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB0280 Offset: 0xAF680 VA: 0x1800B0280
	[BaseEntity.Menu.Description] // RVA: 0xB0280 Offset: 0xAF680 VA: 0x1800B0280
	[BaseEntity.Menu.Icon] // RVA: 0xB0280 Offset: 0xAF680 VA: 0x1800B0280
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0280 Offset: 0xAF680 VA: 0x1800B0280
	// RVA: 0xAA2350 Offset: 0xAA0950 VA: 0x180AA2350
	public void Menu_OpenCalendar(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_OpenCalendar_ShowIf(BasePlayer player) { }

	// RVA: 0xAA1FE0 Offset: 0xAA05E0 VA: 0x180AA1FE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAA1ED0 Offset: 0xAA04D0 VA: 0x180AA1ED0
	public void CheckCrosses() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

	// RVA: 0xAA2480 Offset: 0xAA0A80 VA: 0x180AA2480
	private static void .cctor() { }

}

public class AdventCalendar.DayReward // TypeDefIndex: 8305
{	// Fields
	public ItemAmount[] rewards; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

