public class PressButton : IOEntity // TypeDefIndex: 8430
{	private Option __menuOption_Menu_Press; // 0x288
	public float pressDuration; // 0x2E0
	public float pressPowerTime; // 0x2E4
	public int pressPowerAmount; // 0x2E8
	public const BaseEntity.Flags Flag_EmittingPower = 512;
	public bool smallBurst; // 0x2EC

	public override bool HasMenuOptions { get; }
	protected virtual bool ShowBasePressOption { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D780 Offset: 0x7CB80 VA: 0x18007D780
	[BaseEntity.Menu.Description] // RVA: 0x7D780 Offset: 0x7CB80 VA: 0x18007D780
	[BaseEntity.Menu.Icon] // RVA: 0x7D780 Offset: 0x7CB80 VA: 0x18007D780
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D780 Offset: 0x7CB80 VA: 0x18007D780
	public void Menu_Press(BasePlayer player) { }

	public bool Menu_Press_ShowIf(BasePlayer player) { }

	protected virtual bool get_ShowBasePressOption() { }

	public void .ctor() { }

}

public class PressButton_TrainTunnel : PressButton // TypeDefIndex: 8431
{	private Option __menuOption_Menu_Press_TrainTunnel; // 0x2F0

	public override bool HasMenuOptions { get; }
	protected override bool ShowBasePressOption { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x7DAA0 Offset: 0x7CEA0 VA: 0x18007DAA0
	[BaseEntity.Menu.Description] // RVA: 0x7DAA0 Offset: 0x7CEA0 VA: 0x18007DAA0
	[BaseEntity.Menu.Icon] // RVA: 0x7DAA0 Offset: 0x7CEA0 VA: 0x18007DAA0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DAA0 Offset: 0x7CEA0 VA: 0x18007DAA0
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	public bool Menu_Press_ShowIf_TrainTunnel(BasePlayer player) { }

	protected override bool get_ShowBasePressOption() { }

	public void .ctor() { }

}

