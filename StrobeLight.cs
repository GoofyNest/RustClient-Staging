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
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
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

	// RVA: 0x79F300 Offset: 0x79D900 VA: 0x18079F300
	public float GetFrequency() { }

	// RVA: 0x7A02E0 Offset: 0x79E8E0 VA: 0x1807A02E0
	public void Update() { }

	// RVA: 0x79F210 Offset: 0x79D810 VA: 0x18079F210
	public void ClientSetLights(bool wantsOn) { }

	// RVA: 0x7A02A0 Offset: 0x79E8A0 VA: 0x1807A02A0
	public void Toggle() { }

	[BaseEntity.Menu] // RVA: 0xA5E50 Offset: 0xA5250 VA: 0x1800A5E50
	[BaseEntity.Menu.Description] // RVA: 0xA5E50 Offset: 0xA5250 VA: 0x1800A5E50
	[BaseEntity.Menu.Icon] // RVA: 0xA5E50 Offset: 0xA5250 VA: 0x1800A5E50
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5E50 Offset: 0xA5250 VA: 0x1800A5E50
	// RVA: 0x7A0160 Offset: 0x79E760 VA: 0x1807A0160
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x7A0080 Offset: 0x79E680 VA: 0x1807A0080
	public bool Menu_StrobeOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA72B0 Offset: 0xA66B0 VA: 0x1800A72B0
	[BaseEntity.Menu.Description] // RVA: 0xA72B0 Offset: 0xA66B0 VA: 0x1800A72B0
	[BaseEntity.Menu.Icon] // RVA: 0xA72B0 Offset: 0xA66B0 VA: 0x1800A72B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA72B0 Offset: 0xA66B0 VA: 0x1800A72B0
	// RVA: 0x7A0110 Offset: 0x79E710 VA: 0x1807A0110
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x7A0040 Offset: 0x79E640 VA: 0x1807A0040
	public bool Menu_StrobeOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	[BaseEntity.Menu.Description] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	[BaseEntity.Menu.Icon] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	// RVA: 0x7A00C0 Offset: 0x79E6C0 VA: 0x1807A00C0
	public void Menu_StrobeSlow(BasePlayer player) { }

	// RVA: 0x55C0E0 Offset: 0x55A6E0 VA: 0x18055C0E0
	public bool Menu_StrobeSlow_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7680 Offset: 0xA6A80 VA: 0x1800A7680
	[BaseEntity.Menu.Description] // RVA: 0xA7680 Offset: 0xA6A80 VA: 0x1800A7680
	[BaseEntity.Menu.Icon] // RVA: 0xA7680 Offset: 0xA6A80 VA: 0x1800A7680
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7680 Offset: 0xA6A80 VA: 0x1800A7680
	// RVA: 0x79FFF0 Offset: 0x79E5F0 VA: 0x18079FFF0
	public void Menu_StrobeMed(BasePlayer player) { }

	// RVA: 0x55C0E0 Offset: 0x55A6E0 VA: 0x18055C0E0
	public bool Menu_StrobeMed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7AA0 Offset: 0xA6EA0 VA: 0x1800A7AA0
	[BaseEntity.Menu.Description] // RVA: 0xA7AA0 Offset: 0xA6EA0 VA: 0x1800A7AA0
	[BaseEntity.Menu.Icon] // RVA: 0xA7AA0 Offset: 0xA6EA0 VA: 0x1800A7AA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7AA0 Offset: 0xA6EA0 VA: 0x1800A7AA0
	// RVA: 0x79FFA0 Offset: 0x79E5A0 VA: 0x18079FFA0
	public void Menu_StrobeFast(BasePlayer player) { }

	// RVA: 0x55C0E0 Offset: 0x55A6E0 VA: 0x18055C0E0
	public bool Menu_StrobeFast_ShowIf(BasePlayer player) { }

	// RVA: 0x79F370 Offset: 0x79D970 VA: 0x18079F370 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A0480 Offset: 0x79EA80 VA: 0x1807A0480 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A01B0 Offset: 0x79E7B0 VA: 0x1807A01B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7A0440 Offset: 0x79EA40 VA: 0x1807A0440
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

