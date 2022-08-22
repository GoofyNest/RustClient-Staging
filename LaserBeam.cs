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
	// RVA: 0x6882E0 Offset: 0x6868E0 VA: 0x1806882E0
	public static void PrintQueue(ConsoleSystem.Arg args) { }

	// RVA: 0x687F00 Offset: 0x686500 VA: 0x180687F00
	public void LaserUpdate() { }

	// RVA: 0x687E20 Offset: 0x686420 VA: 0x180687E20
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x687C70 Offset: 0x686270 VA: 0x180687C70
	public Vector3 GetDotFinalPosition(Ray castRay) { }

	// RVA: 0x6879F0 Offset: 0x685FF0 VA: 0x1806879F0
	public Vector3 DotCast(Ray castRay) { }

	// RVA: 0x688B50 Offset: 0x687150 VA: 0x180688B50
	private void UpdateDot() { }

	// RVA: 0x6881F0 Offset: 0x6867F0 VA: 0x1806881F0
	public void OnEnable() { }

	// RVA: 0x688170 Offset: 0x686770 VA: 0x180688170
	private void OnDisable() { }

	// RVA: 0x688770 Offset: 0x686D70 VA: 0x180688770
	private void UpdateBeam() { }

	// RVA: 0x689870 Offset: 0x687E70 VA: 0x180689870
	private void UpdateLaserPositions() { }

	// RVA: 0x688140 Offset: 0x686740 VA: 0x180688140
	public void LateUpdate() { }

	// RVA: 0x689930 Offset: 0x687F30 VA: 0x180689930
	public void .ctor() { }

	// RVA: 0x689890 Offset: 0x687E90 VA: 0x180689890
	private static void .cctor() { }

}

public class LaserBeam.LaserBeamWorkQueue : PersistentObjectWorkQueue<LaserBeam> // TypeDefIndex: 8892
{	// Methods

	// RVA: 0x6878B0 Offset: 0x685EB0 VA: 0x1806878B0 Slot: 5
	protected override void RunJob(LaserBeam entity) { }

	// RVA: 0x687910 Offset: 0x685F10 VA: 0x180687910 Slot: 4
	protected override bool ShouldAdd(LaserBeam entity) { }

	// RVA: 0x6879B0 Offset: 0x685FB0 VA: 0x1806879B0
	public void .ctor() { }

}

