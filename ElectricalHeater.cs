public class ElectricalHeater : IOEntity // TypeDefIndex: 8705
{	// Fields
	public float fadeDuration; // 0x288
	public Light sourceLight; // 0x290
	public GrowableHeatSource growableHeatSource; // 0x298
	private float initialIntensity; // 0x2A0
	private float currentScale; // 0x2A4
	private bool wasOn; // 0x2A8

	// Methods

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC1FF0 Offset: 0xAC05F0 VA: 0x180AC1FF0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAC1D50 Offset: 0xAC0350 VA: 0x180AC1D50 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAC1F40 Offset: 0xAC0540 VA: 0x180AC1F40 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xAC1DB0 Offset: 0xAC03B0 VA: 0x180AC1DB0
	public void LightLerp() { }

	// RVA: 0xAC20B0 Offset: 0xAC06B0 VA: 0x180AC20B0
	public void .ctor() { }

}

