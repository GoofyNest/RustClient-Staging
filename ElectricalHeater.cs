public class ElectricalHeater : IOEntity // TypeDefIndex: 8705
{	// Fields
	public float fadeDuration; // 0x288
	public Light sourceLight; // 0x290
	public GrowableHeatSource growableHeatSource; // 0x298
	private float initialIntensity; // 0x2A0
	private float currentScale; // 0x2A4
	private bool wasOn; // 0x2A8

	// Methods

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC22B0 Offset: 0xAC08B0 VA: 0x180AC22B0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAC2010 Offset: 0xAC0610 VA: 0x180AC2010 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAC2200 Offset: 0xAC0800 VA: 0x180AC2200 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xAC2070 Offset: 0xAC0670 VA: 0x180AC2070
	public void LightLerp() { }

	// RVA: 0xAC2370 Offset: 0xAC0970 VA: 0x180AC2370
	public void .ctor() { }

}

