public class StrobeLight : BaseCombatEntity // TypeDefIndex: 8281
{	public float frequency; // 0x240
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

	public override bool HasMenuOptions { get; }


	public float GetFrequency() { }

	public void Update() { }

	public void ClientSetLights(bool wantsOn) { }

	public void Toggle() { }

	[BaseEntity.Menu] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	[BaseEntity.Menu.Description] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	[BaseEntity.Menu.Icon] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5EE0 Offset: 0xA52E0 VA: 0x1800A5EE0
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_StrobeOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	[BaseEntity.Menu.Description] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	[BaseEntity.Menu.Icon] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7390 Offset: 0xA6790 VA: 0x1800A7390
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_StrobeOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	[BaseEntity.Menu.Description] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	[BaseEntity.Menu.Icon] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA74A0 Offset: 0xA68A0 VA: 0x1800A74A0
	public void Menu_StrobeSlow(BasePlayer player) { }

	public bool Menu_StrobeSlow_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	[BaseEntity.Menu.Description] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	[BaseEntity.Menu.Icon] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7710 Offset: 0xA6B10 VA: 0x1800A7710
	public void Menu_StrobeMed(BasePlayer player) { }

	public bool Menu_StrobeMed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	[BaseEntity.Menu.Description] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	[BaseEntity.Menu.Icon] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	public void Menu_StrobeFast(BasePlayer player) { }

	public bool Menu_StrobeFast_ShowIf(BasePlayer player) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

