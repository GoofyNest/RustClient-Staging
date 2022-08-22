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

	// RVA: 0x51C150 Offset: 0x51A750 VA: 0x18051C150 Slot: 6
	public override void Initialize() { }

	// RVA: 0x51C1D0 Offset: 0x51A7D0 VA: 0x18051C1D0
	public bool MainCoreVulnerable() { }

	// RVA: 0x51BDB0 Offset: 0x51A3B0 VA: 0x18051BDB0
	public BossFormController.BossDamagePoint GetDamagePointFromCollider(Collider collider) { }

	// RVA: 0x51BE90 Offset: 0x51A490 VA: 0x18051BE90
	public void Hurt(float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x51C240 Offset: 0x51A840 VA: 0x18051C240
	public void RemoveMe() { }

	// RVA: 0x51BA00 Offset: 0x51A000 VA: 0x18051BA00
	public void Animate() { }

	// RVA: 0x51C3C0 Offset: 0x51A9C0 VA: 0x18051C3C0
	public void UpdateDamagePositions() { }

	// RVA: 0x51C2A0 Offset: 0x51A8A0 VA: 0x18051C2A0 Slot: 7
	public override void Shutdown() { }

	// RVA: 0x51BA90 Offset: 0x51A090 VA: 0x18051BA90
	public void FixedUpdate() { }

	// RVA: 0x51C530 Offset: 0x51AB30 VA: 0x18051C530
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

