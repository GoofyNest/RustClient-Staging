public class MainCamera : RustCamera<MainCamera> // TypeDefIndex: 9201
{	// Fields
	public static Camera mainCamera; // 0x0
	public static Transform mainCameraTransform; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Vector3 <velocity>k__BackingField; // 0x10
	private static long[] MipStreamingBudget; // 0x20
	private double totalFrameTime; // 0x148
	private double lowestFrameTime; // 0x150
	private double highestFrameTime; // 0x158
	private int totalFrames; // 0x160
	private RealTimeSince timeSinceFrameSubmit; // 0x164
	private Stopwatch frameTime; // 0x168
	protected const float defaultSqrDistance = 1,677722E+07;

	// Properties
	public static bool isValid { get; }
	public static Vector3 velocity { get; set; }
	public static Vector3 position { get; set; }
	public static Vector3 forward { get; set; }
	public static Vector3 right { get; set; }
	public static Vector3 up { get; set; }
	public static Quaternion rotation { get; set; }
	public static Ray Ray { get; }
	public static RaycastHit Raycast { get; }

	// Methods

	// RVA: 0x55E5A0 Offset: 0x55CBA0 VA: 0x18055E5A0
	public static bool get_isValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x55E8B0 Offset: 0x55CEB0 VA: 0x18055E8B0
	public static Vector3 get_velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x55EC20 Offset: 0x55D220 VA: 0x18055EC20
	private static void set_velocity(Vector3 value) { }

	// RVA: 0x55E680 Offset: 0x55CC80 VA: 0x18055E680
	public static Vector3 get_position() { }

	// RVA: 0x55E9C0 Offset: 0x55CFC0 VA: 0x18055E9C0
	public static void set_position(Vector3 value) { }

	// RVA: 0x55E510 Offset: 0x55CB10 VA: 0x18055E510
	public static Vector3 get_forward() { }

	// RVA: 0x55E920 Offset: 0x55CF20 VA: 0x18055E920
	public static void set_forward(Vector3 value) { }

	// RVA: 0x55E710 Offset: 0x55CD10 VA: 0x18055E710
	public static Vector3 get_right() { }

	// RVA: 0x55EA50 Offset: 0x55D050 VA: 0x18055EA50
	public static void set_right(Vector3 value) { }

	// RVA: 0x55E820 Offset: 0x55CE20 VA: 0x18055E820
	public static Vector3 get_up() { }

	// RVA: 0x55EB70 Offset: 0x55D170 VA: 0x18055EB70
	public static void set_up(Vector3 value) { }

	// RVA: 0x55E7A0 Offset: 0x55CDA0 VA: 0x18055E7A0
	public static Quaternion get_rotation() { }

	// RVA: 0x55EAF0 Offset: 0x55D0F0 VA: 0x18055EAF0
	public static void set_rotation(Quaternion value) { }

	// RVA: 0x55E150 Offset: 0x55C750 VA: 0x18055E150
	public static Ray get_Ray() { }

	// RVA: 0x55E2D0 Offset: 0x55C8D0 VA: 0x18055E2D0
	public static RaycastHit get_Raycast() { }

	// RVA: 0x55CD40 Offset: 0x55B340 VA: 0x18055CD40
	public static EnvironmentType GetEnvironment() { }

	// RVA: 0x55CE20 Offset: 0x55B420 VA: 0x18055CE20
	public static bool InEnvironment(EnvironmentType type) { }

	// RVA: 0x55C5A0 Offset: 0x55ABA0 VA: 0x18055C5A0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x55D770 Offset: 0x55BD70 VA: 0x18055D770
	public void Setup() { }

	// RVA: 0x55D2D0 Offset: 0x55B8D0 VA: 0x18055D2D0 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x55C3B0 Offset: 0x55A9B0 VA: 0x18055C3B0
	private void AdjustTextureStreamingBudget() { }

	// RVA: 0x55E070 Offset: 0x55C670 VA: 0x18055E070
	private void Update() { }

	// RVA: 0x55D3D0 Offset: 0x55B9D0 VA: 0x18055D3D0
	public void RecordFrameTime() { }

	// RVA: 0x55D0C0 Offset: 0x55B6C0 VA: 0x18055D0C0 Slot: 9
	protected override void LateUpdate() { }

	// RVA: 0x55C9B0 Offset: 0x55AFB0 VA: 0x18055C9B0
	public static float Distance(Vector3 pos) { }

	// RVA: 0x55DC00 Offset: 0x55C200 VA: 0x18055DC00
	public static float SqrDistance(Vector3 pos) { }

	// RVA: 0x55CB50 Offset: 0x55B150 VA: 0x18055CB50
	public static float Distance(BaseEntity ent) { }

	// RVA: 0x55D9F0 Offset: 0x55BFF0 VA: 0x18055D9F0
	public static float SqrDistance(BaseEntity ent) { }

	// RVA: 0x55C680 Offset: 0x55AC80 VA: 0x18055C680
	public static float Distance2D(Vector3 pos) { }

	// RVA: 0x55D830 Offset: 0x55BE30 VA: 0x18055D830
	public static float SqrDistance2D(Vector3 pos) { }

	// RVA: 0x55C7F0 Offset: 0x55ADF0 VA: 0x18055C7F0
	public static float Distance2D(BaseEntity ent) { }

	// RVA: 0x55DDD0 Offset: 0x55C3D0 VA: 0x18055DDD0
	public static HitTest Trace(float maxDistance, BaseEntity IgnoreEntity, float radius = 0) { }

	// RVA: 0x55CF10 Offset: 0x55B510 VA: 0x18055CF10
	public static bool IsInFrontOfLocalPlayerCamera(Vector3 point) { }

	// RVA: 0x55E0F0 Offset: 0x55C6F0 VA: 0x18055E0F0
	public void .ctor() { }

	// RVA: 0x55E080 Offset: 0x55C680 VA: 0x18055E080
	private static void .cctor() { }

}

