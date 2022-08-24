public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9756
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool supportsMouseSteer; // 0x328
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; // 0x329


	public override Vector2 GetYawClamp() { }

	public override void OnClientInput(BasePlayer player) { }

	public void .ctor() { }

}

