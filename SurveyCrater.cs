public class SurveyCrater : BaseCombatEntity // TypeDefIndex: 8461
{	// Fields
	private Option __menuOption_Menu_AnalysisComplete; // 0x240
	private ResourceDispenser resourceDispenser; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7C4450 Offset: 0x7C2A50 VA: 0x1807C4450 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7C48B0 Offset: 0x7C2EB0 VA: 0x1807C48B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7C47C0 Offset: 0x7C2DC0 VA: 0x1807C47C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7C4280 Offset: 0x7C2880 VA: 0x1807C4280 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x7C4290 Offset: 0x7C2890 VA: 0x1807C4290 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.Description] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.Icon] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	// RVA: 0x7C4780 Offset: 0x7C2D80 VA: 0x1807C4780
	public void Menu_AnalysisComplete(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Analysis_Start() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool Menu_PerformAnalysis_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

