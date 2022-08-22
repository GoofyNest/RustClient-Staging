public class ElectricalHeater : IOEntity // TypeDefIndex: 8705
{	// Fields
	public float fadeDuration; // 0x288
	public Light sourceLight; // 0x290
	public GrowableHeatSource growableHeatSource; // 0x298
	private float initialIntensity; // 0x2A0
	private float currentScale; // 0x2A4
	private bool wasOn; // 0x2A8

	// Methods

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC2780 Offset: 0xAC0D80 VA: 0x180AC2780 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAC24E0 Offset: 0xAC0AE0 VA: 0x180AC24E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAC26D0 Offset: 0xAC0CD0 VA: 0x180AC26D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xAC2540 Offset: 0xAC0B40 VA: 0x180AC2540
	public void LightLerp() { }

	// RVA: 0xAC2840 Offset: 0xAC0E40 VA: 0x180AC2840
	public void .ctor() { }

}

