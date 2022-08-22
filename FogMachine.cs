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

	// RVA: 0x738190 Offset: 0x736790 VA: 0x180738190
	public bool HasJuice() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 155
	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Description] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.Icon] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5080 Offset: 0xA4480 VA: 0x1800A5080
	// RVA: 0x7943C0 Offset: 0x7929C0 VA: 0x1807943C0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x7941F0 Offset: 0x7927F0 VA: 0x1807941F0
	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Description] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.Icon] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA53E0 Offset: 0xA47E0 VA: 0x1800A53E0
	// RVA: 0x7941B0 Offset: 0x7927B0 VA: 0x1807941B0
	public void Menu_FogOff(BasePlayer player) { }

	// RVA: 0x794160 Offset: 0x792760 VA: 0x180794160
	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Description] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.Icon] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA58E0 Offset: 0xA4CE0 VA: 0x1800A58E0
	// RVA: 0x794370 Offset: 0x792970 VA: 0x180794370
	public void Menu_MotionOn(BasePlayer player) { }

	// RVA: 0x794300 Offset: 0x792900 VA: 0x180794300
	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Description] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.Icon] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5BF0 Offset: 0xA4FF0 VA: 0x1800A5BF0
	// RVA: 0x7942B0 Offset: 0x7928B0 VA: 0x1807942B0
	public void Menu_MotionOff(BasePlayer player) { }

	// RVA: 0x794250 Offset: 0x792850 VA: 0x180794250
	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	// RVA: 0x793770 Offset: 0x791D70 VA: 0x180793770 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x794560 Offset: 0x792B60 VA: 0x180794560 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x794400 Offset: 0x792A00 VA: 0x180794400 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7944F0 Offset: 0x792AF0 VA: 0x1807944F0
	public void .ctor() { }

}

