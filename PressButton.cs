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

	// RVA: 0x9A7640 Offset: 0x9A5C40 VA: 0x1809A7640 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A8010 Offset: 0x9A6610 VA: 0x1809A8010 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A7A30 Offset: 0x9A6030 VA: 0x1809A7A30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A7950 Offset: 0x9A5F50 VA: 0x1809A7950 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[BaseEntity.Menu.Description] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[BaseEntity.Menu.Icon] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	// RVA: 0x9A79F0 Offset: 0x9A5FF0 VA: 0x1809A79F0
	public void Menu_Press(BasePlayer player) { }

	// RVA: 0x9A79B0 Offset: 0x9A5FB0 VA: 0x1809A79B0
	public bool Menu_Press_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 159
	protected virtual bool get_ShowBasePressOption() { }

	// RVA: 0x9A7E50 Offset: 0x9A6450 VA: 0x1809A7E50
	public void .ctor() { }

}

public class PressButton_TrainTunnel : PressButton // TypeDefIndex: 8431
{	// Fields
	private Option __menuOption_Menu_Press_TrainTunnel; // 0x2F0

	// Properties
	public override bool HasMenuOptions { get; }
	protected override bool ShowBasePressOption { get; }

	// Methods

	// RVA: 0x9A7B20 Offset: 0x9A6120 VA: 0x1809A7B20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A7EC0 Offset: 0x9A64C0 VA: 0x1809A7EC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[BaseEntity.Menu.Description] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[BaseEntity.Menu.Icon] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D9C0 Offset: 0x7CDC0 VA: 0x18007D9C0
	// RVA: 0x9A7E10 Offset: 0x9A6410 VA: 0x1809A7E10
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x6FDC20 Offset: 0x6FC220 VA: 0x1806FDC20
	public bool Menu_Press_ShowIf_TrainTunnel(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	protected override bool get_ShowBasePressOption() { }

	// RVA: 0x9A7E50 Offset: 0x9A6450 VA: 0x1809A7E50
	public void .ctor() { }

}

