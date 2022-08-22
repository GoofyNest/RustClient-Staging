public class BaseFirework : BaseCombatEntity, IIgniteable // TypeDefIndex: 8271
{	// Fields
	public float fuseLength; // 0x240
	public float activityLength; // 0x244
	public const BaseEntity.Flags Flag_Spent = 65536;
	public float corpseDuration; // 0x248
	public bool limitActiveCount; // 0x24C

	// Methods

	// RVA: 0x7AB880 Offset: 0x7A9E80 VA: 0x1807AB880
	public bool IsLit() { }

	// RVA: 0x7B3130 Offset: 0x7B1730 VA: 0x1807B3130
	public bool IsExhausted() { }

	// RVA: 0x7B3080 Offset: 0x7B1680 VA: 0x1807B3080 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x7B3140 Offset: 0x7B1740 VA: 0x1807B3140
	public void .ctor() { }

}

