public class BaseAnimalNPC : BaseNpc, IAIAttack, IAITirednessAbove, IAISleep, IAIHungerAbove, IAISenses // TypeDefIndex: 8315
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	public string deathStatName; // 0x3C8
	protected BaseAIBrain<BaseAnimalNPC> brain; // 0x3D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7D0E60 Offset: 0x7CF460 VA: 0x1807D0E60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D1310 Offset: 0x7CF910 VA: 0x1807D1310 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x7D11D0 Offset: 0x7CF7D0 VA: 0x1807D11D0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7D0DC0 Offset: 0x7CF3C0 VA: 0x1807D0DC0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7D12A0 Offset: 0x7CF8A0 VA: 0x1807D12A0
	public void .ctor() { }

}

