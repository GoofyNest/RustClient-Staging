public class HumanNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8399
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x7D8
	[HeaderAttribute] // RVA: 0xE7CE0 Offset: 0xE70E0 VA: 0x1800E7CE0
	public int AdditionalLosBlockingLayer; // 0x830
	[HeaderAttribute] // RVA: 0x83090 Offset: 0x82490 VA: 0x180083090
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x838
	[HeaderAttribute] // RVA: 0xCB6A0 Offset: 0xCAAA0 VA: 0x1800CB6A0
	public float aimConeScale; // 0x840
	public float lastDismountTime; // 0x844
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseAIBrain<HumanNPC> <Brain>k__BackingField; // 0x848

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseAIBrain<HumanNPC> Brain { get; set; }

	// Methods

	// RVA: 0x745870 Offset: 0x743E70 VA: 0x180745870 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x745C80 Offset: 0x744280 VA: 0x180745C80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70 Slot: 111
	public override float MaxHealth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x745C70 Offset: 0x744270 VA: 0x180745C70
	public BaseAIBrain<HumanNPC> get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x745D40 Offset: 0x744340 VA: 0x180745D40
	private void set_Brain(BaseAIBrain<HumanNPC> value) { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x745B80 Offset: 0x744180 VA: 0x180745B80
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x745770 Offset: 0x743D70 VA: 0x180745770
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 151
	public override bool IsOnGround() { }

	// RVA: 0x745C50 Offset: 0x744250 VA: 0x180745C50
	public void .ctor() { }

}

