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

	// RVA: 0x792430 Offset: 0x790A30 VA: 0x180792430 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7922E0 Offset: 0x7908E0 VA: 0x1807922E0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x792180 Offset: 0x790780 VA: 0x180792180
	public void Flash() { }

	// RVA: 0x7920E0 Offset: 0x7906E0 VA: 0x1807920E0
	public void FlashOn() { }

	// RVA: 0x7924F0 Offset: 0x790AF0 VA: 0x1807924F0
	public void SetOff() { }

	// RVA: 0x792530 Offset: 0x790B30 VA: 0x180792530
	public void .ctor() { }

}

