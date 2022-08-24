public class HumanNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8399
{	private Option __menuOption_MenuDesignAI; // 0x7D8
	[HeaderAttribute] // RVA: 0xE7E00 Offset: 0xE7200 VA: 0x1800E7E00
	public int AdditionalLosBlockingLayer; // 0x830
	[HeaderAttribute] // RVA: 0x831A0 Offset: 0x825A0 VA: 0x1800831A0
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x838
	[HeaderAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	public float aimConeScale; // 0x840
	public float lastDismountTime; // 0x844
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ScientistBrain <Brain>k__BackingField; // 0x848

	public override bool HasMenuOptions { get; }
	public ScientistBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ScientistBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Brain(ScientistBrain value) { }

	[BaseEntity.Menu] // RVA: 0x83320 Offset: 0x82720 VA: 0x180083320
	[BaseEntity.Menu.Description] // RVA: 0x83320 Offset: 0x82720 VA: 0x180083320
	[BaseEntity.Menu.ShowIf] // RVA: 0x83320 Offset: 0x82720 VA: 0x180083320
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public override bool IsOnGround() { }

	public void .ctor() { }

}

