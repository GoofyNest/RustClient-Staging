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

	// RVA: 0x9A8960 Offset: 0x9A6F60 VA: 0x1809A8960 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A9490 Offset: 0x9A7A90 VA: 0x1809A9490 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A8EC0 Offset: 0x9A74C0 VA: 0x1809A8EC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A8C50 Offset: 0x9A7250 VA: 0x1809A8C50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Description] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Icon] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	// RVA: 0x9A8DF0 Offset: 0x9A73F0 VA: 0x1809A8DF0
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x9A8DD0 Offset: 0x9A73D0 VA: 0x1809A8DD0
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x9A8FB0 Offset: 0x9A75B0 VA: 0x1809A8FB0
	private void ResetLift() { }

	// RVA: 0x9A8E30 Offset: 0x9A7430 VA: 0x1809A8E30
	private void MoveToFloor(int floor) { }

	// RVA: 0x9A8FC0 Offset: 0x9A75C0 VA: 0x1809A8FC0
	private void SnapToFloor(int floor) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnFinishedMoving() { }

	// RVA: 0x9A90E0 Offset: 0x9A76E0 VA: 0x1809A90E0
	protected void Update() { }

	// RVA: 0x9A9420 Offset: 0x9A7A20 VA: 0x1809A9420
	public void .ctor() { }

}

