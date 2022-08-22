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

	// RVA: 0x73C3D0 Offset: 0x73A9D0 VA: 0x18073C3D0
	public bool IsProjectile() { }

	// RVA: 0x73CC20 Offset: 0x73B220 VA: 0x18073CC20
	public BasePlayer get_InitiatorPlayer() { }

	// RVA: 0x73CCB0 Offset: 0x73B2B0 VA: 0x18073CCB0
	public Vector3 get_attackNormal() { }

	// RVA: 0x73D1B0 Offset: 0x73B7B0 VA: 0x18073D1B0
	public bool get_hasDamage() { }

	// RVA: 0x73CA40 Offset: 0x73B040 VA: 0x18073CA40
	public void .ctor() { }

	// RVA: 0x73CAC0 Offset: 0x73B0C0 VA: 0x18073CAC0
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount, Vector3 vhitPosition) { }

	// RVA: 0x73C890 Offset: 0x73AE90 VA: 0x18073C890
	public void .ctor(BaseEntity attacker, BaseEntity target, DamageType type, float damageAmount) { }

	// RVA: 0x73C3E0 Offset: 0x73A9E0 VA: 0x18073C3E0
	public void LoadFromAttack(Attack attack, bool serverSide) { }

	// RVA: 0x73D1E0 Offset: 0x73B7E0 VA: 0x18073D1E0
	public bool get_isHeadshot() { }

	// RVA: 0x73D050 Offset: 0x73B650 VA: 0x18073D050
	public Translate.Phrase get_bonePhrase() { }

	// RVA: 0x73CEC0 Offset: 0x73B4C0 VA: 0x18073CEC0
	public string get_boneName() { }

	// RVA: 0x73CDB0 Offset: 0x73B3B0 VA: 0x18073CDB0
	public HitArea get_boneArea() { }

	// RVA: 0x73C5E0 Offset: 0x73ABE0 VA: 0x18073C5E0
	public Vector3 PositionOnRay(Vector3 position) { }

	// RVA: 0x73C1A0 Offset: 0x73A7A0 VA: 0x18073C1A0
	public Vector3 HitPositionOnRay() { }

	// RVA: 0x73C1F0 Offset: 0x73A7F0 VA: 0x18073C1F0
	public bool IsNaNOrInfinity() { }

}

