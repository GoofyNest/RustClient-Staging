public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8442
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BaseAIBrain<ScarecrowNPC> <Brain>k__BackingField; // 0x830
	public float BaseAttackRate; // 0x838
	public float BaseAttackDamge; // 0x83C
	public DamageType AttackDamageType; // 0x840
	[HeaderAttribute] // RVA: 0x82FF0 Offset: 0x823F0 VA: 0x180082FF0
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x848

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<ScarecrowNPC> Brain { get; set; }

	// Methods

	// RVA: 0x4A0B90 Offset: 0x49F190 VA: 0x1804A0B90 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4A0FA0 Offset: 0x49F5A0 VA: 0x1804A0FA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A0F90 Offset: 0x49F590 VA: 0x1804A0F90
	public BaseAIBrain<ScarecrowNPC> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A1060 Offset: 0x49F660 VA: 0x1804A1060
	protected void set_Brain(BaseAIBrain<ScarecrowNPC> value) { }

	[BaseEntity.Menu] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	[BaseEntity.Menu.Description] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	[BaseEntity.Menu.ShowIf] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	// RVA: 0x4A0E90 Offset: 0x49F490 VA: 0x1804A0E90
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x4A0A90 Offset: 0x49F090 VA: 0x1804A0A90
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x4A0F60 Offset: 0x49F560 VA: 0x1804A0F60
	public void .ctor() { }

}

