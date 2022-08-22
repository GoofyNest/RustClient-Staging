public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses // TypeDefIndex: 8324
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	protected BaseAIBrain<BaseFishNPC> brain; // 0x3C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7E78F0 Offset: 0x7E5EF0 VA: 0x1807E78F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7E7D90 Offset: 0x7E6390 VA: 0x1807E7D90 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x7E7C60 Offset: 0x7E6260 VA: 0x1807E7C60
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7E7850 Offset: 0x7E5E50 VA: 0x1807E7850
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7E7D30 Offset: 0x7E6330 VA: 0x1807E7D30
	public void .ctor() { }

}

