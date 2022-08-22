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

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool IsEmitting() { }

	// RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	public bool HasJuice() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 155
	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Description] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Icon] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	// RVA: 0x7944D0 Offset: 0x792AD0 VA: 0x1807944D0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x794300 Offset: 0x792900 VA: 0x180794300
	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Description] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Icon] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	// RVA: 0x7942C0 Offset: 0x7928C0 VA: 0x1807942C0
	public void Menu_FogOff(BasePlayer player) { }

	// RVA: 0x794270 Offset: 0x792870 VA: 0x180794270
	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Description] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Icon] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	// RVA: 0x794480 Offset: 0x792A80 VA: 0x180794480
	public void Menu_MotionOn(BasePlayer player) { }

	// RVA: 0x794410 Offset: 0x792A10 VA: 0x180794410
	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Description] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Icon] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	// RVA: 0x7943C0 Offset: 0x7929C0 VA: 0x1807943C0
	public void Menu_MotionOff(BasePlayer player) { }

	// RVA: 0x794360 Offset: 0x792960 VA: 0x180794360
	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	// RVA: 0x793880 Offset: 0x791E80 VA: 0x180793880 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x794670 Offset: 0x792C70 VA: 0x180794670 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x794510 Offset: 0x792B10 VA: 0x180794510 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x794600 Offset: 0x792C00 VA: 0x180794600
	public void .ctor() { }

}

