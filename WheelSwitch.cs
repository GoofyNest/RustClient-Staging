public class WheelSwitch : IOEntity // TypeDefIndex: 8487
{	// Fields
	private Option __menuOption_Menu_Turn; // 0x288
	public Transform wheelObj; // 0x2E0
	public float rotateSpeed; // 0x2E8
	public BaseEntity.Flags BeingRotated; // 0x2EC
	public BaseEntity.Flags RotatingLeft; // 0x2F0
	public BaseEntity.Flags RotatingRight; // 0x2F4
	public float rotateProgress; // 0x2F8
	public Animator animator; // 0x300
	public float kineticEnergyPerSec; // 0x308
	private BasePlayer rotatorPlayer; // 0x310
	private float animProgress; // 0x318

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8F5AB0 Offset: 0x8F40B0 VA: 0x1808F5AB0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8F6150 Offset: 0x8F4750 VA: 0x1808F6150 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8F5E80 Offset: 0x8F4480 VA: 0x1808F5E80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F5F70 Offset: 0x8F4570 VA: 0x1808F5F70 Slot: 69
	public override void OnUseStopped(BasePlayer player) { }

	// RVA: 0x5B1260 Offset: 0x5AF860 VA: 0x1805B1260 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8F5FD0 Offset: 0x8F45D0 VA: 0x1808F5FD0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	[BaseEntity.Menu.Description] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	[BaseEntity.Menu.Icon] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	// RVA: 0x8F5E40 Offset: 0x8F4440 VA: 0x1808F5E40
	public void Menu_Turn(BasePlayer player) { }

	// RVA: 0x8F5E20 Offset: 0x8F4420 VA: 0x1808F5E20
	public bool Menu_Turn_ShowIf(BasePlayer player) { }

	// RVA: 0x8F5DB0 Offset: 0x8F43B0 VA: 0x1808F5DB0
	public bool IsBeingRotated() { }

	// RVA: 0x8F5DC0 Offset: 0x8F43C0 VA: 0x1808F5DC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8F60C0 Offset: 0x8F46C0 VA: 0x1808F60C0
	public void .ctor() { }

}

