public class TriggerParent : TriggerBase, IServerComponent // TypeDefIndex: 10036
{	[TooltipAttribute] // RVA: 0xAEB80 Offset: 0xADF80 VA: 0x1800AEB80
	[SerializeField] // RVA: 0xAEB80 Offset: 0xADF80 VA: 0x1800AEB80
	private bool doClippingCheck; // 0x30
	[TooltipAttribute] // RVA: 0xB0010 Offset: 0xAF410 VA: 0x1800B0010
	public BaseMountable associatedMountable; // 0x38
	[TooltipAttribute] // RVA: 0xB0120 Offset: 0xAF520 VA: 0x1800B0120
	public bool parentMountedPlayers; // 0x40
	[TooltipAttribute] // RVA: 0xB0180 Offset: 0xAF580 VA: 0x1800B0180
	public bool parentSleepers; // 0x41
	public bool ParentNPCPlayers; // 0x42
	[TooltipAttribute] // RVA: 0xB01E0 Offset: 0xAF5E0 VA: 0x1800B01E0
	public bool overrideOtherTriggers; // 0x43
	public const int CLIP_CHECK_MASK = 1218511105;


	public void .ctor() { }

}

