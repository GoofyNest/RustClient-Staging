public class SimpleShark : BaseCombatEntity // TypeDefIndex: 8925
{	// Fields
	public Vector3 destination; // 0x240
	public float minSpeed; // 0x24C
	public float maxSpeed; // 0x250
	public float idealDepth; // 0x254
	public float minTurnSpeed; // 0x258
	public float maxTurnSpeed; // 0x25C
	public float attackCooldown; // 0x260
	public float aggroRange; // 0x264
	public float obstacleDetectionRadius; // 0x268
	public Animator animator; // 0x270
	public GameObjectRef bloodCloud; // 0x278
	public GameObjectRef corpsePrefab; // 0x280
	private static int param_speed; // 0x0
	private static int param_mouthOpen; // 0x4
	private float currentMouthOpen; // 0x288

	// Properties
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x59D750 Offset: 0x59BD50 VA: 0x18059D750
	public void Update() { }

	// RVA: 0x59D5A0 Offset: 0x59BBA0 VA: 0x18059D5A0
	public void UpdateAnimations() { }

	// RVA: 0x59D980 Offset: 0x59BF80 VA: 0x18059D980
	public void .ctor() { }

	// RVA: 0x59D910 Offset: 0x59BF10 VA: 0x18059D910
	private static void .cctor() { }

}

