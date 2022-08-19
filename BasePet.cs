public class BasePet : NPCPlayer // TypeDefIndex: 8335
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool queuedMovementsAllowed; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool onlyQueueBaseNavMovements; // 0x1
	[ServerVar] // RVA: 0xBB5F0 Offset: 0xBA9F0 VA: 0x1800BB5F0
	[HelpAttribute] // RVA: 0xBB5F0 Offset: 0xBA9F0 VA: 0x1800BB5F0
	public static float movementupdatebudgetms; // 0x4
	public float BaseAttackRate; // 0x830
	public float BaseAttackDamge; // 0x834
	public DamageType AttackDamageType; // 0x838
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BaseAIBrain<BasePet> <Brain>k__BackingField; // 0x840
	public GameObjectRef mapMarkerPrefab; // 0x848
	private BaseEntity _mapMarkerInstance; // 0x850

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<BasePet> Brain { get; set; }

	// Methods

	// RVA: 0xA53450 Offset: 0xA51A50 VA: 0x180A53450 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA538C0 Offset: 0xA51EC0 VA: 0x180A538C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA538B0 Offset: 0xA51EB0 VA: 0x180A538B0
	public BaseAIBrain<BasePet> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA53980 Offset: 0xA51F80 VA: 0x180A53980
	protected void set_Brain(BaseAIBrain<BasePet> value) { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x7D79B0 Offset: 0x7D5FB0 VA: 0x1807D79B0 Slot: 111
	public override float MaxHealth() { }

	[BaseEntity.Menu] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	[BaseEntity.Menu.Description] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	[BaseEntity.Menu.ShowIf] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	// RVA: 0xA53750 Offset: 0xA51D50 VA: 0x180A53750
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0xA53350 Offset: 0xA51950 VA: 0x180A53350
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0xA53880 Offset: 0xA51E80 VA: 0x180A53880
	public void .ctor() { }

	// RVA: 0xA53820 Offset: 0xA51E20 VA: 0x180A53820
	private static void .cctor() { }

}

