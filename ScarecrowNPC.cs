public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8442
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScarecrowBrain <Brain>k__BackingField; // 0x830
	public float BaseAttackRate; // 0x838
	public float BaseAttackDamge; // 0x83C
	public DamageType AttackDamageType; // 0x840
	[HeaderAttribute] // RVA: 0x83090 Offset: 0x82490 VA: 0x180083090
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x848

	// Properties
	public override bool HasMenuOptions { get; }
	public ScarecrowBrain Brain { get; set; }

	// Methods

	// RVA: 0x4A0B60 Offset: 0x49F160 VA: 0x1804A0B60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4A0F70 Offset: 0x49F570 VA: 0x1804A0F70 Slot: 50
	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A0F60 Offset: 0x49F560 VA: 0x1804A0F60
	public ScarecrowBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A1030 Offset: 0x49F630 VA: 0x1804A1030
	protected void set_Brain(ScarecrowBrain value) { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x4A0E60 Offset: 0x49F460 VA: 0x1804A0E60
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x4A0A60 Offset: 0x49F060 VA: 0x1804A0A60
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x4A0F30 Offset: 0x49F530 VA: 0x1804A0F30
	public void .ctor() { }

}

