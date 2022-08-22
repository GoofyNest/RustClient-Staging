public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses // TypeDefIndex: 8324
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	protected FishBrain brain; // 0x3C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7B3210 Offset: 0x7B1810 VA: 0x1807B3210 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B36B0 Offset: 0x7B1CB0 VA: 0x1807B36B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x7B3580 Offset: 0x7B1B80 VA: 0x1807B3580
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x7B3170 Offset: 0x7B1770 VA: 0x1807B3170
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x7B3650 Offset: 0x7B1C50 VA: 0x1807B3650
	public void .ctor() { }

}

