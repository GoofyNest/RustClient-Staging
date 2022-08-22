public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9756
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool supportsMouseSteer; // 0x328
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; // 0x329

	// Methods

	// RVA: 0x7D9D00 Offset: 0x7D8300 VA: 0x1807D9D00 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x7D9DD0 Offset: 0x7D83D0 VA: 0x1807D9DD0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x5A6510 Offset: 0x5A4B10 VA: 0x1805A6510
	public void .ctor() { }

}

