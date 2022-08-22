public class BasePet : NPCPlayer // TypeDefIndex: 8335
{	private Option __menuOption_MenuDesignAI; // 0x7D8
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

	public override bool HasMenuOptions { get; }
	public PetBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public PetBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_Brain(PetBrain value) { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

