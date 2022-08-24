public class HumanNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8399
{	private Option __menuOption_MenuDesignAI; // 0x7D8
	[HeaderAttribute] // RVA: 0xE7DC0 Offset: 0xE71C0 VA: 0x1800E7DC0
	public int AdditionalLosBlockingLayer; // 0x830
	[HeaderAttribute] // RVA: 0x830A0 Offset: 0x824A0 VA: 0x1800830A0
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x838
	[HeaderAttribute] // RVA: 0xCB840 Offset: 0xCAC40 VA: 0x1800CB840
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

	[BaseEntity.Menu] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.Description] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.ShowIf] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public override bool IsOnGround() { }

	public void .ctor() { }

}

