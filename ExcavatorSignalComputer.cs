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

	// RVA: 0x8CE1F0 Offset: 0x8CC7F0 VA: 0x1808CE1F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8CE990 Offset: 0x8CCF90 VA: 0x1808CE990 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8CE610 Offset: 0x8CCC10 VA: 0x1808CE610 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool IsPowered() { }

	// RVA: 0x8CE4F0 Offset: 0x8CCAF0 VA: 0x1808CE4F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDF8B0 Offset: 0xDECB0 VA: 0x1800DF8B0
	[BaseEntity.Menu.Description] // RVA: 0xDF8B0 Offset: 0xDECB0 VA: 0x1800DF8B0
	[BaseEntity.Menu.Icon] // RVA: 0xDF8B0 Offset: 0xDECB0 VA: 0x1800DF8B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF8B0 Offset: 0xDECB0 VA: 0x1800DF8B0
	// RVA: 0x8CE5C0 Offset: 0x8CCBC0 VA: 0x1808CE5C0
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x8CE600 Offset: 0x8CCC00 VA: 0x1808CE600
	public bool Menu_Request_Supplies_ShowIf(BasePlayer player) { }

	// RVA: 0x8CE700 Offset: 0x8CCD00 VA: 0x1808CE700 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

	// RVA: 0x8CE8C0 Offset: 0x8CCEC0 VA: 0x1808CE8C0
	private static void .cctor() { }

}

