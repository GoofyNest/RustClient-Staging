public class BossFormController : ArcadeEntityController // TypeDefIndex: 8763
{	// Fields
	public float animationSpeed; // 0x38
	public Sprite[] animationFrames; // 0x40
	public Vector2 roamDistance; // 0x48
	public Transform colliderParent; // 0x50
	public BossFormController.BossDamagePoint[] damagePoints; // 0x58
	public ArcadeEntityController flashController; // 0x60
	public float health; // 0x68
	private int currentFrame; // 0x6C
	private int animDirection; // 0x70

	// Methods

	// RVA: 0x51C1C0 Offset: 0x51A7C0 VA: 0x18051C1C0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x51C240 Offset: 0x51A840 VA: 0x18051C240
	public bool MainCoreVulnerable() { }

	// RVA: 0x51BE20 Offset: 0x51A420 VA: 0x18051BE20
	public BossFormController.BossDamagePoint GetDamagePointFromCollider(Collider collider) { }

	// RVA: 0x51BF00 Offset: 0x51A500 VA: 0x18051BF00
	public void Hurt(float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x51C2B0 Offset: 0x51A8B0 VA: 0x18051C2B0
	public void RemoveMe() { }

	// RVA: 0x51BA70 Offset: 0x51A070 VA: 0x18051BA70
	public void Animate() { }

	// RVA: 0x51C430 Offset: 0x51AA30 VA: 0x18051C430
	public void UpdateDamagePositions() { }

	// RVA: 0x51C310 Offset: 0x51A910 VA: 0x18051C310 Slot: 7
	public override void Shutdown() { }

	// RVA: 0x51BB00 Offset: 0x51A100 VA: 0x18051BB00
	public void FixedUpdate() { }

	// RVA: 0x51C5A0 Offset: 0x51ABA0 VA: 0x18051C5A0
	public void .ctor() { }

}

public class BossFormController.BossDamagePoint // TypeDefIndex: 8764
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

