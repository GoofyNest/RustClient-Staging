public class LiquidWeapon : BaseLiquidVessel // TypeDefIndex: 8597
{	// Fields
	[HeaderAttribute] // RVA: 0xB02B0 Offset: 0xAF6B0 VA: 0x1800B02B0
	public float FireRate; // 0x2F8
	public float MaxRange; // 0x2FC
	public int FireAmountML; // 0x300
	public int MaxPressure; // 0x304
	public int PressureLossPerTick; // 0x308
	public int PressureGainedPerPump; // 0x30C
	public float MinDmgRadius; // 0x310
	public float MaxDmgRadius; // 0x314
	public float SplashRadius; // 0x318
	public GameObjectRef ImpactSplashEffect; // 0x320
	public AnimationCurve PowerCurve; // 0x328
	public List<DamageTypeEntry> Damage; // 0x330
	public LiquidWeaponEffects EntityWeaponEffects; // 0x338
	public bool RequiresPumping; // 0x340
	public bool AutoPump; // 0x341
	public bool WaitForFillAnim; // 0x342
	public bool UseFalloffCurve; // 0x343
	public AnimationCurve FalloffCurve; // 0x348
	public float PumpingBlockDuration; // 0x350
	public float StartFillingBlockDuration; // 0x354
	public float StopFillingBlockDuration; // 0x358
	private float cooldownTime; // 0x35C
	private bool filling; // 0x360
	private LiquidWeaponEffects viewModelweaponEffects; // 0x368
	private int pressure; // 0x370

	// Properties
	public float PressureFraction { get; }
	public float MinimumPressureFraction { get; }
	public float CurrentRange { get; }

	// Methods

	// RVA: 0x4F6C90 Offset: 0x4F5290 VA: 0x1804F6C90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F7430 Offset: 0x4F5A30 VA: 0x1804F7430
	public float get_PressureFraction() { }

	// RVA: 0x4F7410 Offset: 0x4F5A10 VA: 0x1804F7410
	public float get_MinimumPressureFraction() { }

	// RVA: 0x4F7390 Offset: 0x4F5990 VA: 0x1804F7390
	public float get_CurrentRange() { }

	// RVA: 0x4F70C0 Offset: 0x4F56C0 VA: 0x1804F70C0
	private void StartCooldown(float duration) { }

	// RVA: 0x4F65A0 Offset: 0x4F4BA0 VA: 0x1804F65A0
	private bool OnCooldown() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	private bool Firing() { }

	// RVA: 0x4F71E0 Offset: 0x4F57E0 VA: 0x1804F71E0
	private void Update() { }

	// RVA: 0x4F66E0 Offset: 0x4F4CE0 VA: 0x1804F66E0 Slot: 163
	public override void OnEmptyPrimaryAttackPressed() { }

	// RVA: 0x4F6860 Offset: 0x4F4E60 VA: 0x1804F6860 Slot: 162
	public override void OnPrimaryAttackPressed() { }

	// RVA: 0x4F69E0 Offset: 0x4F4FE0 VA: 0x1804F69E0 Slot: 164
	public override void OnPrimaryAttackReleased() { }

	// RVA: 0x4F7110 Offset: 0x4F5710 VA: 0x1804F7110
	private void StopFiringAnim() { }

	// RVA: 0x4F6A30 Offset: 0x4F5030 VA: 0x1804F6A30 Slot: 166
	public override void OnReloadHeld() { }

	// RVA: 0x4F6A60 Offset: 0x4F5060 VA: 0x1804F6A60 Slot: 165
	public override void OnReloadPressed() { }

	// RVA: 0x4F6050 Offset: 0x4F4650 VA: 0x1804F6050
	private bool CanPump() { }

	// RVA: 0x4F6230 Offset: 0x4F4830 VA: 0x1804F6230
	private void DryFire() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 167
	public override void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0x4F6160 Offset: 0x4F4760 VA: 0x1804F6160 Slot: 161
	public override void DoSendFilling(bool flag) { }

	// RVA: 0x4F6D80 Offset: 0x4F5380 VA: 0x1804F6D80 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 160
	public override void CLThrow() { }

	// RVA: 0x4F6750 Offset: 0x4F4D50 VA: 0x1804F6750 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4F6E70 Offset: 0x4F5470 VA: 0x1804F6E70
	private void SetEmissionEffectActive(bool flag) { }

	// RVA: 0x4F6320 Offset: 0x4F4920 VA: 0x1804F6320
	private LiquidWeaponEffects GetEmissionEffects() { }

	// RVA: 0x4F65D0 Offset: 0x4F4BD0 VA: 0x1804F65D0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x4F6470 Offset: 0x4F4A70 VA: 0x1804F6470 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4F7310 Offset: 0x4F5910 VA: 0x1804F7310
	public void .ctor() { }

}

