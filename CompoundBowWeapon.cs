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

	// RVA: 0x6D22C0 Offset: 0x6D08C0 VA: 0x1806D22C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D2A60 Offset: 0x6D1060 VA: 0x1806D2A60
	public void UpdateMovementPenalty(float delta) { }

	// RVA: 0x6D1D10 Offset: 0x6D0310 VA: 0x1806D1D10 Slot: 165
	public override void DidAttackClientside() { }

	// RVA: 0x6D1F80 Offset: 0x6D0580 VA: 0x1806D1F80 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6D1EE0 Offset: 0x6D04E0 VA: 0x1806D1EE0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x6D24B0 Offset: 0x6D0AB0 VA: 0x1806D24B0
	public void SetStringHeld(bool isHeld) { }

	// RVA: 0x6D23B0 Offset: 0x6D09B0 VA: 0x1806D23B0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x6D1DB0 Offset: 0x6D03B0 VA: 0x1806D1DB0
	public float GetLastPlayerMovementTime() { }

	// RVA: 0x6D1E20 Offset: 0x6D0420 VA: 0x1806D1E20
	public float GetStringBonusScale() { }

	// RVA: 0x6D1D30 Offset: 0x6D0330 VA: 0x1806D1D30 Slot: 160
	public override float GetDamageScale(bool getMax = False) { }

	// RVA: 0x6D1D70 Offset: 0x6D0370 VA: 0x1806D1D70 Slot: 161
	public override float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x6D1DE0 Offset: 0x6D03E0 VA: 0x1806D1DE0 Slot: 162
	public override float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x6D2520 Offset: 0x6D0B20 VA: 0x1806D2520
	private void StopDrawSounds() { }

	// RVA: 0x6D2650 Offset: 0x6D0C50 VA: 0x1806D2650
	private void UpdateDrawSounds() { }

	// RVA: 0x6D2BF0 Offset: 0x6D11F0 VA: 0x1806D2BF0
	public void .ctor() { }

}

