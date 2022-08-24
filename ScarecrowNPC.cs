public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8442
{	private Option __menuOption_MenuDesignAI; // 0x7D8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ScarecrowBrain <Brain>k__BackingField; // 0x830
	public float BaseAttackRate; // 0x838
	public float BaseAttackDamge; // 0x83C
	public DamageType AttackDamageType; // 0x840
	[HeaderAttribute] // RVA: 0x830A0 Offset: 0x824A0 VA: 0x1800830A0
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x848

	public override bool HasMenuOptions { get; }
	public ScarecrowBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ScarecrowBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected void set_Brain(ScarecrowBrain value) { }

	[BaseEntity.Menu] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.Description] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.ShowIf] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

