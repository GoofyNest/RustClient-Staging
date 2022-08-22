public class LightListener : BaseEntity // TypeDefIndex: 9636
{	public string onMessage; // 0x168
	public string offMessage; // 0x170
	[TooltipAttribute] // RVA: 0x7CDE0 Offset: 0x7C1E0 VA: 0x18007CDE0
	public LightGroupAtTime onLights; // 0x178
	[TooltipAttribute] // RVA: 0x7CDE0 Offset: 0x7C1E0 VA: 0x18007CDE0
	public LightGroupAtTime offLights; // 0x180


	public override void PostNetworkUpdate() { }

	public void SetLightsOn(bool wantsOn) { }

	public void .ctor() { }

}

