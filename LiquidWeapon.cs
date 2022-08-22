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

	// RVA: 0x4F6C20 Offset: 0x4F5220 VA: 0x1804F6C20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F73C0 Offset: 0x4F59C0 VA: 0x1804F73C0
	public float get_PressureFraction() { }

	// RVA: 0x4F73A0 Offset: 0x4F59A0 VA: 0x1804F73A0
	public float get_MinimumPressureFraction() { }

	// RVA: 0x4F7320 Offset: 0x4F5920 VA: 0x1804F7320
	public float get_CurrentRange() { }

	// RVA: 0x4F7050 Offset: 0x4F5650 VA: 0x1804F7050
	private void StartCooldown(float duration) { }

	// RVA: 0x4F6530 Offset: 0x4F4B30 VA: 0x1804F6530
	private bool OnCooldown() { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	private bool Firing() { }

	// RVA: 0x4F7170 Offset: 0x4F5770 VA: 0x1804F7170
	private void Update() { }

	// RVA: 0x4F6670 Offset: 0x4F4C70 VA: 0x1804F6670 Slot: 163
	public override void OnEmptyPrimaryAttackPressed() { }

	// RVA: 0x4F67F0 Offset: 0x4F4DF0 VA: 0x1804F67F0 Slot: 162
	public override void OnPrimaryAttackPressed() { }

	// RVA: 0x4F6970 Offset: 0x4F4F70 VA: 0x1804F6970 Slot: 164
	public override void OnPrimaryAttackReleased() { }

	// RVA: 0x4F70A0 Offset: 0x4F56A0 VA: 0x1804F70A0
	private void StopFiringAnim() { }

	// RVA: 0x4F69C0 Offset: 0x4F4FC0 VA: 0x1804F69C0 Slot: 166
	public override void OnReloadHeld() { }

	// RVA: 0x4F69F0 Offset: 0x4F4FF0 VA: 0x1804F69F0 Slot: 165
	public override void OnReloadPressed() { }

	// RVA: 0x4F5FE0 Offset: 0x4F45E0 VA: 0x1804F5FE0
	private bool CanPump() { }

	// RVA: 0x4F61C0 Offset: 0x4F47C0 VA: 0x1804F61C0
	private void DryFire() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 167
	public override void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0x4F60F0 Offset: 0x4F46F0 VA: 0x1804F60F0 Slot: 161
	public override void DoSendFilling(bool flag) { }

	// RVA: 0x4F6D10 Offset: 0x4F5310 VA: 0x1804F6D10 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 160
	public override void CLThrow() { }

	// RVA: 0x4F66E0 Offset: 0x4F4CE0 VA: 0x1804F66E0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4F6E00 Offset: 0x4F5400 VA: 0x1804F6E00
	private void SetEmissionEffectActive(bool flag) { }

	// RVA: 0x4F62B0 Offset: 0x4F48B0 VA: 0x1804F62B0
	private LiquidWeaponEffects GetEmissionEffects() { }

	// RVA: 0x4F6560 Offset: 0x4F4B60 VA: 0x1804F6560 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x4F6400 Offset: 0x4F4A00 VA: 0x1804F6400 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4F72A0 Offset: 0x4F58A0 VA: 0x1804F72A0
	public void .ctor() { }

}

