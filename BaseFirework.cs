public class BaseFirework : BaseCombatEntity, IIgniteable // TypeDefIndex: 8271
{	// Fields
	public float fuseLength; // 0x240
	public float activityLength; // 0x244
	public const BaseEntity.Flags Flag_Spent = 65536;
	public float corpseDuration; // 0x248
	public bool limitActiveCount; // 0x24C

	// Methods

	// RVA: 0x7DFF60 Offset: 0x7DE560 VA: 0x1807DFF60
	public bool IsLit() { }

	// RVA: 0x7E7810 Offset: 0x7E5E10 VA: 0x1807E7810
	public bool IsExhausted() { }

	// RVA: 0x7E7760 Offset: 0x7E5D60 VA: 0x1807E7760 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x7E7820 Offset: 0x7E5E20 VA: 0x1807E7820
	public void .ctor() { }

}

