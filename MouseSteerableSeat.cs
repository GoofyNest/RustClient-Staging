public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9760
{
	[SerializeField] 
	private bool supportsMouseSteer; 
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; 


	public override Vector2 GetYawClamp() { }

	public override void OnClientInput(BasePlayer player) { }

	public void .ctor() { }

}

