public class TriggerParent : TriggerBase, IServerComponent // TypeDefIndex: 10036
{	// Fields
	[TooltipAttribute] // RVA: 0xB0190 Offset: 0xAF590 VA: 0x1800B0190
	[SerializeField] // RVA: 0xB0190 Offset: 0xAF590 VA: 0x1800B0190
	private bool doClippingCheck; // 0x30
	[TooltipAttribute] // RVA: 0xB0350 Offset: 0xAF750 VA: 0x1800B0350
	public BaseMountable associatedMountable; // 0x38
	[TooltipAttribute] // RVA: 0xB03C0 Offset: 0xAF7C0 VA: 0x1800B03C0
	public bool parentMountedPlayers; // 0x40
	[TooltipAttribute] // RVA: 0xB0420 Offset: 0xAF820 VA: 0x1800B0420
	public bool parentSleepers; // 0x41
	public bool ParentNPCPlayers; // 0x42
	[TooltipAttribute] // RVA: 0xB05D0 Offset: 0xAF9D0 VA: 0x1800B05D0
	public bool overrideOtherTriggers; // 0x43
	public const int CLIP_CHECK_MASK = 1218511105;

	// Methods

	// RVA: 0xA22290 Offset: 0xA20890 VA: 0x180A22290
	public void .ctor() { }

}

