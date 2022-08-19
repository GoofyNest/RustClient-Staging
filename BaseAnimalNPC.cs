public class BaseAnimalNPC : BaseNpc, IAIAttack, IAITirednessAbove, IAISleep, IAIHungerAbove, IAISenses // TypeDefIndex: 8315
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	public string deathStatName; // 0x3C8
	protected BaseAIBrain<BaseAnimalNPC> brain; // 0x3D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7D0D50 Offset: 0x7CF350 VA: 0x1807D0D50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D1200 Offset: 0x7CF800 VA: 0x1807D1200 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	[BaseEntity.Menu.Description] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	[BaseEntity.Menu.ShowIf] // RVA: 0x83110 Offset: 0x82510 VA: 0x180083110
	// RVA: 0x7D10C0 Offset: 0x7CF6C0 VA: 0x1807D10C0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7D0CB0 Offset: 0x7CF2B0 VA: 0x1807D0CB0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7D1190 Offset: 0x7CF790 VA: 0x1807D1190
	public void .ctor() { }

}

