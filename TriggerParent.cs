public class TriggerParent : TriggerBase, IServerComponent // TypeDefIndex: 10036
{	[TooltipAttribute] // RVA: 0xB0340 Offset: 0xAF740 VA: 0x1800B0340
	[SerializeField] // RVA: 0xB0340 Offset: 0xAF740 VA: 0x1800B0340
	private bool doClippingCheck; // 0x30
	[TooltipAttribute] // RVA: 0xB0500 Offset: 0xAF900 VA: 0x1800B0500
	public BaseMountable associatedMountable; // 0x38
	[TooltipAttribute] // RVA: 0xB0570 Offset: 0xAF970 VA: 0x1800B0570
	public bool parentMountedPlayers; // 0x40
	[TooltipAttribute] // RVA: 0xB0600 Offset: 0xAFA00 VA: 0x1800B0600
	public bool parentSleepers; // 0x41
	public bool ParentNPCPlayers; // 0x42
	[TooltipAttribute] // RVA: 0xB0740 Offset: 0xAFB40 VA: 0x1800B0740
	public bool overrideOtherTriggers; // 0x43
	public const int CLIP_CHECK_MASK = 1218511105;


	public void .ctor() { }

}

