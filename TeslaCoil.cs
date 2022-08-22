public class TeslaCoil : IOEntity // TypeDefIndex: 8717
{	// Fields
	public TargetTrigger targetTrigger; // 0x288
	public TriggerMovement movementTrigger; // 0x290
	public float powerToDamageRatio; // 0x298
	public float dischargeTickRate; // 0x29C
	public float maxDischargeSelfDamageSeconds; // 0x2A0
	public float maxDamageOutput; // 0x2A4
	public Transform damageEyes; // 0x2A8
	public const BaseEntity.Flags Flag_WeakShorting = 128;
	public const BaseEntity.Flags Flag_StrongShorting = 256;
	public int powerForHeavyShorting; // 0x2B0

	// Methods

	// RVA: 0x868820 Offset: 0x866E20 VA: 0x180868820 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x8688A0 Offset: 0x866EA0 VA: 0x1808688A0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x868900 Offset: 0x866F00 VA: 0x180868900
	public void .ctor() { }

}

