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

	// RVA: 0x99C9E0 Offset: 0x99AFE0 VA: 0x18099C9E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x99DCB0 Offset: 0x99C2B0 VA: 0x18099DCB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x99D5C0 Offset: 0x99BBC0 VA: 0x18099D5C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool DisplayPassthrough() { }

	// RVA: 0x99C960 Offset: 0x99AF60 VA: 0x18099C960
	public bool DisplayCounter() { }

	// RVA: 0x99C7A0 Offset: 0x99ADA0 VA: 0x18099C7A0
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x99D1E0 Offset: 0x99B7E0 VA: 0x18099D1E0
	public int GetTarget() { }

	// RVA: 0x99D730 Offset: 0x99BD30 VA: 0x18099D730 Slot: 27
	public override void ResetState() { }

	// RVA: 0x99D1F0 Offset: 0x99B7F0 VA: 0x18099D1F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x99D980 Offset: 0x99BF80 VA: 0x18099D980
	public void UpdateNumber(int newNumber) { }

	// RVA: 0x99DA40 Offset: 0x99C040 VA: 0x18099DA40
	public void Update() { }

	// RVA: 0x99C8C0 Offset: 0x99AEC0 VA: 0x18099C8C0
	public void DelayedNumberChange() { }

	// RVA: 0x99C980 Offset: 0x99AF80 VA: 0x18099C980
	public Color GetColor() { }

	// RVA: 0x99D8D0 Offset: 0x99BED0 VA: 0x18099D8D0
	public void UpdateColor() { }

	// RVA: 0x99C820 Offset: 0x99AE20 VA: 0x18099C820 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x99D6B0 Offset: 0x99BCB0 VA: 0x18099D6B0 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.Menu] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	[BaseEntity.Menu.Description] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	[BaseEntity.Menu.Icon] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CA60 Offset: 0x7BE60 VA: 0x18007CA60
	// RVA: 0x99D570 Offset: 0x99BB70 VA: 0x18099D570
	public void Menu_ShowPassthrough(BasePlayer player) { }

	// RVA: 0x99C960 Offset: 0x99AF60 VA: 0x18099C960
	public bool Menu_Passthrough_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	[BaseEntity.Menu.Description] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	[BaseEntity.Menu.Icon] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	// RVA: 0x99D520 Offset: 0x99BB20 VA: 0x18099D520
	public void Menu_ShowCounter(BasePlayer player) { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool Menu_Counter_ShowIf(BasePlayer player) { }

	// RVA: 0x99D770 Offset: 0x99BD70 VA: 0x18099D770
	public void SendNewTarget(int newTarget) { }

	[BaseEntity.Menu] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	[BaseEntity.Menu.Description] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	[BaseEntity.Menu.Icon] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D060 Offset: 0x7C460 VA: 0x18007D060
	// RVA: 0x99D310 Offset: 0x99B910 VA: 0x18099D310
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x99D270 Offset: 0x99B870 VA: 0x18099D270
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	// RVA: 0x99DC40 Offset: 0x99C240 VA: 0x18099DC40
	public void .ctor() { }

}

