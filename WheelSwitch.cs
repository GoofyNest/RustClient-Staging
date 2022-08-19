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

	// RVA: 0x8F5490 Offset: 0x8F3A90 VA: 0x1808F5490 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8F5B30 Offset: 0x8F4130 VA: 0x1808F5B30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8F5860 Offset: 0x8F3E60 VA: 0x1808F5860 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F5950 Offset: 0x8F3F50 VA: 0x1808F5950 Slot: 69
	public override void OnUseStopped(BasePlayer player) { }

	// RVA: 0x5B12D0 Offset: 0x5AF8D0 VA: 0x1805B12D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8F59B0 Offset: 0x8F3FB0 VA: 0x1808F59B0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x9CE50 Offset: 0x9C250 VA: 0x18009CE50
	[BaseEntity.Menu.Description] // RVA: 0x9CE50 Offset: 0x9C250 VA: 0x18009CE50
	[BaseEntity.Menu.Icon] // RVA: 0x9CE50 Offset: 0x9C250 VA: 0x18009CE50
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CE50 Offset: 0x9C250 VA: 0x18009CE50
	// RVA: 0x8F5820 Offset: 0x8F3E20 VA: 0x1808F5820
	public void Menu_Turn(BasePlayer player) { }

	// RVA: 0x8F5800 Offset: 0x8F3E00 VA: 0x1808F5800
	public bool Menu_Turn_ShowIf(BasePlayer player) { }

	// RVA: 0x8F5790 Offset: 0x8F3D90 VA: 0x1808F5790
	public bool IsBeingRotated() { }

	// RVA: 0x8F57A0 Offset: 0x8F3DA0 VA: 0x1808F57A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8F5AA0 Offset: 0x8F40A0 VA: 0x1808F5AA0
	public void .ctor() { }

}

