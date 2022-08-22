public class ExcavatorSignalComputer : BaseCombatEntity // TypeDefIndex: 8391
{	// Fields
	private Option __menuOption_Menu_Press_TrainTunnel; // 0x240
	public float chargePower; // 0x298
	public const BaseEntity.Flags Flag_Ready = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public GameObjectRef supplyPlanePrefab; // 0x2A0
	public Transform[] dropPoints; // 0x2A8
	public Text statusText; // 0x2B0
	public Text timerText; // 0x2B8
	public static readonly Translate.Phrase readyphrase; // 0x0
	public static readonly Translate.Phrase chargephrase; // 0x8
	public static float client_chargeNeeded; // 0x10

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8CE300 Offset: 0x8CC900 VA: 0x1808CE300 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8CEAA0 Offset: 0x8CD0A0 VA: 0x1808CEAA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8CE720 Offset: 0x8CCD20 VA: 0x1808CE720 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool IsPowered() { }

	// RVA: 0x8CE600 Offset: 0x8CCC00 VA: 0x1808CE600 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	[BaseEntity.Menu.Description] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	[BaseEntity.Menu.Icon] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	// RVA: 0x8CE6D0 Offset: 0x8CCCD0 VA: 0x1808CE6D0
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x8CE710 Offset: 0x8CCD10 VA: 0x1808CE710
	public bool Menu_Request_Supplies_ShowIf(BasePlayer player) { }

	// RVA: 0x8CE810 Offset: 0x8CCE10 VA: 0x1808CE810 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

	// RVA: 0x8CE9D0 Offset: 0x8CCFD0 VA: 0x1808CE9D0
	private static void .cctor() { }

}

