public class FlasherLight : IOEntity // TypeDefIndex: 10443
{
	public EmissionToggle toggler;
	public Light myLight;
	public float flashSpacing;
	public float flashBurstSpacing;
	public float flashOnTime;
	public int numFlashesPerBurst;
	private int flashBurstCount;


	public override void ResetState() { }

	public override void PostNetworkUpdate() { }

	public void Flash() { }

	public void FlashOn() { }

	public void SetOff() { }

	public void .ctor() { }

}

