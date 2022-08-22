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

	// RVA: 0x8F55A0 Offset: 0x8F3BA0 VA: 0x1808F55A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8F5C40 Offset: 0x8F4240 VA: 0x1808F5C40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8F5970 Offset: 0x8F3F70 VA: 0x1808F5970 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F5A60 Offset: 0x8F4060 VA: 0x1808F5A60 Slot: 69
	public override void OnUseStopped(BasePlayer player) { }

	// RVA: 0x5B12D0 Offset: 0x5AF8D0 VA: 0x1805B12D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8F5AC0 Offset: 0x8F40C0 VA: 0x1808F5AC0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	[BaseEntity.Menu.Description] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	[BaseEntity.Menu.Icon] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CF10 Offset: 0x9C310 VA: 0x18009CF10
	// RVA: 0x8F5930 Offset: 0x8F3F30 VA: 0x1808F5930
	public void Menu_Turn(BasePlayer player) { }

	// RVA: 0x8F5910 Offset: 0x8F3F10 VA: 0x1808F5910
	public bool Menu_Turn_ShowIf(BasePlayer player) { }

	// RVA: 0x8F58A0 Offset: 0x8F3EA0 VA: 0x1808F58A0
	public bool IsBeingRotated() { }

	// RVA: 0x8F58B0 Offset: 0x8F3EB0 VA: 0x1808F58B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8F5BB0 Offset: 0x8F41B0 VA: 0x1808F5BB0
	public void .ctor() { }

}

