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

	// RVA: 0x792520 Offset: 0x790B20 VA: 0x180792520 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7923D0 Offset: 0x7909D0 VA: 0x1807923D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x792270 Offset: 0x790870 VA: 0x180792270
	public void Flash() { }

	// RVA: 0x7921D0 Offset: 0x7907D0 VA: 0x1807921D0
	public void FlashOn() { }

	// RVA: 0x7925E0 Offset: 0x790BE0 VA: 0x1807925E0
	public void SetOff() { }

	// RVA: 0x792620 Offset: 0x790C20 VA: 0x180792620
	public void .ctor() { }

}

