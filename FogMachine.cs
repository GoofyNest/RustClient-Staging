public class FogMachine : StorageContainer // TypeDefIndex: 8280
{	public const BaseEntity.Flags FogFieldOn = 65536;
	public const BaseEntity.Flags MotionMode = 32768;
	public const BaseEntity.Flags Emitting = 16384;
	public const BaseEntity.Flags Flag_HasJuice = 2048;
	public float fogLength; // 0x3D0
	public float nozzleBlastDuration; // 0x3D4
	private Option __menuOption_Menu_FogOff; // 0x3D8
	private Option __menuOption_Menu_MotionOff; // 0x430
	private Option __menuOption_Menu_MotionOn; // 0x488
	private Option __menuOption_Menu_TurnOn; // 0x4E0

	public override bool HasMenuOptions { get; }


	public bool IsEmitting() { }

	public bool HasJuice() { }

	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] // RVA: 0xA5150 Offset: 0xA4550 VA: 0x1800A5150
	[BaseEntity.Menu.Description] // RVA: 0xA5150 Offset: 0xA4550 VA: 0x1800A5150
	[BaseEntity.Menu.Icon] // RVA: 0xA5150 Offset: 0xA4550 VA: 0x1800A5150
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5150 Offset: 0xA4550 VA: 0x1800A5150
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA54D0 Offset: 0xA48D0 VA: 0x1800A54D0
	[BaseEntity.Menu.Description] // RVA: 0xA54D0 Offset: 0xA48D0 VA: 0x1800A54D0
	[BaseEntity.Menu.Icon] // RVA: 0xA54D0 Offset: 0xA48D0 VA: 0x1800A54D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA54D0 Offset: 0xA48D0 VA: 0x1800A54D0
	public void Menu_FogOff(BasePlayer player) { }

	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5990 Offset: 0xA4D90 VA: 0x1800A5990
	[BaseEntity.Menu.Description] // RVA: 0xA5990 Offset: 0xA4D90 VA: 0x1800A5990
	[BaseEntity.Menu.Icon] // RVA: 0xA5990 Offset: 0xA4D90 VA: 0x1800A5990
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5990 Offset: 0xA4D90 VA: 0x1800A5990
	public void Menu_MotionOn(BasePlayer player) { }

	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5D10 Offset: 0xA5110 VA: 0x1800A5D10
	[BaseEntity.Menu.Description] // RVA: 0xA5D10 Offset: 0xA5110 VA: 0x1800A5D10
	[BaseEntity.Menu.Icon] // RVA: 0xA5D10 Offset: 0xA5110 VA: 0x1800A5D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5D10 Offset: 0xA5110 VA: 0x1800A5D10
	public void Menu_MotionOff(BasePlayer player) { }

	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

