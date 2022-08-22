public class LightListener : BaseEntity // TypeDefIndex: 9636
{	// Fields
	public string onMessage; // 0x168
	public string offMessage; // 0x170
	[TooltipAttribute] // RVA: 0x7CDE0 Offset: 0x7C1E0 VA: 0x18007CDE0
	public LightGroupAtTime onLights; // 0x178
	[TooltipAttribute] // RVA: 0x7CDE0 Offset: 0x7C1E0 VA: 0x18007CDE0
	public LightGroupAtTime offLights; // 0x180

	// Methods

	// RVA: 0x4F2480 Offset: 0x4F0A80 VA: 0x1804F2480 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4F2610 Offset: 0x4F0C10 VA: 0x1804F2610
	public void SetLightsOn(bool wantsOn) { }

	// RVA: 0x4F2790 Offset: 0x4F0D90 VA: 0x1804F2790
	public void .ctor() { }

}

