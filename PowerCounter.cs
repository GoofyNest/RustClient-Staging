public class PowerCounter : IOEntity // TypeDefIndex: 8428
{	// Fields
	private Option __menuOption_Menu_SetTarget; // 0x288
	private Option __menuOption_Menu_ShowCounter; // 0x2E0
	private Option __menuOption_Menu_ShowPassthrough; // 0x338
	private int counterNumber; // 0x390
	private int targetCounterNumber; // 0x394
	public Canvas canvas; // 0x398
	public CanvasGroup screenAlpha; // 0x3A0
	public Text screenText; // 0x3A8
	public const BaseEntity.Flags Flag_ShowPassthrough = 256;
	public GameObjectRef counterConfigPanel; // 0x3B0
	public Color passthroughColor; // 0x3B8
	public Color counterColor; // 0x3C8
	private int client_counterNumber; // 0x3D8
	private int client_passthrough; // 0x3DC
	private float nextScreenVisTime; // 0x3E0
	private int pendingNumberChange; // 0x3E4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x99CED0 Offset: 0x99B4D0 VA: 0x18099CED0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x99E1A0 Offset: 0x99C7A0 VA: 0x18099E1A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x99DAB0 Offset: 0x99C0B0 VA: 0x18099DAB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	public bool DisplayPassthrough() { }

	// RVA: 0x99CE50 Offset: 0x99B450 VA: 0x18099CE50
	public bool DisplayCounter() { }

	// RVA: 0x99CC90 Offset: 0x99B290 VA: 0x18099CC90
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x99D6D0 Offset: 0x99BCD0 VA: 0x18099D6D0
	public int GetTarget() { }

	// RVA: 0x99DC20 Offset: 0x99C220 VA: 0x18099DC20 Slot: 27
	public override void ResetState() { }

	// RVA: 0x99D6E0 Offset: 0x99BCE0 VA: 0x18099D6E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x99DE70 Offset: 0x99C470 VA: 0x18099DE70
	public void UpdateNumber(int newNumber) { }

	// RVA: 0x99DF30 Offset: 0x99C530 VA: 0x18099DF30
	public void Update() { }

	// RVA: 0x99CDB0 Offset: 0x99B3B0 VA: 0x18099CDB0
	public void DelayedNumberChange() { }

	// RVA: 0x99CE70 Offset: 0x99B470 VA: 0x18099CE70
	public Color GetColor() { }

	// RVA: 0x99DDC0 Offset: 0x99C3C0 VA: 0x18099DDC0
	public void UpdateColor() { }

	// RVA: 0x99CD10 Offset: 0x99B310 VA: 0x18099CD10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x99DBA0 Offset: 0x99C1A0 VA: 0x18099DBA0 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.Menu] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	[BaseEntity.Menu.Description] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	[BaseEntity.Menu.Icon] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	// RVA: 0x99DA60 Offset: 0x99C060 VA: 0x18099DA60
	public void Menu_ShowPassthrough(BasePlayer player) { }

	// RVA: 0x99CE50 Offset: 0x99B450 VA: 0x18099CE50
	public bool Menu_Passthrough_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	[BaseEntity.Menu.Description] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	[BaseEntity.Menu.Icon] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	// RVA: 0x99DA10 Offset: 0x99C010 VA: 0x18099DA10
	public void Menu_ShowCounter(BasePlayer player) { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	public bool Menu_Counter_ShowIf(BasePlayer player) { }

	// RVA: 0x99DC60 Offset: 0x99C260 VA: 0x18099DC60
	public void SendNewTarget(int newTarget) { }

	[BaseEntity.Menu] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	[BaseEntity.Menu.Description] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	[BaseEntity.Menu.Icon] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	// RVA: 0x99D800 Offset: 0x99BE00 VA: 0x18099D800
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x99D760 Offset: 0x99BD60 VA: 0x18099D760
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	// RVA: 0x99E130 Offset: 0x99C730 VA: 0x18099E130
	public void .ctor() { }

}

