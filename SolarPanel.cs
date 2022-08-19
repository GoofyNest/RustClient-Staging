public class SolarPanel : IOEntity // TypeDefIndex: 8712
{	// Fields
	public Transform sunSampler; // 0x288
	private const int tickrateSeconds = 60;
	public int maximalPowerOutput; // 0x290
	public float dot_minimum; // 0x294
	public float dot_maximum; // 0x298

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x5BFA60 Offset: 0x5BE060 VA: 0x1805BFA60 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5BFA70 Offset: 0x5BE070 VA: 0x1805BFA70
	public void .ctor() { }

}

