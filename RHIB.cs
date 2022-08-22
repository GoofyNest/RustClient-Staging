public class RHIB : MotorRowboat // TypeDefIndex: 8439
{	// Fields
	private Option __menuOption_Release; // 0x688
	public GameObject steeringWheel; // 0x6E0
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float rhibpopulation; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6A1480 Offset: 0x69FA80 VA: 0x1806A1480 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6A1E10 Offset: 0x6A0410 VA: 0x1806A1E10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6A1890 Offset: 0x69FE90 VA: 0x1806A1890 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.Description] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.Icon] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.ShowIf] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	// RVA: 0x6A1A90 Offset: 0x6A0090 VA: 0x1806A1A90
	public void Release(BasePlayer player) { }

	// RVA: 0x6A1980 Offset: 0x69FF80 VA: 0x1806A1980
	public bool Release_ShowIf(BasePlayer player) { }

	// RVA: 0x6A1790 Offset: 0x69FD90 VA: 0x1806A1790 Slot: 198
	public override bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A1870 Offset: 0x69FE70 VA: 0x1806A1870 Slot: 199
	public override bool LookingAtFuelArea(BasePlayer player) { }

	// RVA: 0x6A1AD0 Offset: 0x6A00D0 VA: 0x1806A1AD0 Slot: 197
	public override void UpdateEngineRotation() { }

	// RVA: 0x6A1DB0 Offset: 0x6A03B0 VA: 0x1806A1DB0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

