public class LightListener : BaseEntity // TypeDefIndex: 9636
{	public string onMessage; // 0x168
	public string offMessage; // 0x170
	[TooltipAttribute] // RVA: 0x7CD90 Offset: 0x7C190 VA: 0x18007CD90
	public LightGroupAtTime onLights; // 0x178
	[TooltipAttribute] // RVA: 0x7CD90 Offset: 0x7C190 VA: 0x18007CD90
	public LightGroupAtTime offLights; // 0x180


	public override void PostNetworkUpdate() { }

	public void SetLightsOn(bool wantsOn) { }

	public void .ctor() { }

}

