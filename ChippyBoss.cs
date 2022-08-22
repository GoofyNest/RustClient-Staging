public class ChippyBoss : SpriteArcadeEntity // TypeDefIndex: 8766
{	// Fields
	public Vector2 roamDistance; // 0x98
	public float animationSpeed; // 0xA0
	public Sprite[] animationFrames; // 0xA8
	public ArcadeEntity bulletTest; // 0xB0
	public SpriteRenderer flashRenderer; // 0xB8
	public ChippyBoss.BossDamagePoint[] damagePoints; // 0xC0
	private float moveSpeed; // 0xC8
	private int bossLevel; // 0xCC
	private float fireRate; // 0xD0
	private int currentFrame; // 0xD4
	private int animDirection; // 0xD8
	private float nextBulletTime; // 0xDC

	// Methods

	// RVA: 0x539F40 Offset: 0x538540 VA: 0x180539F40
	public void SetLevel(int newLevel) { }

	// RVA: 0x539D50 Offset: 0x538350 VA: 0x180539D50 Slot: 6
	public override bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x539BE0 Offset: 0x5381E0 VA: 0x180539BE0
	public void Flash() { }

	// RVA: 0x539CD0 Offset: 0x5382D0 VA: 0x180539CD0 Slot: 11
	public override void Initialize() { }

	// RVA: 0x539EE0 Offset: 0x5384E0 VA: 0x180539EE0
	public void RemoveMe() { }

	// RVA: 0x539740 Offset: 0x537D40 VA: 0x180539740
	public void Animate() { }

	// RVA: 0x539C30 Offset: 0x538230 VA: 0x180539C30 Slot: 7
	public override void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x539E10 Offset: 0x538410 VA: 0x180539E10 Slot: 8
	public override void OnKilled() { }

	// RVA: 0x539810 Offset: 0x537E10 VA: 0x180539810
	public void FixedUpdate() { }

	// RVA: 0x53A040 Offset: 0x538640 VA: 0x18053A040
	public void .ctor() { }

}

public class ChippyBoss.BossDamagePoint // TypeDefIndex: 8767
{	// Fields
	public BoxCollider hitBox; // 0x10
	public float health; // 0x18
	public ArcadeEntityController damagePrefab; // 0x20
	public ArcadeEntityController damageInstance; // 0x28
	public bool destroyed; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

