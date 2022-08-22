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
	private PetBrain <Brain>k__BackingField; // 0x840
	public GameObjectRef mapMarkerPrefab; // 0x848
	private BaseEntity _mapMarkerInstance; // 0x850

	// Properties
	public override bool HasMenuOptions { get; }
	public PetBrain Brain { get; set; }

	// Methods

	// RVA: 0xA53BE0 Offset: 0xA521E0 VA: 0x180A53BE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA54050 Offset: 0xA52650 VA: 0x180A54050 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA54040 Offset: 0xA52640 VA: 0x180A54040
	public PetBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA54110 Offset: 0xA52710 VA: 0x180A54110
	protected void set_Brain(PetBrain value) { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x7A33E0 Offset: 0x7A19E0 VA: 0x1807A33E0 Slot: 111
	public override float MaxHealth() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0xA53EE0 Offset: 0xA524E0 VA: 0x180A53EE0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0xA53AE0 Offset: 0xA520E0 VA: 0x180A53AE0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0xA54010 Offset: 0xA52610 VA: 0x180A54010
	public void .ctor() { }

	// RVA: 0xA53FB0 Offset: 0xA525B0 VA: 0x180A53FB0
	private static void .cctor() { }

}

