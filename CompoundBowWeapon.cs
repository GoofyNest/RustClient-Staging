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

	// RVA: 0x6D2360 Offset: 0x6D0960 VA: 0x1806D2360 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D2B00 Offset: 0x6D1100 VA: 0x1806D2B00
	public void UpdateMovementPenalty(float delta) { }

	// RVA: 0x6D1DB0 Offset: 0x6D03B0 VA: 0x1806D1DB0 Slot: 165
	public override void DidAttackClientside() { }

	// RVA: 0x6D2020 Offset: 0x6D0620 VA: 0x1806D2020 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6D1F80 Offset: 0x6D0580 VA: 0x1806D1F80 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x6D2550 Offset: 0x6D0B50 VA: 0x1806D2550
	public void SetStringHeld(bool isHeld) { }

	// RVA: 0x6D2450 Offset: 0x6D0A50 VA: 0x1806D2450 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x6D1E50 Offset: 0x6D0450 VA: 0x1806D1E50
	public float GetLastPlayerMovementTime() { }

	// RVA: 0x6D1EC0 Offset: 0x6D04C0 VA: 0x1806D1EC0
	public float GetStringBonusScale() { }

	// RVA: 0x6D1DD0 Offset: 0x6D03D0 VA: 0x1806D1DD0 Slot: 160
	public override float GetDamageScale(bool getMax = False) { }

	// RVA: 0x6D1E10 Offset: 0x6D0410 VA: 0x1806D1E10 Slot: 161
	public override float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x6D1E80 Offset: 0x6D0480 VA: 0x1806D1E80 Slot: 162
	public override float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x6D25C0 Offset: 0x6D0BC0 VA: 0x1806D25C0
	private void StopDrawSounds() { }

	// RVA: 0x6D26F0 Offset: 0x6D0CF0 VA: 0x1806D26F0
	private void UpdateDrawSounds() { }

	// RVA: 0x6D2C90 Offset: 0x6D1290 VA: 0x1806D2C90
	public void .ctor() { }

}

