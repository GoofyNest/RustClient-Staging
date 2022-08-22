public class HumanNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8399
{	private Option __menuOption_MenuDesignAI; // 0x7D8
	[HeaderAttribute] // RVA: 0xE7CE0 Offset: 0xE70E0 VA: 0x1800E7CE0
	public int AdditionalLosBlockingLayer; // 0x830
	[HeaderAttribute] // RVA: 0x83090 Offset: 0x82490 VA: 0x180083090
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x838
	[HeaderAttribute] // RVA: 0xCB6A0 Offset: 0xCAAA0 VA: 0x1800CB6A0
	public float aimConeScale; // 0x840
	public float lastDismountTime; // 0x844
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScientistBrain <Brain>k__BackingField; // 0x848

	public override bool HasMenuOptions { get; }
	public ScientistBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ScientistBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Brain(ScientistBrain value) { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public override bool IsOnGround() { }

	public void .ctor() { }

}

