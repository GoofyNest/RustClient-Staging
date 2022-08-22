public class SolarPanel : IOEntity // TypeDefIndex: 8712
{	// Fields
	public Transform sunSampler; // 0x288
	private const int tickrateSeconds = 60;
	public int maximalPowerOutput; // 0x290
	public float dot_minimum; // 0x294
	public float dot_maximum; // 0x298

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x5BF9F0 Offset: 0x5BDFF0 VA: 0x1805BF9F0 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5BFA00 Offset: 0x5BE000 VA: 0x1805BFA00
	public void .ctor() { }

}

