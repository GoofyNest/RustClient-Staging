public class BaseAnimalNPC : BaseNpc, IAIAttack, IAITirednessAbove, IAISleep, IAIHungerAbove, IAISenses // TypeDefIndex: 8315
{	private Option __menuOption_MenuDesignAI; // 0x370
	public string deathStatName; // 0x3C8
	protected AnimalBrain brain; // 0x3D0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x83320 Offset: 0x82720 VA: 0x180083320
	[BaseEntity.Menu.Description] // RVA: 0x83320 Offset: 0x82720 VA: 0x180083320
	[BaseEntity.Menu.ShowIf] // RVA: 0x83320 Offset: 0x82720 VA: 0x180083320
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

