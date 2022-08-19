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

	// RVA: 0x99C8D0 Offset: 0x99AED0 VA: 0x18099C8D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x99DBA0 Offset: 0x99C1A0 VA: 0x18099DBA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x99D4B0 Offset: 0x99BAB0 VA: 0x18099D4B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool DisplayPassthrough() { }

	// RVA: 0x99C850 Offset: 0x99AE50 VA: 0x18099C850
	public bool DisplayCounter() { }

	// RVA: 0x99C690 Offset: 0x99AC90 VA: 0x18099C690
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x99D0D0 Offset: 0x99B6D0 VA: 0x18099D0D0
	public int GetTarget() { }

	// RVA: 0x99D620 Offset: 0x99BC20 VA: 0x18099D620 Slot: 27
	public override void ResetState() { }

	// RVA: 0x99D0E0 Offset: 0x99B6E0 VA: 0x18099D0E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x99D870 Offset: 0x99BE70 VA: 0x18099D870
	public void UpdateNumber(int newNumber) { }

	// RVA: 0x99D930 Offset: 0x99BF30 VA: 0x18099D930
	public void Update() { }

	// RVA: 0x99C7B0 Offset: 0x99ADB0 VA: 0x18099C7B0
	public void DelayedNumberChange() { }

	// RVA: 0x99C870 Offset: 0x99AE70 VA: 0x18099C870
	public Color GetColor() { }

	// RVA: 0x99D7C0 Offset: 0x99BDC0 VA: 0x18099D7C0
	public void UpdateColor() { }

	// RVA: 0x99C710 Offset: 0x99AD10 VA: 0x18099C710 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x99D5A0 Offset: 0x99BBA0 VA: 0x18099D5A0 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.Menu] // RVA: 0x7C990 Offset: 0x7BD90 VA: 0x18007C990
	[BaseEntity.Menu.Description] // RVA: 0x7C990 Offset: 0x7BD90 VA: 0x18007C990
	[BaseEntity.Menu.Icon] // RVA: 0x7C990 Offset: 0x7BD90 VA: 0x18007C990
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C990 Offset: 0x7BD90 VA: 0x18007C990
	// RVA: 0x99D460 Offset: 0x99BA60 VA: 0x18099D460
	public void Menu_ShowPassthrough(BasePlayer player) { }

	// RVA: 0x99C850 Offset: 0x99AE50 VA: 0x18099C850
	public bool Menu_Passthrough_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[BaseEntity.Menu.Description] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[BaseEntity.Menu.Icon] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CD70 Offset: 0x7C170 VA: 0x18007CD70
	// RVA: 0x99D410 Offset: 0x99BA10 VA: 0x18099D410
	public void Menu_ShowCounter(BasePlayer player) { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool Menu_Counter_ShowIf(BasePlayer player) { }

	// RVA: 0x99D660 Offset: 0x99BC60 VA: 0x18099D660
	public void SendNewTarget(int newTarget) { }

	[BaseEntity.Menu] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	[BaseEntity.Menu.Description] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	[BaseEntity.Menu.Icon] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	// RVA: 0x99D200 Offset: 0x99B800 VA: 0x18099D200
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x99D160 Offset: 0x99B760 VA: 0x18099D160
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	// RVA: 0x99DB30 Offset: 0x99C130 VA: 0x18099DB30
	public void .ctor() { }

}

