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

	// RVA: 0x88B200 Offset: 0x889800 VA: 0x18088B200 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x88B8B0 Offset: 0x889EB0 VA: 0x18088B8B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x88B5C0 Offset: 0x889BC0 VA: 0x18088B5C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x88B510 Offset: 0x889B10 VA: 0x18088B510 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x88B6B0 Offset: 0x889CB0 VA: 0x18088B6B0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x90A70 Offset: 0x8FE70 VA: 0x180090A70
	[BaseEntity.Menu.Description] // RVA: 0x90A70 Offset: 0x8FE70 VA: 0x180090A70
	[BaseEntity.Menu.Icon] // RVA: 0x90A70 Offset: 0x8FE70 VA: 0x180090A70
	[BaseEntity.Menu.ShowIf] // RVA: 0x90A70 Offset: 0x8FE70 VA: 0x180090A70
	// RVA: 0x88B580 Offset: 0x889B80 VA: 0x18088B580
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x6C7940 Offset: 0x6C5F40 VA: 0x1806C7940
	public bool Menu_Activate_ShowIf(BasePlayer player) { }

	// RVA: 0x88B840 Offset: 0x889E40 VA: 0x18088B840
	public void .ctor() { }

}

