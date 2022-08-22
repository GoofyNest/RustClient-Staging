public class BaseProjectile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6318
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Magazine primaryMagazine; // 0x18

	// Methods

	// RVA: 0x1F65D90 Offset: 0x1F64390 VA: 0x181F65D90
	public static void ResetToPool(BaseProjectile instance) { }

	// RVA: 0x1F65CF0 Offset: 0x1F642F0 VA: 0x181F65CF0
	public void ResetToPool() { }

	// RVA: 0x1F65B90 Offset: 0x1F64190 VA: 0x181F65B90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F650F0 Offset: 0x1F636F0 VA: 0x181F650F0
	public void CopyTo(BaseProjectile instance) { }

	// RVA: 0x1F65160 Offset: 0x1F63760 VA: 0x181F65160
	public BaseProjectile Copy() { }

	// RVA: 0x1F658F0 Offset: 0x1F63EF0 VA: 0x181F658F0
	public static BaseProjectile Deserialize(Stream stream) { }

	// RVA: 0x1F65470 Offset: 0x1F63A70 VA: 0x181F65470
	public static BaseProjectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F654F0 Offset: 0x1F63AF0 VA: 0x181F654F0
	public static BaseProjectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F65A70 Offset: 0x1F64070 VA: 0x181F65A70
	public static BaseProjectile Deserialize(byte[] buffer) { }

	// RVA: 0x1F65CB0 Offset: 0x1F642B0 VA: 0x181F65CB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F66320 Offset: 0x1F64920 VA: 0x181F66320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F66340 Offset: 0x1F64940 VA: 0x181F66340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseProjectile previous) { }

	// RVA: 0x1F65CD0 Offset: 0x1F642D0 VA: 0x181F65CD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F65970 Offset: 0x1F63F70 VA: 0x181F65970
	public static BaseProjectile Deserialize(byte[] buffer, BaseProjectile instance, bool isDelta = False) { }

	// RVA: 0x1F65790 Offset: 0x1F63D90 VA: 0x181F65790
	public static BaseProjectile Deserialize(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F65230 Offset: 0x1F63830 VA: 0x181F65230
	public static BaseProjectile DeserializeLengthDelimited(Stream stream, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F65580 Offset: 0x1F63B80 VA: 0x181F65580
	public static BaseProjectile DeserializeLength(Stream stream, int length, BaseProjectile instance, bool isDelta) { }

	// RVA: 0x1F65E30 Offset: 0x1F64430 VA: 0x181F65E30
	public static void SerializeDelta(Stream stream, BaseProjectile instance, BaseProjectile previous) { }

	// RVA: 0x1F66190 Offset: 0x1F64790 VA: 0x181F66190
	public static void Serialize(Stream stream, BaseProjectile instance) { }

	// RVA: 0x1F66310 Offset: 0x1F64910 VA: 0x181F66310
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F66320 Offset: 0x1F64920 VA: 0x181F66320
	public void ToProto(Stream stream) { }

	// RVA: 0x1F66080 Offset: 0x1F64680 VA: 0x181F66080
	public static byte[] SerializeToBytes(BaseProjectile instance) { }

	// RVA: 0x1F65FD0 Offset: 0x1F645D0 VA: 0x181F65FD0
	public static void SerializeLengthDelimited(Stream stream, BaseProjectile instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1FF69A0 Offset: 0x1FF4FA0 VA: 0x181FF69A0
	public static void ResetToPool(Attack instance) { }

	// RVA: 0x1FF6870 Offset: 0x1FF4E70 VA: 0x181FF6870
	public void ResetToPool() { }

	// RVA: 0x1FF6300 Offset: 0x1FF4900 VA: 0x181FF6300 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF4700 Offset: 0x1FF2D00 VA: 0x181FF4700
	public void CopyTo(Attack instance) { }

	// RVA: 0x1FF47A0 Offset: 0x1FF2DA0 VA: 0x181FF47A0
	public Attack Copy() { }

	// RVA: 0x1FF5AB0 Offset: 0x1FF40B0 VA: 0x181FF5AB0
	public static Attack Deserialize(Stream stream) { }

	// RVA: 0x1FF4D00 Offset: 0x1FF3300 VA: 0x181FF4D00
	public static Attack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF4D80 Offset: 0x1FF3380 VA: 0x181FF4D80
	public static Attack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF5260 Offset: 0x1FF3860 VA: 0x181FF5260
	public static Attack Deserialize(byte[] buffer) { }

	// RVA: 0x1FF64B0 Offset: 0x1FF4AB0 VA: 0x181FF64B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF7D90 Offset: 0x1FF6390 VA: 0x181FF7D90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF7DB0 Offset: 0x1FF63B0 VA: 0x181FF7DB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Attack previous) { }

	// RVA: 0x1FF6850 Offset: 0x1FF4E50 VA: 0x181FF6850 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF5E80 Offset: 0x1FF4480 VA: 0x181FF5E80
	public static Attack Deserialize(byte[] buffer, Attack instance, bool isDelta = False) { }

	// RVA: 0x1FF5710 Offset: 0x1FF3D10 VA: 0x181FF5710
	public static Attack Deserialize(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FF4890 Offset: 0x1FF2E90 VA: 0x181FF4890
	public static Attack DeserializeLengthDelimited(Stream stream, Attack instance, bool isDelta) { }

	// RVA: 0x1FF4E10 Offset: 0x1FF3410 VA: 0x181FF4E10
	public static Attack DeserializeLength(Stream stream, int length, Attack instance, bool isDelta) { }

	// RVA: 0x1FF6AD0 Offset: 0x1FF50D0 VA: 0x181FF6AD0
	public static void SerializeDelta(Stream stream, Attack instance, Attack previous) { }

	// RVA: 0x1FF7790 Offset: 0x1FF5D90 VA: 0x181FF7790
	public static void Serialize(Stream stream, Attack instance) { }

	// RVA: 0x1FF7D80 Offset: 0x1FF6380 VA: 0x181FF7D80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF7D90 Offset: 0x1FF6390 VA: 0x181FF7D90
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF7680 Offset: 0x1FF5C80 VA: 0x181FF7680
	public static byte[] SerializeToBytes(Attack instance) { }

	// RVA: 0x1FF75D0 Offset: 0x1FF5BD0 VA: 0x181FF75D0
	public static void SerializeLengthDelimited(Stream stream, Attack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ProjectileShoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6488
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int ammoType; // 0x14
	public List<ProjectileShoot.Projectile> projectiles; // 0x18

	// Methods

	// RVA: 0x204A3C0 Offset: 0x20489C0 VA: 0x18204A3C0
	public static void ResetToPool(ProjectileShoot instance) { }

	// RVA: 0x204A580 Offset: 0x2048B80 VA: 0x18204A580
	public void ResetToPool() { }

	// RVA: 0x204A300 Offset: 0x2048900 VA: 0x18204A300 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2049380 Offset: 0x2047980 VA: 0x182049380
	public void CopyTo(ProjectileShoot instance) { }

	// RVA: 0x2049530 Offset: 0x2047B30 VA: 0x182049530
	public ProjectileShoot Copy() { }

	// RVA: 0x2049E30 Offset: 0x2048430 VA: 0x182049E30
	public static ProjectileShoot Deserialize(Stream stream) { }

	// RVA: 0x2049730 Offset: 0x2047D30 VA: 0x182049730
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2049DA0 Offset: 0x20483A0 VA: 0x182049DA0
	public static ProjectileShoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204A1E0 Offset: 0x20487E0 VA: 0x18204A1E0
	public static ProjectileShoot Deserialize(byte[] buffer) { }

	// RVA: 0x204A380 Offset: 0x2048980 VA: 0x18204A380
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204AD70 Offset: 0x2049370 VA: 0x18204AD70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204AD90 Offset: 0x2049390 VA: 0x18204AD90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot previous) { }

	// RVA: 0x204A3A0 Offset: 0x20489A0 VA: 0x18204A3A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2049EB0 Offset: 0x20484B0 VA: 0x182049EB0
	public static ProjectileShoot Deserialize(byte[] buffer, ProjectileShoot instance, bool isDelta = False) { }

	// RVA: 0x2049FB0 Offset: 0x20485B0 VA: 0x182049FB0
	public static ProjectileShoot Deserialize(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x20497B0 Offset: 0x2047DB0 VA: 0x1820497B0
	public static ProjectileShoot DeserializeLengthDelimited(Stream stream, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x2049AC0 Offset: 0x20480C0 VA: 0x182049AC0
	public static ProjectileShoot DeserializeLength(Stream stream, int length, ProjectileShoot instance, bool isDelta) { }

	// RVA: 0x204A740 Offset: 0x2048D40 VA: 0x18204A740
	public static void SerializeDelta(Stream stream, ProjectileShoot instance, ProjectileShoot previous) { }

	// RVA: 0x204AB40 Offset: 0x2049140 VA: 0x18204AB40
	public static void Serialize(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x204AD60 Offset: 0x2049360 VA: 0x18204AD60
	public byte[] ToProtoBytes() { }

	// RVA: 0x204AD70 Offset: 0x2049370 VA: 0x18204AD70
	public void ToProto(Stream stream) { }

	// RVA: 0x204AA30 Offset: 0x2049030 VA: 0x18204AA30
	public static byte[] SerializeToBytes(ProjectileShoot instance) { }

	// RVA: 0x204A980 Offset: 0x2048F80 VA: 0x18204A980
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x204C180 Offset: 0x204A780 VA: 0x18204C180
	public static void ResetToPool(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204C230 Offset: 0x204A830 VA: 0x18204C230
	public void ResetToPool() { }

	// RVA: 0x204BEE0 Offset: 0x204A4E0 VA: 0x18204BEE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203DEC0 Offset: 0x203C4C0 VA: 0x18203DEC0
	public void CopyTo(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204ADB0 Offset: 0x20493B0 VA: 0x18204ADB0
	public ProjectileShoot.Projectile Copy() { }

	// RVA: 0x204B9D0 Offset: 0x2049FD0 VA: 0x18204B9D0
	public static ProjectileShoot.Projectile Deserialize(Stream stream) { }

	// RVA: 0x204AE50 Offset: 0x2049450 VA: 0x18204AE50
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204B1A0 Offset: 0x20497A0 VA: 0x18204B1A0
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204B6F0 Offset: 0x2049CF0 VA: 0x18204B6F0
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer) { }

	// RVA: 0x204BF60 Offset: 0x204A560 VA: 0x18204BF60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204CB90 Offset: 0x204B190 VA: 0x18204CB90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204CBB0 Offset: 0x204B1B0 VA: 0x18204CBB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ProjectileShoot.Projectile previous) { }

	// RVA: 0x204C160 Offset: 0x204A760 VA: 0x18204C160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204BC10 Offset: 0x204A210 VA: 0x18204BC10
	public static ProjectileShoot.Projectile Deserialize(byte[] buffer, ProjectileShoot.Projectile instance, bool isDelta = False) { }

	// RVA: 0x204B4E0 Offset: 0x2049AE0 VA: 0x18204B4E0
	public static ProjectileShoot.Projectile Deserialize(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204AED0 Offset: 0x20494D0 VA: 0x18204AED0
	public static ProjectileShoot.Projectile DeserializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204B230 Offset: 0x2049830 VA: 0x18204B230
	public static ProjectileShoot.Projectile DeserializeLength(Stream stream, int length, ProjectileShoot.Projectile instance, bool isDelta) { }

	// RVA: 0x204C2E0 Offset: 0x204A8E0 VA: 0x18204C2E0
	public static void SerializeDelta(Stream stream, ProjectileShoot.Projectile instance, ProjectileShoot.Projectile previous) { }

	// RVA: 0x204C8F0 Offset: 0x204AEF0 VA: 0x18204C8F0
	public static void Serialize(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x204CB80 Offset: 0x204B180 VA: 0x18204CB80
	public byte[] ToProtoBytes() { }

	// RVA: 0x204CB90 Offset: 0x204B190 VA: 0x18204CB90
	public void ToProto(Stream stream) { }

	// RVA: 0x204C7E0 Offset: 0x204ADE0 VA: 0x18204C7E0
	public static byte[] SerializeToBytes(ProjectileShoot.Projectile instance) { }

	// RVA: 0x204C730 Offset: 0x204AD30 VA: 0x18204C730
	public static void SerializeLengthDelimited(Stream stream, ProjectileShoot.Projectile instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x926BD0 Offset: 0x9251D0 VA: 0x180926BD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x928730 Offset: 0x926D30 VA: 0x180928730
	public RecoilProperties get_recoilProperties() { }

	// RVA: 0x9241D0 Offset: 0x9227D0 VA: 0x1809241D0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x9241B0 Offset: 0x9227B0 VA: 0x1809241B0 Slot: 160
	public virtual float GetDamageScale(bool getMax = False) { }

	// RVA: 0x9241C0 Offset: 0x9227C0 VA: 0x1809241C0 Slot: 161
	public virtual float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x9249B0 Offset: 0x922FB0 VA: 0x1809249B0 Slot: 162
	public virtual float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x9283B0 Offset: 0x9269B0 VA: 0x1809283B0
	protected void StartReloadCooldown(float cooldown) { }

	// RVA: 0x9277D0 Offset: 0x925DD0 VA: 0x1809277D0
	protected void ResetReloadCooldown() { }

	// RVA: 0x9250D0 Offset: 0x9236D0 VA: 0x1809250D0
	protected bool HasReloadCooldown() { }

	// RVA: 0x9249D0 Offset: 0x922FD0 VA: 0x1809249D0
	protected float GetReloadCooldown() { }

	// RVA: 0x924B30 Offset: 0x923130 VA: 0x180924B30
	protected float GetReloadIdle() { }

	// RVA: 0x926410 Offset: 0x924A10 VA: 0x180926410
	private void OnDrawGizmos() { }

	// RVA: 0x9249C0 Offset: 0x922FC0 VA: 0x1809249C0 Slot: 163
	public virtual RecoilProperties GetRecoil() { }

	// RVA: 0x928720 Offset: 0x926D20 VA: 0x180928720
	public bool get_isSemiAuto() { }

	// RVA: 0x9236C0 Offset: 0x921CC0 VA: 0x1809236C0 Slot: 164
	public virtual float GetAimCone() { }

	// RVA: 0x9277E0 Offset: 0x925DE0 VA: 0x1809277E0
	public float ScaleRepeatDelay(float delay) { }

	// RVA: 0x924370 Offset: 0x922970 VA: 0x180924370
	public Projectile.Modifier GetProjectileModifier() { }

	// RVA: 0x921BB0 Offset: 0x9201B0 VA: 0x180921BB0 Slot: 165
	public virtual void DidAttackClientside() { }

	// RVA: 0x924220 Offset: 0x922820 VA: 0x180924220 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x9218D0 Offset: 0x91FED0 VA: 0x1809218D0
	public bool ClientIsReloading() { }

	// RVA: 0x9263C0 Offset: 0x9249C0 VA: 0x1809263C0
	public void NotifySpectatorReloading(bool state) { }

	// RVA: 0x922CC0 Offset: 0x9212C0 VA: 0x180922CC0 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x9267E0 Offset: 0x924DE0 VA: 0x1809267E0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x927B10 Offset: 0x926110 VA: 0x180927B10 Slot: 166
	public virtual void ShotFired() { }

	// RVA: 0x927B70 Offset: 0x926170 VA: 0x180927B70 Slot: 167
	public virtual void SimulateAimcone() { }

	// RVA: 0x9216D0 Offset: 0x91FCD0 VA: 0x1809216D0 Slot: 168
	public virtual bool CanAttack() { }

	// RVA: 0x9216A0 Offset: 0x91FCA0 VA: 0x1809216A0 Slot: 169
	public virtual bool CanAim() { }

	// RVA: 0x9267F0 Offset: 0x924DF0 VA: 0x1809267F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x927720 Offset: 0x925D20 VA: 0x180927720
	public bool ReadyToAim() { }

	// RVA: 0x927770 Offset: 0x925D70 VA: 0x180927770
	public bool ReadyToFire() { }

	// RVA: 0x921580 Offset: 0x91FB80 VA: 0x180921580
	public void AmmoTypeClicked(ItemDefinition newAmmoType) { }

	// RVA: 0x9213D0 Offset: 0x91F9D0 VA: 0x1809213D0
	private void AddAmmoOption(ItemDefinition ammo, List<Option> opts, int order = 0) { }

	// RVA: 0x924BB0 Offset: 0x9231B0 VA: 0x180924BB0
	public List<Option> GetReloadMenu(BasePlayer player) { }

	// RVA: 0x927380 Offset: 0x925980 VA: 0x180927380
	private void PredictAmmoType() { }

	// RVA: 0x924E20 Offset: 0x923420 VA: 0x180924E20 Slot: 170
	public virtual bool HasMoreThanOneAmmoType(AmmoTypes ammoType) { }

	// RVA: 0x9263D0 Offset: 0x9249D0 VA: 0x1809263D0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x922740 Offset: 0x920D40 VA: 0x180922740
	private void DoReload() { }

	// RVA: 0x925100 Offset: 0x923700 VA: 0x180925100
	protected void InsertAmmoFraction() { }

	// RVA: 0x9216F0 Offset: 0x91FCF0 VA: 0x1809216F0
	public void CancelFractionalReloading() { }

	// RVA: 0x921790 Offset: 0x91FD90 VA: 0x180921790
	protected void ClientFinishFractionalReload() { }

	// RVA: 0x9218E0 Offset: 0x91FEE0 VA: 0x1809218E0
	protected void ClientSingleReload() { }

	// RVA: 0x921C80 Offset: 0x920280 VA: 0x180921C80 Slot: 171
	public virtual void DoAttack() { }

	// RVA: 0x921610 Offset: 0x91FC10 VA: 0x180921610
	public void BeginCycle() { }

	// RVA: 0x9261D0 Offset: 0x9247D0 VA: 0x1809261D0 Slot: 172
	public virtual void LaunchProjectile() { }

	// RVA: 0x922C00 Offset: 0x921200 VA: 0x180922C00
	public void DryFire() { }

	// RVA: 0x9276C0 Offset: 0x925CC0 VA: 0x1809276C0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x9275B0 Offset: 0x925BB0 VA: 0x1809275B0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x924A50 Offset: 0x923050 VA: 0x180924A50
	public float GetReloadDuration() { }

	// RVA: 0x923FA0 Offset: 0x9225A0 VA: 0x180923FA0
	public int GetAvailableAmmo() { }

	// RVA: 0x925160 Offset: 0x923760 VA: 0x180925160
	public bool IsSilenced() { }

	// RVA: 0x923630 Offset: 0x921C30 VA: 0x180923630
	public bool FiredUnderground() { }

	// RVA: 0x926CC0 Offset: 0x9252C0 VA: 0x180926CC0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x925340 Offset: 0x923940 VA: 0x180925340
	internal void LaunchProjectileClientside(ItemDefinition ammo, int projectileCount, float projSpreadaimCone) { }

	// RVA: 0x921A20 Offset: 0x920020 VA: 0x180921A20
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0x928400 Offset: 0x926A00 VA: 0x180928400 Slot: 173
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool get_UsingInfiniteAmmoCheat() { }

	// RVA: 0x926320 Offset: 0x924920 VA: 0x180926320 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9284B0 Offset: 0x926AB0 VA: 0x1809284B0
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

	// RVA: 0x93AE00 Offset: 0x939400 VA: 0x18093AE00
	public void ServerInit() { }

	// RVA: 0x93AD30 Offset: 0x939330 VA: 0x18093AD30
	public Magazine Save() { }

	// RVA: 0x93ACE0 Offset: 0x9392E0 VA: 0x18093ACE0
	public void Load(Magazine mag) { }

	// RVA: 0x93ACA0 Offset: 0x9392A0 VA: 0x18093ACA0
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

	// RVA: 0x93B940 Offset: 0x939F40 VA: 0x18093B940
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B630 Offset: 0x939C30 VA: 0x18093B630
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <GetAimCone>b__63_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B630 Offset: 0x939C30 VA: 0x18093B630
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <GetAimCone>b__63_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B660 Offset: 0x939C60 VA: 0x18093B660
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_4(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <GetAimCone>b__63_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B660 Offset: 0x939C60 VA: 0x18093B660
	internal ProjectileWeaponMod.Modifier <GetAimCone>b__63_6(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <GetAimCone>b__63_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B7C0 Offset: 0x939DC0 VA: 0x18093B7C0
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <ScaleRepeatDelay>b__64_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B7C0 Offset: 0x939DC0 VA: 0x18093B7C0
	internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__64_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <ScaleRepeatDelay>b__64_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B690 Offset: 0x939C90 VA: 0x18093B690
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <GetProjectileModifier>b__65_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B690 Offset: 0x939C90 VA: 0x18093B690
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <GetProjectileModifier>b__65_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B6C0 Offset: 0x939CC0 VA: 0x18093B6C0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_4(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <GetProjectileModifier>b__65_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B6C0 Offset: 0x939CC0 VA: 0x18093B6C0
	internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__65_6(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <GetProjectileModifier>b__65_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B5D0 Offset: 0x939BD0 VA: 0x18093B5D0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <EditViewAngles>b__72_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B5D0 Offset: 0x939BD0 VA: 0x18093B5D0
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <EditViewAngles>b__72_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B600 Offset: 0x939C00 VA: 0x18093B600
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_4(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <EditViewAngles>b__72_5(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B600 Offset: 0x939C00 VA: 0x18093B600
	internal ProjectileWeaponMod.Modifier <EditViewAngles>b__72_6(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <EditViewAngles>b__72_7(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B570 Offset: 0x939B70 VA: 0x18093B570
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <SimulateAimcone>b__76_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B570 Offset: 0x939B70 VA: 0x18093B570
	internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__76_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <SimulateAimcone>b__76_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B570 Offset: 0x939B70 VA: 0x18093B570
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <DoAttack>b__98_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B570 Offset: 0x939B70 VA: 0x18093B570
	internal ProjectileWeaponMod.Modifier <DoAttack>b__98_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <DoAttack>b__98_3(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B760 Offset: 0x939D60 VA: 0x18093B760
	internal bool <OnSignal>b__110_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B6F0 Offset: 0x939CF0 VA: 0x18093B6F0
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_0(ProjectileWeaponMod x) { }

	// RVA: 0x93B5A0 Offset: 0x939BA0 VA: 0x18093B5A0
	internal float <LaunchProjectileClientside>b__112_1(ProjectileWeaponMod.Modifier y) { }

	// RVA: 0x93B6F0 Offset: 0x939CF0 VA: 0x18093B6F0
	internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__112_2(ProjectileWeaponMod x) { }

	// RVA: 0x93B5B0 Offset: 0x939BB0 VA: 0x18093B5B0
	internal float <LaunchProjectileClientside>b__112_3(ProjectileWeaponMod.Modifier y) { }

}

private sealed class BaseProjectile.<>c__DisplayClass84_0 // TypeDefIndex: 8533
{	// Fields
	public BaseProjectile <>4__this; // 0x10
	public ItemDefinition ammoType; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B8A0 Offset: 0x939EA0 VA: 0x18093B8A0
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

	// RVA: 0x6947D0 Offset: 0x692DD0 VA: 0x1806947D0
	public void CalculateDamage(HitInfo info, Projectile.Modifier mod, float scale) { }

	// RVA: 0x699580 Offset: 0x697B80 VA: 0x180699580
	public bool get_isAuthoritative() { }

	// RVA: 0x699540 Offset: 0x697B40 VA: 0x180699540
	private bool get_isAlive() { }

	// RVA: 0x698330 Offset: 0x696930 VA: 0x180698330
	private void Retire() { }

	// RVA: 0x694D20 Offset: 0x693320 VA: 0x180694D20
	private void Cleanup() { }

	// RVA: 0x694560 Offset: 0x692B60 VA: 0x180694560
	public void AdjustVelocity(Vector3 delta) { }

	// RVA: 0x697570 Offset: 0x695B70 VA: 0x180697570
	public void InitializeVelocity(Vector3 overrideVel) { }

	// RVA: 0x6977E0 Offset: 0x695DE0 VA: 0x1806977E0
	protected void OnDisable() { }

	// RVA: 0x6991A0 Offset: 0x6977A0 VA: 0x1806991A0
	protected void Update() { }

	// RVA: 0x698900 Offset: 0x696F00 VA: 0x180698900
	private void SetEffectScale(float eScale) { }

	// RVA: 0x694F20 Offset: 0x693520 VA: 0x180694F20
	private void DoFlybySound() { }

	// RVA: 0x694C80 Offset: 0x693280 VA: 0x180694C80 Slot: 6
	protected virtual float CalculateEffectScale() { }

	// RVA: 0x698EC0 Offset: 0x6974C0 VA: 0x180698EC0
	private void UpdateVelocity(float deltaTime) { }

	// RVA: 0x696D80 Offset: 0x695380 VA: 0x180696D80
	private void DoVelocityUpdate(float deltaTime) { }

	// RVA: 0x695C40 Offset: 0x694240 VA: 0x180695C40
	private void DoMovement(float deltaTime) { }

	// RVA: 0x697160 Offset: 0x695760 VA: 0x180697160
	private bool DoWaterHit(ref HitTest test, Vector3 targetPosition) { }

	// RVA: 0x696960 Offset: 0x694F60 VA: 0x180696960
	private bool DoRicochet(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x695530 Offset: 0x693B30 VA: 0x180695530
	private bool DoHit(HitTest test, Vector3 point, Vector3 normal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void AdditiveImpactEffect(HitInfo info) { }

	// RVA: 0x697AB0 Offset: 0x6960B0 VA: 0x180697AB0
	private bool Reflect(ref uint seed, Vector3 point, Vector3 normal) { }

	// RVA: 0x697E00 Offset: 0x696400 VA: 0x180697E00
	private bool Refract(ref uint seed, Vector3 point, Vector3 normal, float resistance) { }

	// RVA: 0x6981D0 Offset: 0x6967D0 VA: 0x1806981D0
	private Vector3 Refract(Vector3 v, Vector3 n, float f) { }

	// RVA: 0x6979B0 Offset: 0x695FB0 VA: 0x1806979B0
	private Quaternion RandomRotation(ref uint seed, float range) { }

	// RVA: 0x697750 Offset: 0x695D50 VA: 0x180697750
	internal void Launch() { }

	// RVA: 0x697470 Offset: 0x695A70 VA: 0x180697470
	public static uint FleshMaterialID() { }

	// RVA: 0x6992A0 Offset: 0x6978A0 VA: 0x1806992A0
	public static uint WaterMaterialID() { }

	// RVA: 0x697620 Offset: 0x695C20 VA: 0x180697620
	public static bool IsWaterMaterial(string hitMaterial) { }

	// RVA: 0x698E00 Offset: 0x697400 VA: 0x180698E00
	public static bool ShouldStopProjectile(RaycastHit hit) { }

	// RVA: 0x6993A0 Offset: 0x6979A0 VA: 0x1806993A0
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

	// RVA: 0x691550 Offset: 0x68FB50 VA: 0x180691550
	private static void .cctor() { }

}

public class ProjectileTestSpawner : MonoBehaviour // TypeDefIndex: 9323
{	// Fields
	public Projectile TargetProjectile; // 0x18
	public float RepeatTime; // 0x20
	public float VelocityScale; // 0x24

	// Methods

	// RVA: 0x693090 Offset: 0x691690 VA: 0x180693090
	public void .ctor() { }

}

public class AttackTickAIEvent : BaseAIEvent // TypeDefIndex: 9391
{	// Methods

	// RVA: 0x835C70 Offset: 0x834270 VA: 0x180835C70
	public void .ctor() { }

}

public class AttackedAIEvent : BaseAIEvent // TypeDefIndex: 9392
{	// Fields
	protected float lastExecuteTime; // 0x40
	private BaseCombatEntity combatEntity; // 0x48

	// Methods

	// RVA: 0x835CA0 Offset: 0x8342A0 VA: 0x180835CA0
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

	// RVA: 0x835730 Offset: 0x833D30 VA: 0x180835730 Slot: 157
	public virtual Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x835C60 Offset: 0x834260 VA: 0x180835C60
	public float get_NextAttackTime() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	public virtual void GetAttackStats(HitInfo info) { }

	// RVA: 0x8359A0 Offset: 0x833FA0 VA: 0x1808359A0
	protected void StartAttackCooldownRaw(float cooldown) { }

	// RVA: 0x8359D0 Offset: 0x833FD0 VA: 0x1808359D0
	protected void StartAttackCooldown(float cooldown) { }

	// RVA: 0x835940 Offset: 0x833F40 VA: 0x180835940
	protected void ResetAttackCooldown() { }

	// RVA: 0x8357A0 Offset: 0x833DA0 VA: 0x1808357A0
	public bool HasAttackCooldown() { }

	// RVA: 0x835630 Offset: 0x833C30 VA: 0x180835630
	protected float GetAttackCooldown() { }

	// RVA: 0x8356B0 Offset: 0x833CB0 VA: 0x1808356B0
	protected float GetAttackIdle() { }

	// RVA: 0x834A60 Offset: 0x833060 VA: 0x180834A60
	protected float CalculateCooldownTime(float nextTime, float cooldown, bool catchup) { }

	// RVA: 0x8357D0 Offset: 0x833DD0 VA: 0x1808357D0 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x835870 Offset: 0x833E70 VA: 0x180835870
	protected void ProcessInputTime() { }

	// RVA: 0x835810 Offset: 0x833E10 VA: 0x180835810 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8357F0 Offset: 0x833DF0 VA: 0x1808357F0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x835950 Offset: 0x833F50 VA: 0x180835950
	public void SpectatorNotifyDeploy() { }

	// RVA: 0x835960 Offset: 0x833F60 VA: 0x180835960
	public void SpectatorNotifyTick() { }

	// RVA: 0x8358C0 Offset: 0x833EC0 VA: 0x1808358C0
	public bool RecoilCompReady() { }

	// RVA: 0x8348B0 Offset: 0x832EB0 VA: 0x1808348B0 Slot: 131
	public override void AddPunch(Vector3 amount, float duration) { }

	// RVA: 0x834BA0 Offset: 0x8331A0 VA: 0x180834BA0 Slot: 132
	public override void DoRecoilCompensation() { }

	// RVA: 0x835B70 Offset: 0x834170 VA: 0x180835B70
	public void .ctor() { }

	// RVA: 0x835B00 Offset: 0x834100 VA: 0x180835B00
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

	// RVA: 0x694350 Offset: 0x692950 VA: 0x180694350 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x694420 Offset: 0x692A20 VA: 0x180694420 Slot: 131
	public virtual void SetAiming(bool isAiming) { }

	// RVA: 0x693DC0 Offset: 0x6923C0 VA: 0x180693DC0
	public float GetZoomAmount() { }

	// RVA: 0x694170 Offset: 0x692770 VA: 0x180694170
	public static float Mult(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x694460 Offset: 0x692A60 VA: 0x180694460
	public static float Sum(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693B00 Offset: 0x692100 VA: 0x180693B00
	public static float Average(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x694030 Offset: 0x692630 VA: 0x180694030
	public static float Max(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x6940D0 Offset: 0x6926D0 VA: 0x1806940D0
	public static float Min(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value, float def) { }

	// RVA: 0x693BA0 Offset: 0x6921A0 VA: 0x180693BA0
	public static IEnumerable<float> GetMods(BaseEntity parentEnt, Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> selector_modifier, Func<ProjectileWeaponMod.Modifier, float> selector_value) { }

	// RVA: 0x693F00 Offset: 0x692500 VA: 0x180693F00
	public static bool HasBrokenWeaponMod(BaseEntity parentEnt) { }

	// RVA: 0x694500 Offset: 0x692B00 VA: 0x180694500
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

	// RVA: 0x6AD3A0 Offset: 0x6AB9A0 VA: 0x1806AD3A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6AD210 Offset: 0x6AB810 VA: 0x1806AD210
	internal bool <GetMods>b__27_0(ProjectileWeaponMod x) { }

	// RVA: 0x6AD2A0 Offset: 0x6AB8A0 VA: 0x1806AD2A0
	internal bool <GetMods>b__27_1(ProjectileWeaponMod.Modifier x) { }

	// RVA: 0x6AD2B0 Offset: 0x6AB8B0 VA: 0x1806AD2B0
	internal bool <HasBrokenWeaponMod>b__28_0(ProjectileWeaponMod x) { }

}

public class AttackTickEventUI : BaseEventUI // TypeDefIndex: 10787
{	// Methods

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

public class AttackedEventUI : BaseEventUI // TypeDefIndex: 10788
{	// Methods

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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

	// RVA: 0x6930B0 Offset: 0x6916B0 VA: 0x1806930B0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x6931A0 Offset: 0x6917A0 VA: 0x1806931A0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

