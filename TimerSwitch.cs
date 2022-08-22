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

	// RVA: 0x86E650 Offset: 0x86CC50 VA: 0x18086E650 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x86ED00 Offset: 0x86D300 VA: 0x18086ED00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x86EA10 Offset: 0x86D010 VA: 0x18086EA10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x86E960 Offset: 0x86CF60 VA: 0x18086E960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x86EB00 Offset: 0x86D100 VA: 0x18086EB00
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	[BaseEntity.Menu.Description] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	[BaseEntity.Menu.Icon] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x90AF0 Offset: 0x8FEF0 VA: 0x180090AF0
	// RVA: 0x86E9D0 Offset: 0x86CFD0 VA: 0x18086E9D0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x6C79E0 Offset: 0x6C5FE0 VA: 0x1806C79E0
	public bool Menu_Activate_ShowIf(BasePlayer player) { }

	// RVA: 0x86EC90 Offset: 0x86D290 VA: 0x18086EC90
	public void .ctor() { }

}

