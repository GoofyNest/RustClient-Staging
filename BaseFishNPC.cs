public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses // TypeDefIndex: 8324
{	private Option __menuOption_MenuDesignAI; // 0x370
	protected FishBrain brain; // 0x3C8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.Description] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

