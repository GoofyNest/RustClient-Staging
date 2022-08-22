public class BasePet : NPCPlayer // TypeDefIndex: 8335
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool queuedMovementsAllowed; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool onlyQueueBaseNavMovements; // 0x1
	[ServerVar] // RVA: 0xBB690 Offset: 0xBAA90 VA: 0x1800BB690
	[HelpAttribute] // RVA: 0xBB690 Offset: 0xBAA90 VA: 0x1800BB690
	public static float movementupdatebudgetms; // 0x4
	public float BaseAttackRate; // 0x830
	public float BaseAttackDamge; // 0x834
	public DamageType AttackDamageType; // 0x838
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseAIBrain<BasePet> <Brain>k__BackingField; // 0x840
	public GameObjectRef mapMarkerPrefab; // 0x848
	private BaseEntity _mapMarkerInstance; // 0x850

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<BasePet> Brain { get; set; }

	// Methods

	// RVA: 0xA53710 Offset: 0xA51D10 VA: 0x180A53710 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA53B80 Offset: 0xA52180 VA: 0x180A53B80 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA53B70 Offset: 0xA52170 VA: 0x180A53B70
	public BaseAIBrain<BasePet> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA53C40 Offset: 0xA52240 VA: 0x180A53C40
	protected void set_Brain(BaseAIBrain<BasePet> value) { }

	// RVA: 0x745C80 Offset: 0x744280 VA: 0x180745C80 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x745C80 Offset: 0x744280 VA: 0x180745C80 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x7D7AC0 Offset: 0x7D60C0 VA: 0x1807D7AC0 Slot: 111
	public override float MaxHealth() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0xA53A10 Offset: 0xA52010 VA: 0x180A53A10
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0xA53610 Offset: 0xA51C10 VA: 0x180A53610
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0xA53B40 Offset: 0xA52140 VA: 0x180A53B40
	public void .ctor() { }

	// RVA: 0xA53AE0 Offset: 0xA520E0 VA: 0x180A53AE0
	private static void .cctor() { }

}

