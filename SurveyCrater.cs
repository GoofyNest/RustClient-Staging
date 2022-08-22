public class SurveyCrater : BaseCombatEntity // TypeDefIndex: 8461
{	// Fields
	private Option __menuOption_Menu_AnalysisComplete; // 0x240
	private ResourceDispenser resourceDispenser; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7A6050 Offset: 0x7A4650 VA: 0x1807A6050 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A64B0 Offset: 0x7A4AB0 VA: 0x1807A64B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A63C0 Offset: 0x7A49C0 VA: 0x1807A63C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7A5E80 Offset: 0x7A4480 VA: 0x1807A5E80 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x7A5E90 Offset: 0x7A4490 VA: 0x1807A5E90 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.Description] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.Icon] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F500 Offset: 0x8E900 VA: 0x18008F500
	// RVA: 0x7A6380 Offset: 0x7A4980 VA: 0x1807A6380
	public void Menu_AnalysisComplete(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Analysis_Start() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_PerformAnalysis_ShowIf(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

