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

	// RVA: 0x55E530 Offset: 0x55CB30 VA: 0x18055E530
	public static bool get_isValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x55E840 Offset: 0x55CE40 VA: 0x18055E840
	public static Vector3 get_velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x55EBB0 Offset: 0x55D1B0 VA: 0x18055EBB0
	private static void set_velocity(Vector3 value) { }

	// RVA: 0x55E610 Offset: 0x55CC10 VA: 0x18055E610
	public static Vector3 get_position() { }

	// RVA: 0x55E950 Offset: 0x55CF50 VA: 0x18055E950
	public static void set_position(Vector3 value) { }

	// RVA: 0x55E4A0 Offset: 0x55CAA0 VA: 0x18055E4A0
	public static Vector3 get_forward() { }

	// RVA: 0x55E8B0 Offset: 0x55CEB0 VA: 0x18055E8B0
	public static void set_forward(Vector3 value) { }

	// RVA: 0x55E6A0 Offset: 0x55CCA0 VA: 0x18055E6A0
	public static Vector3 get_right() { }

	// RVA: 0x55E9E0 Offset: 0x55CFE0 VA: 0x18055E9E0
	public static void set_right(Vector3 value) { }

	// RVA: 0x55E7B0 Offset: 0x55CDB0 VA: 0x18055E7B0
	public static Vector3 get_up() { }

	// RVA: 0x55EB00 Offset: 0x55D100 VA: 0x18055EB00
	public static void set_up(Vector3 value) { }

	// RVA: 0x55E730 Offset: 0x55CD30 VA: 0x18055E730
	public static Quaternion get_rotation() { }

	// RVA: 0x55EA80 Offset: 0x55D080 VA: 0x18055EA80
	public static void set_rotation(Quaternion value) { }

	// RVA: 0x55E0E0 Offset: 0x55C6E0 VA: 0x18055E0E0
	public static Ray get_Ray() { }

	// RVA: 0x55E260 Offset: 0x55C860 VA: 0x18055E260
	public static RaycastHit get_Raycast() { }

	// RVA: 0x55CCD0 Offset: 0x55B2D0 VA: 0x18055CCD0
	public static EnvironmentType GetEnvironment() { }

	// RVA: 0x55CDB0 Offset: 0x55B3B0 VA: 0x18055CDB0
	public static bool InEnvironment(EnvironmentType type) { }

	// RVA: 0x55C530 Offset: 0x55AB30 VA: 0x18055C530 Slot: 6
	protected override void Awake() { }

	// RVA: 0x55D700 Offset: 0x55BD00 VA: 0x18055D700
	public void Setup() { }

	// RVA: 0x55D260 Offset: 0x55B860 VA: 0x18055D260 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x55C340 Offset: 0x55A940 VA: 0x18055C340
	private void AdjustTextureStreamingBudget() { }

	// RVA: 0x55E000 Offset: 0x55C600 VA: 0x18055E000
	private void Update() { }

	// RVA: 0x55D360 Offset: 0x55B960 VA: 0x18055D360
	public void RecordFrameTime() { }

	// RVA: 0x55D050 Offset: 0x55B650 VA: 0x18055D050 Slot: 9
	protected override void LateUpdate() { }

	// RVA: 0x55C940 Offset: 0x55AF40 VA: 0x18055C940
	public static float Distance(Vector3 pos) { }

	// RVA: 0x55DB90 Offset: 0x55C190 VA: 0x18055DB90
	public static float SqrDistance(Vector3 pos) { }

	// RVA: 0x55CAE0 Offset: 0x55B0E0 VA: 0x18055CAE0
	public static float Distance(BaseEntity ent) { }

	// RVA: 0x55D980 Offset: 0x55BF80 VA: 0x18055D980
	public static float SqrDistance(BaseEntity ent) { }

	// RVA: 0x55C610 Offset: 0x55AC10 VA: 0x18055C610
	public static float Distance2D(Vector3 pos) { }

	// RVA: 0x55D7C0 Offset: 0x55BDC0 VA: 0x18055D7C0
	public static float SqrDistance2D(Vector3 pos) { }

	// RVA: 0x55C780 Offset: 0x55AD80 VA: 0x18055C780
	public static float Distance2D(BaseEntity ent) { }

	// RVA: 0x55DD60 Offset: 0x55C360 VA: 0x18055DD60
	public static HitTest Trace(float maxDistance, BaseEntity IgnoreEntity, float radius = 0) { }

	// RVA: 0x55CEA0 Offset: 0x55B4A0 VA: 0x18055CEA0
	public static bool IsInFrontOfLocalPlayerCamera(Vector3 point) { }

	// RVA: 0x55E080 Offset: 0x55C680 VA: 0x18055E080
	public void .ctor() { }

	// RVA: 0x55E010 Offset: 0x55C610 VA: 0x18055E010
	private static void .cctor() { }

}

