public class TimerSwitch : IOEntity // TypeDefIndex: 8466
{	// Fields
	private Option __menuOption_Menu_TurnOn; // 0x288
	public float timerLength; // 0x2E0
	public Transform timerDrum; // 0x2E8
	private float timePassed; // 0x2F0
	private float oldTimeFraction; // 0x2F4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x88B310 Offset: 0x889910 VA: 0x18088B310 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x88B9C0 Offset: 0x889FC0 VA: 0x18088B9C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x88B6D0 Offset: 0x889CD0 VA: 0x18088B6D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x88B620 Offset: 0x889C20 VA: 0x18088B620 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x88B7C0 Offset: 0x889DC0 VA: 0x18088B7C0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	[BaseEntity.Menu.Description] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	[BaseEntity.Menu.Icon] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	// RVA: 0x88B690 Offset: 0x889C90 VA: 0x18088B690
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x6C7A50 Offset: 0x6C6050 VA: 0x1806C7A50
	public bool Menu_Activate_ShowIf(BasePlayer player) { }

	// RVA: 0x88B950 Offset: 0x889F50 VA: 0x18088B950
	public void .ctor() { }

}

