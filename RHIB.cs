public class RHIB : MotorRowboat // TypeDefIndex: 8439
{	// Fields
	private Option __menuOption_Release; // 0x688
	public GameObject steeringWheel; // 0x6E0
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float rhibpopulation; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6A13E0 Offset: 0x69F9E0 VA: 0x1806A13E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6A1D70 Offset: 0x6A0370 VA: 0x1806A1D70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6A17F0 Offset: 0x69FDF0 VA: 0x1806A17F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.Description] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.Icon] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.ShowIf] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	// RVA: 0x6A19F0 Offset: 0x69FFF0 VA: 0x1806A19F0
	public void Release(BasePlayer player) { }

	// RVA: 0x6A18E0 Offset: 0x69FEE0 VA: 0x1806A18E0
	public bool Release_ShowIf(BasePlayer player) { }

	// RVA: 0x6A16F0 Offset: 0x69FCF0 VA: 0x1806A16F0 Slot: 198
	public override bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A17D0 Offset: 0x69FDD0 VA: 0x1806A17D0 Slot: 199
	public override bool LookingAtFuelArea(BasePlayer player) { }

	// RVA: 0x6A1A30 Offset: 0x6A0030 VA: 0x1806A1A30 Slot: 197
	public override void UpdateEngineRotation() { }

	// RVA: 0x6A1D10 Offset: 0x6A0310 VA: 0x1806A1D10
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

