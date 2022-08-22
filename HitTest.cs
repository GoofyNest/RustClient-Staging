public class HitTest // TypeDefIndex: 9898
{	// Fields
	public HitTest.Type type; // 0x10
	public Ray AttackRay; // 0x14
	public float Radius; // 0x2C
	public float Forgiveness; // 0x30
	public float MaxDistance; // 0x34
	public RaycastHit RayHit; // 0x38
	public bool MultiHit; // 0x64
	public bool BestHit; // 0x65
	public bool DidHit; // 0x66
	public DamageProperties damageProperties; // 0x68
	public GameObject gameObject; // 0x70
	public Collider collider; // 0x78
	public BaseEntity ignoreEntity; // 0x80
	public BaseEntity HitEntity; // 0x88
	public Vector3 HitPoint; // 0x90
	public Vector3 HitNormal; // 0x9C
	public float HitDistance; // 0xA8
	public Transform HitTransform; // 0xB0
	public uint HitPart; // 0xB8
	public string HitMaterial; // 0xC0

	// Methods

	// RVA: 0x73DE60 Offset: 0x73C460 VA: 0x18073DE60
	public Vector3 HitPointWorld() { }

	// RVA: 0x73DD40 Offset: 0x73C340 VA: 0x18073DD40
	public Vector3 HitNormalWorld() { }

	// RVA: 0x73D4B0 Offset: 0x73BAB0 VA: 0x18073D4B0
	public Attack BuildAttackMessage() { }

	// RVA: 0x73DC60 Offset: 0x73C260 VA: 0x18073DC60
	public void Clear() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum HitTest.Type // TypeDefIndex: 9899
{	// Fields
	public int value__; // 0x0
	public const HitTest.Type Generic = 0;
	public const HitTest.Type ProjectileEffect = 1;
	public const HitTest.Type Projectile = 2;
	public const HitTest.Type MeleeAttack = 3;
	public const HitTest.Type Use = 4;

}

