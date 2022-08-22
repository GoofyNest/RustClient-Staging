public class PressButton : IOEntity // TypeDefIndex: 8430
{	// Fields
	private Option __menuOption_Menu_Press; // 0x288
	public float pressDuration; // 0x2E0
	public float pressPowerTime; // 0x2E4
	public int pressPowerAmount; // 0x2E8
	public const BaseEntity.Flags Flag_EmittingPower = 512;
	public bool smallBurst; // 0x2EC

	// Properties
	public override bool HasMenuOptions { get; }
	protected virtual bool ShowBasePressOption { get; }

	// Methods

	// RVA: 0x9A7DF0 Offset: 0x9A63F0 VA: 0x1809A7DF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A87C0 Offset: 0x9A6DC0 VA: 0x1809A87C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A81E0 Offset: 0x9A67E0 VA: 0x1809A81E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A8100 Offset: 0x9A6700 VA: 0x1809A8100 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[BaseEntity.Menu.Description] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[BaseEntity.Menu.Icon] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	// RVA: 0x9A81A0 Offset: 0x9A67A0 VA: 0x1809A81A0
	public void Menu_Press(BasePlayer player) { }

	// RVA: 0x9A8160 Offset: 0x9A6760 VA: 0x1809A8160
	public bool Menu_Press_ShowIf(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 159
	protected virtual bool get_ShowBasePressOption() { }

	// RVA: 0x9A8600 Offset: 0x9A6C00 VA: 0x1809A8600
	public void .ctor() { }

}

public class PressButton_TrainTunnel : PressButton // TypeDefIndex: 8431
{	// Fields
	private Option __menuOption_Menu_Press_TrainTunnel; // 0x2F0

	// Properties
	public override bool HasMenuOptions { get; }
	protected override bool ShowBasePressOption { get; }

	// Methods

	// RVA: 0x9A82D0 Offset: 0x9A68D0 VA: 0x1809A82D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A8670 Offset: 0x9A6C70 VA: 0x1809A8670 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[BaseEntity.Menu.Description] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[BaseEntity.Menu.Icon] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	// RVA: 0x9A85C0 Offset: 0x9A6BC0 VA: 0x1809A85C0
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x6FDC80 Offset: 0x6FC280 VA: 0x1806FDC80
	public bool Menu_Press_ShowIf_TrainTunnel(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	protected override bool get_ShowBasePressOption() { }

	// RVA: 0x9A8600 Offset: 0x9A6C00 VA: 0x1809A8600
	public void .ctor() { }

}

