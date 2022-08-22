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

	// RVA: 0x9A81B0 Offset: 0x9A67B0 VA: 0x1809A81B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A8CE0 Offset: 0x9A72E0 VA: 0x1809A8CE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A8710 Offset: 0x9A6D10 VA: 0x1809A8710 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A84A0 Offset: 0x9A6AA0 VA: 0x1809A84A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Description] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Icon] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	// RVA: 0x9A8640 Offset: 0x9A6C40 VA: 0x1809A8640
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x9A8620 Offset: 0x9A6C20 VA: 0x1809A8620
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x9A8800 Offset: 0x9A6E00 VA: 0x1809A8800
	private void ResetLift() { }

	// RVA: 0x9A8680 Offset: 0x9A6C80 VA: 0x1809A8680
	private void MoveToFloor(int floor) { }

	// RVA: 0x9A8810 Offset: 0x9A6E10 VA: 0x1809A8810
	private void SnapToFloor(int floor) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnFinishedMoving() { }

	// RVA: 0x9A8930 Offset: 0x9A6F30 VA: 0x1809A8930
	protected void Update() { }

	// RVA: 0x9A8C70 Offset: 0x9A7270 VA: 0x1809A8C70
	public void .ctor() { }

}

