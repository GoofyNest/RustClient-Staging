public class SurveyCrater : BaseCombatEntity // TypeDefIndex: 8461
{	// Fields
	private Option __menuOption_Menu_AnalysisComplete; // 0x240
	private ResourceDispenser resourceDispenser; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7A5F40 Offset: 0x7A4540 VA: 0x1807A5F40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A63A0 Offset: 0x7A49A0 VA: 0x1807A63A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A62B0 Offset: 0x7A48B0 VA: 0x1807A62B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7A5D70 Offset: 0x7A4370 VA: 0x1807A5D70 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x7A5D80 Offset: 0x7A4380 VA: 0x1807A5D80 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.Description] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.Icon] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	// RVA: 0x7A6270 Offset: 0x7A4870 VA: 0x1807A6270
	public void Menu_AnalysisComplete(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Analysis_Start() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_PerformAnalysis_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

