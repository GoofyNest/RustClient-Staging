public class SmartSwitch : AppIOEntity // TypeDefIndex: 8450
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	[HeaderAttribute] // RVA: 0x881E0 Offset: 0x875E0 VA: 0x1800881E0
	public Animator ReceiverAnimator; // 0x390
	private static readonly int ReceiverNoPower; // 0x0
	private static readonly int ReceiverOn; // 0x4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5AFA30 Offset: 0x5AE030 VA: 0x1805AFA30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5B04B0 Offset: 0x5AEAB0 VA: 0x1805B04B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5B0230 Offset: 0x5AE830 VA: 0x1805B0230 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430 Slot: 148
	public override bool WantsPower() { }

	// RVA: 0x5B01A0 Offset: 0x5AE7A0 VA: 0x1805B01A0
	public void OnPowerStatusChange(bool isPowered) { }

	// RVA: 0x5B0320 Offset: 0x5AE920 VA: 0x1805B0320
	public void OnSwitchStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x882D0 Offset: 0x876D0 VA: 0x1800882D0
	[BaseEntity.Menu.Description] // RVA: 0x882D0 Offset: 0x876D0 VA: 0x1800882D0
	[BaseEntity.Menu.Icon] // RVA: 0x882D0 Offset: 0x876D0 VA: 0x1800882D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x882D0 Offset: 0x876D0 VA: 0x1800882D0
	// RVA: 0x5B0160 Offset: 0x5AE760 VA: 0x1805B0160
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x5B0090 Offset: 0x5AE690 VA: 0x1805B0090
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x886A0 Offset: 0x87AA0 VA: 0x1800886A0
	[BaseEntity.Menu.Description] // RVA: 0x886A0 Offset: 0x87AA0 VA: 0x1800886A0
	[BaseEntity.Menu.Icon] // RVA: 0x886A0 Offset: 0x87AA0 VA: 0x1800886A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x886A0 Offset: 0x87AA0 VA: 0x1800886A0
	// RVA: 0x5B0050 Offset: 0x5AE650 VA: 0x1805B0050
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x5AFF80 Offset: 0x5AE580 VA: 0x1805AFF80
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x5B03B0 Offset: 0x5AE9B0 VA: 0x1805B03B0
	private static bool PlayerCanToggle(BasePlayer player) { }

	// RVA: 0x5AF910 Offset: 0x5ADF10 VA: 0x1805AF910
	public void .ctor() { }

	// RVA: 0x5B0440 Offset: 0x5AEA40 VA: 0x1805B0440
	private static void .cctor() { }

}

