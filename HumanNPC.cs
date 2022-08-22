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
	private ScientistBrain <Brain>k__BackingField; // 0x848

	// Properties
	public override bool HasMenuOptions { get; }
	public ScientistBrain Brain { get; set; }

	// Methods

	// RVA: 0x7458D0 Offset: 0x743ED0 VA: 0x1807458D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x745CE0 Offset: 0x7442E0 VA: 0x180745CE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0 Slot: 111
	public override float MaxHealth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x745CD0 Offset: 0x7442D0 VA: 0x180745CD0
	public ScientistBrain get_Brain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x745DA0 Offset: 0x7443A0 VA: 0x180745DA0
	private void set_Brain(ScientistBrain value) { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x745BE0 Offset: 0x7441E0 VA: 0x180745BE0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7457D0 Offset: 0x743DD0 VA: 0x1807457D0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 151
	public override bool IsOnGround() { }

	// RVA: 0x745CB0 Offset: 0x7442B0 VA: 0x180745CB0
	public void .ctor() { }

}

