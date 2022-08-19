public class HitInfo // TypeDefIndex: 9900
{	// Fields
	public BaseEntity Initiator; // 0x10
	public BaseEntity WeaponPrefab; // 0x18
	public AttackEntity Weapon; // 0x20
	public bool DoHitEffects; // 0x28
	public bool DoDecals; // 0x29
	public bool IsPredicting; // 0x2A
	public bool UseProtection; // 0x2B
	public Connection Predicted; // 0x30
	public bool DidHit; // 0x38
	public BaseEntity HitEntity; // 0x40
	public uint HitBone; // 0x48
	public uint HitPart; // 0x4C
	public uint HitMaterial; // 0x50
	public Vector3 HitPositionWorld; // 0x54
	public Vector3 HitPositionLocal; // 0x60
	public Vector3 HitNormalWorld; // 0x6C
	public Vector3 HitNormalLocal; // 0x78
	public Vector3 PointStart; // 0x84
	public Vector3 PointEnd; // 0x90
	public int ProjectileID; // 0x9C
	public int ProjectileHits; // 0xA0
	public float ProjectileDistance; // 0xA4
	public float ProjectileIntegrity; // 0xA8
	public float ProjectileTravelTime; // 0xAC
	public float ProjectileTrajectoryMismatch; // 0xB0
	public Vector3 ProjectileVelocity; // 0xB4
	public Projectile ProjectilePrefab; // 0xC0
	public PhysicMaterial material; // 0xC8
	public DamageProperties damageProperties; // 0xD0
	public DamageTypeList damageTypes; // 0xD8
	public bool CanGather; // 0xE0
	public bool DidGather; // 0xE1
	public float gatherScale; // 0xE4

	// Properties
	public BasePlayer InitiatorPlayer { get; }
	public Vector3 attackNormal { get; }
	public bool hasDamage { get; }
	public bool isHeadshot { get; }
	public Translate.Phrase bonePhrase { get; }
	public string boneName { get; }
	public HitArea boneArea { get; }

	// Methods

	// RVA: 0x73C370 Offset: 0x73A970 VA: 0x18073C370
	public bool IsProjectile() { }

	// RVA: 0x73CBC0 Offset: 0x73B1C0 VA: 0x18073CBC0
	public BasePlayer get_InitiatorPlayer() { }

	// RVA: 0x73CC50 Offset: 0x73B250 VA: 0x18073CC50
	public Vector3 get_attackNormal() { }

	// RVA: 0x73D150 Offset: 0x73B750 VA: 0x18073D150
	public bool get_hasDamage() { }

	// RVA: 0x73C9E0 Offset: 0x73AFE0 VA: 0x18073C9E0
	public void .ctor() { }

	// RVA: 0x73CA60 Offset: 0x73B060 VA: 0x18073CA60
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount, Vector3 vhitPosition) { }

	// RVA: 0x73C830 Offset: 0x73AE30 VA: 0x18073C830
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount) { }

	// RVA: 0x73C380 Offset: 0x73A980 VA: 0x18073C380
	public void LoadFromAttack(Attack attack, bool serverSide) { }

	// RVA: 0x73D180 Offset: 0x73B780 VA: 0x18073D180
	public bool get_isHeadshot() { }

	// RVA: 0x73CFF0 Offset: 0x73B5F0 VA: 0x18073CFF0
	public Translate.Phrase get_bonePhrase() { }

	// RVA: 0x73CE60 Offset: 0x73B460 VA: 0x18073CE60
	public string get_boneName() { }

	// RVA: 0x73CD50 Offset: 0x73B350 VA: 0x18073CD50
	public HitArea get_boneArea() { }

	// RVA: 0x73C580 Offset: 0x73AB80 VA: 0x18073C580
	public Vector3 PositionOnRay(Vector3 position) { }

	// RVA: 0x73C140 Offset: 0x73A740 VA: 0x18073C140
	public Vector3 HitPositionOnRay() { }

	// RVA: 0x73C190 Offset: 0x73A790 VA: 0x18073C190
	public bool IsNaNOrInfinity() { }

}

