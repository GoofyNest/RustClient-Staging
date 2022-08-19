public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9756
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool supportsMouseSteer; // 0x328
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; // 0x329

	// Methods

	// RVA: 0x7BB800 Offset: 0x7B9E00 VA: 0x1807BB800 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x7BB8D0 Offset: 0x7B9ED0 VA: 0x1807BB8D0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x5A6580 Offset: 0x5A4B80 VA: 0x1805A6580
	public void .ctor() { }

}

