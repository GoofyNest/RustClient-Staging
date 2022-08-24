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

	[BaseEntity.Menu] // RVA: 0xA5230 Offset: 0xA4630 VA: 0x1800A5230
	[BaseEntity.Menu.Description] // RVA: 0xA5230 Offset: 0xA4630 VA: 0x1800A5230
	[BaseEntity.Menu.Icon] // RVA: 0xA5230 Offset: 0xA4630 VA: 0x1800A5230
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5230 Offset: 0xA4630 VA: 0x1800A5230
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA54E0 Offset: 0xA48E0 VA: 0x1800A54E0
	[BaseEntity.Menu.Description] // RVA: 0xA54E0 Offset: 0xA48E0 VA: 0x1800A54E0
	[BaseEntity.Menu.Icon] // RVA: 0xA54E0 Offset: 0xA48E0 VA: 0x1800A54E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA54E0 Offset: 0xA48E0 VA: 0x1800A54E0
	public void Menu_FogOff(BasePlayer player) { }

	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5900 Offset: 0xA4D00 VA: 0x1800A5900
	[BaseEntity.Menu.Description] // RVA: 0xA5900 Offset: 0xA4D00 VA: 0x1800A5900
	[BaseEntity.Menu.Icon] // RVA: 0xA5900 Offset: 0xA4D00 VA: 0x1800A5900
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5900 Offset: 0xA4D00 VA: 0x1800A5900
	public void Menu_MotionOn(BasePlayer player) { }

	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA5C40 Offset: 0xA5040 VA: 0x1800A5C40
	[BaseEntity.Menu.Description] // RVA: 0xA5C40 Offset: 0xA5040 VA: 0x1800A5C40
	[BaseEntity.Menu.Icon] // RVA: 0xA5C40 Offset: 0xA5040 VA: 0x1800A5C40
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5C40 Offset: 0xA5040 VA: 0x1800A5C40
	public void Menu_MotionOff(BasePlayer player) { }

	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

