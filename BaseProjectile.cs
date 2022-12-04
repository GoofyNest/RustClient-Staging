public class BaseProjectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6327
{
	public bool ShouldPool;
	private bool _disposed;
	public Magazine primaryMagazine;


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

public class Attack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6495
{
	public bool ShouldPool;
	private bool _disposed;
	public Vector3 pointStart;
	public Vector3 pointEnd;
	public uint hitID;
	public uint hitBone;
	public Vector3 hitNormalLocal;
	public Vector3 hitPositionLocal;
	public Vector3 hitNormalWorld;
	public Vector3 hitPositionWorld;
	public uint hitPartID;
	public uint hitMaterialID;
	public uint hitItem;


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

public class ProjectileShoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6500
{
	public bool ShouldPool;
	private bool _disposed;
	public int ammoType;
	public List<ProjectileShoot.Projectile> projectiles;


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

public class ProjectileShoot.Projectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6501
{
	public bool ShouldPool;
	private bool _disposed;
	public int projectileID;
	public Vector3 startPos;
	public Vector3 startVel;
	public int seed;


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

public class BaseProjectile : AttackEntity // TypeDefIndex: 10252
{
	[HeaderAttribute]
	public float NoiseRadius;
	[HeaderAttribute]
	public float damageScale;
	public float distanceScale;
	public float projectileVelocityScale;
	public bool automatic;
	public bool usableByTurret;
	[TooltipAttribute]
	public float turretDamageScale;
	[HeaderAttribute]
	public GameObjectRef attackFX;
	public GameObjectRef silencedAttack;
	public GameObjectRef muzzleBrakeAttack;
	public Transform MuzzlePoint;
	[HeaderAttribute]
	public float reloadTime;
	public bool canUnloadAmmo;
	public BaseProjectile.Magazine primaryMagazine;
	public bool fractionalReload;
	public float reloadStartDuration;
	public float reloadFractionDuration;
	public float reloadEndDuration;
	[HeaderAttribute]
	public float aimSway;
	public float aimSwaySpeed;
	public RecoilProperties recoil;
	[HeaderAttribute]
	public AnimationCurve aimconeCurve;
	public float aimCone;
	public float hipAimCone;
	public float aimconePenaltyPerShot;
	public float aimConePenaltyMax;
	public float aimconePenaltyRecoverTime;
	public float aimconePenaltyRecoverDelay;
	public float stancePenaltyScale;
	[HeaderAttribute]
	public bool hasADS;
	public bool noAimingWhileCycling;
	public bool manualCycle;
	protected bool needsCycle;
	protected bool isCycling;
	public bool aiming;
	[HeaderAttribute]
	public bool isBurstWeapon;
	public bool canChangeFireModes;
	public bool defaultOn;
	public float internalBurstRecoilScale;
	public float internalBurstFireRateScale;
	public float internalBurstAimConeScale;
	public Translate.Phrase Toast_BurstDisabled;
	public Translate.Phrase Toast_BurstEnabled;
	public float resetDuration;
	public int numShotsFired;
	private float nextReloadTime;
	private float startReloadTime;
	private float stancePenalty;
	private float aimconePenalty;
	private uint cachedModHash;
	private float sightAimConeScale;
	private float sightAimConeOffset;
	private float hipAimConeScale;
	private float hipAimConeOffset;
	protected bool isReloading;
	private float swaySampleTime;
	private float lastShotTime;
	public float reloadPressTime;
	private ItemDefinition ammoTypePreReload;
	private int fractionalReloadDesiredCount;
	private int fractionalReloadNumAdded;
	private int currentBurst;
	private bool triggerReady;
	private float nextHeightCheckTime;
	private bool cachedUnderground;
	private List<Projectile> createdProjectiles;

	public RecoilProperties recoilProperties { get; }
	public bool isSemiAuto { get; }
	private bool UsingInfiniteAmmoCheat { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public RecoilProperties get_recoilProperties() { }

	public override Vector3 GetInheritedVelocity(BasePlayer player, Vector3 direction) { }

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

	public bool UsingBurstMode() { }

	public bool UsingInternalBurstMode() { }

	public bool IsBurstEligable() { }

	public float TimeBetweenBursts() { }

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

	public bool IsBursting() { }

	public int GetBurstModeCount() { }

	public virtual void DoAttack() { }

	public void BeginCycle() { }

	public virtual void LaunchProjectile() { }

	public void DryFire() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public float GetReloadDuration() { }

	public int GetAvailableAmmo() { }

	public bool IsBurstDisabled() { }

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

public class BaseProjectile.Magazine // TypeDefIndex: 10253
{
	public BaseProjectile.Magazine.Definition definition;
	public int capacity;
	public int contents;
	[ItemSelector]
	public ItemDefinition ammoType;


	public void ServerInit() { }

	public Magazine Save() { }

	public void Load(Magazine mag) { }

	public bool CanReload(BasePlayer owner) { }

	public void .ctor() { }

}

public struct BaseProjectile.Magazine.Definition // TypeDefIndex: 10254
{
	[TooltipAttribute]
	public int builtInSize;
	[TooltipAttribute]
	[InspectorFlagsAttribute]
	public AmmoTypes ammoTypes;

}

public static class BaseProjectile.BaseProjectileFlags // TypeDefIndex: 10255
{
	public const BaseEntity.Flags BurstToggle = 16384;

}

private sealed class BaseProjectile.<>c // TypeDefIndex: 10256
{
	public static readonly BaseProjectile.<>c <>9;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_3;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_4;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_5;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__72_6;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__72_7;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__73_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__73_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__73_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__73_3;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__74_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__74_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__74_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__74_3;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__74_4;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__74_5;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__74_6;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__74_7;
	public static Func<ProjectileWeaponMod, bool> <>9__75_0;
	public static Func<ProjectileWeaponMod, bool> <>9__77_0;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__85_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__85_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__85_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__85_3;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__85_4;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__85_5;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__85_6;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__85_7;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__89_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__89_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__89_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__89_3;
	public static Func<ProjectileWeaponMod, bool> <>9__112_0;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__114_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__114_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__114_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__114_3;
	public static Func<ProjectileWeaponMod, bool> <>9__127_0;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__129_0;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__129_1;
	public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__129_2;
	public static Func<ProjectileWeaponMod.Modifier, float> <>9__129_3;


	private static void .cctor() { }

	public void .ctor() { }

	internal ProjectileWeaponMod.Modifier <GetAimCone>

	internal float <GetAimCone>

	internal ProjectileWeaponMod.Modifier <GetAimCone>

	internal float <GetAimCone>

	internal ProjectileWeaponMod.Modifier <GetAimCone>

	internal float <GetAimCone>

	internal ProjectileWeaponMod.Modifier <GetAimCone>

	internal float <GetAimCone>

	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>

	internal float <ScaleRepeatDelay>

	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>

	internal float <ScaleRepeatDelay>

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>

	internal float <GetProjectileModifier>

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>

	internal float <GetProjectileModifier>

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>

	internal float <GetProjectileModifier>

	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>

	internal float <GetProjectileModifier>

	internal bool <UsingBurstMode>

	internal bool <IsBurstEligable>

	internal ProjectileWeaponMod.Modifier <EditViewAngles>

	internal float <EditViewAngles>

	internal ProjectileWeaponMod.Modifier <EditViewAngles>

	internal float <EditViewAngles>

	internal ProjectileWeaponMod.Modifier <EditViewAngles>

	internal float <EditViewAngles>

	internal ProjectileWeaponMod.Modifier <EditViewAngles>

	internal float <EditViewAngles>

	internal ProjectileWeaponMod.Modifier <SimulateAimcone>

	internal float <SimulateAimcone>

	internal ProjectileWeaponMod.Modifier <SimulateAimcone>

	internal float <SimulateAimcone>

	internal bool <GetBurstModeCount>

	internal ProjectileWeaponMod.Modifier <DoAttack>

	internal float <DoAttack>

	internal ProjectileWeaponMod.Modifier <DoAttack>

	internal float <DoAttack>

	internal bool <OnSignal>

	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>

	internal float <LaunchProjectileClientside>

	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>

	internal float <LaunchProjectileClientside>

}

private sealed class BaseProjectile.<>c__DisplayClass97_0 // TypeDefIndex: 10257
{
	public BaseProjectile <>4__this;
	public ItemDefinition ammoType;


	public void .ctor() { }

	internal void <AddAmmoOption>

}

public class Projectile : BaseMonoBehaviour // TypeDefIndex: 10959
{
	public const float moveDeltaTime = 0,03125;
	public const float lifeTime = 8;
	[HeaderAttribute]
	public Vector3 initialVelocity;
	public float drag;
	public float gravityModifier;
	public float thickness;
	[TooltipAttribute]
	public float initialDistance;
	[HeaderAttribute]
	public bool remainInWorld;
	[RangeAttribute]
	public float stickProbability;
	[RangeAttribute]
	public float breakProbability;
	[RangeAttribute]
	public float conditionLoss;
	[RangeAttribute]
	public float ricochetChance;
	public float penetrationPower;
	[HeaderAttribute]
	public DamageProperties damageProperties;
	[HorizontalAttribute]
	public MinMax damageDistances;
	[HorizontalAttribute]
	public MinMax damageMultipliers;
	public List<DamageTypeEntry> damageTypes;
	[HeaderAttribute]
	public ScaleRenderer rendererToScale;
	public ScaleRenderer firstPersonRenderer;
	public bool createDecals;
	[HeaderAttribute]
	public bool doDefaultHitEffects;
	[HeaderAttribute]
	public SoundDefinition flybySound;
	public float flybySoundDistance;
	public SoundDefinition closeFlybySound;
	public float closeFlybyDistance;
	[HeaderAttribute]
	public float tumbleSpeed;
	public Vector3 tumbleAxis;
	[HeaderAttribute]
	public Vector3 swimScale;
	public Vector3 swimSpeed;
	public BasePlayer owner;
	public AttackEntity sourceWeaponPrefab;
	public Projectile sourceProjectilePrefab;
	public ItemModProjectile mod;
	public int projectileID;
	public int seed;
	public bool clientsideEffect;
	public bool clientsideAttack;
	public float integrity;
	public float maxDistance;
	public Projectile.Modifier modifier;
	public bool invisible;
	internal Vector3 currentVelocity;
	internal Vector3 currentPosition;
	private float traveledDistance;
	private float traveledTime;
	private float launchTime;
	private Vector3 sentPosition;
	private Vector3 previousPosition;
	private Vector3 previousVelocity;
	private float previousTraveledTime;
	private bool isRicochet;
	private bool isRetiring;
	private bool flybyPlayed;
	private bool wasFacingPlayer;
	private Plane flybyPlane;
	private Ray flybyRay;
	private Action cleanupAction;
	private HitTest hitTest;
	private float swimRandom;
	private static uint _fleshMaterialID;
	private static uint _waterMaterialID;
	private static uint cachedWaterString;

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

public struct Projectile.Modifier // TypeDefIndex: 10960
{
	public float damageScale;
	public float damageOffset;
	public float distanceScale;
	public float distanceOffset;
	public static Projectile.Modifier Default;


	private static void .cctor() { }

}

public class ProjectileTestSpawner : MonoBehaviour // TypeDefIndex: 11064
{
	public Projectile TargetProjectile;
	public float RepeatTime;
	public float VelocityScale;


	public void .ctor() { }

}

public class AttackTickAIEvent : BaseAIEvent // TypeDefIndex: 11132
{

	public void .ctor() { }

}

public class AttackedAIEvent : BaseAIEvent // TypeDefIndex: 11133
{
	protected float lastExecuteTime;
	private BaseCombatEntity combatEntity;


	public void .ctor() { }

}

public class AttackEntity : HeldEntity // TypeDefIndex: 11201
{
	[HeaderAttribute]
	public float deployDelay;
	public float repeatDelay;
	public float animationDelay;
	[HeaderAttribute]
	public float effectiveRange;
	public float npcDamageScale;
	public float attackLengthMin;
	public float attackLengthMax;
	public float attackSpacing;
	public float aiAimSwayOffset;
	public float aiAimCone;
	public bool aiOnlyInRange;
	public float CloseRangeAddition;
	public float MediumRangeAddition;
	public float LongRangeAddition;
	public bool CanUseAtMediumRange;
	public bool CanUseAtLongRange;
	public SoundDefinition[] reloadSounds;
	public SoundDefinition thirdPersonMeleeSound;
	[HeaderAttribute]
	public float recoilCompDelayOverride;
	public bool wantsRecoilComp;
	private float nextAttackTime;
	private float lastTickTime;
	private float nextTickTime;
	private float timeSinceDeploy;
	public static Vector3 reductionSpeedScalars;
	private float lastRecoilCompTime;
	private Vector3 startAimingDirection;
	private bool wasDoingRecoilComp;
	private Vector3 reductionSpeed;

	public float NextAttackTime { get; }


	public virtual Vector3 GetInheritedVelocity(BasePlayer player, Vector3 direction) { }

	public float get_NextAttackTime() { }

	public virtual void GetAttackStats(HitInfo info) { }

	protected void StartAttackCooldownRaw(float cooldown) { }

	protected void StartAttackCooldown(float cooldown) { }

	public void ResetAttackCooldown() { }

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

public class ProjectileWeaponMod : BaseEntity // TypeDefIndex: 11368
{
	[HeaderAttribute]
	public GameObjectRef defaultSilencerEffect;
	public bool isSilencer;
	[HeaderAttribute]
	public ProjectileWeaponMod.Modifier repeatDelay;
	public ProjectileWeaponMod.Modifier projectileVelocity;
	public ProjectileWeaponMod.Modifier projectileDamage;
	public ProjectileWeaponMod.Modifier projectileDistance;
	[HeaderAttribute]
	public ProjectileWeaponMod.Modifier aimsway;
	public ProjectileWeaponMod.Modifier aimswaySpeed;
	public ProjectileWeaponMod.Modifier recoil;
	[HeaderAttribute]
	public ProjectileWeaponMod.Modifier sightAimCone;
	public ProjectileWeaponMod.Modifier hipAimCone;
	[HeaderAttribute]
	public bool isLight;
	[HeaderAttribute]
	public bool isMuzzleBrake;
	[HeaderAttribute]
	public bool isMuzzleBoost;
	[HeaderAttribute]
	public bool isScope;
	public float zoomAmountDisplayOnly;
	[HeaderAttribute]
	public ProjectileWeaponMod.Modifier magazineCapacity;
	public bool needsOnForEffects;
	[HeaderAttribute]
	public int burstCount;
	public float timeBetweenBursts;


	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected override void DoClientDestroy() { }

	public virtual void SetAiming(bool isAiming) { }

	public virtual void SetInternalModOn(bool isOn) { }

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

public struct ProjectileWeaponMod.Modifier // TypeDefIndex: 11369
{
	public bool enabled;
	[TooltipAttribute]
	public float scalar;
	[TooltipAttribute]
	public float offset;

}

private sealed class ProjectileWeaponMod.<>c // TypeDefIndex: 11370
{
	public static readonly ProjectileWeaponMod.<>c <>9;
	public static Func<ProjectileWeaponMod, bool> <>9__31_0;
	public static Func<ProjectileWeaponMod.Modifier, bool> <>9__31_1;
	public static Func<ProjectileWeaponMod, bool> <>9__32_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetMods>

	internal bool <GetMods>

	internal bool <HasBrokenWeaponMod>

}

public class AttackTickEventUI : BaseEventUI // TypeDefIndex: 12555
{

	public void .ctor() { }

}

public class AttackedEventUI : BaseEventUI // TypeDefIndex: 12556
{

	public void .ctor() { }

}

public class ProjectileWeaponInformationPanel : ItemInformationPanel // TypeDefIndex: 12832
{
	public ItemStatValue damageDisplay;
	public ItemStatValue recoilDisplay;
	public ItemStatValue rofDisplay;
	public ItemStatValue accuracyDisplay;
	public ItemStatValue rangeDisplay;


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

