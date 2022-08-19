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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x59D7C0 Offset: 0x59BDC0 VA: 0x18059D7C0
	public void Update() { }

	// RVA: 0x59D610 Offset: 0x59BC10 VA: 0x18059D610
	public void UpdateAnimations() { }

	// RVA: 0x59D9F0 Offset: 0x59BFF0 VA: 0x18059D9F0
	public void .ctor() { }

	// RVA: 0x59D980 Offset: 0x59BF80 VA: 0x18059D980
	private static void .cctor() { }

}

