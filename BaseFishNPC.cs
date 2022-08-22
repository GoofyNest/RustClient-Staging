public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses // TypeDefIndex: 8324
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	protected BaseAIBrain<BaseFishNPC> brain; // 0x3C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7E77E0 Offset: 0x7E5DE0 VA: 0x1807E77E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7E7C80 Offset: 0x7E6280 VA: 0x1807E7C80 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x7E7B50 Offset: 0x7E6150 VA: 0x1807E7B50
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7E7740 Offset: 0x7E5D40 VA: 0x1807E7740
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7E7C20 Offset: 0x7E6220 VA: 0x1807E7C20
	public void .ctor() { }

}

