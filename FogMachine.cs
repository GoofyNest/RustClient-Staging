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

	[BaseEntity.Menu] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Description] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Icon] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Description] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Icon] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	public void Menu_FogOff(BasePlayer player) { }

	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Description] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Icon] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	public void Menu_MotionOn(BasePlayer player) { }

	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Description] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Icon] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	public void Menu_MotionOff(BasePlayer player) { }

	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

