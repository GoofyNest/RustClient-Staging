public class BasePet : NPCPlayer // TypeDefIndex: 8335
{	private Option __menuOption_MenuDesignAI; // 0x7D8
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static bool queuedMovementsAllowed; // 0x0
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static bool onlyQueueBaseNavMovements; // 0x1
	[ServerVar] // RVA: 0xBB7D0 Offset: 0xBABD0 VA: 0x1800BB7D0
	[HelpAttribute] // RVA: 0xBB7D0 Offset: 0xBABD0 VA: 0x1800BB7D0
	public static float movementupdatebudgetms; // 0x4
	public float BaseAttackRate; // 0x830
	public float BaseAttackDamge; // 0x834
	public DamageType AttackDamageType; // 0x838
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private PetBrain <Brain>k__BackingField; // 0x840
	public GameObjectRef mapMarkerPrefab; // 0x848
	private BaseEntity _mapMarkerInstance; // 0x850

	public override bool HasMenuOptions { get; }
	public PetBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public PetBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected void set_Brain(PetBrain value) { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	[BaseEntity.Menu] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.Description] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.ShowIf] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

