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

	// RVA: 0x539FB0 Offset: 0x5385B0 VA: 0x180539FB0
	public void SetLevel(int newLevel) { }

	// RVA: 0x539DC0 Offset: 0x5383C0 VA: 0x180539DC0 Slot: 6
	public override bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x539C50 Offset: 0x538250 VA: 0x180539C50
	public void Flash() { }

	// RVA: 0x539D40 Offset: 0x538340 VA: 0x180539D40 Slot: 11
	public override void Initialize() { }

	// RVA: 0x539F50 Offset: 0x538550 VA: 0x180539F50
	public void RemoveMe() { }

	// RVA: 0x5397B0 Offset: 0x537DB0 VA: 0x1805397B0
	public void Animate() { }

	// RVA: 0x539CA0 Offset: 0x5382A0 VA: 0x180539CA0 Slot: 7
	public override void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x539E80 Offset: 0x538480 VA: 0x180539E80 Slot: 8
	public override void OnKilled() { }

	// RVA: 0x539880 Offset: 0x537E80 VA: 0x180539880
	public void FixedUpdate() { }

	// RVA: 0x53A0B0 Offset: 0x5386B0 VA: 0x18053A0B0
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

