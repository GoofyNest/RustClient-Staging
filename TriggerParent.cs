public class TriggerParent : TriggerBase, IServerComponent // TypeDefIndex: 10036
{	[TooltipAttribute] // RVA: 0xB0260 Offset: 0xAF660 VA: 0x1800B0260
	[SerializeField] // RVA: 0xB0260 Offset: 0xAF660 VA: 0x1800B0260
	private bool doClippingCheck; // 0x30
	[TooltipAttribute] // RVA: 0xB03F0 Offset: 0xAF7F0 VA: 0x1800B03F0
	public BaseMountable associatedMountable; // 0x38
	[TooltipAttribute] // RVA: 0xB0460 Offset: 0xAF860 VA: 0x1800B0460
	public bool parentMountedPlayers; // 0x40
	[TooltipAttribute] // RVA: 0xB04F0 Offset: 0xAF8F0 VA: 0x1800B04F0
	public bool parentSleepers; // 0x41
	public bool ParentNPCPlayers; // 0x42
	[TooltipAttribute] // RVA: 0xB0670 Offset: 0xAFA70 VA: 0x1800B0670
	public bool overrideOtherTriggers; // 0x43
	public const int CLIP_CHECK_MASK = 1218511105;


	public void .ctor() { }

}

