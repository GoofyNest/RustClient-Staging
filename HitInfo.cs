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

	// RVA: 0x73C480 Offset: 0x73AA80 VA: 0x18073C480
	public bool IsProjectile() { }

	// RVA: 0x73CCD0 Offset: 0x73B2D0 VA: 0x18073CCD0
	public BasePlayer get_InitiatorPlayer() { }

	// RVA: 0x73CD60 Offset: 0x73B360 VA: 0x18073CD60
	public Vector3 get_attackNormal() { }

	// RVA: 0x73D260 Offset: 0x73B860 VA: 0x18073D260
	public bool get_hasDamage() { }

	// RVA: 0x73CAF0 Offset: 0x73B0F0 VA: 0x18073CAF0
	public void .ctor() { }

	// RVA: 0x73CB70 Offset: 0x73B170 VA: 0x18073CB70
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount, Vector3 vhitPosition) { }

	// RVA: 0x73C940 Offset: 0x73AF40 VA: 0x18073C940
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount) { }

	// RVA: 0x73C490 Offset: 0x73AA90 VA: 0x18073C490
	public void LoadFromAttack(Attack attack, bool serverSide) { }

	// RVA: 0x73D290 Offset: 0x73B890 VA: 0x18073D290
	public bool get_isHeadshot() { }

	// RVA: 0x73D100 Offset: 0x73B700 VA: 0x18073D100
	public Translate.Phrase get_bonePhrase() { }

	// RVA: 0x73CF70 Offset: 0x73B570 VA: 0x18073CF70
	public string get_boneName() { }

	// RVA: 0x73CE60 Offset: 0x73B460 VA: 0x18073CE60
	public HitArea get_boneArea() { }

	// RVA: 0x73C690 Offset: 0x73AC90 VA: 0x18073C690
	public Vector3 PositionOnRay(Vector3 position) { }

	// RVA: 0x73C250 Offset: 0x73A850 VA: 0x18073C250
	public Vector3 HitPositionOnRay() { }

	// RVA: 0x73C2A0 Offset: 0x73A8A0 VA: 0x18073C2A0
	public bool IsNaNOrInfinity() { }

}

