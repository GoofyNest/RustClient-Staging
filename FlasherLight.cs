public class FlasherLight : IOEntity // TypeDefIndex: 8714
{	// Fields
	public EmissionToggle toggler; // 0x288
	public Light myLight; // 0x290
	public float flashSpacing; // 0x298
	public float flashBurstSpacing; // 0x29C
	public float flashOnTime; // 0x2A0
	public int numFlashesPerBurst; // 0x2A4
	private int flashBurstCount; // 0x2A8

	// Methods

	// RVA: 0x792410 Offset: 0x790A10 VA: 0x180792410 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7922C0 Offset: 0x7908C0 VA: 0x1807922C0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x792160 Offset: 0x790760 VA: 0x180792160
	public void Flash() { }

	// RVA: 0x7920C0 Offset: 0x7906C0 VA: 0x1807920C0
	public void FlashOn() { }

	// RVA: 0x7924D0 Offset: 0x790AD0 VA: 0x1807924D0
	public void SetOff() { }

	// RVA: 0x792510 Offset: 0x790B10 VA: 0x180792510
	public void .ctor() { }

}

