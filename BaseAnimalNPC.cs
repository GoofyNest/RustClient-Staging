public class BaseAnimalNPC : BaseNpc, IAIAttack, IAITirednessAbove, IAISleep, IAIHungerAbove, IAISenses // TypeDefIndex: 8315
{	// Fields
	private Option __menuOption_MenuDesignAI; // 0x370
	public string deathStatName; // 0x3C8
	protected AnimalBrain brain; // 0x3D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x79C780 Offset: 0x79AD80 VA: 0x18079C780 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x79CC30 Offset: 0x79B230 VA: 0x18079CC30 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	// RVA: 0x79CAF0 Offset: 0x79B0F0 VA: 0x18079CAF0
	public void MenuDesignAI(BasePlayer ply) { }

	// RVA: 0x79C6E0 Offset: 0x79ACE0 VA: 0x18079C6E0
	public bool CanDesignAI(BasePlayer player) { }

	// RVA: 0x79CBC0 Offset: 0x79B1C0 VA: 0x18079CBC0
	public void .ctor() { }

}

