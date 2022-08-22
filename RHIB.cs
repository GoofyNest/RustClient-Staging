public class RHIB : MotorRowboat // TypeDefIndex: 8439
{	private Option __menuOption_Release; // 0x688
	public GameObject steeringWheel; // 0x6E0
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float rhibpopulation; // 0x0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.Description] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.Icon] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	[BaseEntity.Menu.ShowIf] // RVA: 0x80A30 Offset: 0x7FE30 VA: 0x180080A30
	public void Release(BasePlayer player) { }

	public bool Release_ShowIf(BasePlayer player) { }

	public override bool LookingAtEngine(BasePlayer player) { }

	public override bool LookingAtFuelArea(BasePlayer player) { }

	public override void UpdateEngineRotation() { }

	public void .ctor() { }

	private static void .cctor() { }

}

