public class BaseProjectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6318
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Magazine primaryMagazine; // 0x18


	public static void ResetToPool(BaseProjectile instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseProjectile instance) { }

	public BaseProjectile Copy() { }

	public static BaseProjectile Deserialize(Stream stream) { }

	public static BaseProjectile DeserializeLengthDelimited(Stream stream) { }

	public static BaseProjectile DeserializeLength(Stream stream, int length) { }

	public static BaseProjectile Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseProjectile previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseProjectile Deserialize(byte[] buffer, BaseProjectile instance, bool isDelta = False) { }

	public static BaseProjectile Deserialize(Stream stream, BaseProjectile instance, bool isDelta) { }

	public static BaseProjectile DeserializeLengthDelimited(Stream stream, BaseProjectile instance, bool isDelta) { }

	public static BaseProjectile DeserializeLength(Stream stream, int length, BaseProjectile instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseProjectile instance, BaseProjectile previous) { }

	public static void Serialize(Stream stream, BaseProjectile instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseProjectile instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseProjectile instance) { }

	public void .ctor() { }

}

public class Attack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6483
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 pointStart; // 0x14
	public Vector3 pointEnd; // 0x20
	public uint hitID; // 0x2C
	public uint hitBone; // 0x30
	public Vector3 hitNormalLocal; // 0x34
	public Vector3 hitPositionLocal; // 0x40
	public Vector3 hitNormalWorld; // 0x4C
	public Vector3 hitPositionWorld; // 0x58
	public uint hitPartID; // 0x64
	public uint hitMaterialID; // 0x68
	public uint hitItem; // 0x6C


	public static void ResetToPool(Attack instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Attack instance) { }

	public Attack Copy() { }

	public static Attack Deserialize(Stream stream) { }

	public static Attack DeserializeLengthDelimited(Stream stream) { }

	public static Attack DeserializeLength(Stream stream, int length) { }

	public static Attack Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Attack previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Attack Deserialize(byte[] buffer, Attack instance, bool isDelta = False) { }

	public static Attack Deserialize(Stream stream, Attack instance, bool isDelta) { }

	public static Attack DeserializeLengthDelimited(Stream stream, Attack instance, bool isDelta) { }

	public static Attack DeserializeLength(Stream stream, int length, Attack instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Attack instance, Attack previous) { }

	public static void Serialize(Stream stream, Attack instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Attack instance) { }

	public static void SerializeLengthDelimited(Stream stream, Attack instance) { }

	public void .ctor() { }

}

public class ProjectileShoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6488
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int ammoType; // 0x14
	public List<ProjectileShoot.Projectile> projectiles; // 0x18


	public static void ResetToPool(ProjectileShoot instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ProjectileShoot instance) { }

	public ProjectileShoot Copy() { }

	public static ProjectileShoot Deserialize(Stream stream) { }

	public static ProjectileShoot DeserializeLengthDelimited(Stream stream) { }

	public static ProjectileShoot DeserializeLength(Stream stream, int length) { }

	public static ProjectileShoot Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ProjectileShoot Deserialize(byte[] buffer, ProjectileShoot instance, bool isDelta = False) { }

	public static ProjectileShoot Deserialize(Stream stream, ProjectileShoot instance, bool isDelta) { }

	public static ProjectileShoot DeserializeLengthDelimited(Stream stream, ProjectileShoot instance, bool isDelta) { }

	public static ProjectileShoot DeserializeLength(Stream stream, int length, ProjectileShoot instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ProjectileShoot instance, ProjectileShoot previous) { }

	public static void Serialize(Stream stream, ProjectileShoot instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ProjectileShoot instance) { }

	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot instance) { }

	public void .ctor() { }

}

public class ProjectileShoot.Projectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6489
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 startPos; // 0x18
	public Vector3 startVel; // 0x24
	public int seed; // 0x30


	public static void ResetToPool(ProjectileShoot.Projectile instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ProjectileShoot.Projectile instance) { }

	public ProjectileShoot.Projectile Copy() { }

	public static ProjectileShoot.Projectile Deserialize(Stream stream) { }

	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream) { }

	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length) { }

	public static ProjectileShoot.Projectile Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot.Projectile previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ProjectileShoot.Projectile Deserialize(byte[] buffer, ProjectileShoot.Projectile instance, bool isDelta = False) { }

	public static ProjectileShoot.Projectile Deserialize(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length, ProjectileShoot.Projectile instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ProjectileShoot.Projectile instance, ProjectileShoot.Projectile previous) { }

	public static void Serialize(Stream stream, ProjectileShoot.Projectile instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ProjectileShoot.Projectile instance) { }

	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance) { }

	public void .ctor() { }

}

public class BaseProjectile : AttackEntity // TypeDefIndex: 8529
{	[HeaderAttribute] // RVA: 0xA5FA0 Offset: 0xA53A0 VA: 0x1800A5FA0
	public float NoiseRadius; // 0x280
	[HeaderAttribute] // RVA: 0xA73A0 Offset: 0xA67A0 VA: 0x1800A73A0
	public float damageScale; // 0x284
	public float distanceScale; // 0x288
	public float projectileVelocityScale; // 0x28C
	public bool automatic; // 0x290
	public bool usableByTurret; // 0x291
	[TooltipAttribute] // RVA: 0xA73D0 Offset: 0xA67D0 VA: 0x1800A73D0
	public float turretDamageScale; // 0x294
	[HeaderAttribute] // RVA: 0x78850 Offset: 0x77C50 VA: 0x180078850
	public GameObjectRef attackFX; // 0x298
	public GameObjectRef silencedAttack; // 0x2A0
	public GameObjectRef muzzleBrakeAttack; // 0x2A8
	public Transform MuzzlePoint; // 0x2B0
	[HeaderAttribute] // RVA: 0xA7590 Offset: 0xA6990 VA: 0x1800A7590
	public float reloadTime; // 0x2B8
	public bool canUnloadAmmo; // 0x2BC
	public BaseProjectile.Magazine primaryMagazine; // 0x2C0
	public bool fractionalReload; // 0x2C8
	public float reloadStartDuration; // 0x2CC
	public float reloadFractionDuration; // 0x2D0
	public float reloadEndDuration; // 0x2D4
	[HeaderAttribute] // RVA: 0x7C220 Offset: 0x7B620 VA: 0x18007C220
	public float aimSway; // 0x2D8
	public float aimSwaySpeed; // 0x2DC
	public RecoilProperties recoil; // 0x2E0
	[HeaderAttribute] // RVA: 0x7C290 Offset: 0x7B690 VA: 0x18007C290
	public AnimationCurve aimconeCurve; // 0x2E8
	public float aimCone; // 0x2F0
	public float hipAimCone; // 0x2F4
	public float aimconePenaltyPerShot; // 0x2F8
	public float aimConePenaltyMax; // 0x2FC
	public float aimconePenaltyRecoverTime; // 0x300
	public float aimconePenaltyRecoverDelay; // 0x304
	public float stancePenaltyScale; // 0x308
	[HeaderAttribute] // RVA: 0xA76E0 Offset: 0xA6AE0 VA: 0x1800A76E0
	public bool hasADS; // 0x30C
	public bool noAimingWhileCycling; // 0x30D
	public bool manualCycle; // 0x30E
	protected bool needsCycle; // 0x30F
	protected bool isCycling; // 0x310
	public bool aiming; // 0x311
	public float resetDuration; // 0x314
	public int numShotsFired; // 0x318
	private float nextReloadTime; // 0x31C
	private float startReloadTime; // 0x320
	private float stancePenalty; // 0x324
	private float aimconePenalty; // 0x328
	private uint cachedModHash; // 0x32C
	private float sightAimConeScale; // 0x330
	private float sightAimConeOffset; // 0x334
	private float hipAimConeScale; // 0x338
	private float hipAimConeOffset; // 0x33C
	protected bool isReloading; // 0x340
	private float swaySampleTime; // 0x344
	private float lastShotTime; // 0x348
	public float reloadPressTime; // 0x34C
	private ItemDefinition ammoTypePreReload; // 0x350
	private int fractionalReloadDesiredCount; // 0x358
	private int fractionalReloadNumAdded; // 0x35C
	private bool triggerReady; // 0x360
	private float nextHeightCheckTime; // 0x364
	private bool cachedUnderground; // 0x368
	private List<Projectile> createdProjectiles; // 0x370

	public RecoilProperties recoilProperties { get; }
	public bool isSemiAuto { get; }
	private bool UsingInfiniteAmmoCheat { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public RecoilProperties get_recoilProperties() { }

	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	public virtual float GetDamageScale(bool getMax = False) { }

	public virtual float GetDistanceScale(bool getMax = False) { }

	public virtual float GetProjectileVelocityScale(bool getMax = False) { }

	protected void StartReloadCooldown(float cooldown) { }

	protected void ResetReloadCooldown() { }

	protected bool HasReloadCooldown() { }

	protected float GetReloadCooldown() { }

	protected float GetReloadIdle() { }

	private void OnDrawGizmos() { }

	public virtual RecoilProperties GetRecoil() { }

	public bool get_isSemiAuto() { }

	public virtual float GetAimCone() { }

	public float ScaleRepeatDelay(float delay) { }

	public Projectile.Modifier GetProjectileModifier() { }

	public virtual void DidAttackClientside() { }

	public override void GetItemOptions(List<Option> options) { }

	public bool ClientIsReloading() { }

	public void NotifySpectatorReloading(bool state) { }

	public override void EditViewAngles() { }

	public override void OnFrame() { }

	public virtual void ShotFired() { }

	public virtual void SimulateAimcone() { }

	public virtual bool CanAttack() { }

	public virtual bool CanAim() { }

	public override void OnInput() { }

	public bool ReadyToAim() { }

	public bool ReadyToFire() { }

	public void AmmoTypeClicked(ItemDefinition newAmmoType) { }

	private void AddAmmoOption(ItemDefinition ammo, List<Option> opts, int order = 0) { }

	public List<Option> GetReloadMenu(BasePlayer player) { }

	private void PredictAmmoType() { }

	public virtual bool HasMoreThanOneAmmoType(AmmoTypes ammoType) { }

	public override void OnDeploy() { }

	private void DoReload() { }

	protected void InsertAmmoFraction() { }

	public void CancelFractionalReloading() { }

	protected void ClientFinishFractionalReload() { }

	protected void ClientSingleReload() { }

	public virtual void DoAttack() { }

	public void BeginCycle() { }

	public virtual void LaunchProjectile() { }

	public void DryFire() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public float GetReloadDuration() { }

	public int GetAvailableAmmo() { }

	public bool IsSilenced() { }

	public bool FiredUnderground() { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	internal void LaunchProjectileClientside(ItemDefinition ammo, int projectileCount, float projSpreadaimCone) { }

	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	protected virtual void UpdateAmmoDisplay() { }

	private bool get_UsingInfiniteAmmoCheat() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

public class BaseProjectile.Magazine // TypeDefIndex: 8530
{	public BaseProjectile.Magazine.Definition definition; // 0x10
	public int capacity; // 0x18
	public int contents; // 0x1C
	[ItemSelector] // RVA: 0xA77B0 Offset: 0xA6BB0 VA: 0x1800A77B0
	public ItemDefinition ammoType; // 0x20


	public void ServerInit() { }

	public Magazine Save() { }

	public void Load(Magazine mag) { }

	public bool CanReload(BasePlayer owner) { }

	public void .ctor() { }

}

public struct BaseProjectile.Magazine.Definition // TypeDefIndex: 8531
{	[TooltipAttribute] // RVA: 0xA7800 Offset: 0xA6C00 VA: 0x1800A7800
	public int builtInSize; // 0x0
	[TooltipAttribute] // RVA: 0xA7B00 Offset: 0xA6F00 VA: 0x1800A7B00
	[InspectorFlagsAttribute] // RVA: 0xA7B00 Offset: 0xA6F00 VA: 0x1800A7B00
	public AmmoTypes ammoTypes; // 0x4

}

private sealed class BaseProjectile.<>c // TypeDefIndex: 8532
{	public static readonly BaseProjectile.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_0; // 0x8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_1; // 0x10
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_2; // 0x18
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_3; // 0x20
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_4; // 0x28
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_5; // 0x30
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_6; // 0x38
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_7; // 0x40
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__64_0; // 0x48
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__64_1; // 0x50
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__64_2; // 0x58
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__64_3; // 0x60
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_0; // 0x68
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_1; // 0x70
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_2; // 0x78
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_3; // 0x80
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_4; // 0x88
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_5; // 0x90
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__65_6; // 0x98
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__65_7; // 0xA0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_0; // 0xA8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_1; // 0xB0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_2; // 0xB8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_3; // 0xC0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_4; // 0xC8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_5; // 0xD0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_6; // 0xD8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_7; // 0xE0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__76_0; // 0xE8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__76_1; // 0xF0
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__76_2; // 0xF8
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__76_3; // 0x100
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__98_0; // 0x108
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__98_1; // 0x110
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__98_2; // 0x118
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__98_3; // 0x120
	public static Func<ProjectileWeaponMod, bool> <>9__110_0; // 0x128
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__112_0; // 0x130
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__112_1; // 0x138
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__112_2; // 0x140
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__112_3; // 0x148


	private static void .cctor() { }

	public void .ctor() { }

	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_0(ProjectileWeaponMod x) { }

	internal float <GetAimCone>b__63_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_2(ProjectileWeaponMod x) { }

	internal float <GetAimCone>b__63_3(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_4(ProjectileWeaponMod x) { }

	internal float <GetAimCone>b__63_5(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_6(ProjectileWeaponMod x) { }

	internal float <GetAimCone>b__63_7(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_0(ProjectileWeaponMod x) { }

	internal float <ScaleRepeatDelay>b__64_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_2(ProjectileWeaponMod x) { }

	internal float <ScaleRepeatDelay>b__64_3(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_0(ProjectileWeaponMod x) { }

	internal float <GetProjectileModifier>b__65_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_2(ProjectileWeaponMod x) { }

	internal float <GetProjectileModifier>b__65_3(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_4(ProjectileWeaponMod x) { }

	internal float <GetProjectileModifier>b__65_5(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_6(ProjectileWeaponMod x) { }

	internal float <GetProjectileModifier>b__65_7(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_0(ProjectileWeaponMod x) { }

	internal float <EditViewAngles>b__72_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_2(ProjectileWeaponMod x) { }

	internal float <EditViewAngles>b__72_3(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_4(ProjectileWeaponMod x) { }

	internal float <EditViewAngles>b__72_5(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_6(ProjectileWeaponMod x) { }

	internal float <EditViewAngles>b__72_7(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_0(ProjectileWeaponMod x) { }

	internal float <SimulateAimcone>b__76_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_2(ProjectileWeaponMod x) { }

	internal float <SimulateAimcone>b__76_3(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_0(ProjectileWeaponMod x) { }

	internal float <DoAttack>b__98_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_2(ProjectileWeaponMod x) { }

	internal float <DoAttack>b__98_3(ProjectileWeaponMod.Modifier y) { }

	internal bool <OnSignal>b__110_0(ProjectileWeaponMod x) { }

	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_0(ProjectileWeaponMod x) { }

	internal float <LaunchProjectileClientside>b__112_1(ProjectileWeaponMod.Modifier y) { }

	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_2(ProjectileWeaponMod x) { }

	internal float <LaunchProjectileClientside>b__112_3(ProjectileWeaponMod.Modifier y) { }

}

private sealed class BaseProjectile.<>c__DisplayClass84_0 // TypeDefIndex: 8533
{	public BaseProjectile <>4__this; // 0x10
	public ItemDefinition ammoType; // 0x18


	public void .ctor() { }

	internal void <AddAmmoOption>b__0(BasePlayer ply) { }

}

public class Projectile : BaseMonoBehaviour // TypeDefIndex: 9223
{	public const float moveDeltaTime = 0,03125;
	public const float lifeTime = 8;
	[HeaderAttribute] // RVA: 0xDA3F0 Offset: 0xD97F0 VA: 0x1800DA3F0
	public Vector3 initialVelocity; // 0x18
	public float drag; // 0x24
	public float gravityModifier; // 0x28
	public float thickness; // 0x2C
	[TooltipAttribute] // RVA: 0xDA5C0 Offset: 0xD99C0 VA: 0x1800DA5C0
	public float initialDistance; // 0x30
	[HeaderAttribute] // RVA: 0xDA6D0 Offset: 0xD9AD0 VA: 0x1800DA6D0
	public bool remainInWorld; // 0x34
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float stickProbability; // 0x38
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float breakProbability; // 0x3C
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float conditionLoss; // 0x40
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float ricochetChance; // 0x44
	public float penetrationPower; // 0x48
	[HeaderAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	public DamageProperties damageProperties; // 0x50
	[HorizontalAttribute] // RVA: 0xC9110 Offset: 0xC8510 VA: 0x1800C9110
	public MinMax damageDistances; // 0x58
	[HorizontalAttribute] // RVA: 0xC9110 Offset: 0xC8510 VA: 0x1800C9110
	public MinMax damageMultipliers; // 0x60
	public List<DamageTypeEntry> damageTypes; // 0x68
	[HeaderAttribute] // RVA: 0xDAD20 Offset: 0xDA120 VA: 0x1800DAD20
	public ScaleRenderer rendererToScale; // 0x70
	public ScaleRenderer firstPersonRenderer; // 0x78
	public bool createDecals; // 0x80
	[HeaderAttribute] // RVA: 0x78850 Offset: 0x77C50 VA: 0x180078850
	public bool doDefaultHitEffects; // 0x81
	[HeaderAttribute] // RVA: 0x72120 Offset: 0x71520 VA: 0x180072120
	public SoundDefinition flybySound; // 0x88
	public float flybySoundDistance; // 0x90
	public SoundDefinition closeFlybySound; // 0x98
	public float closeFlybyDistance; // 0xA0
	[HeaderAttribute] // RVA: 0xDAFC0 Offset: 0xDA3C0 VA: 0x1800DAFC0
	public float tumbleSpeed; // 0xA4
	public Vector3 tumbleAxis; // 0xA8
	[HeaderAttribute] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	public Vector3 swimScale; // 0xB4
	public Vector3 swimSpeed; // 0xC0
	public BasePlayer owner; // 0xD0
	public AttackEntity sourceWeaponPrefab; // 0xD8
	public Projectile sourceProjectilePrefab; // 0xE0
	public ItemModProjectile mod; // 0xE8
	public int projectileID; // 0xF0
	public int seed; // 0xF4
	public bool clientsideEffect; // 0xF8
	public bool clientsideAttack; // 0xF9
	public float integrity; // 0xFC
	public float maxDistance; // 0x100
	public Projectile.Modifier modifier; // 0x104
	public bool invisible; // 0x114
	private Vector3 currentVelocity; // 0x118
	private Vector3 currentPosition; // 0x124
	private float traveledDistance; // 0x130
	private float traveledTime; // 0x134
	private float launchTime; // 0x138
	private Vector3 sentPosition; // 0x13C
	private Vector3 previousPosition; // 0x148
	private Vector3 previousVelocity; // 0x154
	private float previousTraveledTime; // 0x160
	private bool isRicochet; // 0x164
	private bool isRetiring; // 0x165
	private bool flybyPlayed; // 0x166
	private bool wasFacingPlayer; // 0x167
	private Plane flybyPlane; // 0x168
	private Ray flybyRay; // 0x178
	private Action cleanupAction; // 0x190
	private HitTest hitTest; // 0x198
	private float swimRandom; // 0x1A0
	private static uint _fleshMaterialID; // 0x0
	private static uint _waterMaterialID; // 0x4
	private static uint cachedWaterString; // 0x8

	public bool isAuthoritative { get; }
	private bool isAlive { get; }


	public void CalculateDamage(HitInfo info, Projectile.Modifier mod, float scale) { }

	public bool get_isAuthoritative() { }

	private bool get_isAlive() { }

	private void Retire() { }

	private void Cleanup() { }

	public void AdjustVelocity(Vector3 delta) { }

	public void InitializeVelocity(Vector3 overrideVel) { }

	protected void OnDisable() { }

	protected void Update() { }

	private void SetEffectScale(float eScale) { }

	private void DoFlybySound() { }

	protected virtual float CalculateEffectScale() { }

	private void UpdateVelocity(float deltaTime) { }

	private void DoVelocityUpdate(float deltaTime) { }

	private void DoMovement(float deltaTime) { }

	private bool DoWaterHit(ref HitTest test, Vector3 targetPosition) { }

	private bool DoRicochet(HitTest test, Vector3 point, Vector3 normal) { }

	private bool DoHit(HitTest test, Vector3 point, Vector3 normal) { }

	protected virtual void AdditiveImpactEffect(HitInfo info) { }

	private bool Reflect(ref uint seed, Vector3 point, Vector3 normal) { }

	private bool Refract(ref uint seed, Vector3 point, Vector3 normal, float resistance) { }

	private Vector3 Refract(Vector3 v, Vector3 n, float f) { }

	private Quaternion RandomRotation(ref uint seed, float range) { }

	internal void Launch() { }

	public static uint FleshMaterialID() { }

	public static uint WaterMaterialID() { }

	public static bool IsWaterMaterial(string hitMaterial) { }

	public static bool ShouldStopProjectile(RaycastHit hit) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Projectile.Modifier // TypeDefIndex: 9224
{	public float damageScale; // 0x0
	public float damageOffset; // 0x4
	public float distanceScale; // 0x8
	public float distanceOffset; // 0xC
	public static Projectile.Modifier Default; // 0x0


	private static void .cctor() { }

}

public class ProjectileTestSpawner : MonoBehaviour // TypeDefIndex: 9323
{	public Projectile TargetProjectile; // 0x18
	public float RepeatTime; // 0x20
	public float VelocityScale; // 0x24


	public void .ctor() { }

}

public class AttackTickAIEvent : BaseAIEvent // TypeDefIndex: 9391
{
	public void .ctor() { }

}

public class AttackedAIEvent : BaseAIEvent // TypeDefIndex: 9392
{	protected float lastExecuteTime; // 0x40
	private BaseCombatEntity combatEntity; // 0x48


	public void .ctor() { }

}

public class AttackEntity : HeldEntity // TypeDefIndex: 9460
{	[HeaderAttribute] // RVA: 0x71690 Offset: 0x70A90 VA: 0x180071690
	public float deployDelay; // 0x1F8
	public float repeatDelay; // 0x1FC
	public float animationDelay; // 0x200
	[HeaderAttribute] // RVA: 0x717D0 Offset: 0x70BD0 VA: 0x1800717D0
	public float effectiveRange; // 0x204
	public float npcDamageScale; // 0x208
	public float attackLengthMin; // 0x20C
	public float attackLengthMax; // 0x210
	public float attackSpacing; // 0x214
	public float aiAimSwayOffset; // 0x218
	public float aiAimCone; // 0x21C
	public bool aiOnlyInRange; // 0x220
	public float CloseRangeAddition; // 0x224
	public float MediumRangeAddition; // 0x228
	public float LongRangeAddition; // 0x22C
	public bool CanUseAtMediumRange; // 0x230
	public bool CanUseAtLongRange; // 0x231
	public SoundDefinition[] reloadSounds; // 0x238
	public SoundDefinition thirdPersonMeleeSound; // 0x240
	[HeaderAttribute] // RVA: 0x71930 Offset: 0x70D30 VA: 0x180071930
	public float recoilCompDelayOverride; // 0x248
	public bool wantsRecoilComp; // 0x24C
	private float nextAttackTime; // 0x250
	private float lastTickTime; // 0x254
	private float nextTickTime; // 0x258
	private float timeSinceDeploy; // 0x25C
	public static Vector3 reductionSpeedScalars; // 0x0
	private float lastRecoilCompTime; // 0x260
	private Vector3 startAimingDirection; // 0x264
	private bool wasDoingRecoilComp; // 0x270
	private Vector3 reductionSpeed; // 0x274

	public float NextAttackTime { get; }


	public virtual Vector3 GetInheritedVelocity(BasePlayer player) { }

	public float get_NextAttackTime() { }

	public virtual void GetAttackStats(HitInfo info) { }

	protected void StartAttackCooldownRaw(float cooldown) { }

	protected void StartAttackCooldown(float cooldown) { }

	protected void ResetAttackCooldown() { }

	public bool HasAttackCooldown() { }

	protected float GetAttackCooldown() { }

	protected float GetAttackIdle() { }

	protected float CalculateCooldownTime(float nextTime, float cooldown, bool catchup) { }

	public virtual bool IsFullyDeployed() { }

	protected void ProcessInputTime() { }

	public override void OnInput() { }

	public override void OnDeploy() { }

	public void SpectatorNotifyDeploy() { }

	public void SpectatorNotifyTick() { }

	public bool RecoilCompReady() { }

	public override void AddPunch(Vector3 amount, float duration) { }

	public override void DoRecoilCompensation() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ProjectileWeaponMod : BaseEntity // TypeDefIndex: 9626
{	[HeaderAttribute] // RVA: 0x7C060 Offset: 0x7B460 VA: 0x18007C060
	public GameObjectRef defaultSilencerEffect; // 0x168
	public bool isSilencer; // 0x170
	[HeaderAttribute] // RVA: 0x7C160 Offset: 0x7B560 VA: 0x18007C160
	public ProjectileWeaponMod.Modifier repeatDelay; // 0x174
	public ProjectileWeaponMod.Modifier projectileVelocity; // 0x180
	public ProjectileWeaponMod.Modifier projectileDamage; // 0x18C
	public ProjectileWeaponMod.Modifier projectileDistance; // 0x198
	[HeaderAttribute] // RVA: 0x7C220 Offset: 0x7B620 VA: 0x18007C220
	public ProjectileWeaponMod.Modifier aimsway; // 0x1A4
	public ProjectileWeaponMod.Modifier aimswaySpeed; // 0x1B0
	public ProjectileWeaponMod.Modifier recoil; // 0x1BC
	[HeaderAttribute] // RVA: 0x7C290 Offset: 0x7B690 VA: 0x18007C290
	public ProjectileWeaponMod.Modifier sightAimCone; // 0x1C8
	public ProjectileWeaponMod.Modifier hipAimCone; // 0x1D4
	[HeaderAttribute] // RVA: 0x7C3D0 Offset: 0x7B7D0 VA: 0x18007C3D0
	public bool isLight; // 0x1E0
	[HeaderAttribute] // RVA: 0x7C490 Offset: 0x7B890 VA: 0x18007C490
	public bool isMuzzleBrake; // 0x1E1
	[HeaderAttribute] // RVA: 0x7C650 Offset: 0x7BA50 VA: 0x18007C650
	public bool isMuzzleBoost; // 0x1E2
	[HeaderAttribute] // RVA: 0x7C730 Offset: 0x7BB30 VA: 0x18007C730
	public bool isScope; // 0x1E3
	public float zoomAmountDisplayOnly; // 0x1E4
	[HeaderAttribute] // RVA: 0x7C950 Offset: 0x7BD50 VA: 0x18007C950
	public ProjectileWeaponMod.Modifier magazineCapacity; // 0x1E8
	public bool needsOnForEffects; // 0x1F4


	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public virtual void SetAiming(bool isAiming) { }

	public float GetZoomAmount() { }

	public static float Mult(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	public static float Sum(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	public static float Average(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	public static float Max(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	public static float Min(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	public static IEnumerable<float> GetMods(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value) { }

	public static bool HasBrokenWeaponMod(BaseEntity parentEnt) { }

	public void .ctor() { }

}

public struct ProjectileWeaponMod.Modifier // TypeDefIndex: 9627
{	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0x7C9F0 Offset: 0x7BDF0 VA: 0x18007C9F0
	public float scalar; // 0x4
	[TooltipAttribute] // RVA: 0x7CAC0 Offset: 0x7BEC0 VA: 0x18007CAC0
	public float offset; // 0x8

}

private sealed class ProjectileWeaponMod.<>c // TypeDefIndex: 9628
{	public static readonly ProjectileWeaponMod.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__27_0; // 0x8
	public static Func<ProjectileWeaponMod.Modifier, bool> <>9__27_1; // 0x10
	public static Func<ProjectileWeaponMod, bool> <>9__28_0; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetMods>b__27_0(ProjectileWeaponMod x) { }

	internal bool <GetMods>b__27_1(ProjectileWeaponMod.Modifier x) { }

	internal bool <HasBrokenWeaponMod>b__28_0(ProjectileWeaponMod x) { }

}

public class AttackTickEventUI : BaseEventUI // TypeDefIndex: 10791
{
	public void .ctor() { }

}

public class AttackedEventUI : BaseEventUI // TypeDefIndex: 10792
{
	public void .ctor() { }

}

public class ProjectileWeaponInformationPanel : ItemInformationPanel // TypeDefIndex: 11047
{	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue recoilDisplay; // 0x20
	public ItemStatValue rofDisplay; // 0x28
	public ItemStatValue accuracyDisplay; // 0x30
	public ItemStatValue rangeDisplay; // 0x38


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

