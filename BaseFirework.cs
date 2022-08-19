public class BaseFirework : BaseCombatEntity, IIgniteable // TypeDefIndex: 8271
{	// Fields
	public float fuseLength; // 0x240
	public float activityLength; // 0x244
	public const BaseEntity.Flags Flag_Spent = 65536;
	public float corpseDuration; // 0x248
	public bool limitActiveCount; // 0x24C

	// Methods

	// RVA: 0x7DFE50 Offset: 0x7DE450 VA: 0x1807DFE50
	public bool IsLit() { }

	// RVA: 0x7E7700 Offset: 0x7E5D00 VA: 0x1807E7700
	public bool IsExhausted() { }

	// RVA: 0x7E7650 Offset: 0x7E5C50 VA: 0x1807E7650 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x7E7710 Offset: 0x7E5D10 VA: 0x1807E7710
	public void .ctor() { }

}

