public class SmartSwitch : AppIOEntity // TypeDefIndex: 8450
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x2E0
	private Option __menuOption_Menu_TurnOn; // 0x338
	[HeaderAttribute] // RVA: 0x88250 Offset: 0x87650 VA: 0x180088250
	public Animator ReceiverAnimator; // 0x390
	private static readonly int ReceiverNoPower; // 0x0
	private static readonly int ReceiverOn; // 0x4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5AF9C0 Offset: 0x5ADFC0 VA: 0x1805AF9C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5B0440 Offset: 0x5AEA40 VA: 0x1805B0440 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5B01C0 Offset: 0x5AE7C0 VA: 0x1805B01C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B03C0 Offset: 0x5AE9C0 VA: 0x1805B03C0 Slot: 148
	public override bool WantsPower() { }

	// RVA: 0x5B0130 Offset: 0x5AE730 VA: 0x1805B0130
	public void OnPowerStatusChange(bool isPowered) { }

	// RVA: 0x5B02B0 Offset: 0x5AE8B0 VA: 0x1805B02B0
	public void OnSwitchStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Description] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.Icon] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[BaseEntity.Menu.ShowIf] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	// RVA: 0x5B00F0 Offset: 0x5AE6F0 VA: 0x1805B00F0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x5B0020 Offset: 0x5AE620 VA: 0x1805B0020
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Description] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.Icon] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	[BaseEntity.Menu.ShowIf] // RVA: 0x88760 Offset: 0x87B60 VA: 0x180088760
	// RVA: 0x5AFFE0 Offset: 0x5AE5E0 VA: 0x1805AFFE0
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x5AFF10 Offset: 0x5AE510 VA: 0x1805AFF10
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x5B0340 Offset: 0x5AE940 VA: 0x1805B0340
	private static bool PlayerCanToggle(BasePlayer player) { }

	// RVA: 0x5AF8A0 Offset: 0x5ADEA0 VA: 0x1805AF8A0
	public void .ctor() { }

	// RVA: 0x5B03D0 Offset: 0x5AE9D0 VA: 0x1805B03D0
	private static void .cctor() { }

}

