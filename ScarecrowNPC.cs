public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8442
{	private Option __menuOption_MenuDesignAI; // 0x7D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScarecrowBrain <Brain>k__BackingField; // 0x830
	public float BaseAttackRate; // 0x838
	public float BaseAttackDamge; // 0x83C
	public DamageType AttackDamageType; // 0x840
	[HeaderAttribute] // RVA: 0x83090 Offset: 0x82490 VA: 0x180083090
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x848

	public override bool HasMenuOptions { get; }
	public ScarecrowBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ScarecrowBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_Brain(ScarecrowBrain value) { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

