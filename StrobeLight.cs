public class StrobeLight : BaseCombatEntity // TypeDefIndex: 8281
{	// Fields
	public float frequency; // 0x240
	public MeshRenderer lightMesh; // 0x248
	public Light strobeLight; // 0x250
	private float speedSlow; // 0x258
	private float speedMed; // 0x25C
	private float speedFast; // 0x260
	public float burnRate; // 0x264
	public float lifeTimeSeconds; // 0x268
	public const BaseEntity.Flags Flag_Slow = 16384;
	public const BaseEntity.Flags Flag_Med = 32768;
	public const BaseEntity.Flags Flag_Fast = 65536;
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool forceoff; // 0x0
	private float lastStrobeTime; // 0x26C
	private Option __menuOption_Menu_StrobeFast; // 0x270
	private Option __menuOption_Menu_StrobeMed; // 0x2C8
	private Option __menuOption_Menu_StrobeSlow; // 0x320
	private Option __menuOption_Menu_TurnOff; // 0x378
	private Option __menuOption_Menu_TurnOn; // 0x3D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7BD810 Offset: 0x7BBE10 VA: 0x1807BD810
	public float GetFrequency() { }

	// RVA: 0x7BE7F0 Offset: 0x7BCDF0 VA: 0x1807BE7F0
	public void Update() { }

	// RVA: 0x7BD720 Offset: 0x7BBD20 VA: 0x1807BD720
	public void ClientSetLights(bool wantsOn) { }

	// RVA: 0x7BE7B0 Offset: 0x7BCDB0 VA: 0x1807BE7B0
	public void Toggle() { }

	[BaseEntity.Menu] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	[BaseEntity.Menu.Description] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	[BaseEntity.Menu.Icon] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	// RVA: 0x7BE670 Offset: 0x7BCC70 VA: 0x1807BE670
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x7BE590 Offset: 0x7BCB90 VA: 0x1807BE590
	public bool Menu_StrobeOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	[BaseEntity.Menu.Description] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	[BaseEntity.Menu.Icon] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	// RVA: 0x7BE620 Offset: 0x7BCC20 VA: 0x1807BE620
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x7BE550 Offset: 0x7BCB50 VA: 0x1807BE550
	public bool Menu_StrobeOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	[BaseEntity.Menu.Description] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	[BaseEntity.Menu.Icon] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	// RVA: 0x7BE5D0 Offset: 0x7BCBD0 VA: 0x1807BE5D0
	public void Menu_StrobeSlow(BasePlayer player) { }

	// RVA: 0x55C070 Offset: 0x55A670 VA: 0x18055C070
	public bool Menu_StrobeSlow_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	[BaseEntity.Menu.Description] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	[BaseEntity.Menu.Icon] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	// RVA: 0x7BE500 Offset: 0x7BCB00 VA: 0x1807BE500
	public void Menu_StrobeMed(BasePlayer player) { }

	// RVA: 0x55C070 Offset: 0x55A670 VA: 0x18055C070
	public bool Menu_StrobeMed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	[BaseEntity.Menu.Description] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	[BaseEntity.Menu.Icon] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	// RVA: 0x7BE4B0 Offset: 0x7BCAB0 VA: 0x1807BE4B0
	public void Menu_StrobeFast(BasePlayer player) { }

	// RVA: 0x55C070 Offset: 0x55A670 VA: 0x18055C070
	public bool Menu_StrobeFast_ShowIf(BasePlayer player) { }

	// RVA: 0x7BD880 Offset: 0x7BBE80 VA: 0x1807BD880 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7BE990 Offset: 0x7BCF90 VA: 0x1807BE990 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7BE6C0 Offset: 0x7BCCC0 VA: 0x1807BE6C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7BE950 Offset: 0x7BCF50 VA: 0x1807BE950
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

