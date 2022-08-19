public class BaseProjectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6318
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Magazine primaryMagazine; // 0x18

	// Methods

	// RVA: 0x1F65470 Offset: 0x1F63A70 VA: 0x181F65470
	public static void ResetToPool(BaseProjectile instance) { }

	// RVA: 0x1F653D0 Offset: 0x1F639D0 VA: 0x181F653D0
	public void ResetToPool() { }

	// RVA: 0x1F65270 Offset: 0x1F63870 VA: 0x181F65270 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F647D0 Offset: 0x1F62DD0 VA: 0x181F647D0
	public void CopyTo(BaseProjectile instance) { }

	// RVA: 0x1F64840 Offset: 0x1F62E40 VA: 0x181F64840
	public BaseProjectile Copy() { }

	// RVA: 0x1F64FD0 Offset: 0x1F635D0 VA: 0x181F64FD0
	public static BaseProjectile Deserialize(Stream stream) { }

	// RVA: 0x1F64B50 Offset: 0x1F63150 VA: 0x181F64B50
	public static BaseProjectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F64BD0 Offset: 0x1F631D0 VA: 0x181F64BD0
	public static BaseProjectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F65150 Offset: 0x1F63750 VA: 0x181F65150
	public static BaseProjectile Deserialize(byte[] buffer) { }

	// RVA: 0x1F65390 Offset: 0x1F63990 VA: 0x181F65390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F65A00 Offset: 0x1F64000 VA: 0x181F65A00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F65A20 Offset: 0x1F64020 VA: 0x181F65A20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseProjectile previous) { }

	// RVA: 0x1F653B0 Offset: 0x1F639B0 VA: 0x181F653B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F65050 Offset: 0x1F63650 VA: 0x181F65050
	public static BaseProjectile Deserialize(byte[] buffer, BaseProjectile instance, bool isDelta = False) { }

	// RVA: 0x1F64E70 Offset: 0x1F63470 VA: 0x181F64E70
	public static BaseProjectile Deserialize(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F64910 Offset: 0x1F62F10 VA: 0x181F64910
	public static BaseProjectile DeserializeLengthDelimited(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F64C60 Offset: 0x1F63260 VA: 0x181F64C60
	public static BaseProjectile DeserializeLength(Stream stream, int length, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F65510 Offset: 0x1F63B10 VA: 0x181F65510
	public static void SerializeDelta(Stream stream, BaseProjectile instance, BaseProjectile previous) { }

	// RVA: 0x1F65870 Offset: 0x1F63E70 VA: 0x181F65870
	public static void Serialize(Stream stream, BaseProjectile instance) { }

	// RVA: 0x1F659F0 Offset: 0x1F63FF0 VA: 0x181F659F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F65A00 Offset: 0x1F64000 VA: 0x181F65A00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F65760 Offset: 0x1F63D60 VA: 0x181F65760
	public static byte[] SerializeToBytes(BaseProjectile instance) { }

	// RVA: 0x1F656B0 Offset: 0x1F63CB0 VA: 0x181F656B0
	public static void SerializeLengthDelimited(Stream stream, BaseProjectile instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1FF6080 Offset: 0x1FF4680 VA: 0x181FF6080
	public static void ResetToPool(Attack instance) { }

	// RVA: 0x1FF5F50 Offset: 0x1FF4550 VA: 0x181FF5F50
	public void ResetToPool() { }

	// RVA: 0x1FF59E0 Offset: 0x1FF3FE0 VA: 0x181FF59E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF3DE0 Offset: 0x1FF23E0 VA: 0x181FF3DE0
	public void CopyTo(Attack instance) { }

	// RVA: 0x1FF3E80 Offset: 0x1FF2480 VA: 0x181FF3E80
	public Attack Copy() { }

	// RVA: 0x1FF5190 Offset: 0x1FF3790 VA: 0x181FF5190
	public static Attack Deserialize(Stream stream) { }

	// RVA: 0x1FF43E0 Offset: 0x1FF29E0 VA: 0x181FF43E0
	public static Attack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF4460 Offset: 0x1FF2A60 VA: 0x181FF4460
	public static Attack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF4940 Offset: 0x1FF2F40 VA: 0x181FF4940
	public static Attack Deserialize(byte[] buffer) { }

	// RVA: 0x1FF5B90 Offset: 0x1FF4190 VA: 0x181FF5B90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF7470 Offset: 0x1FF5A70 VA: 0x181FF7470 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF7490 Offset: 0x1FF5A90 VA: 0x181FF7490 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Attack previous) { }

	// RVA: 0x1FF5F30 Offset: 0x1FF4530 VA: 0x181FF5F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF5560 Offset: 0x1FF3B60 VA: 0x181FF5560
	public static Attack Deserialize(byte[] buffer, Attack instance, bool isDelta = False) { }

	// RVA: 0x1FF4DF0 Offset: 0x1FF33F0 VA: 0x181FF4DF0
	public static Attack Deserialize(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FF3F70 Offset: 0x1FF2570 VA: 0x181FF3F70
	public static Attack DeserializeLengthDelimited(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FF44F0 Offset: 0x1FF2AF0 VA: 0x181FF44F0
	public static Attack DeserializeLength(Stream stream, int length, Attack instance, bool isDelta) { }

	// RVA: 0x1FF61B0 Offset: 0x1FF47B0 VA: 0x181FF61B0
	public static void SerializeDelta(Stream stream, Attack instance, Attack previous) { }

	// RVA: 0x1FF6E70 Offset: 0x1FF5470 VA: 0x181FF6E70
	public static void Serialize(Stream stream, Attack instance) { }

	// RVA: 0x1FF7460 Offset: 0x1FF5A60 VA: 0x181FF7460
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF7470 Offset: 0x1FF5A70 VA: 0x181FF7470
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF6D60 Offset: 0x1FF5360 VA: 0x181FF6D60
	public static byte[] SerializeToBytes(Attack instance) { }

	// RVA: 0x1FF6CB0 Offset: 0x1FF52B0 VA: 0x181FF6CB0
	public static void SerializeLengthDelimited(Stream stream, Attack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ProjectileShoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6488
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int ammoType; // 0x14
	public List<ProjectileShoot.Projectile> projectiles; // 0x18

	// Methods

	// RVA: 0x2049AA0 Offset: 0x20480A0 VA: 0x182049AA0
	public static void ResetToPool(ProjectileShoot instance) { }

	// RVA: 0x2049C60 Offset: 0x2048260 VA: 0x182049C60
	public void ResetToPool() { }

	// RVA: 0x20499E0 Offset: 0x2047FE0 VA: 0x1820499E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2048A60 Offset: 0x2047060 VA: 0x182048A60
	public void CopyTo(ProjectileShoot instance) { }

	// RVA: 0x2048C10 Offset: 0x2047210 VA: 0x182048C10
	public ProjectileShoot Copy() { }

	// RVA: 0x2049510 Offset: 0x2047B10 VA: 0x182049510
	public static ProjectileShoot Deserialize(Stream stream) { }

	// RVA: 0x2048E10 Offset: 0x2047410 VA: 0x182048E10
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2049480 Offset: 0x2047A80 VA: 0x182049480
	public static ProjectileShoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20498C0 Offset: 0x2047EC0 VA: 0x1820498C0
	public static ProjectileShoot Deserialize(byte[] buffer) { }

	// RVA: 0x2049A60 Offset: 0x2048060 VA: 0x182049A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204A450 Offset: 0x2048A50 VA: 0x18204A450 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204A470 Offset: 0x2048A70 VA: 0x18204A470 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot previous) { }

	// RVA: 0x2049A80 Offset: 0x2048080 VA: 0x182049A80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2049590 Offset: 0x2047B90 VA: 0x182049590
	public static ProjectileShoot Deserialize(byte[] buffer, ProjectileShoot instance, bool isDelta = False) { }

	// RVA: 0x2049690 Offset: 0x2047C90 VA: 0x182049690
	public static ProjectileShoot Deserialize(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2048E90 Offset: 0x2047490 VA: 0x182048E90
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x20491A0 Offset: 0x20477A0 VA: 0x1820491A0
	public static ProjectileShoot DeserializeLength(Stream stream, int length, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2049E20 Offset: 0x2048420 VA: 0x182049E20
	public static void SerializeDelta(Stream stream, ProjectileShoot instance, ProjectileShoot previous) { }

	// RVA: 0x204A220 Offset: 0x2048820 VA: 0x18204A220
	public static void Serialize(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x204A440 Offset: 0x2048A40 VA: 0x18204A440
	public byte[] ToProtoBytes() { }

	// RVA: 0x204A450 Offset: 0x2048A50 VA: 0x18204A450
	public void ToProto(Stream stream) { }

	// RVA: 0x204A110 Offset: 0x2048710 VA: 0x18204A110
	public static byte[] SerializeToBytes(ProjectileShoot instance) { }

	// RVA: 0x204A060 Offset: 0x2048660 VA: 0x18204A060
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x204B860 Offset: 0x2049E60 VA: 0x18204B860
	public static void ResetToPool(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204B910 Offset: 0x2049F10 VA: 0x18204B910
	public void ResetToPool() { }

	// RVA: 0x204B5C0 Offset: 0x2049BC0 VA: 0x18204B5C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203D5A0 Offset: 0x203BBA0 VA: 0x18203D5A0
	public void CopyTo(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204A490 Offset: 0x2048A90 VA: 0x18204A490
	public ProjectileShoot.Projectile Copy() { }

	// RVA: 0x204B0B0 Offset: 0x20496B0 VA: 0x18204B0B0
	public static ProjectileShoot.Projectile Deserialize(Stream stream) { }

	// RVA: 0x204A530 Offset: 0x2048B30 VA: 0x18204A530
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204A880 Offset: 0x2048E80 VA: 0x18204A880
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204ADD0 Offset: 0x20493D0 VA: 0x18204ADD0
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer) { }

	// RVA: 0x204B640 Offset: 0x2049C40 VA: 0x18204B640
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204C270 Offset: 0x204A870 VA: 0x18204C270 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204C290 Offset: 0x204A890 VA: 0x18204C290 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot.Projectile previous) { }

	// RVA: 0x204B840 Offset: 0x2049E40 VA: 0x18204B840 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204B2F0 Offset: 0x20498F0 VA: 0x18204B2F0
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer, ProjectileShoot.Projectile instance, bool isDelta = False) { }

	// RVA: 0x204ABC0 Offset: 0x20491C0 VA: 0x18204ABC0
	public static ProjectileShoot.Projectile Deserialize(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204A5B0 Offset: 0x2048BB0 VA: 0x18204A5B0
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204A910 Offset: 0x2048F10 VA: 0x18204A910
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204B9C0 Offset: 0x2049FC0 VA: 0x18204B9C0
	public static void SerializeDelta(Stream stream, ProjectileShoot.Projectile instance, ProjectileShoot.Projectile previous) { }

	// RVA: 0x204BFD0 Offset: 0x204A5D0 VA: 0x18204BFD0
	public static void Serialize(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x204C260 Offset: 0x204A860 VA: 0x18204C260
	public byte[] ToProtoBytes() { }

	// RVA: 0x204C270 Offset: 0x204A870 VA: 0x18204C270
	public void ToProto(Stream stream) { }

	// RVA: 0x204BEC0 Offset: 0x204A4C0 VA: 0x18204BEC0
	public static byte[] SerializeToBytes(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204BE10 Offset: 0x204A410 VA: 0x18204BE10
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class BaseProjectile : AttackEntity // TypeDefIndex: 8529
{	// Fields
	[HeaderAttribute] // RVA: 0xA5DF0 Offset: 0xA51F0 VA: 0x1800A5DF0
	public float NoiseRadius; // 0x280
	[HeaderAttribute] // RVA: 0xA7220 Offset: 0xA6620 VA: 0x1800A7220
	public float damageScale; // 0x284
	public float distanceScale; // 0x288
	public float projectileVelocityScale; // 0x28C
	public bool automatic; // 0x290
	public bool usableByTurret; // 0x291
	[TooltipAttribute] // RVA: 0xA7280 Offset: 0xA6680 VA: 0x1800A7280
	public float turretDamageScale; // 0x294
	[HeaderAttribute] // RVA: 0x786F0 Offset: 0x77AF0 VA: 0x1800786F0
	public GameObjectRef attackFX; // 0x298
	public GameObjectRef silencedAttack; // 0x2A0
	public GameObjectRef muzzleBrakeAttack; // 0x2A8
	public Transform MuzzlePoint; // 0x2B0
	[HeaderAttribute] // RVA: 0xA73E0 Offset: 0xA67E0 VA: 0x1800A73E0
	public float reloadTime; // 0x2B8
	public bool canUnloadAmmo; // 0x2BC
	public BaseProjectile.Magazine primaryMagazine; // 0x2C0
	public bool fractionalReload; // 0x2C8
	public float reloadStartDuration; // 0x2CC
	public float reloadFractionDuration; // 0x2D0
	public float reloadEndDuration; // 0x2D4
	[HeaderAttribute] // RVA: 0x7C090 Offset: 0x7B490 VA: 0x18007C090
	public float aimSway; // 0x2D8
	public float aimSwaySpeed; // 0x2DC
	public RecoilProperties recoil; // 0x2E0
	[HeaderAttribute] // RVA: 0x7C130 Offset: 0x7B530 VA: 0x18007C130
	public AnimationCurve aimconeCurve; // 0x2E8
	public float aimCone; // 0x2F0
	public float hipAimCone; // 0x2F4
	public float aimconePenaltyPerShot; // 0x2F8
	public float aimConePenaltyMax; // 0x2FC
	public float aimconePenaltyRecoverTime; // 0x300
	public float aimconePenaltyRecoverDelay; // 0x304
	public float stancePenaltyScale; // 0x308
	[HeaderAttribute] // RVA: 0xA74E0 Offset: 0xA68E0 VA: 0x1800A74E0
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

	// RVA: 0x9265B0 Offset: 0x924BB0 VA: 0x1809265B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x928110 Offset: 0x926710 VA: 0x180928110
	public RecoilProperties get_recoilProperties() { }

	// RVA: 0x923BB0 Offset: 0x9221B0 VA: 0x180923BB0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x923B90 Offset: 0x922190 VA: 0x180923B90 Slot: 160
	public virtual float GetDamageScale(bool getMax = False) { }

	// RVA: 0x923BA0 Offset: 0x9221A0 VA: 0x180923BA0 Slot: 161
	public virtual float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x924390 Offset: 0x922990 VA: 0x180924390 Slot: 162
	public virtual float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x927D90 Offset: 0x926390 VA: 0x180927D90
	protected void StartReloadCooldown(float cooldown) { }

	// RVA: 0x9271B0 Offset: 0x9257B0 VA: 0x1809271B0
	protected void ResetReloadCooldown() { }

	// RVA: 0x924AB0 Offset: 0x9230B0 VA: 0x180924AB0
	protected bool HasReloadCooldown() { }

	// RVA: 0x9243B0 Offset: 0x9229B0 VA: 0x1809243B0
	protected float GetReloadCooldown() { }

	// RVA: 0x924510 Offset: 0x922B10 VA: 0x180924510
	protected float GetReloadIdle() { }

	// RVA: 0x925DF0 Offset: 0x9243F0 VA: 0x180925DF0
	private void OnDrawGizmos() { }

	// RVA: 0x9243A0 Offset: 0x9229A0 VA: 0x1809243A0 Slot: 163
	public virtual RecoilProperties GetRecoil() { }

	// RVA: 0x928100 Offset: 0x926700 VA: 0x180928100
	public bool get_isSemiAuto() { }

	// RVA: 0x9230A0 Offset: 0x9216A0 VA: 0x1809230A0 Slot: 164
	public virtual float GetAimCone() { }

	// RVA: 0x9271C0 Offset: 0x9257C0 VA: 0x1809271C0
	public float ScaleRepeatDelay(float delay) { }

	// RVA: 0x923D50 Offset: 0x922350 VA: 0x180923D50
	public Projectile.Modifier GetProjectileModifier() { }

	// RVA: 0x921590 Offset: 0x91FB90 VA: 0x180921590 Slot: 165
	public virtual void DidAttackClientside() { }

	// RVA: 0x923C00 Offset: 0x922200 VA: 0x180923C00 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x9212B0 Offset: 0x91F8B0 VA: 0x1809212B0
	public bool ClientIsReloading() { }

	// RVA: 0x925DA0 Offset: 0x9243A0 VA: 0x180925DA0
	public void NotifySpectatorReloading(bool state) { }

	// RVA: 0x9226A0 Offset: 0x920CA0 VA: 0x1809226A0 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x9261C0 Offset: 0x9247C0 VA: 0x1809261C0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x9274F0 Offset: 0x925AF0 VA: 0x1809274F0 Slot: 166
	public virtual void ShotFired() { }

	// RVA: 0x927550 Offset: 0x925B50 VA: 0x180927550 Slot: 167
	public virtual void SimulateAimcone() { }

	// RVA: 0x9210B0 Offset: 0x91F6B0 VA: 0x1809210B0 Slot: 168
	public virtual bool CanAttack() { }

	// RVA: 0x921080 Offset: 0x91F680 VA: 0x180921080 Slot: 169
	public virtual bool CanAim() { }

	// RVA: 0x9261D0 Offset: 0x9247D0 VA: 0x1809261D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x927100 Offset: 0x925700 VA: 0x180927100
	public bool ReadyToAim() { }

	// RVA: 0x927150 Offset: 0x925750 VA: 0x180927150
	public bool ReadyToFire() { }

	// RVA: 0x920F60 Offset: 0x91F560 VA: 0x180920F60
	public void AmmoTypeClicked(ItemDefinition newAmmoType) { }

	// RVA: 0x920DB0 Offset: 0x91F3B0 VA: 0x180920DB0
	private void AddAmmoOption(ItemDefinition ammo, List<Option> opts, int order = 0) { }

	// RVA: 0x924590 Offset: 0x922B90 VA: 0x180924590
	public List<Option> GetReloadMenu(BasePlayer player) { }

	// RVA: 0x926D60 Offset: 0x925360 VA: 0x180926D60
	private void PredictAmmoType() { }

	// RVA: 0x924800 Offset: 0x922E00 VA: 0x180924800 Slot: 170
	public virtual bool HasMoreThanOneAmmoType(AmmoTypes ammoType) { }

	// RVA: 0x925DB0 Offset: 0x9243B0 VA: 0x180925DB0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x922120 Offset: 0x920720 VA: 0x180922120
	private void DoReload() { }

	// RVA: 0x924AE0 Offset: 0x9230E0 VA: 0x180924AE0
	protected void InsertAmmoFraction() { }

	// RVA: 0x9210D0 Offset: 0x91F6D0 VA: 0x1809210D0
	public void CancelFractionalReloading() { }

	// RVA: 0x921170 Offset: 0x91F770 VA: 0x180921170
	protected void ClientFinishFractionalReload() { }

	// RVA: 0x9212C0 Offset: 0x91F8C0 VA: 0x1809212C0
	protected void ClientSingleReload() { }

	// RVA: 0x921660 Offset: 0x91FC60 VA: 0x180921660 Slot: 171
	public virtual void DoAttack() { }

	// RVA: 0x920FF0 Offset: 0x91F5F0 VA: 0x180920FF0
	public void BeginCycle() { }

	// RVA: 0x925BB0 Offset: 0x9241B0 VA: 0x180925BB0 Slot: 172
	public virtual void LaunchProjectile() { }

	// RVA: 0x9225E0 Offset: 0x920BE0 VA: 0x1809225E0
	public void DryFire() { }

	// RVA: 0x9270A0 Offset: 0x9256A0 VA: 0x1809270A0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x926F90 Offset: 0x925590 VA: 0x180926F90 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x924430 Offset: 0x922A30 VA: 0x180924430
	public float GetReloadDuration() { }

	// RVA: 0x923980 Offset: 0x921F80 VA: 0x180923980
	public int GetAvailableAmmo() { }

	// RVA: 0x924B40 Offset: 0x923140 VA: 0x180924B40
	public bool IsSilenced() { }

	// RVA: 0x923010 Offset: 0x921610 VA: 0x180923010
	public bool FiredUnderground() { }

	// RVA: 0x9266A0 Offset: 0x924CA0 VA: 0x1809266A0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x924D20 Offset: 0x923320 VA: 0x180924D20
	internal void LaunchProjectileClientside(ItemDefinition ammo, int projectileCount, float projSpreadaimCone) { }

	// RVA: 0x921400 Offset: 0x91FA00 VA: 0x180921400
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0x927DE0 Offset: 0x9263E0 VA: 0x180927DE0 Slot: 173
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool get_UsingInfiniteAmmoCheat() { }

	// RVA: 0x925D00 Offset: 0x924300 VA: 0x180925D00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x927E90 Offset: 0x926490 VA: 0x180927E90
	public void .ctor() { }

}

public class BaseProjectile.Magazine // TypeDefIndex: 8530
{	// Fields
	public BaseProjectile.Magazine.Definition definition; // 0x10
	public int capacity; // 0x18
	public int contents; // 0x1C
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition ammoType; // 0x20

	// Methods

	// RVA: 0x93A7E0 Offset: 0x938DE0 VA: 0x18093A7E0
	public void ServerInit() { }

	// RVA: 0x93A710 Offset: 0x938D10 VA: 0x18093A710
	public Magazine Save() { }

	// RVA: 0x93A6C0 Offset: 0x938CC0 VA: 0x18093A6C0
	public void Load(Magazine mag) { }

	// RVA: 0x93A680 Offset: 0x938C80 VA: 0x18093A680
	public bool CanReload(BasePlayer owner) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct BaseProjectile.Magazine.Definition // TypeDefIndex: 8531
{	// Fields
	[TooltipAttribute] // RVA: 0xA7650 Offset: 0xA6A50 VA: 0x1800A7650
	public int builtInSize; // 0x0
	[TooltipAttribute] // RVA: 0xA7950 Offset: 0xA6D50 VA: 0x1800A7950
	[InspectorFlagsAttribute] // RVA: 0xA7950 Offset: 0xA6D50 VA: 0x1800A7950
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

	// RVA: 0x93B320 Offset: 0x939920 VA: 0x18093B320
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B010 Offset: 0x939610 VA: 0x18093B010
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <GetAimCone>b__63_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B010 Offset: 0x939610 VA: 0x18093B010
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <GetAimCone>b__63_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B040 Offset: 0x939640 VA: 0x18093B040
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_4(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <GetAimCone>b__63_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B040 Offset: 0x939640 VA: 0x18093B040
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_6(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <GetAimCone>b__63_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B1A0 Offset: 0x9397A0 VA: 0x18093B1A0
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <ScaleRepeatDelay>b__64_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B1A0 Offset: 0x9397A0 VA: 0x18093B1A0
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <ScaleRepeatDelay>b__64_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B070 Offset: 0x939670 VA: 0x18093B070
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <GetProjectileModifier>b__65_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B070 Offset: 0x939670 VA: 0x18093B070
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <GetProjectileModifier>b__65_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_4(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <GetProjectileModifier>b__65_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0A0 Offset: 0x9396A0 VA: 0x18093B0A0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_6(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <GetProjectileModifier>b__65_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AFB0 Offset: 0x9395B0 VA: 0x18093AFB0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <EditViewAngles>b__72_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AFB0 Offset: 0x9395B0 VA: 0x18093AFB0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <EditViewAngles>b__72_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AFE0 Offset: 0x9395E0 VA: 0x18093AFE0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_4(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <EditViewAngles>b__72_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AFE0 Offset: 0x9395E0 VA: 0x18093AFE0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_6(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <EditViewAngles>b__72_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AF50 Offset: 0x939550 VA: 0x18093AF50
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <SimulateAimcone>b__76_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AF50 Offset: 0x939550 VA: 0x18093AF50
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <SimulateAimcone>b__76_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AF50 Offset: 0x939550 VA: 0x18093AF50
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <DoAttack>b__98_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93AF50 Offset: 0x939550 VA: 0x18093AF50
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <DoAttack>b__98_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B140 Offset: 0x939740 VA: 0x18093B140
	internal bool <OnSignal>b__110_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B0D0 Offset: 0x9396D0 VA: 0x18093B0D0
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_0(ProjectileWeaponMod x) { }

	// RVA: 0x93AF80 Offset: 0x939580 VA: 0x18093AF80
	internal float <LaunchProjectileClientside>b__112_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B0D0 Offset: 0x9396D0 VA: 0x18093B0D0
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_2(ProjectileWeaponMod x) { }

	// RVA: 0x93AF90 Offset: 0x939590 VA: 0x18093AF90
	internal float <LaunchProjectileClientside>b__112_3(ProjectileWeaponMod.Modifier y) { }

}

private sealed class BaseProjectile.<>c__DisplayClass84_0 // TypeDefIndex: 8533
{	// Fields
	public BaseProjectile <>4__this; // 0x10
	public ItemDefinition ammoType; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B280 Offset: 0x939880 VA: 0x18093B280
	internal void <AddAmmoOption>b__0(BasePlayer ply) { }

}

public class Projectile : BaseMonoBehaviour // TypeDefIndex: 9223
{	// Fields
	public const float moveDeltaTime = 0,03125;
	public const float lifeTime = 8;
	[HeaderAttribute] // RVA: 0xDA2A0 Offset: 0xD96A0 VA: 0x1800DA2A0
	public Vector3 initialVelocity; // 0x18
	public float drag; // 0x24
	public float gravityModifier; // 0x28
	public float thickness; // 0x2C
	[TooltipAttribute] // RVA: 0xDA4F0 Offset: 0xD98F0 VA: 0x1800DA4F0
	public float initialDistance; // 0x30
	[HeaderAttribute] // RVA: 0xDA6C0 Offset: 0xD9AC0 VA: 0x1800DA6C0
	public bool remainInWorld; // 0x34
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float stickProbability; // 0x38
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float breakProbability; // 0x3C
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float conditionLoss; // 0x40
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float ricochetChance; // 0x44
	public float penetrationPower; // 0x48
	[HeaderAttribute] // RVA: 0xCB670 Offset: 0xCAA70 VA: 0x1800CB670
	public DamageProperties damageProperties; // 0x50
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public MinMax damageDistances; // 0x58
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public MinMax damageMultipliers; // 0x60
	public List<DamageTypeEntry> damageTypes; // 0x68
	[HeaderAttribute] // RVA: 0xDAC40 Offset: 0xDA040 VA: 0x1800DAC40
	public ScaleRenderer rendererToScale; // 0x70
	public ScaleRenderer firstPersonRenderer; // 0x78
	public bool createDecals; // 0x80
	[HeaderAttribute] // RVA: 0x786F0 Offset: 0x77AF0 VA: 0x1800786F0
	public bool doDefaultHitEffects; // 0x81
	[HeaderAttribute] // RVA: 0x72010 Offset: 0x71410 VA: 0x180072010
	public SoundDefinition flybySound; // 0x88
	public float flybySoundDistance; // 0x90
	public SoundDefinition closeFlybySound; // 0x98
	public float closeFlybyDistance; // 0xA0
	[HeaderAttribute] // RVA: 0xDAEE0 Offset: 0xDA2E0 VA: 0x1800DAEE0
	public float tumbleSpeed; // 0xA4
	public Vector3 tumbleAxis; // 0xA8
	[HeaderAttribute] // RVA: 0xDAFC0 Offset: 0xDA3C0 VA: 0x1800DAFC0
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

	// RVA: 0x694730 Offset: 0x692D30 VA: 0x180694730
	public void CalculateDamage(HitInfo info, Projectile.Modifier mod, float scale) { }

	// RVA: 0x6994E0 Offset: 0x697AE0 VA: 0x1806994E0
	public bool get_isAuthoritative() { }

	// RVA: 0x6994A0 Offset: 0x697AA0 VA: 0x1806994A0
	private bool get_isAlive() { }

	// RVA: 0x698290 Offset: 0x696890 VA: 0x180698290
	private void Retire() { }

	// RVA: 0x694C80 Offset: 0x693280 VA: 0x180694C80
	private void Cleanup() { }

	// RVA: 0x6944C0 Offset: 0x692AC0 VA: 0x1806944C0
	public void AdjustVelocity(Vector3 delta) { }

	// RVA: 0x6974D0 Offset: 0x695AD0 VA: 0x1806974D0
	public void InitializeVelocity(Vector3 overrideVel) { }

	// RVA: 0x697740 Offset: 0x695D40 VA: 0x180697740
	protected void OnDisable() { }

	// RVA: 0x699100 Offset: 0x697700 VA: 0x180699100
	protected void Update() { }

	// RVA: 0x698860 Offset: 0x696E60 VA: 0x180698860
	private void SetEffectScale(float eScale) { }

	// RVA: 0x694E80 Offset: 0x693480 VA: 0x180694E80
	private void DoFlybySound() { }

	// RVA: 0x694BE0 Offset: 0x6931E0 VA: 0x180694BE0 Slot: 6
	protected virtual float CalculateEffectScale() { }

	// RVA: 0x698E20 Offset: 0x697420 VA: 0x180698E20
	private void UpdateVelocity(float deltaTime) { }

	// RVA: 0x696CE0 Offset: 0x6952E0 VA: 0x180696CE0
	private void DoVelocityUpdate(float deltaTime) { }

	// RVA: 0x695BA0 Offset: 0x6941A0 VA: 0x180695BA0
	private void DoMovement(float deltaTime) { }

	// RVA: 0x6970C0 Offset: 0x6956C0 VA: 0x1806970C0
	private bool DoWaterHit(ref HitTest test, Vector3 targetPosition) { }

	// RVA: 0x6968C0 Offset: 0x694EC0 VA: 0x1806968C0
	private bool DoRicochet(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x695490 Offset: 0x693A90 VA: 0x180695490
	private bool DoHit(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void AdditiveImpactEffect(HitInfo info) { }

	// RVA: 0x697A10 Offset: 0x696010 VA: 0x180697A10
	private bool Reflect(ref uint seed, Vector3 point, Vector3 normal) { }

	// RVA: 0x697D60 Offset: 0x696360 VA: 0x180697D60
	private bool Refract(ref uint seed, Vector3 point, Vector3 normal, float resistance) { }

	// RVA: 0x698130 Offset: 0x696730 VA: 0x180698130
	private Vector3 Refract(Vector3 v, Vector3 n, float f) { }

	// RVA: 0x697910 Offset: 0x695F10 VA: 0x180697910
	private Quaternion RandomRotation(ref uint seed, float range) { }

	// RVA: 0x6976B0 Offset: 0x695CB0 VA: 0x1806976B0
	internal void Launch() { }

	// RVA: 0x6973D0 Offset: 0x6959D0 VA: 0x1806973D0
	public static uint FleshMaterialID() { }

	// RVA: 0x699200 Offset: 0x697800 VA: 0x180699200
	public static uint WaterMaterialID() { }

	// RVA: 0x697580 Offset: 0x695B80 VA: 0x180697580
	public static bool IsWaterMaterial(string hitMaterial) { }

	// RVA: 0x698D60 Offset: 0x697360 VA: 0x180698D60
	public static bool ShouldStopProjectile(RaycastHit hit) { }

	// RVA: 0x699300 Offset: 0x697900 VA: 0x180699300
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

	// RVA: 0x6914B0 Offset: 0x68FAB0 VA: 0x1806914B0
	private static void .cctor() { }

}

public class ProjectileTestSpawner : MonoBehaviour // TypeDefIndex: 9323
{	// Fields
	public Projectile TargetProjectile; // 0x18
	public float RepeatTime; // 0x20
	public float VelocityScale; // 0x24

	// Methods

	// RVA: 0x692FF0 Offset: 0x6915F0 VA: 0x180692FF0
	public void .ctor() { }

}

public class AttackTickAIEvent : BaseAIEvent // TypeDefIndex: 9391
{	// Methods

	// RVA: 0x835610 Offset: 0x833C10 VA: 0x180835610
	public void .ctor() { }

}

public class AttackedAIEvent : BaseAIEvent // TypeDefIndex: 9392
{	// Fields
	protected float lastExecuteTime; // 0x40
	private BaseCombatEntity combatEntity; // 0x48

	// Methods

	// RVA: 0x835640 Offset: 0x833C40 VA: 0x180835640
	public void .ctor() { }

}

public class AttackEntity : HeldEntity // TypeDefIndex: 9460
{	// Fields
	[HeaderAttribute] // RVA: 0x71550 Offset: 0x70950 VA: 0x180071550
	public float deployDelay; // 0x1F8
	public float repeatDelay; // 0x1FC
	public float animationDelay; // 0x200
	[HeaderAttribute] // RVA: 0x71680 Offset: 0x70A80 VA: 0x180071680
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
	[HeaderAttribute] // RVA: 0x71760 Offset: 0x70B60 VA: 0x180071760
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

	// RVA: 0x8350D0 Offset: 0x8336D0 VA: 0x1808350D0 Slot: 157
	public virtual Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x835600 Offset: 0x833C00 VA: 0x180835600
	public float get_NextAttackTime() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	public virtual void GetAttackStats(HitInfo info) { }

	// RVA: 0x835340 Offset: 0x833940 VA: 0x180835340
	protected void StartAttackCooldownRaw(float cooldown) { }

	// RVA: 0x835370 Offset: 0x833970 VA: 0x180835370
	protected void StartAttackCooldown(float cooldown) { }

	// RVA: 0x8352E0 Offset: 0x8338E0 VA: 0x1808352E0
	protected void ResetAttackCooldown() { }

	// RVA: 0x835140 Offset: 0x833740 VA: 0x180835140
	public bool HasAttackCooldown() { }

	// RVA: 0x834FD0 Offset: 0x8335D0 VA: 0x180834FD0
	protected float GetAttackCooldown() { }

	// RVA: 0x835050 Offset: 0x833650 VA: 0x180835050
	protected float GetAttackIdle() { }

	// RVA: 0x834400 Offset: 0x832A00 VA: 0x180834400
	protected float CalculateCooldownTime(float nextTime, float cooldown, bool catchup) { }

	// RVA: 0x835170 Offset: 0x833770 VA: 0x180835170 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x835210 Offset: 0x833810 VA: 0x180835210
	protected void ProcessInputTime() { }

	// RVA: 0x8351B0 Offset: 0x8337B0 VA: 0x1808351B0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x835190 Offset: 0x833790 VA: 0x180835190 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x8352F0 Offset: 0x8338F0 VA: 0x1808352F0
	public void SpectatorNotifyDeploy() { }

	// RVA: 0x835300 Offset: 0x833900 VA: 0x180835300
	public void SpectatorNotifyTick() { }

	// RVA: 0x835260 Offset: 0x833860 VA: 0x180835260
	public bool RecoilCompReady() { }

	// RVA: 0x834250 Offset: 0x832850 VA: 0x180834250 Slot: 131
	public override void AddPunch(Vector3 amount, float duration) { }

	// RVA: 0x834540 Offset: 0x832B40 VA: 0x180834540 Slot: 132
	public override void DoRecoilCompensation() { }

	// RVA: 0x835510 Offset: 0x833B10 VA: 0x180835510
	public void .ctor() { }

	// RVA: 0x8354A0 Offset: 0x833AA0 VA: 0x1808354A0
	private static void .cctor() { }

}

public class ProjectileWeaponMod : BaseEntity // TypeDefIndex: 9626
{	// Fields
	[HeaderAttribute] // RVA: 0x7BEB0 Offset: 0x7B2B0 VA: 0x18007BEB0
	public GameObjectRef defaultSilencerEffect; // 0x168
	public bool isSilencer; // 0x170
	[HeaderAttribute] // RVA: 0x7BFB0 Offset: 0x7B3B0 VA: 0x18007BFB0
	public ProjectileWeaponMod.Modifier repeatDelay; // 0x174
	public ProjectileWeaponMod.Modifier projectileVelocity; // 0x180
	public ProjectileWeaponMod.Modifier projectileDamage; // 0x18C
	public ProjectileWeaponMod.Modifier projectileDistance; // 0x198
	[HeaderAttribute] // RVA: 0x7C090 Offset: 0x7B490 VA: 0x18007C090
	public ProjectileWeaponMod.Modifier aimsway; // 0x1A4
	public ProjectileWeaponMod.Modifier aimswaySpeed; // 0x1B0
	public ProjectileWeaponMod.Modifier recoil; // 0x1BC
	[HeaderAttribute] // RVA: 0x7C130 Offset: 0x7B530 VA: 0x18007C130
	public ProjectileWeaponMod.Modifier sightAimCone; // 0x1C8
	public ProjectileWeaponMod.Modifier hipAimCone; // 0x1D4
	[HeaderAttribute] // RVA: 0x7C2F0 Offset: 0x7B6F0 VA: 0x18007C2F0
	public bool isLight; // 0x1E0
	[HeaderAttribute] // RVA: 0x7C3B0 Offset: 0x7B7B0 VA: 0x18007C3B0
	public bool isMuzzleBrake; // 0x1E1
	[HeaderAttribute] // RVA: 0x7C540 Offset: 0x7B940 VA: 0x18007C540
	public bool isMuzzleBoost; // 0x1E2
	[HeaderAttribute] // RVA: 0x7C5D0 Offset: 0x7B9D0 VA: 0x18007C5D0
	public bool isScope; // 0x1E3
	public float zoomAmountDisplayOnly; // 0x1E4
	[HeaderAttribute] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	public ProjectileWeaponMod.Modifier magazineCapacity; // 0x1E8
	public bool needsOnForEffects; // 0x1F4

	// Methods

	// RVA: 0x6942B0 Offset: 0x6928B0 VA: 0x1806942B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x694380 Offset: 0x692980 VA: 0x180694380 Slot: 131
	public virtual void SetAiming(bool isAiming) { }

	// RVA: 0x693D20 Offset: 0x692320 VA: 0x180693D20
	public float GetZoomAmount() { }

	// RVA: 0x6940D0 Offset: 0x6926D0 VA: 0x1806940D0
	public static float Mult(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x6943C0 Offset: 0x6929C0 VA: 0x1806943C0
	public static float Sum(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693A60 Offset: 0x692060 VA: 0x180693A60
	public static float Average(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693F90 Offset: 0x692590 VA: 0x180693F90
	public static float Max(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x694030 Offset: 0x692630 VA: 0x180694030
	public static float Min(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693B00 Offset: 0x692100 VA: 0x180693B00
	public static IEnumerable<float> GetMods(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value) { }

	// RVA: 0x693E60 Offset: 0x692460 VA: 0x180693E60
	public static bool HasBrokenWeaponMod(BaseEntity parentEnt) { }

	// RVA: 0x694460 Offset: 0x692A60 VA: 0x180694460
	public void .ctor() { }

}

public struct ProjectileWeaponMod.Modifier // TypeDefIndex: 9627
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0x7C830 Offset: 0x7BC30 VA: 0x18007C830
	public float scalar; // 0x4
	[TooltipAttribute] // RVA: 0x7C960 Offset: 0x7BD60 VA: 0x18007C960
	public float offset; // 0x8

}

private sealed class ProjectileWeaponMod.<>c // TypeDefIndex: 9628
{	// Fields
	public static readonly ProjectileWeaponMod.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__27_0; // 0x8
	public static Func<ProjectileWeaponMod.Modifier, bool> <>9__27_1; // 0x10
	public static Func<ProjectileWeaponMod, bool> <>9__28_0; // 0x18

	// Methods

	// RVA: 0x6AD300 Offset: 0x6AB900 VA: 0x1806AD300
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6AD170 Offset: 0x6AB770 VA: 0x1806AD170
	internal bool <GetMods>b__27_0(ProjectileWeaponMod x) { }

	// RVA: 0x6AD200 Offset: 0x6AB800 VA: 0x1806AD200
	internal bool <GetMods>b__27_1(ProjectileWeaponMod.Modifier x) { }

	// RVA: 0x6AD210 Offset: 0x6AB810 VA: 0x1806AD210
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

	// RVA: 0x693010 Offset: 0x691610 VA: 0x180693010 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x693100 Offset: 0x691700 VA: 0x180693100 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

