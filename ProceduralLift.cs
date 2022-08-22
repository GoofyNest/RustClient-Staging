public class ProceduralLift : BaseEntity // TypeDefIndex: 8432
{	// Fields
	private Option __menuOption_Menu_UseLift; // 0x168
	public float movementSpeed; // 0x1C0
	public float resetDelay; // 0x1C4
	public ProceduralLiftCabin cabin; // 0x1C8
	public ProceduralLiftStop[] stops; // 0x1D0
	public GameObjectRef triggerPrefab; // 0x1D8
	public string triggerBone; // 0x1E0
	private int floorIndex; // 0x1E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x9A8470 Offset: 0x9A6A70 VA: 0x1809A8470 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A8FA0 Offset: 0x9A75A0 VA: 0x1809A8FA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A89D0 Offset: 0x9A6FD0 VA: 0x1809A89D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A8760 Offset: 0x9A6D60 VA: 0x1809A8760 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Description] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Icon] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	// RVA: 0x9A8900 Offset: 0x9A6F00 VA: 0x1809A8900
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x9A88E0 Offset: 0x9A6EE0 VA: 0x1809A88E0
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x9A8AC0 Offset: 0x9A70C0 VA: 0x1809A8AC0
	private void ResetLift() { }

	// RVA: 0x9A8940 Offset: 0x9A6F40 VA: 0x1809A8940
	private void MoveToFloor(int floor) { }

	// RVA: 0x9A8AD0 Offset: 0x9A70D0 VA: 0x1809A8AD0
	private void SnapToFloor(int floor) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnFinishedMoving() { }

	// RVA: 0x9A8BF0 Offset: 0x9A71F0 VA: 0x1809A8BF0
	protected void Update() { }

	// RVA: 0x9A8F30 Offset: 0x9A7530 VA: 0x1809A8F30
	public void .ctor() { }

}

