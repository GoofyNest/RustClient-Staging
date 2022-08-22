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

	// RVA: 0x8854E0 Offset: 0x883AE0 VA: 0x1808854E0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x885560 Offset: 0x883B60 VA: 0x180885560 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8855C0 Offset: 0x883BC0 VA: 0x1808855C0
	public void .ctor() { }

}

