public class FogMachine : StorageContainer // TypeDefIndex: 8280
{	// Fields
	public const BaseEntity.Flags FogFieldOn = 65536;
	public const BaseEntity.Flags MotionMode = 32768;
	public const BaseEntity.Flags Emitting = 16384;
	public const BaseEntity.Flags Flag_HasJuice = 2048;
	public float fogLength; // 0x3D0
	public float nozzleBlastDuration; // 0x3D4
	private Option __menuOption_Menu_FogOff; // 0x3D8
	private Option __menuOption_Menu_MotionOff; // 0x430
	private Option __menuOption_Menu_MotionOn; // 0x488
	private Option __menuOption_Menu_TurnOn; // 0x4E0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool IsEmitting() { }

	// RVA: 0x7381F0 Offset: 0x7367F0 VA: 0x1807381F0
	public bool HasJuice() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 155
	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Description] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Icon] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	// RVA: 0x7943E0 Offset: 0x7929E0 VA: 0x1807943E0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x794210 Offset: 0x792810 VA: 0x180794210
	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Description] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Icon] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	// RVA: 0x7941D0 Offset: 0x7927D0 VA: 0x1807941D0
	public void Menu_FogOff(BasePlayer player) { }

	// RVA: 0x794180 Offset: 0x792780 VA: 0x180794180
	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Description] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Icon] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	// RVA: 0x794390 Offset: 0x792990 VA: 0x180794390
	public void Menu_MotionOn(BasePlayer player) { }

	// RVA: 0x794320 Offset: 0x792920 VA: 0x180794320
	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Description] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Icon] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	// RVA: 0x7942D0 Offset: 0x7928D0 VA: 0x1807942D0
	public void Menu_MotionOff(BasePlayer player) { }

	// RVA: 0x794270 Offset: 0x792870 VA: 0x180794270
	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	// RVA: 0x793790 Offset: 0x791D90 VA: 0x180793790 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x794580 Offset: 0x792B80 VA: 0x180794580 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x794420 Offset: 0x792A20 VA: 0x180794420 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x794510 Offset: 0x792B10 VA: 0x180794510
	public void .ctor() { }

}

