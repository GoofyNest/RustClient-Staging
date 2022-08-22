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

	// RVA: 0x8CE810 Offset: 0x8CCE10 VA: 0x1808CE810 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8CEFB0 Offset: 0x8CD5B0 VA: 0x1808CEFB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8CEC30 Offset: 0x8CD230 VA: 0x1808CEC30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0
	public bool IsPowered() { }

	// RVA: 0x8CEB10 Offset: 0x8CD110 VA: 0x1808CEB10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	[BaseEntity.Menu.Description] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	[BaseEntity.Menu.Icon] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF930 Offset: 0xDED30 VA: 0x1800DF930
	// RVA: 0x8CEBE0 Offset: 0x8CD1E0 VA: 0x1808CEBE0
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x8CEC20 Offset: 0x8CD220 VA: 0x1808CEC20
	public bool Menu_Request_Supplies_ShowIf(BasePlayer player) { }

	// RVA: 0x8CED20 Offset: 0x8CD320 VA: 0x1808CED20 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

	// RVA: 0x8CEEE0 Offset: 0x8CD4E0 VA: 0x1808CEEE0
	private static void .cctor() { }

}

