public class BaseProjectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6318
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Magazine primaryMagazine; // 0x18

	// Methods

	// RVA: 0x1F65570 Offset: 0x1F63B70 VA: 0x181F65570
	public static void ResetToPool(BaseProjectile instance) { }

	// RVA: 0x1F654D0 Offset: 0x1F63AD0 VA: 0x181F654D0
	public void ResetToPool() { }

	// RVA: 0x1F65370 Offset: 0x1F63970 VA: 0x181F65370 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F648D0 Offset: 0x1F62ED0 VA: 0x181F648D0
	public void CopyTo(BaseProjectile instance) { }

	// RVA: 0x1F64940 Offset: 0x1F62F40 VA: 0x181F64940
	public BaseProjectile Copy() { }

	// RVA: 0x1F650D0 Offset: 0x1F636D0 VA: 0x181F650D0
	public static BaseProjectile Deserialize(Stream stream) { }

	// RVA: 0x1F64C50 Offset: 0x1F63250 VA: 0x181F64C50
	public static BaseProjectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F64CD0 Offset: 0x1F632D0 VA: 0x181F64CD0
	public static BaseProjectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F65250 Offset: 0x1F63850 VA: 0x181F65250
	public static BaseProjectile Deserialize(byte[] buffer) { }

	// RVA: 0x1F65490 Offset: 0x1F63A90 VA: 0x181F65490
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F65B00 Offset: 0x1F64100 VA: 0x181F65B00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F65B20 Offset: 0x1F64120 VA: 0x181F65B20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseProjectile previous) { }

	// RVA: 0x1F654B0 Offset: 0x1F63AB0 VA: 0x181F654B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F65150 Offset: 0x1F63750 VA: 0x181F65150
	public static BaseProjectile Deserialize(byte[] buffer, BaseProjectile instance, bool isDelta = False) { }

	// RVA: 0x1F64F70 Offset: 0x1F63570 VA: 0x181F64F70
	public static BaseProjectile Deserialize(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F64A10 Offset: 0x1F63010 VA: 0x181F64A10
	public static BaseProjectile DeserializeLengthDelimited(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F64D60 Offset: 0x1F63360 VA: 0x181F64D60
	public static BaseProjectile DeserializeLength(Stream stream, int length, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F65610 Offset: 0x1F63C10 VA: 0x181F65610
	public static void SerializeDelta(Stream stream, BaseProjectile instance, BaseProjectile previous) { }

	// RVA: 0x1F65970 Offset: 0x1F63F70 VA: 0x181F65970
	public static void Serialize(Stream stream, BaseProjectile instance) { }

	// RVA: 0x1F65AF0 Offset: 0x1F640F0 VA: 0x181F65AF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F65B00 Offset: 0x1F64100 VA: 0x181F65B00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F65860 Offset: 0x1F63E60 VA: 0x181F65860
	public static byte[] SerializeToBytes(BaseProjectile instance) { }

	// RVA: 0x1F657B0 Offset: 0x1F63DB0 VA: 0x181F657B0
	public static void SerializeLengthDelimited(Stream stream, BaseProjectile instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class Attack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6483
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1FF6180 Offset: 0x1FF4780 VA: 0x181FF6180
	public static void ResetToPool(Attack instance) { }

	// RVA: 0x1FF6050 Offset: 0x1FF4650 VA: 0x181FF6050
	public void ResetToPool() { }

	// RVA: 0x1FF5AE0 Offset: 0x1FF40E0 VA: 0x181FF5AE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF3EE0 Offset: 0x1FF24E0 VA: 0x181FF3EE0
	public void CopyTo(Attack instance) { }

	// RVA: 0x1FF3F80 Offset: 0x1FF2580 VA: 0x181FF3F80
	public Attack Copy() { }

	// RVA: 0x1FF5290 Offset: 0x1FF3890 VA: 0x181FF5290
	public static Attack Deserialize(Stream stream) { }

	// RVA: 0x1FF44E0 Offset: 0x1FF2AE0 VA: 0x181FF44E0
	public static Attack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF4560 Offset: 0x1FF2B60 VA: 0x181FF4560
	public static Attack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF4A40 Offset: 0x1FF3040 VA: 0x181FF4A40
	public static Attack Deserialize(byte[] buffer) { }

	// RVA: 0x1FF5C90 Offset: 0x1FF4290 VA: 0x181FF5C90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF7570 Offset: 0x1FF5B70 VA: 0x181FF7570 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF7590 Offset: 0x1FF5B90 VA: 0x181FF7590 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Attack previous) { }

	// RVA: 0x1FF6030 Offset: 0x1FF4630 VA: 0x181FF6030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF5660 Offset: 0x1FF3C60 VA: 0x181FF5660
	public static Attack Deserialize(byte[] buffer, Attack instance, bool isDelta = False) { }

	// RVA: 0x1FF4EF0 Offset: 0x1FF34F0 VA: 0x181FF4EF0
	public static Attack Deserialize(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FF4070 Offset: 0x1FF2670 VA: 0x181FF4070
	public static Attack DeserializeLengthDelimited(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FF45F0 Offset: 0x1FF2BF0 VA: 0x181FF45F0
	public static Attack DeserializeLength(Stream stream, int length, Attack instance, bool isDelta) { }

	// RVA: 0x1FF62B0 Offset: 0x1FF48B0 VA: 0x181FF62B0
	public static void SerializeDelta(Stream stream, Attack instance, Attack previous) { }

	// RVA: 0x1FF6F70 Offset: 0x1FF5570 VA: 0x181FF6F70
	public static void Serialize(Stream stream, Attack instance) { }

	// RVA: 0x1FF7560 Offset: 0x1FF5B60 VA: 0x181FF7560
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF7570 Offset: 0x1FF5B70 VA: 0x181FF7570
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF6E60 Offset: 0x1FF5460 VA: 0x181FF6E60
	public static byte[] SerializeToBytes(Attack instance) { }

	// RVA: 0x1FF6DB0 Offset: 0x1FF53B0 VA: 0x181FF6DB0
	public static void SerializeLengthDelimited(Stream stream, Attack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ProjectileShoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6488
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int ammoType; // 0x14
	public List<ProjectileShoot.Projectile> projectiles; // 0x18

	// Methods

	// RVA: 0x2049BA0 Offset: 0x20481A0 VA: 0x182049BA0
	public static void ResetToPool(ProjectileShoot instance) { }

	// RVA: 0x2049D60 Offset: 0x2048360 VA: 0x182049D60
	public void ResetToPool() { }

	// RVA: 0x2049AE0 Offset: 0x20480E0 VA: 0x182049AE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2048B60 Offset: 0x2047160 VA: 0x182048B60
	public void CopyTo(ProjectileShoot instance) { }

	// RVA: 0x2048D10 Offset: 0x2047310 VA: 0x182048D10
	public ProjectileShoot Copy() { }

	// RVA: 0x2049610 Offset: 0x2047C10 VA: 0x182049610
	public static ProjectileShoot Deserialize(Stream stream) { }

	// RVA: 0x2048F10 Offset: 0x2047510 VA: 0x182048F10
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2049580 Offset: 0x2047B80 VA: 0x182049580
	public static ProjectileShoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20499C0 Offset: 0x2047FC0 VA: 0x1820499C0
	public static ProjectileShoot Deserialize(byte[] buffer) { }

	// RVA: 0x2049B60 Offset: 0x2048160 VA: 0x182049B60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204A550 Offset: 0x2048B50 VA: 0x18204A550 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204A570 Offset: 0x2048B70 VA: 0x18204A570 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot previous) { }

	// RVA: 0x2049B80 Offset: 0x2048180 VA: 0x182049B80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2049690 Offset: 0x2047C90 VA: 0x182049690
	public static ProjectileShoot Deserialize(byte[] buffer, ProjectileShoot instance, bool isDelta = False) { }

	// RVA: 0x2049790 Offset: 0x2047D90 VA: 0x182049790
	public static ProjectileShoot Deserialize(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2048F90 Offset: 0x2047590 VA: 0x182048F90
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x20492A0 Offset: 0x20478A0 VA: 0x1820492A0
	public static ProjectileShoot DeserializeLength(Stream stream, int length, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2049F20 Offset: 0x2048520 VA: 0x182049F20
	public static void SerializeDelta(Stream stream, ProjectileShoot instance, ProjectileShoot previous) { }

	// RVA: 0x204A320 Offset: 0x2048920 VA: 0x18204A320
	public static void Serialize(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x204A540 Offset: 0x2048B40 VA: 0x18204A540
	public byte[] ToProtoBytes() { }

	// RVA: 0x204A550 Offset: 0x2048B50 VA: 0x18204A550
	public void ToProto(Stream stream) { }

	// RVA: 0x204A210 Offset: 0x2048810 VA: 0x18204A210
	public static byte[] SerializeToBytes(ProjectileShoot instance) { }

	// RVA: 0x204A160 Offset: 0x2048760 VA: 0x18204A160
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ProjectileShoot.Projectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6489
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 startPos; // 0x18
	public Vector3 startVel; // 0x24
	public int seed; // 0x30

	// Methods

	// RVA: 0x204B960 Offset: 0x2049F60 VA: 0x18204B960
	public static void ResetToPool(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204BA10 Offset: 0x204A010 VA: 0x18204BA10
	public void ResetToPool() { }

	// RVA: 0x204B6C0 Offset: 0x2049CC0 VA: 0x18204B6C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203D6A0 Offset: 0x203BCA0 VA: 0x18203D6A0
	public void CopyTo(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204A590 Offset: 0x2048B90 VA: 0x18204A590
	public ProjectileShoot.Projectile Copy() { }

	// RVA: 0x204B1B0 Offset: 0x20497B0 VA: 0x18204B1B0
	public static ProjectileShoot.Projectile Deserialize(Stream stream) { }

	// RVA: 0x204A630 Offset: 0x2048C30 VA: 0x18204A630
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204A980 Offset: 0x2048F80 VA: 0x18204A980
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204AED0 Offset: 0x20494D0 VA: 0x18204AED0
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer) { }

	// RVA: 0x204B740 Offset: 0x2049D40 VA: 0x18204B740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204C370 Offset: 0x204A970 VA: 0x18204C370 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204C390 Offset: 0x204A990 VA: 0x18204C390 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot.Projectile previous) { }

	// RVA: 0x204B940 Offset: 0x2049F40 VA: 0x18204B940 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204B3F0 Offset: 0x20499F0 VA: 0x18204B3F0
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer, ProjectileShoot.Projectile instance, bool isDelta = False) { }

	// RVA: 0x204ACC0 Offset: 0x20492C0 VA: 0x18204ACC0
	public static ProjectileShoot.Projectile Deserialize(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204A6B0 Offset: 0x2048CB0 VA: 0x18204A6B0
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204AA10 Offset: 0x2049010 VA: 0x18204AA10
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204BAC0 Offset: 0x204A0C0 VA: 0x18204BAC0
	public static void SerializeDelta(Stream stream, ProjectileShoot.Projectile instance, ProjectileShoot.Projectile previous) { }

	// RVA: 0x204C0D0 Offset: 0x204A6D0 VA: 0x18204C0D0
	public static void Serialize(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x204C360 Offset: 0x204A960 VA: 0x18204C360
	public byte[] ToProtoBytes() { }

	// RVA: 0x204C370 Offset: 0x204A970 VA: 0x18204C370
	public void ToProto(Stream stream) { }

	// RVA: 0x204BFC0 Offset: 0x204A5C0 VA: 0x18204BFC0
	public static byte[] SerializeToBytes(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204BF10 Offset: 0x204A510 VA: 0x18204BF10
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class BaseProjectile : AttackEntity // TypeDefIndex: 8529
{	// Fields
	[HeaderAttribute] // RVA: 0xA5E80 Offset: 0xA5280 VA: 0x1800A5E80
	public float NoiseRadius; // 0x280
	[HeaderAttribute] // RVA: 0xA72B0 Offset: 0xA66B0 VA: 0x1800A72B0
	public float damageScale; // 0x284
	public float distanceScale; // 0x288
	public float projectileVelocityScale; // 0x28C
	public bool automatic; // 0x290
	public bool usableByTurret; // 0x291
	[TooltipAttribute] // RVA: 0xA7310 Offset: 0xA6710 VA: 0x1800A7310
	public float turretDamageScale; // 0x294
	[HeaderAttribute] // RVA: 0x787C0 Offset: 0x77BC0 VA: 0x1800787C0
	public GameObjectRef attackFX; // 0x298
	public GameObjectRef silencedAttack; // 0x2A0
	public GameObjectRef muzzleBrakeAttack; // 0x2A8
	public Transform MuzzlePoint; // 0x2B0
	[HeaderAttribute] // RVA: 0xA7470 Offset: 0xA6870 VA: 0x1800A7470
	public float reloadTime; // 0x2B8
	public bool canUnloadAmmo; // 0x2BC
	public BaseProjectile.Magazine primaryMagazine; // 0x2C0
	public bool fractionalReload; // 0x2C8
	public float reloadStartDuration; // 0x2CC
	public float reloadFractionDuration; // 0x2D0
	public float reloadEndDuration; // 0x2D4
	[HeaderAttribute] // RVA: 0x7C140 Offset: 0x7B540 VA: 0x18007C140
	public float aimSway; // 0x2D8
	public float aimSwaySpeed; // 0x2DC
	public RecoilProperties recoil; // 0x2E0
	[HeaderAttribute] // RVA: 0x7C200 Offset: 0x7B600 VA: 0x18007C200
	public AnimationCurve aimconeCurve; // 0x2E8
	public float aimCone; // 0x2F0
	public float hipAimCone; // 0x2F4
	public float aimconePenaltyPerShot; // 0x2F8
	public float aimConePenaltyMax; // 0x2FC
	public float aimconePenaltyRecoverTime; // 0x300
	public float aimconePenaltyRecoverDelay; // 0x304
	public float stancePenaltyScale; // 0x308
	[HeaderAttribute] // RVA: 0xA75C0 Offset: 0xA69C0 VA: 0x1800A75C0
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

	// Properties
	public RecoilProperties recoilProperties { get; }
	public bool isSemiAuto { get; }
	private bool UsingInfiniteAmmoCheat { get; }

	// Methods

	// RVA: 0x9266C0 Offset: 0x924CC0 VA: 0x1809266C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x928220 Offset: 0x926820 VA: 0x180928220
	public RecoilProperties get_recoilProperties() { }

	// RVA: 0x923CC0 Offset: 0x9222C0 VA: 0x180923CC0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x923CA0 Offset: 0x9222A0 VA: 0x180923CA0 Slot: 160
	public virtual float GetDamageScale(bool getMax = False) { }

	// RVA: 0x923CB0 Offset: 0x9222B0 VA: 0x180923CB0 Slot: 161
	public virtual float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x9244A0 Offset: 0x922AA0 VA: 0x1809244A0 Slot: 162
	public virtual float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x927EA0 Offset: 0x9264A0 VA: 0x180927EA0
	protected void StartReloadCooldown(float cooldown) { }

	// RVA: 0x9272C0 Offset: 0x9258C0 VA: 0x1809272C0
	protected void ResetReloadCooldown() { }

	// RVA: 0x924BC0 Offset: 0x9231C0 VA: 0x180924BC0
	protected bool HasReloadCooldown() { }

	// RVA: 0x9244C0 Offset: 0x922AC0 VA: 0x1809244C0
	protected float GetReloadCooldown() { }

	// RVA: 0x924620 Offset: 0x922C20 VA: 0x180924620
	protected float GetReloadIdle() { }

	// RVA: 0x925F00 Offset: 0x924500 VA: 0x180925F00
	private void OnDrawGizmos() { }

	// RVA: 0x9244B0 Offset: 0x922AB0 VA: 0x1809244B0 Slot: 163
	public virtual RecoilProperties GetRecoil() { }

	// RVA: 0x928210 Offset: 0x926810 VA: 0x180928210
	public bool get_isSemiAuto() { }

	// RVA: 0x9231B0 Offset: 0x9217B0 VA: 0x1809231B0 Slot: 164
	public virtual float GetAimCone() { }

	// RVA: 0x9272D0 Offset: 0x9258D0 VA: 0x1809272D0
	public float ScaleRepeatDelay(float delay) { }

	// RVA: 0x923E60 Offset: 0x922460 VA: 0x180923E60
	public Projectile.Modifier GetProjectileModifier() { }

	// RVA: 0x9216A0 Offset: 0x91FCA0 VA: 0x1809216A0 Slot: 165
	public virtual void DidAttackClientside() { }

	// RVA: 0x923D10 Offset: 0x922310 VA: 0x180923D10 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x9213C0 Offset: 0x91F9C0 VA: 0x1809213C0
	public bool ClientIsReloading() { }

	// RVA: 0x925EB0 Offset: 0x9244B0 VA: 0x180925EB0
	public void NotifySpectatorReloading(bool state) { }

	// RVA: 0x9227B0 Offset: 0x920DB0 VA: 0x1809227B0 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x9262D0 Offset: 0x9248D0 VA: 0x1809262D0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x927600 Offset: 0x925C00 VA: 0x180927600 Slot: 166
	public virtual void ShotFired() { }

	// RVA: 0x927660 Offset: 0x925C60 VA: 0x180927660 Slot: 167
	public virtual void SimulateAimcone() { }

	// RVA: 0x9211C0 Offset: 0x91F7C0 VA: 0x1809211C0 Slot: 168
	public virtual bool CanAttack() { }

	// RVA: 0x921190 Offset: 0x91F790 VA: 0x180921190 Slot: 169
	public virtual bool CanAim() { }

	// RVA: 0x9262E0 Offset: 0x9248E0 VA: 0x1809262E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x927210 Offset: 0x925810 VA: 0x180927210
	public bool ReadyToAim() { }

	// RVA: 0x927260 Offset: 0x925860 VA: 0x180927260
	public bool ReadyToFire() { }

	// RVA: 0x921070 Offset: 0x91F670 VA: 0x180921070
	public void AmmoTypeClicked(ItemDefinition newAmmoType) { }

	// RVA: 0x920EC0 Offset: 0x91F4C0 VA: 0x180920EC0
	private void AddAmmoOption(ItemDefinition ammo, List<Option> opts, int order = 0) { }

	// RVA: 0x9246A0 Offset: 0x922CA0 VA: 0x1809246A0
	public List<Option> GetReloadMenu(BasePlayer player) { }

	// RVA: 0x926E70 Offset: 0x925470 VA: 0x180926E70
	private void PredictAmmoType() { }

	// RVA: 0x924910 Offset: 0x922F10 VA: 0x180924910 Slot: 170
	public virtual bool HasMoreThanOneAmmoType(AmmoTypes ammoType) { }

	// RVA: 0x925EC0 Offset: 0x9244C0 VA: 0x180925EC0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x922230 Offset: 0x920830 VA: 0x180922230
	private void DoReload() { }

	// RVA: 0x924BF0 Offset: 0x9231F0 VA: 0x180924BF0
	protected void InsertAmmoFraction() { }

	// RVA: 0x9211E0 Offset: 0x91F7E0 VA: 0x1809211E0
	public void CancelFractionalReloading() { }

	// RVA: 0x921280 Offset: 0x91F880 VA: 0x180921280
	protected void ClientFinishFractionalReload() { }

	// RVA: 0x9213D0 Offset: 0x91F9D0 VA: 0x1809213D0
	protected void ClientSingleReload() { }

	// RVA: 0x921770 Offset: 0x91FD70 VA: 0x180921770 Slot: 171
	public virtual void DoAttack() { }

	// RVA: 0x921100 Offset: 0x91F700 VA: 0x180921100
	public void BeginCycle() { }

	// RVA: 0x925CC0 Offset: 0x9242C0 VA: 0x180925CC0 Slot: 172
	public virtual void LaunchProjectile() { }

	// RVA: 0x9226F0 Offset: 0x920CF0 VA: 0x1809226F0
	public void DryFire() { }

	// RVA: 0x9271B0 Offset: 0x9257B0 VA: 0x1809271B0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x9270A0 Offset: 0x9256A0 VA: 0x1809270A0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x924540 Offset: 0x922B40 VA: 0x180924540
	public float GetReloadDuration() { }

	// RVA: 0x923A90 Offset: 0x922090 VA: 0x180923A90
	public int GetAvailableAmmo() { }

	// RVA: 0x924C50 Offset: 0x923250 VA: 0x180924C50
	public bool IsSilenced() { }

	// RVA: 0x923120 Offset: 0x921720 VA: 0x180923120
	public bool FiredUnderground() { }

	// RVA: 0x9267B0 Offset: 0x924DB0 VA: 0x1809267B0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x924E30 Offset: 0x923430 VA: 0x180924E30
	internal void LaunchProjectileClientside(ItemDefinition ammo, int projectileCount, float projSpreadaimCone) { }

	// RVA: 0x921510 Offset: 0x91FB10 VA: 0x180921510
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0x927EF0 Offset: 0x9264F0 VA: 0x180927EF0 Slot: 173
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool get_UsingInfiniteAmmoCheat() { }

	// RVA: 0x925E10 Offset: 0x924410 VA: 0x180925E10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x927FA0 Offset: 0x9265A0 VA: 0x180927FA0
	public void .ctor() { }

}

public class BaseProjectile.Magazine // TypeDefIndex: 8530
{	// Fields
	public BaseProjectile.Magazine.Definition definition; // 0x10
	public int capacity; // 0x18
	public int contents; // 0x1C
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition ammoType; // 0x20

	// Methods

	// RVA: 0x93A8F0 Offset: 0x938EF0 VA: 0x18093A8F0
	public void ServerInit() { }

	// RVA: 0x93A820 Offset: 0x938E20 VA: 0x18093A820
	public Magazine Save() { }

	// RVA: 0x93A7D0 Offset: 0x938DD0 VA: 0x18093A7D0
	public void Load(Magazine mag) { }

	// RVA: 0x93A790 Offset: 0x938D90 VA: 0x18093A790
	public bool CanReload(BasePlayer owner) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct BaseProjectile.Magazine.Definition // TypeDefIndex: 8531
{	// Fields
	[TooltipAttribute] // RVA: 0xA76E0 Offset: 0xA6AE0 VA: 0x1800A76E0
	public int builtInSize; // 0x0
	[TooltipAttribute] // RVA: 0xA79E0 Offset: 0xA6DE0 VA: 0x1800A79E0
	[InspectorFlagsAttribute] // RVA: 0xA79E0 Offset: 0xA6DE0 VA: 0x1800A79E0
	public AmmoTypes ammoTypes; // 0x4

}

private sealed class BaseProjectile.<>c // TypeDefIndex: 8532
{	// Fields
	public static readonly BaseProjectile.<>c <>9; // 0x0
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

	// Methods

	// RVA: 0x93B430 Offset: 0x939A30 VA: 0x18093B430
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B120 Offset: 0x939720 VA: 0x18093B120
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <GetAimCone>b__63_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B120 Offset: 0x939720 VA: 0x18093B120
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <GetAimCone>b__63_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B150 Offset: 0x939750 VA: 0x18093B150
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_4(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <GetAimCone>b__63_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B150 Offset: 0x939750 VA: 0x18093B150
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_6(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <GetAimCone>b__63_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B2B0 Offset: 0x9398B0 VA: 0x18093B2B0
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <ScaleRepeatDelay>b__64_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B2B0 Offset: 0x9398B0 VA: 0x18093B2B0
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <ScaleRepeatDelay>b__64_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B180 Offset: 0x939780 VA: 0x18093B180
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <GetProjectileModifier>b__65_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B180 Offset: 0x939780 VA: 0x18093B180
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <GetProjectileModifier>b__65_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B1B0 Offset: 0x9397B0 VA: 0x18093B1B0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_4(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <GetProjectileModifier>b__65_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B1B0 Offset: 0x9397B0 VA: 0x18093B1B0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_6(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <GetProjectileModifier>b__65_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0C0 Offset: 0x9396C0 VA: 0x18093B0C0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <EditViewAngles>b__72_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0C0 Offset: 0x9396C0 VA: 0x18093B0C0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <EditViewAngles>b__72_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0F0 Offset: 0x9396F0 VA: 0x18093B0F0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_4(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <EditViewAngles>b__72_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0F0 Offset: 0x9396F0 VA: 0x18093B0F0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_6(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <EditViewAngles>b__72_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B060 Offset: 0x939660 VA: 0x18093B060
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <SimulateAimcone>b__76_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B060 Offset: 0x939660 VA: 0x18093B060
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <SimulateAimcone>b__76_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B060 Offset: 0x939660 VA: 0x18093B060
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <DoAttack>b__98_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B060 Offset: 0x939660 VA: 0x18093B060
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <DoAttack>b__98_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B250 Offset: 0x939850 VA: 0x18093B250
	internal bool <OnSignal>b__110_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B1E0 Offset: 0x9397E0 VA: 0x18093B1E0
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B090 Offset: 0x939690 VA: 0x18093B090
	internal float <LaunchProjectileClientside>b__112_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B1E0 Offset: 0x9397E0 VA: 0x18093B1E0
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal float <LaunchProjectileClientside>b__112_3(ProjectileWeaponMod.Modifier y) { }

}

private sealed class BaseProjectile.<>c__DisplayClass84_0 // TypeDefIndex: 8533
{	// Fields
	public BaseProjectile <>4__this; // 0x10
	public ItemDefinition ammoType; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B390 Offset: 0x939990 VA: 0x18093B390
	internal void <AddAmmoOption>b__0(BasePlayer ply) { }

}

public class Projectile : BaseMonoBehaviour // TypeDefIndex: 9223
{	// Fields
	public const float moveDeltaTime = 0,03125;
	public const float lifeTime = 8;
	[HeaderAttribute] // RVA: 0xDA2F0 Offset: 0xD96F0 VA: 0x1800DA2F0
	public Vector3 initialVelocity; // 0x18
	public float drag; // 0x24
	public float gravityModifier; // 0x28
	public float thickness; // 0x2C
	[TooltipAttribute] // RVA: 0xDA510 Offset: 0xD9910 VA: 0x1800DA510
	public float initialDistance; // 0x30
	[HeaderAttribute] // RVA: 0xDA6C0 Offset: 0xD9AC0 VA: 0x1800DA6C0
	public bool remainInWorld; // 0x34
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float stickProbability; // 0x38
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float breakProbability; // 0x3C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float conditionLoss; // 0x40
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float ricochetChance; // 0x44
	public float penetrationPower; // 0x48
	[HeaderAttribute] // RVA: 0xCB6A0 Offset: 0xCAAA0 VA: 0x1800CB6A0
	public DamageProperties damageProperties; // 0x50
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public MinMax damageDistances; // 0x58
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public MinMax damageMultipliers; // 0x60
	public List<DamageTypeEntry> damageTypes; // 0x68
	[HeaderAttribute] // RVA: 0xDAC70 Offset: 0xDA070 VA: 0x1800DAC70
	public ScaleRenderer rendererToScale; // 0x70
	public ScaleRenderer firstPersonRenderer; // 0x78
	public bool createDecals; // 0x80
	[HeaderAttribute] // RVA: 0x787C0 Offset: 0x77BC0 VA: 0x1800787C0
	public bool doDefaultHitEffects; // 0x81
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public SoundDefinition flybySound; // 0x88
	public float flybySoundDistance; // 0x90
	public SoundDefinition closeFlybySound; // 0x98
	public float closeFlybyDistance; // 0xA0
	[HeaderAttribute] // RVA: 0xDAED0 Offset: 0xDA2D0 VA: 0x1800DAED0
	public float tumbleSpeed; // 0xA4
	public Vector3 tumbleAxis; // 0xA8
	[HeaderAttribute] // RVA: 0xDB030 Offset: 0xDA430 VA: 0x1800DB030
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

	// Properties
	public bool isAuthoritative { get; }
	private bool isAlive { get; }

	// Methods

	// RVA: 0x694840 Offset: 0x692E40 VA: 0x180694840
	public void CalculateDamage(HitInfo info, Projectile.Modifier mod, float scale) { }

	// RVA: 0x6995F0 Offset: 0x697BF0 VA: 0x1806995F0
	public bool get_isAuthoritative() { }

	// RVA: 0x6995B0 Offset: 0x697BB0 VA: 0x1806995B0
	private bool get_isAlive() { }

	// RVA: 0x6983A0 Offset: 0x6969A0 VA: 0x1806983A0
	private void Retire() { }

	// RVA: 0x694D90 Offset: 0x693390 VA: 0x180694D90
	private void Cleanup() { }

	// RVA: 0x6945D0 Offset: 0x692BD0 VA: 0x1806945D0
	public void AdjustVelocity(Vector3 delta) { }

	// RVA: 0x6975E0 Offset: 0x695BE0 VA: 0x1806975E0
	public void InitializeVelocity(Vector3 overrideVel) { }

	// RVA: 0x697850 Offset: 0x695E50 VA: 0x180697850
	protected void OnDisable() { }

	// RVA: 0x699210 Offset: 0x697810 VA: 0x180699210
	protected void Update() { }

	// RVA: 0x698970 Offset: 0x696F70 VA: 0x180698970
	private void SetEffectScale(float eScale) { }

	// RVA: 0x694F90 Offset: 0x693590 VA: 0x180694F90
	private void DoFlybySound() { }

	// RVA: 0x694CF0 Offset: 0x6932F0 VA: 0x180694CF0 Slot: 6
	protected virtual float CalculateEffectScale() { }

	// RVA: 0x698F30 Offset: 0x697530 VA: 0x180698F30
	private void UpdateVelocity(float deltaTime) { }

	// RVA: 0x696DF0 Offset: 0x6953F0 VA: 0x180696DF0
	private void DoVelocityUpdate(float deltaTime) { }

	// RVA: 0x695CB0 Offset: 0x6942B0 VA: 0x180695CB0
	private void DoMovement(float deltaTime) { }

	// RVA: 0x6971D0 Offset: 0x6957D0 VA: 0x1806971D0
	private bool DoWaterHit(ref HitTest test, Vector3 targetPosition) { }

	// RVA: 0x6969D0 Offset: 0x694FD0 VA: 0x1806969D0
	private bool DoRicochet(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x6955A0 Offset: 0x693BA0 VA: 0x1806955A0
	private bool DoHit(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void AdditiveImpactEffect(HitInfo info) { }

	// RVA: 0x697B20 Offset: 0x696120 VA: 0x180697B20
	private bool Reflect(ref uint seed, Vector3 point, Vector3 normal) { }

	// RVA: 0x697E70 Offset: 0x696470 VA: 0x180697E70
	private bool Refract(ref uint seed, Vector3 point, Vector3 normal, float resistance) { }

	// RVA: 0x698240 Offset: 0x696840 VA: 0x180698240
	private Vector3 Refract(Vector3 v, Vector3 n, float f) { }

	// RVA: 0x697A20 Offset: 0x696020 VA: 0x180697A20
	private Quaternion RandomRotation(ref uint seed, float range) { }

	// RVA: 0x6977C0 Offset: 0x695DC0 VA: 0x1806977C0
	internal void Launch() { }

	// RVA: 0x6974E0 Offset: 0x695AE0 VA: 0x1806974E0
	public static uint FleshMaterialID() { }

	// RVA: 0x699310 Offset: 0x697910 VA: 0x180699310
	public static uint WaterMaterialID() { }

	// RVA: 0x697690 Offset: 0x695C90 VA: 0x180697690
	public static bool IsWaterMaterial(string hitMaterial) { }

	// RVA: 0x698E70 Offset: 0x697470 VA: 0x180698E70
	public static bool ShouldStopProjectile(RaycastHit hit) { }

	// RVA: 0x699410 Offset: 0x697A10 VA: 0x180699410
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public struct Projectile.Modifier // TypeDefIndex: 9224
{	// Fields
	public float damageScale; // 0x0
	public float damageOffset; // 0x4
	public float distanceScale; // 0x8
	public float distanceOffset; // 0xC
	public static Projectile.Modifier Default; // 0x0

	// Methods

	// RVA: 0x6915C0 Offset: 0x68FBC0 VA: 0x1806915C0
	private static void .cctor() { }

}

public class ProjectileTestSpawner : MonoBehaviour // TypeDefIndex: 9323
{	// Fields
	public Projectile TargetProjectile; // 0x18
	public float RepeatTime; // 0x20
	public float VelocityScale; // 0x24

	// Methods

	// RVA: 0x693100 Offset: 0x691700 VA: 0x180693100
	public void .ctor() { }

}

public class AttackTickAIEvent : BaseAIEvent // TypeDefIndex: 9391
{	// Methods

	// RVA: 0x835720 Offset: 0x833D20 VA: 0x180835720
	public void .ctor() { }

}

public class AttackedAIEvent : BaseAIEvent // TypeDefIndex: 9392
{	// Fields
	protected float lastExecuteTime; // 0x40
	private BaseCombatEntity combatEntity; // 0x48

	// Methods

	// RVA: 0x835750 Offset: 0x833D50 VA: 0x180835750
	public void .ctor() { }

}

public class AttackEntity : HeldEntity // TypeDefIndex: 9460
{	// Fields
	[HeaderAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public float deployDelay; // 0x1F8
	public float repeatDelay; // 0x1FC
	public float animationDelay; // 0x200
	[HeaderAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
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
	[HeaderAttribute] // RVA: 0x71860 Offset: 0x70C60 VA: 0x180071860
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

	// Properties
	public float NextAttackTime { get; }

	// Methods

	// RVA: 0x8351E0 Offset: 0x8337E0 VA: 0x1808351E0 Slot: 157
	public virtual Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x835710 Offset: 0x833D10 VA: 0x180835710
	public float get_NextAttackTime() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	public virtual void GetAttackStats(HitInfo info) { }

	// RVA: 0x835450 Offset: 0x833A50 VA: 0x180835450
	protected void StartAttackCooldownRaw(float cooldown) { }

	// RVA: 0x835480 Offset: 0x833A80 VA: 0x180835480
	protected void StartAttackCooldown(float cooldown) { }

	// RVA: 0x8353F0 Offset: 0x8339F0 VA: 0x1808353F0
	protected void ResetAttackCooldown() { }

	// RVA: 0x835250 Offset: 0x833850 VA: 0x180835250
	public bool HasAttackCooldown() { }

	// RVA: 0x8350E0 Offset: 0x8336E0 VA: 0x1808350E0
	protected float GetAttackCooldown() { }

	// RVA: 0x835160 Offset: 0x833760 VA: 0x180835160
	protected float GetAttackIdle() { }

	// RVA: 0x834510 Offset: 0x832B10 VA: 0x180834510
	protected float CalculateCooldownTime(float nextTime, float cooldown, bool catchup) { }

	// RVA: 0x835280 Offset: 0x833880 VA: 0x180835280 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x835320 Offset: 0x833920 VA: 0x180835320
	protected void ProcessInputTime() { }

	// RVA: 0x8352C0 Offset: 0x8338C0 VA: 0x1808352C0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8352A0 Offset: 0x8338A0 VA: 0x1808352A0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x835400 Offset: 0x833A00 VA: 0x180835400
	public void SpectatorNotifyDeploy() { }

	// RVA: 0x835410 Offset: 0x833A10 VA: 0x180835410
	public void SpectatorNotifyTick() { }

	// RVA: 0x835370 Offset: 0x833970 VA: 0x180835370
	public bool RecoilCompReady() { }

	// RVA: 0x834360 Offset: 0x832960 VA: 0x180834360 Slot: 131
	public override void AddPunch(Vector3 amount, float duration) { }

	// RVA: 0x834650 Offset: 0x832C50 VA: 0x180834650 Slot: 132
	public override void DoRecoilCompensation() { }

	// RVA: 0x835620 Offset: 0x833C20 VA: 0x180835620
	public void .ctor() { }

	// RVA: 0x8355B0 Offset: 0x833BB0 VA: 0x1808355B0
	private static void .cctor() { }

}

public class ProjectileWeaponMod : BaseEntity // TypeDefIndex: 9626
{	// Fields
	[HeaderAttribute] // RVA: 0x7BF80 Offset: 0x7B380 VA: 0x18007BF80
	public GameObjectRef defaultSilencerEffect; // 0x168
	public bool isSilencer; // 0x170
	[HeaderAttribute] // RVA: 0x7C0B0 Offset: 0x7B4B0 VA: 0x18007C0B0
	public ProjectileWeaponMod.Modifier repeatDelay; // 0x174
	public ProjectileWeaponMod.Modifier projectileVelocity; // 0x180
	public ProjectileWeaponMod.Modifier projectileDamage; // 0x18C
	public ProjectileWeaponMod.Modifier projectileDistance; // 0x198
	[HeaderAttribute] // RVA: 0x7C140 Offset: 0x7B540 VA: 0x18007C140
	public ProjectileWeaponMod.Modifier aimsway; // 0x1A4
	public ProjectileWeaponMod.Modifier aimswaySpeed; // 0x1B0
	public ProjectileWeaponMod.Modifier recoil; // 0x1BC
	[HeaderAttribute] // RVA: 0x7C200 Offset: 0x7B600 VA: 0x18007C200
	public ProjectileWeaponMod.Modifier sightAimCone; // 0x1C8
	public ProjectileWeaponMod.Modifier hipAimCone; // 0x1D4
	[HeaderAttribute] // RVA: 0x7C3C0 Offset: 0x7B7C0 VA: 0x18007C3C0
	public bool isLight; // 0x1E0
	[HeaderAttribute] // RVA: 0x7C480 Offset: 0x7B880 VA: 0x18007C480
	public bool isMuzzleBrake; // 0x1E1
	[HeaderAttribute] // RVA: 0x7C5C0 Offset: 0x7B9C0 VA: 0x18007C5C0
	public bool isMuzzleBoost; // 0x1E2
	[HeaderAttribute] // RVA: 0x7C6A0 Offset: 0x7BAA0 VA: 0x18007C6A0
	public bool isScope; // 0x1E3
	public float zoomAmountDisplayOnly; // 0x1E4
	[HeaderAttribute] // RVA: 0x7C8A0 Offset: 0x7BCA0 VA: 0x18007C8A0
	public ProjectileWeaponMod.Modifier magazineCapacity; // 0x1E8
	public bool needsOnForEffects; // 0x1F4

	// Methods

	// RVA: 0x6943C0 Offset: 0x6929C0 VA: 0x1806943C0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x694490 Offset: 0x692A90 VA: 0x180694490 Slot: 131
	public virtual void SetAiming(bool isAiming) { }

	// RVA: 0x693E30 Offset: 0x692430 VA: 0x180693E30
	public float GetZoomAmount() { }

	// RVA: 0x6941E0 Offset: 0x6927E0 VA: 0x1806941E0
	public static float Mult(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x6944D0 Offset: 0x692AD0 VA: 0x1806944D0
	public static float Sum(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693B70 Offset: 0x692170 VA: 0x180693B70
	public static float Average(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x6940A0 Offset: 0x6926A0 VA: 0x1806940A0
	public static float Max(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x694140 Offset: 0x692740 VA: 0x180694140
	public static float Min(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693C10 Offset: 0x692210 VA: 0x180693C10
	public static IEnumerable<float> GetMods(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value) { }

	// RVA: 0x693F70 Offset: 0x692570 VA: 0x180693F70
	public static bool HasBrokenWeaponMod(BaseEntity parentEnt) { }

	// RVA: 0x694570 Offset: 0x692B70 VA: 0x180694570
	public void .ctor() { }

}

public struct ProjectileWeaponMod.Modifier // TypeDefIndex: 9627
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0x7C940 Offset: 0x7BD40 VA: 0x18007C940
	public float scalar; // 0x4
	[TooltipAttribute] // RVA: 0x7CA30 Offset: 0x7BE30 VA: 0x18007CA30
	public float offset; // 0x8

}

private sealed class ProjectileWeaponMod.<>c // TypeDefIndex: 9628
{	// Fields
	public static readonly ProjectileWeaponMod.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__27_0; // 0x8
	public static Func<ProjectileWeaponMod.Modifier, bool> <>9__27_1; // 0x10
	public static Func<ProjectileWeaponMod, bool> <>9__28_0; // 0x18

	// Methods

	// RVA: 0x6AD410 Offset: 0x6ABA10 VA: 0x1806AD410
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6AD280 Offset: 0x6AB880 VA: 0x1806AD280
	internal bool <GetMods>b__27_0(ProjectileWeaponMod x) { }

	// RVA: 0x6AD310 Offset: 0x6AB910 VA: 0x1806AD310
	internal bool <GetMods>b__27_1(ProjectileWeaponMod.Modifier x) { }

	// RVA: 0x6AD320 Offset: 0x6AB920 VA: 0x1806AD320
	internal bool <HasBrokenWeaponMod>b__28_0(ProjectileWeaponMod x) { }

}

public class AttackTickEventUI : BaseEventUI // TypeDefIndex: 10787
{	// Methods

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class AttackedEventUI : BaseEventUI // TypeDefIndex: 10788
{	// Methods

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class ProjectileWeaponInformationPanel : ItemInformationPanel // TypeDefIndex: 11043
{	// Fields
	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue recoilDisplay; // 0x20
	public ItemStatValue rofDisplay; // 0x28
	public ItemStatValue accuracyDisplay; // 0x30
	public ItemStatValue rangeDisplay; // 0x38

	// Methods

	// RVA: 0x693120 Offset: 0x691720 VA: 0x180693120 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x693210 Offset: 0x691810 VA: 0x180693210 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

