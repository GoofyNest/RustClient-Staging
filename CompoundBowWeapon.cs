public class CompoundBowWeapon : BowWeapon // TypeDefIndex: 8561
{	// Fields
	public float stringHoldDurationMax; // 0x390
	public float stringBonusDamage; // 0x394
	public float stringBonusDistance; // 0x398
	public float stringBonusVelocity; // 0x39C
	public float movementPenaltyRampUpTime; // 0x3A0
	public float conditionLossPerSecondHeld; // 0x3A4
	public float conditionLossHeldDelay; // 0x3A8
	public SoundDefinition chargeUpSoundDef; // 0x3B0
	public SoundDefinition stringHeldSoundDef; // 0x3B8
	public SoundDefinition drawFinishSoundDef; // 0x3C0
	private Sound chargeUpSound; // 0x3C8
	private Sound stringHeldSound; // 0x3D0
	protected float movementPenalty; // 0x3D8
	private float lastMoveTime; // 0x3DC
	private float currentHoldProgress; // 0x3E0
	internal float stringHoldTimeStart; // 0x3E4
	private bool drawFinishPlayed; // 0x3E8

	// Methods

	// RVA: 0x6D23D0 Offset: 0x6D09D0 VA: 0x1806D23D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D2B70 Offset: 0x6D1170 VA: 0x1806D2B70
	public void UpdateMovementPenalty(float delta) { }

	// RVA: 0x6D1E20 Offset: 0x6D0420 VA: 0x1806D1E20 Slot: 165
	public override void DidAttackClientside() { }

	// RVA: 0x6D2090 Offset: 0x6D0690 VA: 0x1806D2090 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6D1FF0 Offset: 0x6D05F0 VA: 0x1806D1FF0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x6D25C0 Offset: 0x6D0BC0 VA: 0x1806D25C0
	public void SetStringHeld(bool isHeld) { }

	// RVA: 0x6D24C0 Offset: 0x6D0AC0 VA: 0x1806D24C0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x6D1EC0 Offset: 0x6D04C0 VA: 0x1806D1EC0
	public float GetLastPlayerMovementTime() { }

	// RVA: 0x6D1F30 Offset: 0x6D0530 VA: 0x1806D1F30
	public float GetStringBonusScale() { }

	// RVA: 0x6D1E40 Offset: 0x6D0440 VA: 0x1806D1E40 Slot: 160
	public override float GetDamageScale(bool getMax = False) { }

	// RVA: 0x6D1E80 Offset: 0x6D0480 VA: 0x1806D1E80 Slot: 161
	public override float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x6D1EF0 Offset: 0x6D04F0 VA: 0x1806D1EF0 Slot: 162
	public override float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x6D2630 Offset: 0x6D0C30 VA: 0x1806D2630
	private void StopDrawSounds() { }

	// RVA: 0x6D2760 Offset: 0x6D0D60 VA: 0x1806D2760
	private void UpdateDrawSounds() { }

	// RVA: 0x6D2D00 Offset: 0x6D1300 VA: 0x1806D2D00
	public void .ctor() { }

}

