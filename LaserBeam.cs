public class LaserBeam : MonoBehaviour // TypeDefIndex: 8891
{	// Fields
	public float scrollSpeed; // 0x18
	public LineRenderer beamRenderer; // 0x20
	public GameObject dotObject; // 0x28
	public Renderer dotRenderer; // 0x30
	public GameObject dotSpotlight; // 0x38
	public Vector2 scrollDir; // 0x40
	public float maxDistance; // 0x48
	public float stillBlendFactor; // 0x4C
	public float movementBlendFactor; // 0x50
	public float movementThreshhold; // 0x54
	public bool isFirstPerson; // 0x58
	public Transform emissionOverride; // 0x60
	private MaterialPropertyBlock block; // 0x68
	public static LaserBeam.LaserBeamWorkQueue workQueue; // 0x0
	[ClientVar] // RVA: 0xC1CF0 Offset: 0xC10F0 VA: 0x1800C1CF0
	[HelpAttribute] // RVA: 0xC1CF0 Offset: 0xC10F0 VA: 0x1800C1CF0
	public static float framebudgetms; // 0x8
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debugCollisions; // 0xC
	private TimeSince lastUpdate; // 0x70
	private float cachedDotDistance; // 0x74
	private float aimToBarrelBlendFrac; // 0x78
	private Vector4 laserST; // 0x7C

	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x688350 Offset: 0x686950 VA: 0x180688350
	public static void PrintQueue(ConsoleSystem.Arg args) { }

	// RVA: 0x687F70 Offset: 0x686570 VA: 0x180687F70
	public void LaserUpdate() { }

	// RVA: 0x687E90 Offset: 0x686490 VA: 0x180687E90
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x687CE0 Offset: 0x6862E0 VA: 0x180687CE0
	public Vector3 GetDotFinalPosition(Ray castRay) { }

	// RVA: 0x687A60 Offset: 0x686060 VA: 0x180687A60
	public Vector3 DotCast(Ray castRay) { }

	// RVA: 0x688BC0 Offset: 0x6871C0 VA: 0x180688BC0
	private void UpdateDot() { }

	// RVA: 0x688260 Offset: 0x686860 VA: 0x180688260
	public void OnEnable() { }

	// RVA: 0x6881E0 Offset: 0x6867E0 VA: 0x1806881E0
	private void OnDisable() { }

	// RVA: 0x6887E0 Offset: 0x686DE0 VA: 0x1806887E0
	private void UpdateBeam() { }

	// RVA: 0x6898E0 Offset: 0x687EE0 VA: 0x1806898E0
	private void UpdateLaserPositions() { }

	// RVA: 0x6881B0 Offset: 0x6867B0 VA: 0x1806881B0
	public void LateUpdate() { }

	// RVA: 0x6899A0 Offset: 0x687FA0 VA: 0x1806899A0
	public void .ctor() { }

	// RVA: 0x689900 Offset: 0x687F00 VA: 0x180689900
	private static void .cctor() { }

}

public class LaserBeam.LaserBeamWorkQueue : PersistentObjectWorkQueue<LaserBeam> // TypeDefIndex: 8892
{	// Methods

	// RVA: 0x687920 Offset: 0x685F20 VA: 0x180687920 Slot: 5
	protected override void RunJob(LaserBeam entity) { }

	// RVA: 0x687980 Offset: 0x685F80 VA: 0x180687980 Slot: 4
	protected override bool ShouldAdd(LaserBeam entity) { }

	// RVA: 0x687A20 Offset: 0x686020 VA: 0x180687A20
	public void .ctor() { }

}

