public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9756
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool supportsMouseSteer; // 0x328
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; // 0x329

	// Methods

	// RVA: 0x7BB910 Offset: 0x7B9F10 VA: 0x1807BB910 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x7BB9E0 Offset: 0x7B9FE0 VA: 0x1807BB9E0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x5A6580 Offset: 0x5A4B80 VA: 0x1805A6580
	public void .ctor() { }

}

